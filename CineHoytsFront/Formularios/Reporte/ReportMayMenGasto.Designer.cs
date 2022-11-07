namespace CineHoytsFront.Formularios.Reporte
{
    partial class ReportMayMenGasto
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
            this.sPMAYORMENORGASTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_MAYOR_MENOR_GASTOTableAdapter1 = new CineHoytsFront.Formularios.Reporte.DatReportTableAdapters.SP_MAYOR_MENOR_GASTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMAYORMENORGASTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sPMAYORMENORGASTOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CineHoytsFront.Formularios.Reporte.RDLC.MayMenGasto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(847, 480);
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
            // sPMAYORMENORGASTOBindingSource
            // 
            this.sPMAYORMENORGASTOBindingSource.DataMember = "SP_MAYOR_MENOR_GASTO";
            this.sPMAYORMENORGASTOBindingSource.DataSource = this.datReportBindingSource;
            // 
            // sP_MAYOR_MENOR_GASTOTableAdapter1
            // 
            this.sP_MAYOR_MENOR_GASTOTableAdapter1.ClearBeforeFill = true;
            // 
            // ReportMayMenGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 480);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportMayMenGasto";
            this.Text = "ReportMayMenGasto";
            this.Load += new System.EventHandler(this.ReportMayMenGasto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMAYORMENORGASTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DatReportTableAdapters.SP_MAYOR_MENOR_GASTOTableAdapter sP_MAYOR_MENOR_GASTOTableAdapter;
        private DatReport datReport;
        private System.Windows.Forms.BindingSource datReportBindingSource;
        private System.Windows.Forms.BindingSource sPMAYORMENORGASTOBindingSource;
        private DatReportTableAdapters.SP_MAYOR_MENOR_GASTOTableAdapter sP_MAYOR_MENOR_GASTOTableAdapter1;
    }
}