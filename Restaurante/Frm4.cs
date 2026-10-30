using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Necesario para la conexión con SQL Server

namespace Restaurante
{
    public partial class Frm4 : Form
    {
        // Cambia esta cadena de conexión si tu servidor SQL Server tiene otro nombre o configuración
        private string cadenaConexion = "Server=.;Database=BD_Restaurante;Trusted_Connection=True;";
        private int idClienteActual = 0; // Para almacenar el ID si el cliente ya existe

        public Frm4()
        {
            InitializeComponent();
        }

        private void Frm4_Load(object sender, EventArgs e)
        {
            // Cargar estados por defecto en el ComboBox si existe
            if (cmbEstado != null)
            {
                cmbEstado.Items.Add("Pendiente");
                cmbEstado.Items.Add("Confirmada");
                cmbEstado.Items.Add("Cancelada");
                if (cmbEstado.Items.Count > 0)
                    cmbEstado.SelectedIndex = 0;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Evento generado por defecto por el diseñador de Visual Studio
        }

        // Botón para buscar si el cliente ya está registrado (Programa de fidelidad)
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                MessageBox.Show("Ingrese un número de teléfono o identificación para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT IdCliente, Nombre, Telefono, Correo FROM clientes WHERE Telefono = @Busqueda OR IdCliente = @BusquedaID";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Busqueda", txtBuscar.Text.Trim());
                int idValido = 0;
                int.TryParse(txtBuscar.Text.Trim(), out idValido);
                cmd.Parameters.AddWithValue("@BusquedaID", idValido);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        idClienteActual = Convert.ToInt32(reader["IdCliente"]);
                        txtNombre.Text = reader["Nombre"].ToString();
                        txtTelefono.Text = reader["Telefono"].ToString();
                        txtCorreo.Text = reader["Correo"].ToString();

                        MessageBox.Show("¡Cliente encontrado en el programa de fidelidad! Se han cargado sus datos.", "Cliente Frecuente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cliente no encontrado. Por favor, registre sus datos como cliente nuevo.", "Nuevo Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        idClienteActual = 0;
                        txtNombre.Clear();
                        txtTelefono.Text = txtBuscar.Text; // Autocompleta el teléfono
                        txtCorreo.Clear();
                        txtNombre.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Botón para guardar Cliente (si es nuevo) y registrar la Reserva
        private void btnGuardarReserva_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El nombre y el teléfono del cliente son obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHora.Text))
            {
                MessageBox.Show("Por favor, ingrese la hora de la reserva.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal anticipoVal = 0;
            if (!decimal.TryParse(txtAnticipo.Text, out anticipoVal))
            {
                MessageBox.Show("El formato del anticipo no es válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    // 1. Si idClienteActual == 0, insertamos el nuevo cliente
                    if (idClienteActual == 0)
                    {
                        string queryCliente = "INSERT INTO clientes (Nombre, Telefono, Correo) OUTPUT INSERTED.IdCliente VALUES (@Nombre, @Telefono, @Correo);";
                        SqlCommand cmdCliente = new SqlCommand(queryCliente, conexion, transaccion);
                        cmdCliente.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                        cmdCliente.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());
                        cmdCliente.Parameters.AddWithValue("@Correo", txtCorreo.Text.Trim());

                        idClienteActual = (int)cmdCliente.ExecuteScalar();
                    }
                    else
                    {
                        string queryActCliente = "UPDATE clientes SET Nombre = @Nombre, Correo = @Correo WHERE IdCliente = @IdCliente";
                        SqlCommand cmdAct = new SqlCommand(queryActCliente, conexion, transaccion);
                        cmdAct.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                        cmdAct.Parameters.AddWithValue("@Correo", txtCorreo.Text.Trim());
                        cmdAct.Parameters.AddWithValue("@IdCliente", idClienteActual);
                        cmdAct.ExecuteNonQuery();
                    }

                    // 2. Insertar la Reserva asociada al cliente
                    string queryReserva = "INSERT INTO reservas (IdCliente, Fecha, Hora, NumPersonas, Estado, Anticipo) OUTPUT INSERTED.IdReserva VALUES (@IdCliente, @Fecha, @Hora, @NumPersonas, @Estado, @Anticipo);";
                    SqlCommand cmdReserva = new SqlCommand(queryReserva, conexion, transaccion);
                    cmdReserva.Parameters.AddWithValue("@IdCliente", idClienteActual);
                    cmdReserva.Parameters.AddWithValue("@Fecha", dtpFecha.Value.Date);
                    cmdReserva.Parameters.AddWithValue("@Hora", txtHora.Text.Trim());
                    cmdReserva.Parameters.AddWithValue("@NumPersonas", (int)nudPersonas.Value);
                    cmdReserva.Parameters.AddWithValue("@Estado", cmbEstado.SelectedItem != null ? cmbEstado.SelectedItem.ToString() : "Pendiente");
                    cmdReserva.Parameters.AddWithValue("@Anticipo", anticipoVal);

                    int idReservaGenerada = (int)cmdReserva.ExecuteScalar();

                    transaccion.Commit();

                    MessageBox.Show("¡Reserva y cliente registrados exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir Frm5 enviando el ID de la reserva generada
                    Frm5 formMenu = new Frm5(idReservaGenerada);
                    this.Hide();
                    formMenu.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    MessageBox.Show("Error al guardar en la base de datos: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtHora.Clear();
            if (nudPersonas != null) nudPersonas.Value = 1;
            if (txtAnticipo != null) txtAnticipo.Text = "0.00";
            idClienteActual = 0;
            txtBuscar.Focus();
        }
    }
}