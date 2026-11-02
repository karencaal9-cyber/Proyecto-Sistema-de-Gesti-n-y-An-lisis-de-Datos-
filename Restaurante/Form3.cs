using Restaurante.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurante.Models;

namespace Restaurante
{
    public partial class Form3 : Form
    {
        private MesaDAL mesaDAL = new MesaDAL();
        private ZonaDAL zonaDAL = new ZonaDAL();

        public Form3()
        {
            InitializeComponent();

            CargarZonas();
            CargarMesas();
            btnLimpiar.Click += btnLimpiar_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnEditar.Click += btnEditar_Click;
            btnEliminar.Click += btnEliminar_Click;

        }
        private void CargarZonas()
        {
            try
            {
                var zonas = zonaDAL.ObtenerZonas();

                cmbZona.DataSource = null;
                cmbZona.DataSource = zonas;
                cmbZona.DisplayMember = "NombreZona";
                cmbZona.ValueMember = "IdZona";
                cmbZona.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las zonas: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void CargarMesas()
        {
            try
            {
                var mesas = mesaDAL.ObtenerMesas();

                dgvMesas.DataSource = null;
                dgvMesas.DataSource = mesas;
                dgvMesas.Columns["IdMesa"].FillWeight = 55;
                dgvMesas.Columns["CapacidadMesa"].FillWeight = 75;
                dgvMesas.Columns["EstadoMesa"].FillWeight = 85;
                dgvMesas.Columns["NombreZona"].FillWeight = 120;

                dgvMesas.Columns["IdZona"].Visible = false;

                dgvMesas.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                dgvMesas.ClearSelection();

                CargarMapaMesas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las mesas: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        
private void CargarMapaMesas()
        {
            flpMesas.Controls.Clear();

            var mesas = mesaDAL.ObtenerMesas();

            foreach (Mesa mesa in mesas)
            {
                Button botonMesa = new Button();

                botonMesa.Name = "mesa_" + mesa.IdMesa;
                botonMesa.Text = "MESA " + mesa.IdMesa +
                 "\n" + mesa.CapacidadMesa + " personas" +
                 "\n" + mesa.NombreZona +
                 "\n" + mesa.EstadoMesa;

                botonMesa.Size = new Size(125, 100);
                botonMesa.Margin = new Padding(8);
                botonMesa.FlatStyle = FlatStyle.Flat;
                botonMesa.FlatAppearance.BorderSize = 0;
                botonMesa.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                botonMesa.TextAlign = ContentAlignment.MiddleCenter;
                botonMesa.ForeColor = Color.FromArgb(91, 65, 74);
                botonMesa.Tag = mesa.IdMesa;
                botonMesa.Click += BotonMesa_Click;

                if (mesa.EstadoMesa == "Disponible")
                {
                    botonMesa.BackColor = Color.FromArgb(144, 202, 164);
                }
                else if (mesa.EstadoMesa == "Ocupada")
                {
                    botonMesa.BackColor = Color.FromArgb(220, 120, 140);
                }
                else if (mesa.EstadoMesa == "Reservada")
                {
                    botonMesa.BackColor = Color.FromArgb(250, 215, 120);
                }
                else
                {
                    botonMesa.BackColor = Color.LightGray;
                }

                flpMesas.Controls.Add(botonMesa);
            }
        }

        private void BotonMesa_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;

            if (boton != null)
            {
                int idMesa = Convert.ToInt32(boton.Tag);

                foreach (DataGridViewRow fila in dgvMesas.Rows)
                {
                    if (Convert.ToInt32(fila.Cells["IdMesa"].Value) == idMesa)
                    {
                        dgvMesas.ClearSelection();
                        fila.Selected = true;

                        dgvMesas.CurrentCell = fila.Cells["IdMesa"];

                        nudCapacidad.Value = Convert.ToDecimal(
                            fila.Cells["CapacidadMesa"].Value
                        );

                        cmbEstado.SelectedItem =
                            fila.Cells["EstadoMesa"].Value.ToString();

                        cmbZona.SelectedValue =
                            Convert.ToInt32(fila.Cells["IdZona"].Value);

                        txtNumeroMesa.Text = idMesa.ToString();

                        break;
                    }
                }
            }
        }

        private void LimpiarCampos()
        {
            txtNumeroMesa.Clear();
            nudCapacidad.Value = 2;
            cmbZona.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;

            dgvMesas.ClearSelection();
        }


        private void pnlInformacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMapaMesas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNumeroMesa.Text))
                {
                    MessageBox.Show("Selecciona una mesa para editar.");
                    return;
                }

                if (cmbZona.SelectedIndex == -1 || cmbEstado.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecciona una zona y un estado.");
                    return;
                }

                Mesa mesa = new Mesa();

                mesa.IdMesa = Convert.ToInt32(txtNumeroMesa.Text);
                mesa.CapacidadMesa = Convert.ToInt32(nudCapacidad.Value);
                mesa.EstadoMesa = cmbEstado.SelectedItem.ToString();
                mesa.IdZona = Convert.ToInt32(cmbZona.SelectedValue);

                mesaDAL.ActualizarMesa(mesa);

                MessageBox.Show("Mesa actualizada correctamente.");

                CargarMesas();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo actualizar la mesa: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNumeroMesa.Text))
                {
                    MessageBox.Show("Selecciona una mesa para eliminar.");
                    return;
                }

                int idMesa = Convert.ToInt32(txtNumeroMesa.Text);

                DialogResult respuesta = MessageBox.Show(
                    "¿Estás segura de que deseas eliminar esta mesa?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    mesaDAL.EliminarMesa(idMesa);

                    MessageBox.Show("Mesa eliminada correctamente.");

                    CargarMesas();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo eliminar la mesa. Puede estar relacionada con una reserva.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
