using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurante.Data;

namespace Restaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Mesero");
            cmbRol.Items.Add("Recepcionista");
            cmbRol.SelectedIndex = 0;

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"SELECT E.IdEmpleado, E.NombreEmpleado, E.ApellidoEmpleado, E.RolEmpleado, T.IdTurno, T.InicioTurno, T.FinalizacionTurno 
                             FROM Empleados E
                             LEFT JOIN Turnos T ON E.IdEmpleado = T.IdEmpleado AND GETDATE() BETWEEN T.InicioTurno AND T.FinalizacionTurno 
                             WHERE E.UsuarioEmpleado = @usuario AND E.ContrasenaEmpleado = @contrasena";

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@contrasena", contrasena);

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                int idEmpleado = lector.GetInt32(0);
                                string nombre = lector.GetString(1) + " " + lector.GetString(2);
                                string rol = lector.GetString(3);
                                SesionActual.IdEmpleado = idEmpleado;

                                cmbRol.Text = rol;

                                cmbTurno.Items.Clear();
                                if (!lector.IsDBNull(4))
                                {
                                    DateTime inicioTurno = lector.GetDateTime(5);
                                    DateTime finTurno = lector.GetDateTime(6);

                                    string turnoTexto = $"{inicioTurno:HH:mm} - {finTurno:HH:mm}";

                                    cmbTurno.Items.Add(turnoTexto);
                                    cmbTurno.SelectedIndex = 0;
                                }
                                else
                                {
                                    cmbTurno.Items.Add("Sin turno activo");
                                    cmbTurno.SelectedIndex = 0;
                                }

                            }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtContrasena.Clear();
                                txtUsuario.Focus();

                                cmbRol.SelectedIndex = -1;
                                cmbTurno.Items.Clear();
                                return;
                            }
                        }
                    }

                    string queryId = "SELECT IdEmpleado, NombreEmpleado, ApellidoEmpleado FROM Empleados WHERE UsuarioEmpleado = @usuario";
                    int idEmpLogueado = 0;
                    string nombreCompleto = "";

                    using (SqlCommand cmdInfo = new SqlCommand(queryId, conexion))
                    {
                        cmdInfo.Parameters.AddWithValue("@usuario", usuario);
                        using (SqlDataReader l2 = cmdInfo.ExecuteReader())
                        {
                            if (l2.Read())
                            {
                                idEmpLogueado = l2.GetInt32(0);
                                nombreCompleto = l2.GetString(1) + " " + l2.GetString(2);
                            }
                        }
                    }

                    string queryBitacora = @"INSERT INTO Bitacora (IdEmpleado, TipoOperacion, FechaOperacion, HoraOperacion, TablaAfectada, DescripcionBitacora) 
                                             VALUES (@idEmp, 'LOGIN', GETDATE(), CAST(GETDATE() AS TIME), 'Empleados', @desc)";

                    using (SqlCommand cmdBitacora = new SqlCommand(queryBitacora, conexion))
                    {
                        cmdBitacora.Parameters.AddWithValue("@idEmp", idEmpLogueado);
                        cmdBitacora.Parameters.AddWithValue("@desc", $"El empleado {nombreCompleto} inició sesión en el sistema.");
                        cmdBitacora.ExecuteNonQuery();
                    }

                    MessageBox.Show($"¡Bienvenido al sistema, {nombreCompleto}!", "Inicio de Sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form2 menuPrincipal = new Form2();
                    menuPrincipal.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
