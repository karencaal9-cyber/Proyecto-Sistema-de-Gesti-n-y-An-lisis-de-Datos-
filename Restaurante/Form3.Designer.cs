namespace Restaurante
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNumeroMesa = new System.Windows.Forms.TextBox();
            this.lblNumeroMesa = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.lblZona = new System.Windows.Forms.Label();
            this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblTituloInformacion = new System.Windows.Forms.Label();
            this.pnlMapaMesas = new System.Windows.Forms.Panel();
            this.flpMesas = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.lblOcupada = new System.Windows.Forms.Label();
            this.lblReservada = new System.Windows.Forms.Label();
            this.pnlEncabezado.SuspendLayout();
            this.pnlInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).BeginInit();
            this.pnlMapaMesas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(982, 85);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblTitulo.Location = new System.Drawing.Point(301, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(438, 41);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "GESTIÓN DE MESAS Y ZONAS";
            // 
            // pnlInformacion
            // 
            this.pnlInformacion.BackColor = System.Drawing.Color.White;
            this.pnlInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInformacion.Controls.Add(this.btnLimpiar);
            this.pnlInformacion.Controls.Add(this.btnEliminar);
            this.pnlInformacion.Controls.Add(this.btnEditar);
            this.pnlInformacion.Controls.Add(this.btnGuardar);
            this.pnlInformacion.Controls.Add(this.txtNumeroMesa);
            this.pnlInformacion.Controls.Add(this.lblNumeroMesa);
            this.pnlInformacion.Controls.Add(this.cmbEstado);
            this.pnlInformacion.Controls.Add(this.lblEstado);
            this.pnlInformacion.Controls.Add(this.cmbZona);
            this.pnlInformacion.Controls.Add(this.lblZona);
            this.pnlInformacion.Controls.Add(this.nudCapacidad);
            this.pnlInformacion.Controls.Add(this.lblCapacidad);
            this.pnlInformacion.Controls.Add(this.lblTituloInformacion);
            this.pnlInformacion.Location = new System.Drawing.Point(20, 105);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Size = new System.Drawing.Size(430, 261);
            this.pnlInformacion.TabIndex = 1;
            this.pnlInformacion.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInformacion_Paint);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.btnLimpiar.Location = new System.Drawing.Point(305, 200);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 35);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar ";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(125)))), ((int)(((byte)(145)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.btnEliminar.Location = new System.Drawing.Point(209, 200);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 35);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.btnEditar.Location = new System.Drawing.Point(113, 200);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 35);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Eidtar ";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(183)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.btnGuardar.Location = new System.Drawing.Point(17, 200);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 35);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtNumeroMesa
            // 
            this.txtNumeroMesa.Location = new System.Drawing.Point(197, 165);
            this.txtNumeroMesa.Name = "txtNumeroMesa";
            this.txtNumeroMesa.ReadOnly = true;
            this.txtNumeroMesa.Size = new System.Drawing.Size(166, 22);
            this.txtNumeroMesa.TabIndex = 8;
            // 
            // lblNumeroMesa
            // 
            this.lblNumeroMesa.AutoSize = true;
            this.lblNumeroMesa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblNumeroMesa.Location = new System.Drawing.Point(51, 163);
            this.lblNumeroMesa.Name = "lblNumeroMesa";
            this.lblNumeroMesa.Size = new System.Drawing.Size(140, 23);
            this.lblNumeroMesa.TabIndex = 7;
            this.lblNumeroMesa.Text = "Número de mesa:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Disponible",
            "",
            "",
            "",
            "",
            "Ocupada",
            "",
            "",
            "",
            "",
            "Reservada"});
            this.cmbEstado.Location = new System.Drawing.Point(113, 127);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(250, 24);
            this.cmbEstado.TabIndex = 6;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblEstado.Location = new System.Drawing.Point(51, 128);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(62, 23);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado:";
            // 
            // cmbZona
            // 
            this.cmbZona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.cmbZona.FormattingEnabled = true;
            this.cmbZona.Location = new System.Drawing.Point(113, 89);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.Size = new System.Drawing.Size(250, 24);
            this.cmbZona.TabIndex = 2;
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblZona.Location = new System.Drawing.Point(55, 87);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(52, 23);
            this.lblZona.TabIndex = 4;
            this.lblZona.Text = "Zona:";
            // 
            // nudCapacidad
            // 
            this.nudCapacidad.Location = new System.Drawing.Point(151, 53);
            this.nudCapacidad.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCapacidad.Name = "nudCapacidad";
            this.nudCapacidad.Size = new System.Drawing.Size(150, 22);
            this.nudCapacidad.TabIndex = 3;
            this.nudCapacidad.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblCapacidad.Location = new System.Drawing.Point(55, 50);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(90, 23);
            this.lblCapacidad.TabIndex = 2;
            this.lblCapacidad.Text = "Capacidad:";
            // 
            // lblTituloInformacion
            // 
            this.lblTituloInformacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInformacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblTituloInformacion.Location = new System.Drawing.Point(11, 8);
            this.lblTituloInformacion.Name = "lblTituloInformacion";
            this.lblTituloInformacion.Size = new System.Drawing.Size(400, 30);
            this.lblTituloInformacion.TabIndex = 0;
            this.lblTituloInformacion.Text = "\tINFORMACIÓN DE LA MESA";
            this.lblTituloInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMapaMesas
            // 
            this.pnlMapaMesas.AutoScroll = true;
            this.pnlMapaMesas.BackColor = System.Drawing.Color.White;
            this.pnlMapaMesas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMapaMesas.Controls.Add(this.flpMesas);
            this.pnlMapaMesas.Controls.Add(this.label1);
            this.pnlMapaMesas.Location = new System.Drawing.Point(469, 108);
            this.pnlMapaMesas.Name = "pnlMapaMesas";
            this.pnlMapaMesas.Size = new System.Drawing.Size(501, 470);
            this.pnlMapaMesas.TabIndex = 2;
            this.pnlMapaMesas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMapaMesas_Paint);
            // 
            // flpMesas
            // 
            this.flpMesas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpMesas.AutoScroll = true;
            this.flpMesas.Location = new System.Drawing.Point(24, 67);
            this.flpMesas.Name = "flpMesas";
            this.flpMesas.Size = new System.Drawing.Size(456, 384);
            this.flpMesas.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "MAPA DEL RESTAURANTE ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvMesas
            // 
            this.dgvMesas.AllowUserToAddRows = false;
            this.dgvMesas.AllowUserToDeleteRows = false;
            this.dgvMesas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMesas.BackgroundColor = System.Drawing.Color.White;
            this.dgvMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesas.Location = new System.Drawing.Point(20, 390);
            this.dgvMesas.MultiSelect = false;
            this.dgvMesas.Name = "dgvMesas";
            this.dgvMesas.ReadOnly = true;
            this.dgvMesas.RowHeadersWidth = 51;
            this.dgvMesas.RowTemplate.Height = 24;
            this.dgvMesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMesas.Size = new System.Drawing.Size(430, 188);
            this.dgvMesas.TabIndex = 3;
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.AutoSize = true;
            this.lblLeyenda.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblLeyenda.Location = new System.Drawing.Point(474, 597);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(194, 23);
            this.lblLeyenda.TabIndex = 8;
            this.lblLeyenda.Text = "ESTADOS DE LAS MESAS:";
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(164)))));
            this.lblDisponible.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.lblDisponible.Location = new System.Drawing.Point(680, 597);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(86, 23);
            this.lblDisponible.TabIndex = 9;
            this.lblDisponible.Text = "Disponible";
            // 
            // lblOcupada
            // 
            this.lblOcupada.AutoSize = true;
            this.lblOcupada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(120)))), ((int)(((byte)(140)))));
            this.lblOcupada.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.lblOcupada.Location = new System.Drawing.Point(788, 597);
            this.lblOcupada.Name = "lblOcupada";
            this.lblOcupada.Size = new System.Drawing.Size(75, 23);
            this.lblOcupada.TabIndex = 10;
            this.lblOcupada.Text = "Ocupada";
            // 
            // lblReservada
            // 
            this.lblReservada.AutoSize = true;
            this.lblReservada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(215)))), ((int)(((byte)(120)))));
            this.lblReservada.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.lblReservada.Location = new System.Drawing.Point(886, 597);
            this.lblReservada.Name = "lblReservada";
            this.lblReservada.Size = new System.Drawing.Size(84, 23);
            this.lblReservada.TabIndex = 11;
            this.lblReservada.Text = "Reservada";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(982, 629);
            this.Controls.Add(this.lblReservada);
            this.Controls.Add(this.lblOcupada);
            this.Controls.Add(this.lblDisponible);
            this.Controls.Add(this.lblLeyenda);
            this.Controls.Add(this.dgvMesas);
            this.Controls.Add(this.pnlInformacion);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.pnlMapaMesas);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Mesas y Zonas.";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlInformacion.ResumeLayout(false);
            this.pnlInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).EndInit();
            this.pnlMapaMesas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.Label lblTituloInformacion;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.NumericUpDown nudCapacidad;
        private System.Windows.Forms.ComboBox cmbZona;
        private System.Windows.Forms.Label lblZona;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtNumeroMesa;
        private System.Windows.Forms.Label lblNumeroMesa;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel pnlMapaMesas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpMesas;
        private System.Windows.Forms.DataGridView dgvMesas;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.Label lblOcupada;
        private System.Windows.Forms.Label lblReservada;
    }
}