namespace CineHoytsFront.Formularios.Reporte
{
    partial class RecaudacionxPromo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecaudacionxPromo));
            this.SP_RECAUDACIONxPROMOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datReport = new CineHoytsFront.Formularios.Reporte.DatReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picreset = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.datReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPRECAUDACIONxPROMOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_RECAUDACIONxPROMOTableAdapter = new CineHoytsFront.Formularios.Reporte.DatReportTableAdapters.SP_RECAUDACIONxPROMOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_RECAUDACIONxPROMOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datReport)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picreset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRECAUDACIONxPROMOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_RECAUDACIONxPROMOBindingSource
            // 
            this.SP_RECAUDACIONxPROMOBindingSource.DataMember = "SP_RECAUDACIONxPROMO";
            this.SP_RECAUDACIONxPROMOBindingSource.DataSource = this.datReport;
            // 
            // datReport
            // 
            this.datReport.DataSetName = "DatReport";
            this.datReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.SP_RECAUDACIONxPROMOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CineHoytsFront.Formularios.Reporte.RDLC.RecaucacionXPromo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 122);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(1023, 507);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.picreset);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 125);
            this.panel1.TabIndex = 1;
            // 
            // picreset
            // 
            this.picreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picreset.Image = ((System.Drawing.Image)(resources.GetObject("picreset.Image")));
            this.picreset.Location = new System.Drawing.Point(848, 61);
            this.picreset.Name = "picreset";
            this.picreset.Size = new System.Drawing.Size(50, 49);
            this.picreset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picreset.TabIndex = 52;
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
            this.button1.Location = new System.Drawing.Point(167, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 27);
            this.button1.TabIndex = 80;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 79;
            this.label1.Text = "Gasto Minimo";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(35, 86);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(238, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(628, 28);
            this.label8.TabIndex = 76;
            this.label8.Text = "Recaudación de las promociones en el año en curso";
            // 
            // datReportBindingSource
            // 
            this.datReportBindingSource.DataSource = this.datReport;
            this.datReportBindingSource.Position = 0;
            // 
            // sPRECAUDACIONxPROMOBindingSource
            // 
            this.sPRECAUDACIONxPROMOBindingSource.DataMember = "SP_RECAUDACIONxPROMO";
            this.sPRECAUDACIONxPROMOBindingSource.DataSource = this.datReportBindingSource;
            // 
            // sP_RECAUDACIONxPROMOTableAdapter
            // 
            this.sP_RECAUDACIONxPROMOTableAdapter.ClearBeforeFill = true;
            // 
            // RecaudacionxPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 628);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecaudacionxPromo";
            this.Text = "RecaudacionxPromo";
            this.Load += new System.EventHandler(this.RecaudacionxPromo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_RECAUDACIONxPROMOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picreset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRECAUDACIONxPROMOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picreset;
        private System.Windows.Forms.BindingSource SP_RECAUDACIONxPROMOBindingSource;
        private DatReport datReport;
        private System.Windows.Forms.BindingSource datReportBindingSource;
        private System.Windows.Forms.BindingSource sPRECAUDACIONxPROMOBindingSource;
        private DatReportTableAdapters.SP_RECAUDACIONxPROMOTableAdapter sP_RECAUDACIONxPROMOTableAdapter;
    }
}