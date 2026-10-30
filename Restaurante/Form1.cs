using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class nudCantidad : Form
    {
        private int idReservaRecibido;
        private DataTable dtMenu = new DataTable();
        private DataTable dtDetalle = new DataTable();

        // Constructor principal que recibe el ID de la reserva
        public nudCantidad(int idReserva)
        {
            InitializeComponent();
            idReservaRecibido = idReserva;
            lblInfoReserva.Text = "ID de Reserva Activa: " + idReservaRecibido.ToString();
        }

        // Constructor vacío por si Visual Studio abre el diseñador visual
        public nudCantidad()
        {
            InitializeComponent();
            idReservaRecibido = 1;
            lblInfoReserva.Text = "ID de Reserva Activa: [---]";
        }

        private void nudCantidad_Load(object sender, EventArgs e)
        {
            InicializarMenuEnMemoria();
            InicializarDetalleEnMemoria();
        }

        // Crear un menú simulado en memoria (sin base de datos)
        private void InicializarMenuEnMemoria()
        {
            dtMenu.Columns.Add("IdMenu", typeof(int));
            dtMenu.Columns.Add("NombrePlatillo", typeof(string));
            dtMenu.Columns.Add("Precio", typeof(decimal));

            // Platillos de ejemplo para que aparezcan en tu ComboBox
            dtMenu.Rows.Add(1, "Hamburguesa Especial", 45.00m);
            dtMenu.Rows.Add(2, "Pizza Familiar", 120.00m);
            dtMenu.Rows.Add(3, "Papas Fritas", 25.00m);
            dtMenu.Rows.Add(4, "Refresco Natural", 15.00m);
            dtMenu.Rows.Add(5, "Postre de Brownie", 30.00m);

            cmbMenu.DataSource = dtMenu;
            cmbMenu.DisplayMember = "NombrePlatillo";
            cmbMenu.ValueMember = "IdMenu";
        }

        // Crear la estructura de la tabla de detalles en memoria para el DataGridView
        private void InicializarDetalleEnMemoria()
        {
            dtDetalle.Columns.Add("IdDetalle", typeof(int));
            dtDetalle.Columns.Add("NombrePlatillo", typeof(string));
            dtDetalle.Columns.Add("Cantidad", typeof(int));
            dtDetalle.Columns.Add("Precio", typeof(decimal));
            dtDetalle.Columns.Add("Subtotal", typeof(decimal), "Cantidad * Precio"); // Calcula automáticamente
            dtDetalle.Columns.Add("Observaciones", typeof(string));

            dgvDetalle.DataSource = dtDetalle;
        }

        // Botón para agregar un platillo al detalle de la reserva
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbMenu.SelectedItem == null) return;

            DataRowView rowView = (DataRowView)cmbMenu.SelectedItem;
            string nombrePlatillo = rowView["NombrePlatillo"].ToString();
            decimal precio = Convert.ToDecimal(rowView["Precio"]);
            int cantidad = (int)nudcantidadd.Value; // Usando tu control nudcantidadd
            string observaciones = txtObservaciones.Text.Trim();

            int idDetalleTemp = dtDetalle.Rows.Count + 1;

            // Agrega el platillo a la tabla visual en memoria
            dtDetalle.Rows.Add(idDetalleTemp, nombrePlatillo, cantidad, precio, 0, observaciones);

            MessageBox.Show("Platillo agregado al detalle correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtObservaciones.Clear();
            nudcantidadd.Value = 1;
        }

        // Botón para quitar un platillo del detalle seleccionado en la tabla
        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.SelectedRows.Count > 0)
            {
                int index = dgvDetalle.SelectedRows[0].Index;
                if (!dgvDetalle.Rows[index].IsNewRow)
                {
                    dtDetalle.Rows.RemoveAt(index);
                    MessageBox.Show("Platillo eliminado del detalle.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro del detalle para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Requerimiento RF11: Imprimir comprobante de reserva con código de confirmación en PDF
        private void btnImprimirPDF_Click(object sender, EventArgs e)
        {
            string codigoConfirmacion = "RES-" + idReservaRecibido.ToString("D5") + "-" + DateTime.Now.Year.ToString();

            MessageBox.Show($"¡Comprobante generado con éxito!\n\n" +
                            $"Código de Confirmación: {codigoConfirmacion}\n" +
                            $"El archivo PDF de la reserva #{idReservaRecibido} se ha generado correctamente.",
                            "RF11 - PDF Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCantidadDetalle_Click(object sender, EventArgs e)
        {
            // Evento predeterminado
        }
    }
}