using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Restaurante.Data;

namespace Restaurante
{
    public partial class Form4 : Form
    {
        private int idEmpleadoActual = 1;

        private int idClienteActual = 0;

        public Form4()
        {
            InitializeComponent();

            nudPersonas.ValueChanged += nudPersonas_ValueChanged;

            btnActualizar.Click += btnActualizar_Click;
        }

        private void Frm4_Load(object sender, EventArgs e)
        {
            CargarMesasDisponibles();
            CargarReservas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string telefono = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Ingrese el teléfono del cliente.");
                txtBuscar.Focus();
                return;
            }

            try
            {
                using (SqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    string consulta = @"
                        SELECT IdCliente, NombreCliente,
                               ApellidoCliente, TelefonoCliente
                        FROM Clientes
                        WHERE TelefonoCliente = @Telefono";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = telefono;

                        conexion.Open();

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                idClienteActual = Convert.ToInt32(lector["IdCliente"]);

                                txtNombre.Text = lector["NombreCliente"].ToString();
                                txtApellido.Text = lector["ApellidoCliente"].ToString();
                                txtTelefono.Text = lector["TelefonoCliente"].ToString();

                                MessageBox.Show(
                                    "Cliente encontrado correctamente.",
                                    "Cliente registrado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            else
                            {
                                idClienteActual = 0;

                                txtNombre.Clear();
                                txtApellido.Clear();
                                txtTelefono.Text = telefono;

                                MessageBox.Show(
                                    "Cliente no encontrado. Puede registrar sus datos.",
                                    "Nuevo cliente",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                txtNombre.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar cliente: " + ex.Message);
            }
        }


        private void CargarMesasDisponibles()
        {
            try
            {
                using (SqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    string consulta = @"
                SELECT IdMesa,
                       'Mesa ' + CAST(IdMesa AS VARCHAR(10)) +
                       ' - Capacidad: ' +
                       CAST(CapacidadMesa AS VARCHAR(10)) AS TextoMesa
                FROM Mesas
                WHERE EstadoMesa = 'Disponible'
                AND CapacidadMesa >= @Personas
                ORDER BY IdMesa";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.Add("@Personas", SqlDbType.Int)
                            .Value = Convert.ToInt32(nudPersonas.Value);

                        DataTable tabla = new DataTable();

                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            adaptador.Fill(tabla);
                        }

                        cmbMesa.DataSource = null;
                        cmbMesa.Items.Clear();
                        cmbMesa.DisplayMember = "TextoMesa";
                        cmbMesa.ValueMember = "IdMesa";
                        cmbMesa.DataSource = tabla;

                        if (tabla.Rows.Count > 0)
                        {
                            cmbMesa.SelectedIndex = 0;
                        }
                        else
                        {
                            cmbMesa.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar mesas: " + ex.Message);
            }
        }


        private void nudPersonas_ValueChanged(object sender, EventArgs e)
        {
            CargarMesasDisponibles();
        }

        private void btnGuardarReserva_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Complete los datos del cliente.");
                return;
            }

            if (cmbMesa.SelectedValue == null ||
                cmbMesa.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una mesa disponible.");
                return;
            }

            if (dtpFecha.Value.Date < DateTime.Today)
            {
                MessageBox.Show("La fecha de reserva no puede ser anterior a hoy.");
                return;
            }

            decimal anticipo = nudAnticipo.Value;
            int idMesa = Convert.ToInt32(cmbMesa.SelectedValue);

            try
            {
                using (SqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlTransaction transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            string consultaMesa = @"
                                SELECT COUNT(*)
                                FROM Mesas
                                WHERE IdMesa = @IdMesa
                                AND EstadoMesa = 'Disponible'
                                AND CapacidadMesa >= @Personas";

                            using (SqlCommand comandoMesa =
                                new SqlCommand(consultaMesa, conexion, transaccion))
                            {
                                comandoMesa.Parameters.Add("@IdMesa", SqlDbType.Int).Value = idMesa;
                                comandoMesa.Parameters.Add("@Personas", SqlDbType.Int)
                                    .Value = Convert.ToInt32(nudPersonas.Value);

                                int mesaValida = Convert.ToInt32(comandoMesa.ExecuteScalar());

                                if (mesaValida == 0)
                                {
                                    throw new Exception("La mesa ya no está disponible o no tiene capacidad suficiente.");
                                }
                            }
                            if (idClienteActual == 0)
                            {
                                string insertarCliente = @"
                                    INSERT INTO Clientes
                                    (NombreCliente, ApellidoCliente, TelefonoCliente, PuntosFidelidad)
                                    OUTPUT INSERTED.IdCliente
                                    VALUES (@Nombre, @Apellido, @Telefono, 0)";

                                using (SqlCommand comandoCliente =
                                    new SqlCommand(insertarCliente, conexion, transaccion))
                                {
                                    comandoCliente.Parameters.Add("@Nombre", SqlDbType.VarChar)
                                        .Value = txtNombre.Text.Trim();

                                    comandoCliente.Parameters.Add("@Apellido", SqlDbType.VarChar)
                                        .Value = txtApellido.Text.Trim();

                                    comandoCliente.Parameters.Add("@Telefono", SqlDbType.VarChar)
                                        .Value = txtTelefono.Text.Trim();

                                    idClienteActual = Convert.ToInt32(
                                        comandoCliente.ExecuteScalar());
                                }
                            }

                            string insertarReserva = @"
                                INSERT INTO Reservas
                                (IdCliente, IdMesa, IdEmpleado,
                                 FechaReserva, HoraReserva, AnticipoReserva)
                                VALUES
                                (@IdCliente, @IdMesa, @IdEmpleado,
                                 @Fecha, @Hora, @Anticipo)";

                            using (SqlCommand comandoReserva =
                                new SqlCommand(insertarReserva, conexion, transaccion))
                            {
                                comandoReserva.Parameters.Add("@IdCliente", SqlDbType.Int)
                                    .Value = idClienteActual;

                                comandoReserva.Parameters.Add("@IdMesa", SqlDbType.Int)
                                    .Value = idMesa;

                                comandoReserva.Parameters.Add("@IdEmpleado", SqlDbType.Int)
                                    .Value = idEmpleadoActual;

                                comandoReserva.Parameters.Add("@Fecha", SqlDbType.Date)
                                    .Value = dtpFecha.Value.Date;

                                comandoReserva.Parameters.Add("@Hora", SqlDbType.Time)
                                    .Value = dtpHora.Value.TimeOfDay;

                                comandoReserva.Parameters.Add("@Anticipo", SqlDbType.Decimal)
                                    .Value = anticipo;

                                comandoReserva.Parameters["@Anticipo"].Precision = 10;
                                comandoReserva.Parameters["@Anticipo"].Scale = 2;

                                comandoReserva.ExecuteNonQuery();
                            }

                            transaccion.Commit();

                            MessageBox.Show(
                                "¡Cliente y reserva registrados correctamente!",
                                "Registro exitoso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        catch
                        {
                            transaccion.Rollback();
                            throw;
                        }
                    }
                }

                LimpiarCampos();
                CargarMesasDisponibles();
                CargarReservas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo guardar la reserva:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarReservas()
        {
            try
            {
                using (SqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    string consulta = @"
                        SELECT
                            R.IdReserva,
                            C.NombreCliente,
                            C.ApellidoCliente,
                            C.TelefonoCliente,
                            M.IdMesa,
                            R.FechaReserva,
                            R.HoraReserva,
                            R.AnticipoReserva
                        FROM Reservas R
                        INNER JOIN Clientes C
                            ON R.IdCliente = C.IdCliente
                        INNER JOIN Mesas M
                            ON R.IdMesa = M.IdMesa
                        ORDER BY R.FechaReserva DESC, R.HoraReserva DESC";

                    using (SqlDataAdapter adaptador =
                        new SqlDataAdapter(consulta, conexion))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        dgvReservas.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar reservas: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarMesasDisponibles();
            CargarReservas();

            MessageBox.Show("Lista actualizada correctamente.");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            idClienteActual = 0;

            txtBuscar.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();

            nudPersonas.Value = 2;
            nudAnticipo.Value = 0;

            dtpFecha.Value = DateTime.Today;
            dtpHora.Value = DateTime.Now;

            cmbMesa.SelectedIndex = -1;

            txtBuscar.Focus();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void gbCliente_Enter(object sender, EventArgs e)
        {
        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {
        }
    }
}
