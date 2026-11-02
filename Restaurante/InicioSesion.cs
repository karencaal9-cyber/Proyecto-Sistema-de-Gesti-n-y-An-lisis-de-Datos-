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

namespace Restaurante
{
    public partial class InicioSesion : Form
    {
        private string cadenaConexion = @"Server=localhost\SQLEXPRESS;Database=SistemaReservasDB;Integrated Security=true;TrustServerCertificate=True;";
        public InicioSesion()
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

            // 1. Validar campos vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Consulta SQL para validar credenciales y extraer rol y turnos activos
            string query = @"SELECT E.IdEmpleado, E.NombreEmpleado, E.ApellidoEmpleado, E.RolEmpleado, T.IdTurno, T.InicioTurno, T.FinalizacionTurno 
                             FROM Empleados E
                             LEFT JOIN Turnos T ON E.IdEmpleado = T.IdEmpleado AND GETDATE() BETWEEN T.InicioTurno AND T.FinalizacionTurno 
                             WHERE E.UsuarioEmpleado = @usuario AND E.ContrasenaEmpleado = @contrasena";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
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
                                // Obtener datos del empleado
                                string nombre = lector.GetString(1) + " " + lector.GetString(2);
                                string rol = lector.GetString(3);

                                // Asignar y seleccionar el Rol en el ComboBox
                                cmbRol.Text = rol;

                                // Validar y asignar el Turno en el ComboBox
                                cmbTurno.Items.Clear(); // Limpiar turnos anteriores
                                if (!lector.IsDBNull(4))
                                {
                                    DateTime inicioTurno = lector.GetDateTime(5);
                                    DateTime finTurno = lector.GetDateTime(6);

                                    // CORREGIDO: Todo en una sola línea para evitar errores de sintaxis
                                    string turnoTexto = $"{inicioTurno:HH:mm} - {finTurno:HH:mm}";

                                    cmbTurno.Items.Add(turnoTexto);
                                    cmbTurno.SelectedIndex = 0; // Seleccionar el turno activo encontrado
                                }
                                else
                                {
                                    cmbTurno.Items.Add("Sin turno activo");
                                    cmbTurno.SelectedIndex = 0;
                                }

                                MessageBox.Show($"¡Bienvenido al sistema, {nombre}!", "Inicio de Sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // --- AQUÍ ABRES EL NUEVO FORMULARIO ---
                                Menu_Principal menuPrincipal = new Menu_Principal();
                                menuPrincipal.Show(); // Muestra el menú principal
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtContrasena.Clear();
                                txtUsuario.Focus();

                                // Limpiar los ComboBox en caso de fallo
                                cmbRol.SelectedIndex = -1;
                                cmbTurno.Items.Clear();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }
    }
}
