using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Restaurante.Data;


namespace Restaurante
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void CargarIndicadores()
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string consultaReservas = "SELECT COUNT(*) FROM Reservas";
                string consultaMesas = "SELECT COUNT(*) FROM Mesas";
                string consultaClientes = "SELECT COUNT(*) FROM Clientes";

                using (SqlCommand comando = new SqlCommand(consultaReservas, conexion))
                {
                    lblTotalReservas.Text = comando.ExecuteScalar().ToString();
                }

                using (SqlCommand comando = new SqlCommand(consultaMesas, conexion))
                {
                    lblTotalMesas.Text = comando.ExecuteScalar().ToString();
                }

                using (SqlCommand comando = new SqlCommand(consultaClientes, conexion))
                {
                    lblTotalClientes.Text = comando.ExecuteScalar().ToString();
                }
            }
        }
        private void CargarGraficaMesas()
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string consulta = @"
            SELECT EstadoMesa, COUNT(*) AS Total
            FROM Mesas
            GROUP BY EstadoMesa";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    chartMesas.Series.Clear();
                    chartMesas.Legends.Clear();

                    var serie = chartMesas.Series.Add("Mesas");
                    serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serie.IsValueShownAsLabel = true;

                    while (lector.Read())
                    {
                        string estado = lector["EstadoMesa"].ToString();
                        int total = Convert.ToInt32(lector["Total"]);

                        serie.Points.AddXY(estado, total);
                    }
                }
            }
        }
        private void CargarGraficaReservas()
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string consulta = @"
            SELECT
                FORMAT(FechaReserva, 'yyyy-MM') AS Mes,
                COUNT(*) AS Total
            FROM Reservas
            GROUP BY FORMAT(FechaReserva, 'yyyy-MM')
            ORDER BY Mes";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    chartReservas.Series.Clear();
                    chartReservas.Legends.Clear();

                    var serie = chartReservas.Series.Add("Reservas");
                    serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    serie.IsValueShownAsLabel = true;

                    while (lector.Read())
                    {
                        string mes = lector["Mes"].ToString();
                        int total = Convert.ToInt32(lector["Total"]);

                        serie.Points.AddXY(mes, total);
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarIndicadores();
            CargarGraficaMesas();
            CargarGraficaReservas();
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            Form3 formularioMesas = new Form3();
            formularioMesas.ShowDialog();
        }
    }
}
