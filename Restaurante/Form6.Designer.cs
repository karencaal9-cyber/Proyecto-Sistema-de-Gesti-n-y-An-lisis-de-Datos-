namespace Restaurante
{
    partial class Form6
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
            this.lblForm6 = new System.Windows.Forms.Label();
            this.dgvForm6 = new System.Windows.Forms.DataGridView();
            this.lblNumeroCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cmbRolEmpleado = new System.Windows.Forms.ComboBox();
            this.txtNumeroCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.lblRolEmpleado = new System.Windows.Forms.Label();
            this.btnRegresarMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForm6)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForm6
            // 
            this.lblForm6.AutoSize = true;
            this.lblForm6.Font = new System.Drawing.Font("Segoe UI Black", 24.192F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblForm6.Location = new System.Drawing.Point(321, 12);
            this.lblForm6.Name = "lblForm6";
            this.lblForm6.Size = new System.Drawing.Size(463, 45);
            this.lblForm6.TabIndex = 0;
            this.lblForm6.Text = "CONSULTAS COMBINADAS";
            // 
            // dgvForm6
            // 
            this.dgvForm6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvForm6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForm6.Location = new System.Drawing.Point(25, 331);
            this.dgvForm6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvForm6.Name = "dgvForm6";
            this.dgvForm6.RowHeadersWidth = 53;
            this.dgvForm6.RowTemplate.Height = 24;
            this.dgvForm6.Size = new System.Drawing.Size(897, 234);
            this.dgvForm6.TabIndex = 1;
            // 
            // lblNumeroCliente
            // 
            this.lblNumeroCliente.AutoSize = true;
            this.lblNumeroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumeroCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCliente.Location = new System.Drawing.Point(11, 122);
            this.lblNumeroCliente.Name = "lblNumeroCliente";
            this.lblNumeroCliente.Size = new System.Drawing.Size(209, 19);
            this.lblNumeroCliente.TabIndex = 2;
            this.lblNumeroCliente.Text = "Buscar por número de teléfono: ";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblApellidoCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoCliente.Location = new System.Drawing.Point(557, 122);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(136, 19);
            this.lblApellidoCliente.TabIndex = 3;
            this.lblApellidoCliente.Text = "Buscar por apellido: ";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.btnLimpiar.Location = new System.Drawing.Point(384, 255);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(176, 51);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar filtros";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cmbRolEmpleado
            // 
            this.cmbRolEmpleado.FormattingEnabled = true;
            this.cmbRolEmpleado.Location = new System.Drawing.Point(506, 191);
            this.cmbRolEmpleado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRolEmpleado.Name = "cmbRolEmpleado";
            this.cmbRolEmpleado.Size = new System.Drawing.Size(223, 25);
            this.cmbRolEmpleado.TabIndex = 7;
            this.cmbRolEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbRolEmpleado_SelectedIndexChanged);
            // 
            // txtNumeroCliente
            // 
            this.txtNumeroCliente.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCliente.Location = new System.Drawing.Point(235, 119);
            this.txtNumeroCliente.Name = "txtNumeroCliente";
            this.txtNumeroCliente.Size = new System.Drawing.Size(205, 29);
            this.txtNumeroCliente.TabIndex = 8;
            this.txtNumeroCliente.TextChanged += new System.EventHandler(this.txtNumeroCliente_TextChanged);
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoCliente.Location = new System.Drawing.Point(699, 119);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(214, 29);
            this.txtApellidoCliente.TabIndex = 9;
            this.txtApellidoCliente.TextChanged += new System.EventHandler(this.txtApellidoCliente_TextChanged);
            // 
            // lblRolEmpleado
            // 
            this.lblRolEmpleado.AutoSize = true;
            this.lblRolEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRolEmpleado.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolEmpleado.Location = new System.Drawing.Point(317, 191);
            this.lblRolEmpleado.Name = "lblRolEmpleado";
            this.lblRolEmpleado.Size = new System.Drawing.Size(183, 19);
            this.lblRolEmpleado.TabIndex = 10;
            this.lblRolEmpleado.Text = "Filtrar por rol de empleado: ";
            // 
            // btnRegresarMenu
            // 
            this.btnRegresarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(125)))), ((int)(((byte)(145)))));
            this.btnRegresarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarMenu.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.btnRegresarMenu.Location = new System.Drawing.Point(16, 12);
            this.btnRegresarMenu.Name = "btnRegresarMenu";
            this.btnRegresarMenu.Size = new System.Drawing.Size(218, 54);
            this.btnRegresarMenu.TabIndex = 15;
            this.btnRegresarMenu.Text = "Regresar al Menú";
            this.btnRegresarMenu.UseVisualStyleBackColor = false;
            this.btnRegresarMenu.Click += new System.EventHandler(this.btnRegresarMenu_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(957, 578);
            this.Controls.Add(this.btnRegresarMenu);
            this.Controls.Add(this.lblRolEmpleado);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.txtNumeroCliente);
            this.Controls.Add(this.cmbRolEmpleado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblApellidoCliente);
            this.Controls.Add(this.lblNumeroCliente);
            this.Controls.Add(this.dgvForm6);
            this.Controls.Add(this.lblForm6);
            this.Font = new System.Drawing.Font("Segoe UI", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form6";
            this.Text = "Consultas Combinadas - Sistema de Reservas";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForm6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForm6;
        private System.Windows.Forms.DataGridView dgvForm6;
        private System.Windows.Forms.Label lblNumeroCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cmbRolEmpleado;
        private System.Windows.Forms.TextBox txtNumeroCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.Label lblRolEmpleado;
        private System.Windows.Forms.Button btnRegresarMenu;
    }
}