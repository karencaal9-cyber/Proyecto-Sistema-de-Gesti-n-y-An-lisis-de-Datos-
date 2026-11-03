namespace Restaurante
{
    partial class Form4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblTituloCliente = new System.Windows.Forms.Label();
            this.pnlReserva = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardarReserva = new System.Windows.Forms.Button();
            this.nudAnticipo = new System.Windows.Forms.NumericUpDown();
            this.lblAnticipo = new System.Windows.Forms.Label();
            this.cmbMesa = new System.Windows.Forms.ComboBox();
            this.lblMesa = new System.Windows.Forms.Label();
            this.nudPersonas = new System.Windows.Forms.NumericUpDown();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTituloReserva = new System.Windows.Forms.Label();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnQuitarCliente = new System.Windows.Forms.Button();
            this.pnlEncabezado.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.pnlReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnticipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1200, 85);
            this.pnlEncabezado.TabIndex = 23;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblTitulo.Location = new System.Drawing.Point(191, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(800, 40);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "GESTIÓN DE CLIENTES Y RESERVAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCliente
            // 
            this.pnlCliente.BackColor = System.Drawing.Color.White;
            this.pnlCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCliente.Controls.Add(this.btnQuitarCliente);
            this.pnlCliente.Controls.Add(this.btnEditarCliente);
            this.pnlCliente.Controls.Add(this.btnAgregarCliente);
            this.pnlCliente.Controls.Add(this.btnBuscar);
            this.pnlCliente.Controls.Add(this.txtTelefono);
            this.pnlCliente.Controls.Add(this.txtApellido);
            this.pnlCliente.Controls.Add(this.txtNombre);
            this.pnlCliente.Controls.Add(this.txtBuscar);
            this.pnlCliente.Controls.Add(this.lblTelefono);
            this.pnlCliente.Controls.Add(this.lblApellido);
            this.pnlCliente.Controls.Add(this.lblNombre);
            this.pnlCliente.Controls.Add(this.lblBuscar);
            this.pnlCliente.Controls.Add(this.lblTituloCliente);
            this.pnlCliente.Location = new System.Drawing.Point(20, 105);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(540, 290);
            this.pnlCliente.TabIndex = 24;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.btnBuscar.Location = new System.Drawing.Point(400, 65);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.txtTelefono.Location = new System.Drawing.Point(96, 202);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(274, 30);
            this.txtTelefono.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.txtApellido.Location = new System.Drawing.Point(96, 160);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(274, 30);
            this.txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.txtNombre.Location = new System.Drawing.Point(96, 112);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(274, 30);
            this.txtNombre.TabIndex = 6;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.txtBuscar.Location = new System.Drawing.Point(177, 65);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(193, 30);
            this.txtBuscar.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblTelefono.Location = new System.Drawing.Point(20, 205);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(480, 30);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblApellido
            // 
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblApellido.Location = new System.Drawing.Point(20, 160);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(480, 30);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblNombre.Location = new System.Drawing.Point(20, 115);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(480, 30);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblBuscar
            // 
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblBuscar.Location = new System.Drawing.Point(20, 65);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(480, 30);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar por teléfono:";
            this.lblBuscar.Click += new System.EventHandler(this.lblBuscar_Click);
            // 
            // lblTituloCliente
            // 
            this.lblTituloCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblTituloCliente.Location = new System.Drawing.Point(20, 15);
            this.lblTituloCliente.Name = "lblTituloCliente";
            this.lblTituloCliente.Size = new System.Drawing.Size(480, 30);
            this.lblTituloCliente.TabIndex = 0;
            this.lblTituloCliente.Text = "INFORMACIÓN DEL CLIENTE";
            // 
            // pnlReserva
            // 
            this.pnlReserva.BackColor = System.Drawing.Color.White;
            this.pnlReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReserva.Controls.Add(this.btnActualizar);
            this.pnlReserva.Controls.Add(this.btnLimpiar);
            this.pnlReserva.Controls.Add(this.btnGuardarReserva);
            this.pnlReserva.Controls.Add(this.nudAnticipo);
            this.pnlReserva.Controls.Add(this.lblAnticipo);
            this.pnlReserva.Controls.Add(this.cmbMesa);
            this.pnlReserva.Controls.Add(this.lblMesa);
            this.pnlReserva.Controls.Add(this.nudPersonas);
            this.pnlReserva.Controls.Add(this.lblPersonas);
            this.pnlReserva.Controls.Add(this.dtpHora);
            this.pnlReserva.Controls.Add(this.dtpFecha);
            this.pnlReserva.Controls.Add(this.lblHora);
            this.pnlReserva.Controls.Add(this.lblFecha);
            this.pnlReserva.Controls.Add(this.lblTituloReserva);
            this.pnlReserva.Location = new System.Drawing.Point(574, 105);
            this.pnlReserva.Name = "pnlReserva";
            this.pnlReserva.Size = new System.Drawing.Size(600, 290);
            this.pnlReserva.TabIndex = 25;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.btnActualizar.Location = new System.Drawing.Point(410, 193);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(150, 40);
            this.btnActualizar.TabIndex = 32;
            this.btnActualizar.Text = "Actualizar lista";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.btnLimpiar.Location = new System.Drawing.Point(410, 126);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpiar.TabIndex = 31;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardarReserva
            // 
            this.btnGuardarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(183)))));
            this.btnGuardarReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarReserva.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarReserva.ForeColor = System.Drawing.Color.White;
            this.btnGuardarReserva.Location = new System.Drawing.Point(410, 60);
            this.btnGuardarReserva.Name = "btnGuardarReserva";
            this.btnGuardarReserva.Size = new System.Drawing.Size(150, 40);
            this.btnGuardarReserva.TabIndex = 26;
            this.btnGuardarReserva.Text = "Guardar reserva";
            this.btnGuardarReserva.UseVisualStyleBackColor = false;
            this.btnGuardarReserva.Click += new System.EventHandler(this.btnGuardarReserva_Click);
            // 
            // nudAnticipo
            // 
            this.nudAnticipo.DecimalPlaces = 2;
            this.nudAnticipo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAnticipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.nudAnticipo.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAnticipo.Location = new System.Drawing.Point(128, 243);
            this.nudAnticipo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAnticipo.Name = "nudAnticipo";
            this.nudAnticipo.Size = new System.Drawing.Size(180, 30);
            this.nudAnticipo.TabIndex = 26;
            this.nudAnticipo.ThousandsSeparator = true;
            // 
            // lblAnticipo
            // 
            this.lblAnticipo.AutoSize = true;
            this.lblAnticipo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnticipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblAnticipo.Location = new System.Drawing.Point(20, 245);
            this.lblAnticipo.Name = "lblAnticipo";
            this.lblAnticipo.Size = new System.Drawing.Size(102, 23);
            this.lblAnticipo.TabIndex = 30;
            this.lblAnticipo.Text = "Anticipo (Q):";
            // 
            // cmbMesa
            // 
            this.cmbMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMesa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.cmbMesa.FormattingEnabled = true;
            this.cmbMesa.Location = new System.Drawing.Point(73, 197);
            this.cmbMesa.Name = "cmbMesa";
            this.cmbMesa.Size = new System.Drawing.Size(180, 31);
            this.cmbMesa.TabIndex = 26;
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblMesa.Location = new System.Drawing.Point(20, 200);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(52, 23);
            this.lblMesa.TabIndex = 29;
            this.lblMesa.Text = "Mesa:";
            // 
            // nudPersonas
            // 
            this.nudPersonas.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPersonas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.nudPersonas.Location = new System.Drawing.Point(199, 154);
            this.nudPersonas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudPersonas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPersonas.Name = "nudPersonas";
            this.nudPersonas.Size = new System.Drawing.Size(100, 30);
            this.nudPersonas.TabIndex = 26;
            this.nudPersonas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblPersonas.Location = new System.Drawing.Point(20, 155);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(173, 23);
            this.lblPersonas.TabIndex = 28;
            this.lblPersonas.Text = "Cantidad de personas:";
            // 
            // dtpHora
            // 
            this.dtpHora.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.dtpHora.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.dtpHora.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.dtpHora.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.dtpHora.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(160, 103);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(180, 34);
            this.dtpHora.TabIndex = 27;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(160, 61);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(180, 34);
            this.dtpFecha.TabIndex = 26;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblHora.Location = new System.Drawing.Point(20, 110);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(129, 23);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora de reserva:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblFecha.Location = new System.Drawing.Point(20, 65);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(134, 23);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha de reserva:";
            // 
            // lblTituloReserva
            // 
            this.lblTituloReserva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblTituloReserva.Location = new System.Drawing.Point(20, 15);
            this.lblTituloReserva.Name = "lblTituloReserva";
            this.lblTituloReserva.Size = new System.Drawing.Size(540, 30);
            this.lblTituloReserva.TabIndex = 0;
            this.lblTituloReserva.Text = "AGENDAMIENTO DE RESERVA";
            this.lblTituloReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservas.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReservas.ColumnHeadersHeight = 40;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReservas.EnableHeadersVisualStyles = false;
            this.dgvReservas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.dgvReservas.Location = new System.Drawing.Point(20, 417);
            this.dgvReservas.MultiSelect = false;
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersVisible = false;
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.RowTemplate.Height = 24;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(1154, 220);
            this.dgvReservas.TabIndex = 26;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(185)))));
            this.btnAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCliente.Location = new System.Drawing.Point(400, 115);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(100, 30);
            this.btnAgregarCliente.TabIndex = 26;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.btnEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.btnEditarCliente.Location = new System.Drawing.Point(400, 160);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(100, 30);
            this.btnEditarCliente.TabIndex = 27;
            this.btnEditarCliente.Text = "Editar ";
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnQuitarCliente
            // 
            this.btnQuitarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.btnQuitarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(128)))), ((int)(((byte)(157)))));
            this.btnQuitarCliente.Location = new System.Drawing.Point(400, 205);
            this.btnQuitarCliente.Name = "btnQuitarCliente";
            this.btnQuitarCliente.Size = new System.Drawing.Size(100, 30);
            this.btnQuitarCliente.TabIndex = 28;
            this.btnQuitarCliente.Text = "Quitar";
            this.btnQuitarCliente.UseVisualStyleBackColor = false;
            this.btnQuitarCliente.Click += new System.EventHandler(this.btnQuitarCliente_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1182, 733);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.pnlReserva);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de Clientes y Reservas - Sistema de Reservas";
            this.Load += new System.EventHandler(this.Frm4_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.pnlReserva.ResumeLayout(false);
            this.pnlReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnticipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblTituloCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pnlReserva;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTituloReserva;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.NumericUpDown nudPersonas;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.NumericUpDown nudAnticipo;
        private System.Windows.Forms.Label lblAnticipo;
        private System.Windows.Forms.ComboBox cmbMesa;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardarReserva;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Button btnQuitarCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
    }
}