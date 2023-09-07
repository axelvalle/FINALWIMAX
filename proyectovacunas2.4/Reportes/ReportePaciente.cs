using iTextSharp.text.pdf;
using iTextSharp.text;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Image = iTextSharp.text.Image;

namespace proyectovacunas2._4.Reportes
{
    public partial class ReportePaciente : Form
    {
        CapaBD.ConexionBD _con = new CapaBD.ConexionBD();
        public ReportePaciente()
        {
            InitializeComponent();
        }

        private void CargarTodosLosDatos(string tabla)
        {
            dtPaciente.DataSource = null;
            dtPaciente.Rows.Clear();

            string consultaSQL = $"SELECT PACIENTE_CEDULA, FECHA_INGRESO, ENFERMEDAD_CRONICA FROM {tabla}";

            try
            {
                _con.cn.Open();

                using (SqlCommand comando = new SqlCommand(consultaSQL, _con.cn))
                {
                    DataTable resultado = new DataTable();
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(resultado);

                    dtPaciente.AutoGenerateColumns = false;

                    dtPaciente.Columns["PACIENTE_CEDULA"].DataPropertyName = "PACIENTE_CEDULA";
                    dtPaciente.Columns["FECHA_INGRESO"].DataPropertyName = "FECHA_INGRESO";
                    dtPaciente.Columns["ENFERMEDAD_CRONICA"].DataPropertyName = "ENFERMEDAD_CRONICA";

                    dtPaciente.DataSource = resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar todos los pacientes: {ex.Message}");
            }
            finally
            {
                _con.cn.Close();
            }
        }

        public void GenerarPDF(DataGridView dtPaciente)
        {
            // Validar que la DataGridView no esté vacía
            if (dtPaciente.Rows.Count == 0)
            {
                MessageBox.Show("La DataGridView está vacía. Agregue datos antes de generar el PDF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear un diálogo de guardar archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF|*.pdf";
            saveFileDialog.Title = "Guardar archivo PDF";
            saveFileDialog.FileName = "ReportePacientes.pdf";

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
                            Paragraph tableTitle = new Paragraph("Reporte de Pacientes", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD, colorTitulo));
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
                            PdfPTable dataTable = new PdfPTable(dtPaciente.Columns.Count);
                            dataTable.WidthPercentage = 100;

                            // Agregar encabezados de columna
                            for (int i = 0; i < dtPaciente.Columns.Count; i++)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(dtPaciente.Columns[i].HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, colorTexto)));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                cell.BackgroundColor = colorTitulo;
                                dataTable.AddCell(cell);
                            }

                            // Agregar filas y celdas de datos
                            for (int i = 0; i < dtPaciente.Rows.Count; i++)
                            {
                                for (int j = 0; j < dtPaciente.Columns.Count; j++)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase((dtPaciente.Rows[i].Cells[j].Value ?? "").ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, colorTexto)));
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

        public void GenerarExcel(DataGridView dtPaciente)
        {
            // Validar que la DataGridView no esté vacía
            if (dtPaciente.Rows.Count == 0)
            {
                MessageBox.Show("La DataGridView está vacía. Agregue datos antes de generar el Excel.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear un diálogo de guardar archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Excel|*.xlsx";
            saveFileDialog.Title = "Guardar archivo de Excel";
            saveFileDialog.FileName = "TablaPacientes.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaDestino = saveFileDialog.FileName;

                using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(rutaDestino)))
                {
                    try
                    {
                        // Crear una hoja de trabajo
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Reporte de Pacientes");

                        // Encabezados de columna
                        for (int i = 0; i < dtPaciente.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dtPaciente.Columns[i].HeaderText;
                            worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                            worksheet.Cells[1, i + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        }

                        // Datos
                        for (int i = 0; i < dtPaciente.Rows.Count; i++)
                        {
                            for (int j = 0; j < dtPaciente.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = (dtPaciente.Rows[i].Cells[j].Value ?? "").ToString();
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

        private void ReportePaciente_Load(object sender, EventArgs e)
        {
            CargarTodosLosDatos("PACIENTE");
            timer1.Start();
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
            if (dtPaciente.Rows.Count > 0)
            {
                GenerarPDF(dtPaciente);
            }
            else
            {
                MessageBox.Show("La DataGridView está vacía. Agregue datos antes de generar el PDF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (dtPaciente.Rows.Count > 0)
            {
                GenerarExcel(dtPaciente);
            }
            else
            {
                MessageBox.Show("La DataGridView está vacía. Agregue datos antes de generar el Excel.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
