namespace Restaurante
{
    partial class Form5
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblForm5 = new System.Windows.Forms.Label();
            this.lblPlatillo = new System.Windows.Forms.Label();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.lblCantidadDetalle = new System.Windows.Forms.Label();
            this.nudcantidadd = new System.Windows.Forms.NumericUpDown();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnEliminarItem = new System.Windows.Forms.Button();
            this.btnImprimirPDF = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnRegresarMenu = new System.Windows.Forms.Button();
            this.lblIdReserva = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudcantidadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForm5
            // 
            this.lblForm5.AutoSize = true;
            this.lblForm5.Font = new System.Drawing.Font("Segoe UI Black", 24.192F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblForm5.Location = new System.Drawing.Point(253, 9);
            this.lblForm5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForm5.Name = "lblForm5";
            this.lblForm5.Size = new System.Drawing.Size(656, 57);
            this.lblForm5.TabIndex = 0;
            this.lblForm5.Text = "DETALLE DE RESERVA Y MENÚ";
            // 
            // lblPlatillo
            // 
            this.lblPlatillo.AutoSize = true;
            this.lblPlatillo.Font = new System.Drawing.Font("Segoe UI Semibold", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlatillo.Location = new System.Drawing.Point(127, 113);
            this.lblPlatillo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlatillo.Name = "lblPlatillo";
            this.lblPlatillo.Size = new System.Drawing.Size(209, 30);
            this.lblPlatillo.TabIndex = 2;
            this.lblPlatillo.Text = "Seleccione el Platillo:";
            // 
            // cmbMenu
            // 
            this.cmbMenu.Font = new System.Drawing.Font("Segoe UI", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(340, 113);
            this.cmbMenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(335, 40);
            this.cmbMenu.TabIndex = 3;
            // 
            // lblCantidadDetalle
            // 
            this.lblCantidadDetalle.AutoSize = true;
            this.lblCantidadDetalle.Font = new System.Drawing.Font("Segoe UI Semibold", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDetalle.Location = new System.Drawing.Point(127, 178);
            this.lblCantidadDetalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadDetalle.Name = "lblCantidadDetalle";
            this.lblCantidadDetalle.Size = new System.Drawing.Size(104, 30);
            this.lblCantidadDetalle.TabIndex = 4;
            this.lblCantidadDetalle.Text = "Cantidad:";
            // 
            // nudcantidadd
            // 
            this.nudcantidadd.Font = new System.Drawing.Font("Segoe UI", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudcantidadd.Location = new System.Drawing.Point(340, 178);
            this.nudcantidadd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudcantidadd.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudcantidadd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudcantidadd.Name = "nudcantidadd";
            this.nudcantidadd.Size = new System.Drawing.Size(335, 39);
            this.nudcantidadd.TabIndex = 5;
            this.nudcantidadd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI Semibold", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(127, 247);
            this.lblObservaciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(158, 30);
            this.lblObservaciones.TabIndex = 6;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(340, 247);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(335, 39);
            this.txtObservaciones.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(183)))));
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.btnAgregar.Location = new System.Drawing.Point(717, 152);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(170, 90);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar al Comprobante";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(73, 325);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.RowTemplate.Height = 24;
            this.dgvDetalle.Size = new System.Drawing.Size(734, 103);
            this.dgvDetalle.TabIndex = 9;
            // 
            // btnEliminarItem
            // 
            this.btnEliminarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(125)))), ((int)(((byte)(145)))));
            this.btnEliminarItem.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.btnEliminarItem.Location = new System.Drawing.Point(33, 464);
            this.btnEliminarItem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEliminarItem.Name = "btnEliminarItem";
            this.btnEliminarItem.Size = new System.Drawing.Size(179, 82);
            this.btnEliminarItem.TabIndex = 10;
            this.btnEliminarItem.Text = "Quitar Platillo Seleccionado";
            this.btnEliminarItem.UseVisualStyleBackColor = false;
            this.btnEliminarItem.Click += new System.EventHandler(this.btnEliminarItem_Click);
            // 
            // btnImprimirPDF
            // 
            this.btnImprimirPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btnImprimirPDF.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirPDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.btnImprimirPDF.Location = new System.Drawing.Point(363, 464);
            this.btnImprimirPDF.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnImprimirPDF.Name = "btnImprimirPDF";
            this.btnImprimirPDF.Size = new System.Drawing.Size(224, 82);
            this.btnImprimirPDF.TabIndex = 11;
            this.btnImprimirPDF.Text = "Imprimir Comprobante";
            this.btnImprimirPDF.UseVisualStyleBackColor = false;
            this.btnImprimirPDF.Click += new System.EventHandler(this.btnImprimirPDF_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(183)))));
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.btnNuevo.Location = new System.Drawing.Point(764, 464);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 82);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnRegresarMenu
            // 
            this.btnRegresarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btnRegresarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarMenu.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.btnRegresarMenu.Location = new System.Drawing.Point(6, 14);
            this.btnRegresarMenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRegresarMenu.Name = "btnRegresarMenu";
            this.btnRegresarMenu.Size = new System.Drawing.Size(222, 44);
            this.btnRegresarMenu.TabIndex = 15;
            this.btnRegresarMenu.Text = "Regresar al Menú";
            this.btnRegresarMenu.UseVisualStyleBackColor = false;
            this.btnRegresarMenu.Click += new System.EventHandler(this.btnRegresarMenu_Click);
            // 
            // lblIdReserva
            // 
            this.lblIdReserva.AutoSize = true;
            this.lblIdReserva.Font = new System.Drawing.Font("Segoe UI Semibold", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdReserva.Location = new System.Drawing.Point(68, 64);
            this.lblIdReserva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdReserva.Name = "lblIdReserva";
            this.lblIdReserva.Size = new System.Drawing.Size(149, 30);
            this.lblIdReserva.TabIndex = 16;
            this.lblIdReserva.Text = "ID de Reserva:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(924, 575);
            this.Controls.Add(this.lblIdReserva);
            this.Controls.Add(this.btnRegresarMenu);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnImprimirPDF);
            this.Controls.Add(this.btnEliminarItem);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.nudcantidadd);
            this.Controls.Add(this.lblCantidadDetalle);
            this.Controls.Add(this.cmbMenu);
            this.Controls.Add(this.lblPlatillo);
            this.Controls.Add(this.lblForm5);
            this.Font = new System.Drawing.Font("Segoe UI", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Reserva y Menú - Sistema de Reservas";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudcantidadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForm5;
        private System.Windows.Forms.Label lblPlatillo;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.Label lblCantidadDetalle;
        private System.Windows.Forms.NumericUpDown nudcantidadd;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnEliminarItem;
        private System.Windows.Forms.Button btnImprimirPDF;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnRegresarMenu;
        private System.Windows.Forms.Label lblIdReserva;
    }
}

