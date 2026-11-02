using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Restaurante.Data;


namespace Restaurante
{
    public partial class Form7 : Form
    {
        private DataTable ObtenerDatos(string sql, params SqlParameter[] parametros)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    if (parametros != null && parametros.Length > 0)
                    {
                        comando.Parameters.AddRange(parametros);
                    }
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        public Form7()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            FiltrarMesas();
            MostrarBitacora();
            CargarGraficaBarras();
            CargarGraficaComparativa();
        }

        private void FiltrarMesas()
        {
            string sql = @"SELECT 
                                r.IdReserva, 
                                m.IdMesa,
                                z.NombreZona AS Zona,
                                m.CapacidadMesa AS Capacidad,
                                m.EstadoMesa AS Estado,
                                c.NombreCliente + ' ' + c.ApellidoCliente AS Cliente, 
                                r.FechaReserva, 
                                r.HoraReserva
                           FROM Reservas r
                           INNER JOIN Mesas m ON r.IdMesa = m.IdMesa
                           INNER JOIN Zonas z ON m.IdZona = z.IdZona
                           INNER JOIN Clientes c ON r.IdCliente = c.IdCliente
                           WHERE r.FechaReserva = @FechaFiltro";

            DateTime fechaSeleccionada = tmpMesasDisponibles.Value.Date;
            SqlParameter parametroFecha = new SqlParameter("@FechaFiltro", SqlDbType.Date) { Value = fechaSeleccionada };
            dgvMesasDisponibles.DataSource = ObtenerDatos(sql, parametroFecha);
        }

        private void MostrarBitacora()
        {
            string sql = "SELECT TOP 50 IdReserva, FechaReserva, HoraReserva FROM Reservas ORDER BY IdReserva DESC";
            dgvBitacora.DataSource = ObtenerDatos(sql);
        }

        private void CargarGraficaBarras()
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                string consulta = @"SELECT 
                                        DATEPART(hour, HoraReserva) AS Hora, 
                                        COUNT(*) AS TotalReservas 
                                    FROM Reservas 
                                    GROUP BY DATEPART(hour, HoraReserva) 
                                    ORDER BY Hora";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    ctGraficaBarras.Series.Clear();
                    ctGraficaBarras.Legends.Clear();

                    var serie = ctGraficaBarras.Series.Add("HorasPico");
                    serie.ChartType = SeriesChartType.Column;
                    serie.IsValueShownAsLabel = true;

