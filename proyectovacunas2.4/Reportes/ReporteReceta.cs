using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Font = iTextSharp.text.Font;
using Image = iTextSharp.text.Image;

namespace proyectovacunas2._4.Reportes
{
    public partial class ReporteReceta : Form
    {
        CapaBD.ConexionBD _con = new CapaBD.ConexionBD();

        public ReporteReceta()
        {
            InitializeComponent();
        }

        public void CargarTodasLasRecetas()
        {
            // Limpia la tabla antes de cargar todas las recetas
            dtReceta.DataSource = null;
            dtReceta.Rows.Clear();

            // Define la consulta SQL para seleccionar todas las recetas
            string consultaSQL = "SELECT ID_RECETA, PACIENTE_CEDULA, ID_RECETA_PRODUCTO, CANTIDAD FROM RECETA";

            try
            {
                _con.cn.Open();

                using (SqlCommand comando = new SqlCommand(consultaSQL, _con.cn))
                {
                    // Ejecuta la consulta y obtiene los resultados en un DataTable
                    DataTable resultado = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(resultado);

                    // Configura el DataGridView para que no autogenera columnas automáticamente
                    dtReceta.AutoGenerateColumns = false;

                    // Asigna los datos al DataGridView en las columnas específicas
                    dtReceta.Columns["ID_RECETA"].DataPropertyName = "ID_RECETA";
                    dtReceta.Columns["PACIENTE_CEDULA"].DataPropertyName = "PACIENTE_CEDULA";
                    dtReceta.Columns["ID_RECETA_PRODUCTO"].DataPropertyName = "ID_RECETA_PRODUCTO";
                    dtReceta.Columns["CANTIDAD"].DataPropertyName = "CANTIDAD";

                    // Muestra los resultados en el DataGridView "dtReceta"
                    dtReceta.DataSource = resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar todas las recetas: " + ex.Message);
            }
            finally
            {
                _con.cn.Close();
            }
        }

        public void GenerarPDF(DataGridView dtReceta)
        {
            // Validar que la DataGridView no esté vacía
            if (dtReceta.Rows.Count == 0)
            {
                MessageBox.Show("La DataGridView está vacía. Agregue datos antes de generar el PDF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear un diálogo de guardar archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF|*.pdf";
            saveFileDialog.Title = "Guardar archivo PDF";
            saveFileDialog.FileName = "ReporteRecetas.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaDestino = saveFileDialog.FileName;

                using (Document doc = new Document(PageSize.LETTER, 36, 36, 36, 36))
                {
                    try
                    {
                        // Configurar el escritor PDF
                        using (PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(rutaDestino, FileMode.Create)))
                        {
                            doc.Open();

                            // Colores personalizados
                            BaseColor colorFondo = new BaseColor(245, 245, 245); // Color de fondo
                            BaseColor colorTexto = BaseColor.BLACK; // Color del texto
                            BaseColor colorTitulo = new BaseColor(33, 150, 243); // Color del título

                            // Encabezado
                            PdfPTable headerTable = new PdfPTable(2);
                            headerTable.WidthPercentage = 100;
                            headerTable.SpacingAfter = 10f;
                            headerTable.DefaultCell.BackgroundColor = colorFondo;

                            PdfPCell leftCell = new PdfPCell(new Phrase("WIMAX CENTRO MÉDICO\nDirección: Av. Universitaria, frente a la Academia de Danza Nicaragüense\nTeléfono: +505 2250-6845", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, colorTexto)));
                            leftCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                            leftCell.HorizontalAlignment = Element.ALIGN_LEFT;
                            leftCell.BackgroundColor = colorFondo;

                            PdfPCell rightCell = new PdfPCell(new Phrase($"Fecha: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}\nNúmero de Reporte: 00000111", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, colorTexto)));
                            rightCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                            rightCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                            rightCell.BackgroundColor = colorFondo;

                            headerTable.AddCell(leftCell);
                            headerTable.AddCell(rightCell);

                            doc.Add(headerTable);

                            // Título de la tabla
                            Paragraph tableTitle = new Paragraph("Reporte de Recetas", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD, colorTitulo));
                            tableTitle.Alignment = Element.ALIGN_CENTER;
                            tableTitle.SpacingAfter = 10f;
                            doc.Add(tableTitle);

                            // Agregar marca de agua (imagen) con opacidad al 25%
                            string imagenMarcaDeAgua = "Imagen (25).png"; // Cambia el nombre de la imagen según su ubicación
                            iTextSharp.text.Image imgMarcaDeAgua = Image.GetInstance(imagenMarcaDeAgua);
                            imgMarcaDeAgua.SetAbsolutePosition(100, 300); // Ajusta la posición de la imagen
                            imgMarcaDeAgua.ScaleAbsolute(400, 400); // Ajusta el tamaño de la imagen
                            imgMarcaDeAgua.Alignment = Image.UNDERLYING; // Coloca la imagen debajo del contenido

                            // Establecer la opacidad al 10%
                            PdfGState gs = new PdfGState();
                            gs.FillOpacity = 0.10f; // 25% de opacidad
                            PdfContentByte canvas = writer.DirectContentUnder;
                            canvas.SetGState(gs);

                            canvas.AddImage(imgMarcaDeAgua);

                            // Tabla de datos
                            PdfPTable dataTable = new PdfPTable(dtReceta.Columns.Count);
                            dataTable.WidthPercentage = 100;

                            // Agregar encabezados de columna
                            for (int i = 0; i < dtReceta.Columns.Count; i++)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(dtReceta.Columns[i].HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, colorTexto)));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                cell.BackgroundColor = colorTitulo;
                                dataTable.AddCell(cell);
                            }

