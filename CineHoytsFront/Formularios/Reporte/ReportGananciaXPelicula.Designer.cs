namespace CineHoytsFront.Formularios.Reporte
{
    partial class ReportGananciaXPelicula
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.datReport = new CineHoytsFront.Formularios.Reporte.DatReport();
            this.datReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPGananciasXPeliculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_GananciasXPeliculaTableAdapter1 = new CineHoytsFront.Formularios.Reporte.DatReportTableAdapters.SP_GananciasXPeliculaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGananciasXPeliculaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatGananciaxPelicula";
            reportDataSource1.Value = this.sPGananciasXPeliculaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CineHoytsFront.Formularios.Reporte.RDLC.ReportGananciaXPel.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
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
            // sPGananciasXPeliculaBindingSource
            // 
            this.sPGananciasXPeliculaBindingSource.DataMember = "SP_GananciasXPelicula";
            this.sPGananciasXPeliculaBindingSource.DataSource = this.datReportBindingSource;
            // 
            // sP_GananciasXPeliculaTableAdapter1
            // 
            this.sP_GananciasXPeliculaTableAdapter1.ClearBeforeFill = true;
            // 
            // ReportGananciaXPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportGananciaXPelicula";
            this.Text = "ReportGananciaXPelicula";
            this.Load += new System.EventHandler(this.ReportGananciaXPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGananciasXPeliculaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DatReportTableAdapters.SP_GananciasXPeliculaTableAdapter sP_GananciasXPeliculaTableAdapter;
        private DatReport datReport;
        private System.Windows.Forms.BindingSource datReportBindingSource;
        private System.Windows.Forms.BindingSource sPGananciasXPeliculaBindingSource;
        private DatReportTableAdapters.SP_GananciasXPeliculaTableAdapter sP_GananciasXPeliculaTableAdapter1;
    }
}