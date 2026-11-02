using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurante.Data;

namespace Restaurante
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

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

        private void Form6_Load(object sender, EventArgs e)
        {
            FiltrarReservas();
            CargarRoles();
        }

        private void FiltrarReservas()
        {
            string sql = @"SELECT 
                                r.IdReserva, 
                                c.NombreCliente + ' ' + c.ApellidoCliente AS Cliente, 
                                c.TelefonoCliente, 
                                r.FechaReserva, 
                                r.HoraReserva, 
                                e.NombreEmpleado AS Empleado, 
                                e.RolEmpleado AS Rol 
                           FROM Reservas r
                           INNER JOIN Clientes c ON r.IdCliente = c.IdCliente
                           INNER JOIN Empleados e ON r.IdEmpleado = e.IdEmpleado
                           WHERE 1=1";

            List<SqlParameter> listaParametros = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(txtNumeroCliente.Text.Trim()))
            {
                sql += " AND c.TelefonoCliente LIKE @Telefono";
                listaParametros.Add(new SqlParameter("@Telefono", "%" + txtNumeroCliente.Text.Trim() + "%"));
            }

            if (!string.IsNullOrEmpty(txtApellidoCliente.Text.Trim()))
            {
                sql += "AND c.ApellidoCliente LIKE @Apellido";
                listaParametros.Add(new SqlParameter("@Apellido", "%" + txtApellidoCliente.Text.Trim() + "%"));
            }

            if (cmbRolEmpleado.SelectedValue != null && cmbRolEmpleado.SelectedValue.ToString() != "Todos")
            {
                sql += " AND e.RolEmpleado = @Rol";
                listaParametros.Add(new SqlParameter("@Rol", cmbRolEmpleado.SelectedValue.ToString()));
            }

            sql += " ORDER BY r.FechaReserva DESC";
            dgvForm6.DataSource = ObtenerDatos(sql, listaParametros.ToArray());
        }

        private void Limpiar()
        {
            txtApellidoCliente.Text = " ";
            txtNumeroCliente.Text = " ";
            if (cmbRolEmpleado.Items.Count > 0)
            {
                cmbRolEmpleado.SelectedIndex = 0;
            }
        }

        private void CargarRoles()
        {
            string sql = "SELECT DISTINCT RolEmpleado AS Rol FROM Empleados WHERE RolEmpleado IS NOT NULL";
            DataTable dtRoles = ObtenerDatos(sql);

            DataRow filaTodos = dtRoles.NewRow();
            filaTodos["Rol"] = "Todos";
            dtRoles.Rows.InsertAt(filaTodos, 0);

            cmbRolEmpleado.DataSource = dtRoles;
            cmbRolEmpleado.DisplayMember = "Rol";
            cmbRolEmpleado.ValueMember = "Rol";
            cmbRolEmpleado.SelectedIndex = 0;
        }

        private void txtNumeroCliente_TextChanged(object sender, EventArgs e)
        {
            FiltrarReservas();
        }

        private void txtApellidoCliente_TextChanged(object sender, EventArgs e)
        {
            FiltrarReservas();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void cmbRolEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarReservas();
        }

        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}