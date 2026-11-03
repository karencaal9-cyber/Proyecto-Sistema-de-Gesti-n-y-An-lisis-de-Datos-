using iTextSharp.text;
using iTextSharp.text.pdf;
using Restaurante.Data;
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


namespace Restaurante
{
    public partial class Form5 : Form
    {
        private int idReservaRecibido;
        private DataTable dtMenu = new DataTable();
        private DataTable dtDetalle = new DataTable();

       

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
            CargarReservasEnComboBox();
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
            dtDetalle.Columns.Add("IdMenu", typeof(int));
            dtDetalle.Columns.Add("NombrePlatillo", typeof(string));
            dtDetalle.Columns.Add("Cantidad", typeof(int));
            dtDetalle.Columns.Add("Precio", typeof(decimal));
            dtDetalle.Columns.Add("Subtotal", typeof(decimal), "Cantidad * Precio"); 
            dtDetalle.Columns.Add("Observaciones", typeof(string));

            dgvDetalle.DataSource = dtDetalle;

            if (dgvDetalle.Columns["IdMenu"] != null)
            {
                dgvDetalle.Columns["IdMenu"].Visible = false;
            }
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
            if (cmbReservas.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione una reserva válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtDetalle.Rows.Count == 0)
            {
                MessageBox.Show("No hay platillos agregados al detalle para generar el comprobante.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idReservaSeleccionada = Convert.ToInt32(cmbReservas.SelectedValue);

            try
            {
                using (SqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    foreach (DataRow row in dtDetalle.Rows)
                    {
                        int idMenu = Convert.ToInt32(row["IdMenu"]);
                        int cantidad = Convert.ToInt32(row["Cantidad"]);
                        string observaciones = row["Observaciones"].ToString();

                        string query = @"INSERT INTO DetalleReserva (IdReserva, IdMenu, CantidadReserva, Observaciones) 
                                 VALUES (@IdReserva, @IdMenu, @Cantidad, @Observaciones)";
                        using (SqlCommand comando = new SqlCommand(query, conexion))
                        {
                            comando.Parameters.AddWithValue("@IdReserva", idReservaSeleccionada);
                            comando.Parameters.AddWithValue("@IdMenu", idMenu);
                            comando.Parameters.AddWithValue("@Cantidad", cantidad);
                            comando.Parameters.AddWithValue("@Observaciones", string.IsNullOrEmpty(observaciones) ? (object)DBNull.Value : observaciones);

                            comando.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el detalle en la base de datos: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string codigoConfirmacion = "RES-" + idReservaSeleccionada.ToString("D5") + "-" + DateTime.Now.Year.ToString();

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";
                saveFileDialog.Title = "Guardar Comprobante de Reserva";
                saveFileDialog.FileName = $"Comprobante_{codigoConfirmacion}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Document doc = new Document(PageSize.A4, 36, 36, 36, 36);
                        PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                        doc.Open();

                        iTextSharp.text.Font fontTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, iTextSharp.text.BaseColor.DARK_GRAY);
                        iTextSharp.text.Font fontSub = FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.BaseColor.BLACK);
                        iTextSharp.text.Font fontBold = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, iTextSharp.text.BaseColor.BLACK);
                        iTextSharp.text.Font fontFooter = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 9, iTextSharp.text.BaseColor.GRAY);

                        Paragraph titulo = new Paragraph("SISTEMA DE RESERVAS - RESTAURANTE\nCOMPROBANTE DE RESERVA\n\n", fontTitulo);
                        titulo.Alignment = Element.ALIGN_CENTER;
                        doc.Add(titulo);

                        doc.Add(new Paragraph($"Código de Confirmación : {codigoConfirmacion}", fontBold));
                        doc.Add(new Paragraph($"ID de Reserva Activa   : {idReservaSeleccionada}", fontSub));
                        doc.Add(new Paragraph($"Fecha de Emisión       : {DateTime.Now}\n", fontSub));

                        PdfPTable tabla = new PdfPTable(4);
                        tabla.WidthPercentage = 100;
                        tabla.SetWidths(new float[] { 40f, 15f, 20f, 25f });

                        string[] headers = { "Platillo", "Cant.", "Precio U.", "Subtotal" };
                        foreach (string header in headers)
                        {
                            PdfPCell celda = new PdfPCell(new Phrase(header, fontBold));
                            celda.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
                            celda.HorizontalAlignment = Element.ALIGN_CENTER;
                            tabla.AddCell(celda);
                        }

                        decimal totalGeneral = 0;

                        foreach (DataRow row in dtDetalle.Rows)
                        {
                            string platillo = row["NombrePlatillo"].ToString();
                            int cantidad = Convert.ToInt32(row["Cantidad"]);
                            decimal precio = Convert.ToDecimal(row["Precio"]);
                            decimal subtotal = Convert.ToDecimal(row["Subtotal"]);
                            string observaciones = row["Observaciones"].ToString();

                            string textoPlatillo = platillo;
                            if (!string.IsNullOrEmpty(observaciones))
                            {
                                textoPlatillo += "\n(Nota: " + observaciones + ")";
                            }

                            tabla.AddCell(new PdfPCell(new Phrase(textoPlatillo, fontSub)));

                            PdfPCell celdaCant = new PdfPCell(new Phrase(cantidad.ToString(), fontSub));
                            celdaCant.HorizontalAlignment = Element.ALIGN_CENTER;
                            tabla.AddCell(celdaCant);

                            PdfPCell celdaPrecio = new PdfPCell(new Phrase($"Q{precio:F2}", fontSub));
                            celdaPrecio.HorizontalAlignment = Element.ALIGN_RIGHT;
                            tabla.AddCell(celdaPrecio);

                            PdfPCell celdaSub = new PdfPCell(new Phrase($"Q{subtotal:F2}", fontSub));
                            celdaSub.HorizontalAlignment = Element.ALIGN_RIGHT;
                            tabla.AddCell(celdaSub);

                            totalGeneral += subtotal;
                        }

                        doc.Add(tabla);

                        doc.Add(new Paragraph("\n", fontSub));
                        Paragraph total = new Paragraph($"TOTAL A PAGAR: Q{totalGeneral:F2}\n\n", fontTitulo);
                        total.Alignment = Element.ALIGN_RIGHT;
                        doc.Add(total);

                        Paragraph footer = new Paragraph("¡Gracias por su preferencia! Presente este código al llegar al restaurante.", fontFooter);
                        footer.Alignment = Element.ALIGN_CENTER;
                        doc.Add(footer);

                        doc.Close();

                        MessageBox.Show($"¡Detalle guardado en BD y PDF generado con éxito!\n\nUbicación:\n{saveFileDialog.FileName}",
                                        "Proceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dtDetalle.Rows.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar el archivo PDF: " + ex.Message, "Error PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
            int idMenu = Convert.ToInt32(rowView["IdMenu"]);
            string nombrePlatillo = rowView["NombrePlatillo"].ToString();
            decimal precio = Convert.ToDecimal(rowView["Precio"]);
            int cantidad = (int)nudcantidadd.Value;
            string observaciones = txtObservaciones.Text.Trim();

            int idDetalleTemp = dtDetalle.Rows.Count + 1;

            dtDetalle.Rows.Add(idDetalleTemp, idMenu, nombrePlatillo, cantidad, precio, 0, observaciones);

            MessageBox.Show("Platillo agregado al detalle correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtObservaciones.Clear();
            nudcantidadd.Value = 1;
        }

        private void CargarReservasEnComboBox()
        {
            try
            {
                using (SqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    string query = @"SELECT R.IdReserva, 
                             ('Reserva #' + CAST(R.IdReserva AS VARCHAR) + ' - ' + C.NombreCliente + ' ' + C.ApellidoCliente) AS InfoReserva 
                             FROM Reservas R
                             INNER JOIN Clientes C ON R.IdCliente = C.IdCliente
                             ORDER BY R.IdReserva DESC";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataTable tablaReservas = new DataTable();
                        adaptador.Fill(tablaReservas);

                        cmbReservas.DataSource = tablaReservas;
                        cmbReservas.DisplayMember = "InfoReserva";
                        cmbReservas.ValueMember = "IdReserva";

                        if (tablaReservas.Rows.Count > 0)
                        {
                            cmbReservas.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las reservas en el selector: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}