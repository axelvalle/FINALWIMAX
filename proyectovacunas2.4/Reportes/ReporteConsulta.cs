using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Image = iTextSharp.text.Image;

namespace proyectovacunas2._4.Reportes
{
    public partial class ReporteConsulta : Form
    {
        CapaBD.ConexionBD _con = new CapaBD.ConexionBD();

        public ReporteConsulta()
        {
            InitializeComponent();
        }

        public void CargarTodasLasConsultas()
        {
            // Define la consulta SQL para cargar todas las consultas
            string consultaSQL = "SELECT * FROM Consulta";

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
                    dtConsulta.AutoGenerateColumns = false;

                    // Asigna los datos al DataGridView en las columnas específicas
                    // Asegúrate de que los nombres de las columnas coinciden con las de tu DataGridView
                    dtConsulta.Columns["ID_CONSULTA"].DataPropertyName = "ID_CONSULTA";
                    dtConsulta.Columns["EMPLEADO_CEDULA"].DataPropertyName = "EMPLEADO_CEDULA";
                    dtConsulta.Columns["PACIENTE_CEDULA"].DataPropertyName = "PACIENTE_CEDULA";
                    dtConsulta.Columns["REGISTRO_CONSULTA"].DataPropertyName = "REGISTRO_CONSULTA";
                    dtConsulta.Columns["DIADNOSTICO"].DataPropertyName = "DIADNOSTICO";
                    dtConsulta.Columns["PRESION_SANGUINEA"].DataPropertyName = "PRESION_SANGUINEA";
                    dtConsulta.Columns["OXIGENO"].DataPropertyName = "OXIGENO";
                    dtConsulta.Columns["FRECUENCIA_CARDIACA"].DataPropertyName = "FRECUENCIA_CARDIACA";
                    dtConsulta.Columns["PESO"].DataPropertyName = "PESO";
                    dtConsulta.Columns["TEMPERATURA"].DataPropertyName = "TEMPERATURA";
                    dtConsulta.Columns["PULSO"].DataPropertyName = "PULSO";
                    dtConsulta.Columns["HIPOTIROIDISMO"].DataPropertyName = "HIPOTIROIDISMO";

                    // Muestra los resultados en el DataGridView "dtConsulta"
                    dtConsulta.DataSource = resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar todas las consultas: " + ex.Message);
            }
            finally
            {
                _con.cn.Close();
            }
        }

        public void GenerarPDF(DataGridView dtConsulta)
        {
            // Validar que la DataGridView no esté vacía
            if (dtConsulta.Rows.Count == 0)
            {
                MessageBox.Show("La DataGridView está vacía. Agregue datos antes de generar el PDF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear un diálogo de guardar archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF|*.pdf";
            saveFileDialog.Title = "Guardar archivo PDF";
            saveFileDialog.FileName = "ReporteConsultas.pdf";

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
                            Paragraph tableTitle = new Paragraph("Reporte de Consultas", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD, colorTitulo));
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
                            PdfPTable dataTable = new PdfPTable(dtConsulta.Columns.Count);
                            dataTable.WidthPercentage = 100;

                            // Agregar encabezados de columna
                            for (int i = 0; i < dtConsulta.Columns.Count; i++)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(dtConsulta.Columns[i].HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, colorTexto)));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                cell.BackgroundColor = colorTitulo;
                                dataTable.AddCell(cell);
                            }

                            // Agregar filas y celdas de datos
                            for (int i = 0; i < dtConsulta.Rows.Count; i++)
                            {
                                for (int j = 0; j < dtConsulta.Columns.Count; j++)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase((dtConsulta.Rows[i].Cells[j].Value ?? "").ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, colorTexto)));
                                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                    dataTable.AddCell(cell);
                                }
                            }

                            doc.Add(dataTable);

                            // Cerrar el documento
                            doc.Close();

                            MessageBox.Show("PDF generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (DocumentException ex)
                    {
                        MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error de E/S al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void GenerarExcel(DataGridView dtConsulta)
        {
            // Validar que la DataGridView no esté vacía
            if (dtConsulta.Rows.Count == 0)
            {
                MessageBox.Show("La DataGridView está vacía. Agregue datos antes de generar el Excel.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear un diálogo de guardar archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Excel|*.xlsx";
            saveFileDialog.Title = "Guardar archivo de Excel";
            saveFileDialog.FileName = "TablaConsultas.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaDestino = saveFileDialog.FileName;

                using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(rutaDestino)))
                {
                    try
                    {
                        // Crear una hoja de trabajo
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Reporte de Consultas");

                        // Encabezados de columna
                        for (int i = 0; i < dtConsulta.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dtConsulta.Columns[i].HeaderText;
                            worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                            worksheet.Cells[1, i + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        }

                        // Datos
                        for (int i = 0; i < dtConsulta.Rows.Count; i++)
                        {
                            for (int j = 0; j < dtConsulta.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = (dtConsulta.Rows[i].Cells[j].Value ?? "").ToString();
                                worksheet.Cells[i + 2, j + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            }
                        }

                        // Autoajustar el ancho de las columnas
                        worksheet.Cells.AutoFitColumns();

                        // Guardar el archivo de Excel
                        excelPackage.Save();

                        MessageBox.Show("Archivo de Excel generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar el archivo de Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ReporteConsulta_Load(object sender, EventArgs e)
        {
            CargarTodasLasConsultas();
            timer1.Start();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
            if (dtConsulta.Rows.Count > 0)
            {
                GenerarPDF(dtConsulta);
            }
            else
            {
                MessageBox.Show("La DataGridView está vacía. Agregue datos antes de generar el PDF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (dtConsulta.Rows.Count > 0)
            {
                GenerarExcel(dtConsulta);
            }
            else
            {
                MessageBox.Show("La DataGridView está vacía. Agregue datos antes de generar el Excel.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
