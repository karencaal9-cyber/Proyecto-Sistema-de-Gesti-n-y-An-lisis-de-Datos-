namespace Restaurante
{
    partial class Form7
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblForm7 = new System.Windows.Forms.Label();
            this.lblMesasDisponibles = new System.Windows.Forms.Label();
            this.lblGraficaBarras = new System.Windows.Forms.Label();
            this.tmpMesasDisponibles = new System.Windows.Forms.DateTimePicker();
            this.dgvMesasDisponibles = new System.Windows.Forms.DataGridView();
            this.ctGraficaComparativa = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ctGraficaBarras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnClientesExcel = new System.Windows.Forms.Button();
            this.lblGraficaComparativa = new System.Windows.Forms.Label();
            this.btnReportePDF = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            this.btnRegresarMenu = new System.Windows.Forms.Button();
            this.pnlBitacora = new System.Windows.Forms.Panel();
            this.lblBitacora = new System.Windows.Forms.Label();
            this.pnlGraficayReportes = new System.Windows.Forms.Panel();
            this.lblGraficasyReportes = new System.Windows.Forms.Label();
            this.pnlMesasReservadas = new System.Windows.Forms.Panel();
            this.lblMesasReservadas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesasDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctGraficaComparativa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctGraficaBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            this.pnlBitacora.SuspendLayout();
            this.pnlGraficayReportes.SuspendLayout();
            this.pnlMesasReservadas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblForm7
            // 
            this.lblForm7.AutoSize = true;
            this.lblForm7.Font = new System.Drawing.Font("Segoe UI Black", 24.192F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(122)))));
            this.lblForm7.Location = new System.Drawing.Point(343, 74);
            this.lblForm7.Name = "lblForm7";
            this.lblForm7.Size = new System.Drawing.Size(568, 57);
            this.lblForm7.TabIndex = 0;
            this.lblForm7.Text = "RESULTADOS Y REPORTES";
            // 
            // lblMesasDisponibles
            // 
            this.lblMesasDisponibles.AutoSize = true;
            this.lblMesasDisponibles.Font = new System.Drawing.Font("Segoe UI Semibold", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesasDisponibles.Location = new System.Drawing.Point(17, 46);
            this.lblMesasDisponibles.Name = "lblMesasDisponibles";
            this.lblMesasDisponibles.Size = new System.Drawing.Size(218, 25);
            this.lblMesasDisponibles.TabIndex = 1;
            this.lblMesasDisponibles.Text = "Filtrar por fecha y hora: ";
            // 
            // lblGraficaBarras
            // 
            this.lblGraficaBarras.AutoSize = true;
            this.lblGraficaBarras.Font = new System.Drawing.Font("Segoe UI Semibold", 8.064F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraficaBarras.Location = new System.Drawing.Point(22, 52);
            this.lblGraficaBarras.Name = "lblGraficaBarras";
            this.lblGraficaBarras.Size = new System.Drawing.Size(281, 19);
            this.lblGraficaBarras.TabIndex = 3;
            this.lblGraficaBarras.Text = "Horas pico con mayor afluencia en reservas";
            // 
            // tmpMesasDisponibles
            // 
            this.tmpMesasDisponibles.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmpMesasDisponibles.Location = new System.Drawing.Point(241, 42);
            this.tmpMesasDisponibles.Name = "tmpMesasDisponibles";
            this.tmpMesasDisponibles.Size = new System.Drawing.Size(331, 30);
            this.tmpMesasDisponibles.TabIndex = 4;
            this.tmpMesasDisponibles.ValueChanged += new System.EventHandler(this.tmpMesasDisponibles_ValueChanged);
            // 
            // dgvMesasDisponibles
            // 
            this.dgvMesasDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesasDisponibles.Location = new System.Drawing.Point(19, 98);
            this.dgvMesasDisponibles.Name = "dgvMesasDisponibles";
            this.dgvMesasDisponibles.RowHeadersWidth = 53;
            this.dgvMesasDisponibles.RowTemplate.Height = 24;
            this.dgvMesasDisponibles.Size = new System.Drawing.Size(553, 376);
            this.dgvMesasDisponibles.TabIndex = 5;
            // 
            // ctGraficaComparativa
            // 
            this.ctGraficaComparativa.BorderlineColor = System.Drawing.Color.RosyBrown;
            chartArea3.Name = "ChartArea1";
            this.ctGraficaComparativa.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ctGraficaComparativa.Legends.Add(legend3);
            this.ctGraficaComparativa.Location = new System.Drawing.Point(356, 79);
            this.ctGraficaComparativa.Name = "ctGraficaComparativa";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ctGraficaComparativa.Series.Add(series3);
            this.ctGraficaComparativa.Size = new System.Drawing.Size(243, 269);
            this.ctGraficaComparativa.TabIndex = 7;
            this.ctGraficaComparativa.Text = "chart1";
            this.ctGraficaComparativa.Click += new System.EventHandler(this.chart1_Click);
            // 
            // ctGraficaBarras
            // 
            chartArea4.Name = "ChartArea1";
            this.ctGraficaBarras.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.ctGraficaBarras.Legends.Add(legend4);
            this.ctGraficaBarras.Location = new System.Drawing.Point(41, 79);
            this.ctGraficaBarras.Name = "ctGraficaBarras";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.ctGraficaBarras.Series.Add(series4);
            this.ctGraficaBarras.Size = new System.Drawing.Size(243, 269);
            this.ctGraficaBarras.TabIndex = 8;
            this.ctGraficaBarras.Text = "chart2";
            // 
            // btnClientesExcel
            // 
            this.btnClientesExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btnClientesExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientesExcel.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientesExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.btnClientesExcel.Location = new System.Drawing.Point(369, 382);
            this.btnClientesExcel.Name = "btnClientesExcel";
            this.btnClientesExcel.Size = new System.Drawing.Size(208, 100);
            this.btnClientesExcel.TabIndex = 15;
            this.btnClientesExcel.Text = "Listado de clientes frecuentes";
            this.btnClientesExcel.UseVisualStyleBackColor = false;
            this.btnClientesExcel.Click += new System.EventHandler(this.btnClientesExcel_Click);
            // 
            // lblGraficaComparativa
            // 
            this.lblGraficaComparativa.AutoSize = true;
            this.lblGraficaComparativa.Font = new System.Drawing.Font("Segoe UI Semibold", 8.064F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraficaComparativa.Location = new System.Drawing.Point(365, 52);
            this.lblGraficaComparativa.Name = "lblGraficaComparativa";
            this.lblGraficaComparativa.Size = new System.Drawing.Size(220, 19);
            this.lblGraficaComparativa.TabIndex = 9;
            this.lblGraficaComparativa.Text = "Reservas realizadas según la zona";
            // 
            // btnReportePDF
            // 
            this.btnReportePDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(183)))));
            this.btnReportePDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportePDF.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportePDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.btnReportePDF.Location = new System.Drawing.Point(12, 382);
            this.btnReportePDF.Name = "btnReportePDF";
            this.btnReportePDF.Size = new System.Drawing.Size(306, 100);
            this.btnReportePDF.TabIndex = 12;
            this.btnReportePDF.Text = "Ocupación diaria y consumo promedio por mesa";
            this.btnReportePDF.UseVisualStyleBackColor = false;
            this.btnReportePDF.Click += new System.EventHandler(this.btnReportePDF_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(125)))), ((int)(((byte)(145)))));
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Black", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.btnSalir.Location = new System.Drawing.Point(977, 25);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(230, 66);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacora.Location = new System.Drawing.Point(29, 37);
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.RowHeadersWidth = 53;
            this.dgvBitacora.RowTemplate.Height = 24;
            this.dgvBitacora.Size = new System.Drawing.Size(986, 199);
            this.dgvBitacora.TabIndex = 0;
            // 
            // btnRegresarMenu
            // 
            this.btnRegresarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(195)))), ((int)(((byte)(207)))));
            this.btnRegresarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarMenu.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(74)))));
            this.btnRegresarMenu.Location = new System.Drawing.Point(16, 25);
            this.btnRegresarMenu.Name = "btnRegresarMenu";
            this.btnRegresarMenu.Size = new System.Drawing.Size(218, 54);
            this.btnRegresarMenu.TabIndex = 14;
            this.btnRegresarMenu.Text = "Regresar al Menú";
            this.btnRegresarMenu.UseVisualStyleBackColor = false;
            this.btnRegresarMenu.Click += new System.EventHandler(this.btnRegresarMenu_Click);
            // 
            // pnlBitacora
            // 
            this.pnlBitacora.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBitacora.Controls.Add(this.lblBitacora);
            this.pnlBitacora.Controls.Add(this.dgvBitacora);
            this.pnlBitacora.Location = new System.Drawing.Point(76, 674);
            this.pnlBitacora.Name = "pnlBitacora";
            this.pnlBitacora.Size = new System.Drawing.Size(1049, 252);
            this.pnlBitacora.TabIndex = 6;
            // 
            // lblBitacora
            // 
            this.lblBitacora.AutoSize = true;
            this.lblBitacora.Font = new System.Drawing.Font("Segoe UI Semibold", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitacora.Location = new System.Drawing.Point(8, 7);
            this.lblBitacora.Name = "lblBitacora";
            this.lblBitacora.Size = new System.Drawing.Size(87, 25);
            this.lblBitacora.TabIndex = 2;
            this.lblBitacora.Text = "Bitácora:";
            // 
            // pnlGraficayReportes
            // 
            this.pnlGraficayReportes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlGraficayReportes.Controls.Add(this.lblGraficasyReportes);
            this.pnlGraficayReportes.Controls.Add(this.lblGraficaBarras);
            this.pnlGraficayReportes.Controls.Add(this.ctGraficaBarras);
            this.pnlGraficayReportes.Controls.Add(this.lblGraficaComparativa);
            this.pnlGraficayReportes.Controls.Add(this.btnReportePDF);
            this.pnlGraficayReportes.Controls.Add(this.btnClientesExcel);
            this.pnlGraficayReportes.Controls.Add(this.ctGraficaComparativa);
            this.pnlGraficayReportes.Location = new System.Drawing.Point(608, 169);
            this.pnlGraficayReportes.Name = "pnlGraficayReportes";
            this.pnlGraficayReportes.Size = new System.Drawing.Size(615, 499);
            this.pnlGraficayReportes.TabIndex = 15;
            this.pnlGraficayReportes.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblGraficasyReportes
            // 
            this.lblGraficasyReportes.AutoSize = true;
            this.lblGraficasyReportes.Font = new System.Drawing.Font("Segoe UI Semibold", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraficasyReportes.Location = new System.Drawing.Point(7, 7);
            this.lblGraficasyReportes.Name = "lblGraficasyReportes";
            this.lblGraficasyReportes.Size = new System.Drawing.Size(182, 25);
            this.lblGraficasyReportes.TabIndex = 16;
            this.lblGraficasyReportes.Text = "Gráficas y Reportes:";
            // 
            // pnlMesasReservadas
            // 
            this.pnlMesasReservadas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMesasReservadas.Controls.Add(this.dgvMesasDisponibles);
            this.pnlMesasReservadas.Controls.Add(this.tmpMesasDisponibles);
            this.pnlMesasReservadas.Controls.Add(this.lblMesasDisponibles);
            this.pnlMesasReservadas.Controls.Add(this.lblMesasReservadas);
            this.pnlMesasReservadas.Location = new System.Drawing.Point(9, 170);
            this.pnlMesasReservadas.Name = "pnlMesasReservadas";
            this.pnlMesasReservadas.Size = new System.Drawing.Size(590, 498);
            this.pnlMesasReservadas.TabIndex = 16;
            // 
            // lblMesasReservadas
            // 
            this.lblMesasReservadas.AutoSize = true;
            this.lblMesasReservadas.Font = new System.Drawing.Font("Segoe UI Semibold", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesasReservadas.Location = new System.Drawing.Point(4, 6);
            this.lblMesasReservadas.Name = "lblMesasReservadas";
            this.lblMesasReservadas.Size = new System.Drawing.Size(172, 25);
            this.lblMesasReservadas.TabIndex = 3;
            this.lblMesasReservadas.Text = "Mesas Reservadas:";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1244, 938);
            this.Controls.Add(this.pnlMesasReservadas);
            this.Controls.Add(this.pnlGraficayReportes);
            this.Controls.Add(this.pnlBitacora);
            this.Controls.Add(this.btnRegresarMenu);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblForm7);
            this.Font = new System.Drawing.Font("Segoe UI", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesasDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctGraficaComparativa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctGraficaBarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            this.pnlBitacora.ResumeLayout(false);
            this.pnlBitacora.PerformLayout();
            this.pnlGraficayReportes.ResumeLayout(false);
            this.pnlGraficayReportes.PerformLayout();
            this.pnlMesasReservadas.ResumeLayout(false);
            this.pnlMesasReservadas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForm7;
        private System.Windows.Forms.Label lblMesasDisponibles;
        private System.Windows.Forms.Label lblGraficaBarras;
        private System.Windows.Forms.DateTimePicker tmpMesasDisponibles;
        private System.Windows.Forms.DataGridView dgvMesasDisponibles;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctGraficaComparativa;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctGraficaBarras;
        private System.Windows.Forms.Label lblGraficaComparativa;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReportePDF;
        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.Windows.Forms.Button btnRegresarMenu;
        private System.Windows.Forms.Button btnClientesExcel;
        private System.Windows.Forms.Panel pnlBitacora;
        private System.Windows.Forms.Label lblBitacora;
        private System.Windows.Forms.Panel pnlGraficayReportes;
        private System.Windows.Forms.Label lblGraficasyReportes;
        private System.Windows.Forms.Panel pnlMesasReservadas;
        private System.Windows.Forms.Label lblMesasReservadas;
    }
}