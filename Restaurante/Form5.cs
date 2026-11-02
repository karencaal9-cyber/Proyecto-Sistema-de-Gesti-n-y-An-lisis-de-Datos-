using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Restaurante
{
    public partial class Form5 : Form
    {
        private int idReservaRecibido;
        private DataTable dtMenu = new DataTable();
        private DataTable dtDetalle = new DataTable();

        public Form5(int idReserva)
        {
            InitializeComponent();
            idReservaRecibido = idReserva;
            lblIdReserva.Text = "ID de Reserva Activa: " + idReservaRecibido.ToString();
        }

        public Form5()
        {
            InitializeComponent();
            idReservaRecibido = 1;
            lblIdReserva.Text = "ID de Reserva Activa: [---]";
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            InicializarMenuEnMemoria();
            InicializarDetalleEnMemoria();
        }

        private void InicializarMenuEnMemoria()
        {
            dtMenu.Columns.Add("IdMenu", typeof(int));
            dtMenu.Columns.Add("NombrePlatillo", typeof(string));
            dtMenu.Columns.Add("Precio", typeof(decimal));

            dtMenu.Rows.Add(1, "Hamburguesa Especial", 45.00m);
            dtMenu.Rows.Add(2, "Pizza Familiar", 120.00m);
            dtMenu.Rows.Add(3, "Papas Fritas", 25.00m);
            dtMenu.Rows.Add(4, "Refresco Natural", 15.00m);
            dtMenu.Rows.Add(5, "Postre de Brownie", 30.00m);

            cmbMenu.DataSource = dtMenu;
            cmbMenu.DisplayMember = "NombrePlatillo";
            cmbMenu.ValueMember = "IdMenu";
        }

        private void InicializarDetalleEnMemoria()
        {
            dtDetalle.Columns.Add("IdDetalle", typeof(int));
            dtDetalle.Columns.Add("NombrePlatillo", typeof(string));
            dtDetalle.Columns.Add("Cantidad", typeof(int));
            dtDetalle.Columns.Add("Precio", typeof(decimal));
            dtDetalle.Columns.Add("Subtotal", typeof(decimal), "Cantidad * Precio"); 
            dtDetalle.Columns.Add("Observaciones", typeof(string));

            dgvDetalle.DataSource = dtDetalle;
        }

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

        private void btnImprimirPDF_Click(object sender, EventArgs e)
        {
            if (dtDetalle.Rows.Count == 0)
            {
                MessageBox.Show("No hay platillos agregados al detalle para generar el comprobante.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigoConfirmacion = "RES-" + idReservaRecibido.ToString("D5") + "-" + DateTime.Now.Year.ToString();

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivo de Texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                saveFileDialog.Title = "Guardar Comprobante de Reserva";
                saveFileDialog.FileName = $"Comprobante_{codigoConfirmacion}.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("==================================================");
                    sb.AppendLine("         SISTEMA DE RESERVAS - RESTAURANTE        ");
                    sb.AppendLine("==================================================");
                    sb.AppendLine($"Código de Confirmación : {codigoConfirmacion}");
                    sb.AppendLine($"ID de Reserva Activa   : {idReservaRecibido}");
                    sb.AppendLine($"Fecha de Emisión       : {DateTime.Now}");
                    sb.AppendLine("--------------------------------------------------");
                    sb.AppendLine("DETALLE DEL PEDIDO:");
                    sb.AppendLine("--------------------------------------------------");

                    decimal totalGeneral = 0;

                    foreach (DataRow row in dtDetalle.Rows)
                    {
                        string platillo = row["NombrePlatillo"].ToString();
                        int cantidad = Convert.ToInt32(row["Cantidad"]);
                        decimal precio = Convert.ToDecimal(row["Precio"]);
                        decimal subtotal = Convert.ToDecimal(row["Subtotal"]);
                        string observaciones = row["Observaciones"].ToString();

                        sb.AppendLine($"- {platillo}");
                        sb.AppendLine($"  Cantidad: {cantidad} | Precio U.: Q{precio:F2} | Subtotal: Q{subtotal:F2}");

                        if (!string.IsNullOrEmpty(observaciones))
                        {
                            sb.AppendLine($"  Notas: {observaciones}");
                        }
                        sb.AppendLine("");

                        totalGeneral += subtotal;
                    }

                    sb.AppendLine("--------------------------------------------------");
                    sb.AppendLine($"TOTAL A PAGAR: Q{totalGeneral:F2}");
                    sb.AppendLine("==================================================");
                    sb.AppendLine("¡Gracias por su preferencia! Presente este código al llegar.");

                    System.IO.File.WriteAllText(saveFileDialog.FileName, sb.ToString(), Encoding.UTF8);

                    MessageBox.Show($"¡Comprobante guardado con éxito!\n\nUbicación:\n{saveFileDialog.FileName}",
                                    "Archivo Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtObservaciones.Clear();
            nudcantidadd.Value = 1;

            if (cmbMenu.Items.Count > 0)
            {
                cmbMenu.SelectedIndex = 0;
            }
            dtDetalle.Rows.Clear();

            MessageBox.Show("Se ha limpiado el formulario para una nueva captura.", "Nuevo Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbMenu.SelectedItem == null) return;

            DataRowView rowView = (DataRowView)cmbMenu.SelectedItem;
            string nombrePlatillo = rowView["NombrePlatillo"].ToString();
            decimal precio = Convert.ToDecimal(rowView["Precio"]);
            int cantidad = (int)nudcantidadd.Value;
            string observaciones = txtObservaciones.Text.Trim();

            int idDetalleTemp = dtDetalle.Rows.Count + 1;

            dtDetalle.Rows.Add(idDetalleTemp, nombrePlatillo, cantidad, precio, 0, observaciones);

            MessageBox.Show("Platillo agregado al detalle correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtObservaciones.Clear();
            nudcantidadd.Value = 1;
        }
    }
}