                            // Agregar filas y celdas de datos
                            FontFactory.RegisterDirectories();
                            Font font = FontFactory.GetFont("Helvetica", 10, BaseColor.BLACK);

                            for (int i = 0; i < dtReceta.Rows.Count; i++)
                            {
                                for (int j = 0; j < dtReceta.Columns.Count; j++)
                                {
                                    // Línea corregida para crear una celda con la fuente especificada
                                    PdfPCell cell = new PdfPCell(new Phrase(dtReceta.Rows[i].Cells[j].Value.ToString(), font));
                                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                    dataTable.AddCell(cell);
                                }
                            }


                            doc.Add(dataTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar el PDF: " + ex.Message);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }

                MessageBox.Show("PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void GenerarExcel(DataGridView dtReceta)
        {
            // Validar que la DataGridView no esté vacía
            if (dtReceta.Rows.Count == 0)
            {
                MessageBox.Show("La DataGridView está vacía. Agregue datos antes de generar el archivo Excel.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear un diálogo de guardar archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos Excel|*.xlsx";
            saveFileDialog.Title = "Guardar archivo Excel";
            saveFileDialog.FileName = "ReporteRecetas.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaDestino = saveFileDialog.FileName;

                try
                {
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        // Crear una hoja de trabajo
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Recetas");

                        // Encabezados de columna
                        for (int i = 1; i <= dtReceta.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i].Value = dtReceta.Columns[i - 1].HeaderText;
                            worksheet.Cells[1, i].Style.Font.Bold = true;
                            worksheet.Cells[1, i].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            worksheet.Cells[1, i].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                            worksheet.Cells[1, i].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            worksheet.Cells[1, i].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(33, 150, 243));
                            worksheet.Cells[1, i].Style.Font.Color.SetColor(Color.White);
                        }

                        // Datos de la tabla
                        for (int i = 0; i < dtReceta.Rows.Count; i++)
                        {
                            for (int j = 0; j < dtReceta.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dtReceta.Rows[i].Cells[j].Value.ToString();
                                worksheet.Cells[i + 2, j + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                            }
                        }

                        // Autoajustar el ancho de las columnas
                        worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                        // Guardar el archivo
                        FileInfo excelFile = new FileInfo(rutaDestino);
                        excelPackage.SaveAs(excelFile);
                    }

                    MessageBox.Show("Archivo Excel generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el archivo Excel: " + ex.Message);
                }
            }
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
            GenerarPDF(dtReceta);
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            GenerarExcel(dtReceta);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void ReporteReceta_Load(object sender, EventArgs e)
        {
            timer1.Start();
            CargarTodasLasRecetas();
        }
    }
}
