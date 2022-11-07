namespace CineHoytsFront.Formularios.Reporte
{
    partial class ReporteEspectadores
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteEspectadores));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picreset = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.datReport = new CineHoytsFront.Formularios.Reporte.DatReport();
            this.datReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPCANTIDADENTRADASMINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_CANTIDAD_ENTRADAS_MINTableAdapter = new CineHoytsFront.Formularios.Reporte.DatReportTableAdapters.SP_CANTIDAD_ENTRADAS_MINTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picreset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPCANTIDADENTRADASMINBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.picreset);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 120);
            this.panel1.TabIndex = 0;
            // 
            // picreset
            // 
            this.picreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picreset.Image = ((System.Drawing.Image)(resources.GetObject("picreset.Image")));
            this.picreset.Location = new System.Drawing.Point(738, 55);
            this.picreset.Name = "picreset";
            this.picreset.Size = new System.Drawing.Size(50, 49);
            this.picreset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picreset.TabIndex = 79;
            this.picreset.TabStop = false;
            this.picreset.Click += new System.EventHandler(this.picreset_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(161, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 27);
            this.button1.TabIndex = 78;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 23);
            this.label1.TabIndex = 77;
            this.label1.Text = "Minimo de Espectadores";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(270, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(355, 32);
            this.label11.TabIndex = 76;
            this.label11.Text = "Espectadores por pelicula";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(26, 81);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(128, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataEspectadore";
            reportDataSource1.Value = this.sPCANTIDADENTRADASMINBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CineHoytsFront.Formularios.Reporte.RDLC.ReporteEspectadores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 120);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(800, 330);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // datReport
            // 
            this.datReport.DataSetName = "DatReport";
            this.datReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datReportBindingSource
            // 
            this.datReportBindingSource.DataSource = this.datReport;
            this.datReportBindingSource.Position = 0;
            // 
            // sPCANTIDADENTRADASMINBindingSource
            // 
            this.sPCANTIDADENTRADASMINBindingSource.DataMember = "SP_CANTIDAD_ENTRADAS_MIN";
            this.sPCANTIDADENTRADASMINBindingSource.DataSource = this.datReportBindingSource;
            // 
            // sP_CANTIDAD_ENTRADAS_MINTableAdapter
            // 
            this.sP_CANTIDAD_ENTRADAS_MINTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEspectadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteEspectadores";
            this.Text = "ReporteEspectadores";
            this.Load += new System.EventHandler(this.ReporteEspectadores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picreset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPCANTIDADENTRADASMINBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picreset;
        private System.Windows.Forms.BindingSource sPCANTIDADENTRADASMINBindingSource;
        private System.Windows.Forms.BindingSource datReportBindingSource;
        private DatReport datReport;
        private DatReportTableAdapters.SP_CANTIDAD_ENTRADAS_MINTableAdapter sP_CANTIDAD_ENTRADAS_MINTableAdapter;
    }
}