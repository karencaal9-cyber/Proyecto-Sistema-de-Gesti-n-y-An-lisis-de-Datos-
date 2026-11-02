namespace Restaurante
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlReservas = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMesas = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlClientes = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTituloReservas = new System.Windows.Forms.Label();
            this.lblTotalReservas = new System.Windows.Forms.Label();
            this.lblTituloMesas = new System.Windows.Forms.Label();
            this.lblTotalMesas = new System.Windows.Forms.Label();
            this.lblTituloClientes = new System.Windows.Forms.Label();
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.pnlGraficaReservas = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGraficaMesas = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTituloGraficaReservas = new System.Windows.Forms.Label();
            this.lblTituloGraficaMesas = new System.Windows.Forms.Label();
            this.chartReservas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMesas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnMesas = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.pnlEncabezado.SuspendLayout();
            this.pnlReservas.SuspendLayout();
            this.pnlMesas.SuspendLayout();
            this.pnlClientes.SuspendLayout();
            this.pnlGraficaReservas.SuspendLayout();
            this.pnlGraficaMesas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1082, 85);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblTitulo.Location = new System.Drawing.Point(224, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(700, 50);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "DASHBOARD PRINCIPAL";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlReservas
            // 
            this.pnlReservas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnlReservas.Controls.Add(this.lblTituloReservas);
            this.pnlReservas.Controls.Add(this.lblTotalReservas);
            this.pnlReservas.Location = new System.Drawing.Point(27, 110);
            this.pnlReservas.Name = "pnlReservas";
            this.pnlReservas.Size = new System.Drawing.Size(310, 125);
            this.pnlReservas.TabIndex = 1;
            // 
            // pnlMesas
            // 
            this.pnlMesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnlMesas.Controls.Add(this.lblTituloMesas);
            this.pnlMesas.Controls.Add(this.lblTotalMesas);
            this.pnlMesas.Location = new System.Drawing.Point(392, 110);
            this.pnlMesas.Name = "pnlMesas";
            this.pnlMesas.Size = new System.Drawing.Size(310, 125);
            this.pnlMesas.TabIndex = 2;
            // 
            // pnlClientes
            // 
            this.pnlClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnlClientes.Controls.Add(this.lblTituloClientes);
            this.pnlClientes.Controls.Add(this.lblTotalClientes);
            this.pnlClientes.Location = new System.Drawing.Point(757, 110);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(310, 125);
            this.pnlClientes.TabIndex = 3;
            // 
            // lblTituloReservas
            // 
            this.lblTituloReservas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReservas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblTituloReservas.Location = new System.Drawing.Point(3, 0);
            this.lblTituloReservas.Name = "lblTituloReservas";
            this.lblTituloReservas.Size = new System.Drawing.Size(290, 30);
            this.lblTituloReservas.TabIndex = 4;
            this.lblTituloReservas.Text = "\tTOTAL DE RESERVAS";
            this.lblTituloReservas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalReservas
            // 
            this.lblTotalReservas.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReservas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblTotalReservas.Location = new System.Drawing.Point(3, 30);
            this.lblTotalReservas.Name = "lblTotalReservas";
            this.lblTotalReservas.Size = new System.Drawing.Size(290, 55);
            this.lblTotalReservas.TabIndex = 5;
            this.lblTotalReservas.Text = "0";
            this.lblTotalReservas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloMesas
            // 
            this.lblTituloMesas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMesas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblTituloMesas.Location = new System.Drawing.Point(3, 0);
            this.lblTituloMesas.Name = "lblTituloMesas";
            this.lblTituloMesas.Size = new System.Drawing.Size(290, 30);
            this.lblTituloMesas.TabIndex = 5;
            this.lblTituloMesas.Text = "TOTAL DE MESAS";
            this.lblTituloMesas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalMesas
            // 
            this.lblTotalMesas.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMesas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblTotalMesas.Location = new System.Drawing.Point(3, 30);
            this.lblTotalMesas.Name = "lblTotalMesas";
            this.lblTotalMesas.Size = new System.Drawing.Size(290, 55);
            this.lblTotalMesas.TabIndex = 6;
            this.lblTotalMesas.Text = "0";
            this.lblTotalMesas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloClientes
            // 
            this.lblTituloClientes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblTituloClientes.Location = new System.Drawing.Point(3, 0);
            this.lblTituloClientes.Name = "lblTituloClientes";
            this.lblTituloClientes.Size = new System.Drawing.Size(290, 30);
            this.lblTituloClientes.TabIndex = 7;
            this.lblTituloClientes.Text = "TOTAL DE CLIENTES";
            this.lblTituloClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblTotalClientes.Location = new System.Drawing.Point(3, 30);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(290, 55);
            this.lblTotalClientes.TabIndex = 7;
            this.lblTotalClientes.Text = "0";
            this.lblTotalClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGraficaReservas
            // 
            this.pnlGraficaReservas.BackColor = System.Drawing.Color.White;
            this.pnlGraficaReservas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraficaReservas.Controls.Add(this.lblTituloGraficaReservas);
            this.pnlGraficaReservas.Controls.Add(this.chartReservas);
            this.pnlGraficaReservas.Location = new System.Drawing.Point(30, 270);
            this.pnlGraficaReservas.Name = "pnlGraficaReservas";
            this.pnlGraficaReservas.Size = new System.Drawing.Size(500, 280);
            this.pnlGraficaReservas.TabIndex = 4;
            // 
            // pnlGraficaMesas
            // 
            this.pnlGraficaMesas.BackColor = System.Drawing.Color.White;
            this.pnlGraficaMesas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraficaMesas.Controls.Add(this.lblTituloGraficaMesas);
            this.pnlGraficaMesas.Controls.Add(this.chartMesas);
            this.pnlGraficaMesas.Location = new System.Drawing.Point(550, 270);
            this.pnlGraficaMesas.Name = "pnlGraficaMesas";
            this.pnlGraficaMesas.Size = new System.Drawing.Size(500, 280);
            this.pnlGraficaMesas.TabIndex = 5;
            // 
            // lblTituloGraficaReservas
            // 
            this.lblTituloGraficaReservas.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGraficaReservas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblTituloGraficaReservas.Location = new System.Drawing.Point(3, 0);
            this.lblTituloGraficaReservas.Name = "lblTituloGraficaReservas";
            this.lblTituloGraficaReservas.Size = new System.Drawing.Size(480, 30);
            this.lblTituloGraficaReservas.TabIndex = 6;
            this.lblTituloGraficaReservas.Text = "RESERVAS POR MES";
            this.lblTituloGraficaReservas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloGraficaMesas
            // 
            this.lblTituloGraficaMesas.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGraficaMesas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblTituloGraficaMesas.Location = new System.Drawing.Point(3, 0);
            this.lblTituloGraficaMesas.Name = "lblTituloGraficaMesas";
            this.lblTituloGraficaMesas.Size = new System.Drawing.Size(480, 30);
            this.lblTituloGraficaMesas.TabIndex = 7;
            this.lblTituloGraficaMesas.Text = "MESAS POR ESTADO";
            this.lblTituloGraficaMesas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartReservas
            // 
            chartArea3.Name = "ChartArea1";
            this.chartReservas.ChartAreas.Add(chartArea3);
            this.chartReservas.Location = new System.Drawing.Point(3, 33);
            this.chartReservas.Name = "chartReservas";
            this.chartReservas.Size = new System.Drawing.Size(480, 220);
            this.chartReservas.TabIndex = 7;
            this.chartReservas.Text = "chart1";
            // 
            // chartMesas
            // 
            chartArea4.Name = "ChartArea1";
            this.chartMesas.ChartAreas.Add(chartArea4);
            this.chartMesas.Location = new System.Drawing.Point(3, 33);
            this.chartMesas.Name = "chartMesas";
            this.chartMesas.Size = new System.Drawing.Size(480, 220);
            this.chartMesas.TabIndex = 8;
            this.chartMesas.Text = "chart1";
            // 
            // btnMesas
            // 
            this.btnMesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(183)))));
            this.btnMesas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesas.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.btnMesas.Location = new System.Drawing.Point(159, 573);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(230, 45);
            this.btnMesas.TabIndex = 6;
            this.btnMesas.Text = "GESTIÓN DE MESAS Y ZONAS";
            this.btnMesas.UseVisualStyleBackColor = false;
            this.btnMesas.Click += new System.EventHandler(this.btnMesas_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(183)))));
            this.btnConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.btnConsultas.Location = new System.Drawing.Point(433, 573);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(230, 45);
            this.btnConsultas.TabIndex = 7;
            this.btnConsultas.Text = "CONSULTAS";
            this.btnConsultas.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(183)))));
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.btnReportes.Location = new System.Drawing.Point(669, 573);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(230, 45);
            this.btnReportes.TabIndex = 8;
            this.btnReportes.Text = "REPORTES";
            this.btnReportes.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.btnMesas);
            this.Controls.Add(this.pnlGraficaMesas);
            this.Controls.Add(this.pnlGraficaReservas);
            this.Controls.Add(this.pnlClientes);
            this.Controls.Add(this.pnlMesas);
            this.Controls.Add(this.pnlReservas);
            this.Controls.Add(this.pnlEncabezado);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard - Sistema de Reservas";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlReservas.ResumeLayout(false);
            this.pnlMesas.ResumeLayout(false);
            this.pnlClientes.ResumeLayout(false);
            this.pnlGraficaReservas.ResumeLayout(false);
            this.pnlGraficaMesas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMesas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel pnlReservas;
        private System.Windows.Forms.FlowLayoutPanel pnlMesas;
        private System.Windows.Forms.FlowLayoutPanel pnlClientes;
        private System.Windows.Forms.Label lblTituloReservas;
        private System.Windows.Forms.Label lblTotalReservas;
        private System.Windows.Forms.Label lblTituloMesas;
        private System.Windows.Forms.Label lblTotalMesas;
        private System.Windows.Forms.Label lblTituloClientes;
        private System.Windows.Forms.Label lblTotalClientes;
        private System.Windows.Forms.FlowLayoutPanel pnlGraficaReservas;
        private System.Windows.Forms.Label lblTituloGraficaReservas;
        private System.Windows.Forms.FlowLayoutPanel pnlGraficaMesas;
        private System.Windows.Forms.Label lblTituloGraficaMesas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReservas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMesas;
        private System.Windows.Forms.Button btnMesas;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnReportes;
    }
}