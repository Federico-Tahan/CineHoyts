namespace CineHoytsFront.Formularios.Reporte.RDLC
{
    partial class FormGastoCliente
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sPGetAvgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datReport = new CineHoytsFront.Formularios.Reporte.DatReport();
            this.sPGastoClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sP_GastoClientesTableAdapter = new CineHoytsFront.Formularios.Reporte.DatReportTableAdapters.SP_GastoClientesTableAdapter();
            this.sP_GetAvgTableAdapter = new CineHoytsFront.Formularios.Reporte.DatReportTableAdapters.SP_GetAvgTableAdapter();
            this.SP_GetAvgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_GastoClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sPGetAvgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGastoClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_GetAvgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_GastoClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sPGetAvgBindingSource
            // 
            this.sPGetAvgBindingSource.DataMember = "SP_GetAvg";
            this.sPGetAvgBindingSource.DataSource = this.datReportBindingSource;
            // 
            // datReportBindingSource
            // 
            this.datReportBindingSource.DataSource = this.datReport;
            this.datReportBindingSource.Position = 0;
            // 
            // datReport
            // 
            this.datReport.DataSetName = "DatReport";
            this.datReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPGastoClientesBindingSource
            // 
            this.sPGastoClientesBindingSource.DataMember = "SP_GastoClientes";
            this.sPGastoClientesBindingSource.DataSource = this.datReportBindingSource;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataAvg";
            reportDataSource1.Value = this.SP_GetAvgBindingSource;
            reportDataSource2.Name = "clientes";
            reportDataSource2.Value = this.SP_GastoClientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CineHoytsFront.Formularios.Reporte.RDLC.ReportGastoCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(871, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // sP_GastoClientesTableAdapter
            // 
            this.sP_GastoClientesTableAdapter.ClearBeforeFill = true;
            // 
            // sP_GetAvgTableAdapter
            // 
            this.sP_GetAvgTableAdapter.ClearBeforeFill = true;
            // 
            // SP_GetAvgBindingSource
            // 
            this.SP_GetAvgBindingSource.DataMember = "SP_GetAvg";
            this.SP_GetAvgBindingSource.DataSource = this.datReport;
            // 
            // SP_GastoClientesBindingSource
            // 
            this.SP_GastoClientesBindingSource.DataMember = "SP_GastoClientes";
            this.SP_GastoClientesBindingSource.DataSource = this.datReport;
            // 
            // FormGastoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGastoCliente";
            this.Text = "FormGastoCliente";
            this.Load += new System.EventHandler(this.FormGastoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPGetAvgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGastoClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_GetAvgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_GastoClientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DatReport datReport;
        private System.Windows.Forms.BindingSource datReportBindingSource;
        private System.Windows.Forms.BindingSource sPGastoClientesBindingSource;
        private DatReportTableAdapters.SP_GastoClientesTableAdapter sP_GastoClientesTableAdapter;
        private System.Windows.Forms.BindingSource sPGetAvgBindingSource;
        private DatReportTableAdapters.SP_GetAvgTableAdapter sP_GetAvgTableAdapter;
        private System.Windows.Forms.BindingSource SP_GetAvgBindingSource;
        private System.Windows.Forms.BindingSource SP_GastoClientesBindingSource;
    }
}