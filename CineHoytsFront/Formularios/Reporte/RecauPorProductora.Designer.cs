namespace CineHoytsFront.Formularios.Reporte
{
    partial class RecauPorProductora
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
            this.sPRecaudacionPorFechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_RecaudacionPorFechasTableAdapter = new CineHoytsFront.Formularios.Reporte.DatReportTableAdapters.SP_RecaudacionPorFechasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRecaudacionPorFechasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sPRecaudacionPorFechasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CineHoytsFront.Formularios.Reporte.RDLC.Recaudacionproductora.rdlc";
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
            // sPRecaudacionPorFechasBindingSource
            // 
            this.sPRecaudacionPorFechasBindingSource.DataMember = "SP_RecaudacionPorFechas";
            this.sPRecaudacionPorFechasBindingSource.DataSource = this.datReportBindingSource;
            // 
            // sP_RecaudacionPorFechasTableAdapter
            // 
            this.sP_RecaudacionPorFechasTableAdapter.ClearBeforeFill = true;
            // 
            // RecauPorProductora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecauPorProductora";
            this.Text = "RecauPorProductora";
            this.Load += new System.EventHandler(this.RecauPorProductora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRecaudacionPorFechasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DatReport datReport;
        private System.Windows.Forms.BindingSource datReportBindingSource;
        private System.Windows.Forms.BindingSource sPRecaudacionPorFechasBindingSource;
        private DatReportTableAdapters.SP_RecaudacionPorFechasTableAdapter sP_RecaudacionPorFechasTableAdapter;
    }
}