                    while (lector.Read())
                    {
                        string hora = lector["Hora"].ToString() + ":00 hrs";
                        int total = Convert.ToInt32(lector["TotalReservas"]);
                        serie.Points.AddXY(hora, total);
                    }
                }
            }
        }

        private void CargarGraficaComparativa()
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                string consulta = @"SELECT 
                                        z.NombreZona, 
                                        COUNT(r.IdReserva) AS TotalReservas 
                                    FROM Zonas z
                                    LEFT JOIN Mesas m ON z.IdZona = m.IdZona
                                    LEFT JOIN Reservas r ON m.IdMesa = r.IdMesa
                                    GROUP BY z.NombreZona";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    ctGraficaComparativa.Series.Clear();
                    ctGraficaComparativa.Legends.Clear();

                    var serie = ctGraficaComparativa.Series.Add("ReservasPorZona");
                    serie.ChartType = SeriesChartType.Column;
                    serie.IsValueShownAsLabel = true;

                    while (lector.Read())
                    {
                        string zona = lector["NombreZona"].ToString();
                        int total = Convert.ToInt32(lector["TotalReservas"]);
                        serie.Points.AddXY(zona, total);
                    }
                }
            }
        }

        private DataTable ObtenerDatosPDF()
        {
            string query = @"SELECT 
                                r.FechaReserva AS Fecha,
                                COUNT(r.IdReserva) AS TotalReservas,
                                COUNT(m.IdMesa) AS MesasOcupadas
                             FROM Reservas r
                             INNER JOIN Mesas m ON r.IdMesa = m.IdMesa
                             GROUP BY r.FechaReserva";
            return ObtenerDatos(query);
        }

        private void btnReportePDF_Click(object sender, EventArgs e)
        {
            DataTable dt = ObtenerDatosPDF();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron registros para generar el reporte de ocupación.");
                return;
            }

            string rutaPDF = Path.Combine(Application.StartupPath, "Porcentaje_Ocupación_y_Consumo.pdf");
            Document doc = new Document(PageSize.A4, 20, 20, 20, 20);

            try
            {
                PdfWriter.GetInstance(doc, new FileStream(rutaPDF, FileMode.Create));
                doc.Open();

                Paragraph titulo = new Paragraph("REPORTE DE PORCENTAJE DE OCUPACIÓN DIARIA Y CONSUMO PROMEDIO POR MESA\n\n",
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));
                titulo.Alignment = Element.ALIGN_CENTER;
                doc.Add(titulo);

                PdfPTable tablaPDF = new PdfPTable(dt.Columns.Count);
                tablaPDF.WidthPercentage = 100;

                foreach (DataColumn columna in dt.Columns)
                {
                    PdfPCell celdaHeader = new PdfPCell(new Phrase(columna.ColumnName,
                        FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));
                    celdaHeader.HorizontalAlignment = Element.ALIGN_CENTER;
                    tablaPDF.AddCell(celdaHeader);
                }

                foreach (DataRow fila in dt.Rows)
                {
                    foreach (var item in fila.ItemArray)
                    {
                        tablaPDF.AddCell(item.ToString());
                    }
                }

                doc.Add(tablaPDF);
                doc.Close();

                MessageBox.Show($"Reporte generado con éxito en:\n{rutaPDF}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message);
            }
        }

        private DataTable ObtenerDatosExcel()
        {
            string query = @"SELECT 
                                c.IdCliente,
                                c.NombreCliente + ' ' + c.ApellidoCliente AS NombreCliente,
                                c.TelefonoCliente AS Telefono,
                                COUNT(r.IdReserva) AS TotalReservasRealizadas
                             FROM Clientes c
                             INNER JOIN Reservas r ON c.IdCliente = r.IdCliente
                             GROUP BY c.IdCliente, c.NombreCliente, c.ApellidoCliente, c.TelefonoCliente
                             ORDER BY TotalReservasRealizadas DESC";
            return ObtenerDatos(query);
        }

        private void btnClientesExcel_Click(object sender, EventArgs e)
        {
            DataTable dt = ObtenerDatosExcel();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros de clientes frecuentes para exportar.");
                return;
            }

            string rutaExcel = Path.Combine(Application.StartupPath, "Listado_Clientes_Frecuentes.xlsx");

            try
            {
                FileInfo archivoExcel = new FileInfo(rutaExcel);
                if (archivoExcel.Exists)
                {
                    archivoExcel.Delete();
                }

                ExcelPackage.License.SetNonCommercialPersonal("Cesia");
                using (ExcelPackage package = new ExcelPackage(archivoExcel))
                {
                    ExcelWorksheet hoja = package.Workbook.Worksheets.Add("Clientes frecuentes");

                    hoja.Cells["A1"].LoadFromDataTable(dt, true);

                    #region Formato y Estilos
                    using (ExcelRange rangoEncabezado = hoja.Cells[1, 1, 1, dt.Columns.Count])
                    {
                        rangoEncabezado.Style.Font.Bold = true;
                        rangoEncabezado.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        rangoEncabezado.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.DarkGreen);
                        rangoEncabezado.Style.Font.Color.SetColor(System.Drawing.Color.White);
                        rangoEncabezado.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    }

                    #region Ajuste Automático de Columnas
                    hoja.Cells[hoja.Dimension.Address].AutoFitColumns();
                    #endregion
                    #endregion

                    package.Save();
                }

                MessageBox.Show($"Archivo Excel generado con éxito en:\n{rutaExcel}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a Excel: " + ex.Message);
            }
        }

        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmpMesasDisponibles_ValueChanged(object sender, EventArgs e)
        {
            FiltrarMesas();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
