namespace Restaurante
{
    partial class nudCantidad
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
            this.lblInfoReserva = new System.Windows.Forms.Label();
            this.gvMenu = new System.Windows.Forms.GroupBox();
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
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudcantidadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfoReserva
            // 
            this.lblInfoReserva.AutoSize = true;
            this.lblInfoReserva.Location = new System.Drawing.Point(65, 43);
            this.lblInfoReserva.Name = "lblInfoReserva";
            this.lblInfoReserva.Size = new System.Drawing.Size(284, 25);
            this.lblInfoReserva.TabIndex = 0;
            this.lblInfoReserva.Text = "ID de Reserva Activa";
            // 
            // gvMenu
            // 
            this.gvMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gvMenu.Location = new System.Drawing.Point(70, 86);
            this.gvMenu.Name = "gvMenu";
            this.gvMenu.Size = new System.Drawing.Size(878, 100);
            this.gvMenu.TabIndex = 1;
            this.gvMenu.TabStop = false;
            this.gvMenu.Text = "Seleccion de Alimentos del Menu:";
            // 
            // lblPlatillo
            // 
            this.lblPlatillo.AutoSize = true;
            this.lblPlatillo.Location = new System.Drawing.Point(124, 215);
            this.lblPlatillo.Name = "lblPlatillo";
            this.lblPlatillo.Size = new System.Drawing.Size(281, 25);
            this.lblPlatillo.TabIndex = 2;
            this.lblPlatillo.Text = "Seleccione Platillo:";
            // 
            // cmbMenu
            // 
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(439, 212);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(493, 33);
            this.cmbMenu.TabIndex = 3;
            // 
            // lblCantidadDetalle
            // 
            this.lblCantidadDetalle.AutoSize = true;
            this.lblCantidadDetalle.Location = new System.Drawing.Point(266, 278);
            this.lblCantidadDetalle.Name = "lblCantidadDetalle";
            this.lblCantidadDetalle.Size = new System.Drawing.Size(139, 25);
            this.lblCantidadDetalle.TabIndex = 4;
            this.lblCantidadDetalle.Text = "Cantidad:";
            this.lblCantidadDetalle.Click += new System.EventHandler(this.lblCantidadDetalle_Click);
            // 
            // nudcantidadd
            // 
            this.nudcantidadd.Location = new System.Drawing.Point(439, 276);
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
            this.nudcantidadd.Size = new System.Drawing.Size(493, 33);
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
            this.lblObservaciones.Location = new System.Drawing.Point(12, 331);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(393, 25);
            this.lblObservaciones.TabIndex = 6;
            this.lblObservaciones.Text = "Observaciones (Sin Cebolla):";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(439, 331);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(493, 33);
            this.txtObservaciones.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(88, 394);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(329, 49);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar al Detalle";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(439, 394);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.RowTemplate.Height = 24;
            this.dgvDetalle.Size = new System.Drawing.Size(493, 150);
            this.dgvDetalle.TabIndex = 9;
            // 
            // btnEliminarItem
            // 
            this.btnEliminarItem.Location = new System.Drawing.Point(88, 574);
            this.btnEliminarItem.Name = "btnEliminarItem";
            this.btnEliminarItem.Size = new System.Drawing.Size(280, 71);
            this.btnEliminarItem.TabIndex = 10;
            this.btnEliminarItem.Text = "Quitar Platillo Seleccionado";
            this.btnEliminarItem.UseVisualStyleBackColor = true;
            this.btnEliminarItem.Click += new System.EventHandler(this.btnEliminarItem_Click);
            // 
            // btnImprimirPDF
            // 
            this.btnImprimirPDF.Location = new System.Drawing.Point(404, 574);
            this.btnImprimirPDF.Name = "btnImprimirPDF";
            this.btnImprimirPDF.Size = new System.Drawing.Size(322, 71);
            this.btnImprimirPDF.TabIndex = 11;
            this.btnImprimirPDF.Text = "Imprimir Comprobante PDF (RF11)";
            this.btnImprimirPDF.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(751, 574);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(246, 71);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver-Finalizar";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // nudCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1077, 674);
            this.Controls.Add(this.btnVolver);
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
            this.Controls.Add(this.gvMenu);
            this.Controls.Add(this.lblInfoReserva);
            this.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "nudCantidad";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.nudCantidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudcantidadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoReserva;
        private System.Windows.Forms.GroupBox gvMenu;
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
        private System.Windows.Forms.Button btnVolver;
    }
}

