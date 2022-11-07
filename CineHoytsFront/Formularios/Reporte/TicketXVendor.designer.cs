namespace CineHoytsFront.Formularios.Reporte
{
    partial class TicketXVendor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.datReport = new CineHoytsFront.Formularios.Reporte.DatReport();
            this.datReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPTICKETSxVENDEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_TICKETSxVENDEDORTableAdapter1 = new CineHoytsFront.Formularios.Reporte.DatReportTableAdapters.SP_TICKETSxVENDEDORTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPTICKETSxVENDEDORBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sPTICKETSxVENDEDORBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CineHoytsFront.Formularios.Reporte.RDLC.TicketXVendedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 119);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(985, 515);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 120);
            this.panel1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(227, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(579, 32);
            this.label12.TabIndex = 76;
            this.label12.Text = "Cantidad de Tickets emitidos por vendedor";
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
            // sPTICKETSxVENDEDORBindingSource
            // 
            this.sPTICKETSxVENDEDORBindingSource.DataMember = "SP_TICKETSxVENDEDOR";
            this.sPTICKETSxVENDEDORBindingSource.DataSource = this.datReportBindingSource;
            // 
            // sP_TICKETSxVENDEDORTableAdapter1
            // 
            this.sP_TICKETSxVENDEDORTableAdapter1.ClearBeforeFill = true;
            // 
            // TicketXVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 634);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketXVendor";
            this.Text = "TicketXVendor";
            this.Load += new System.EventHandler(this.TicketXVendor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPTICKETSxVENDEDORBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DatReportTableAdapters.SP_TICKETSxVENDEDORTableAdapter sP_TICKETSxVENDEDORTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private DatReport datReport;
        private System.Windows.Forms.BindingSource datReportBindingSource;
        private System.Windows.Forms.BindingSource sPTICKETSxVENDEDORBindingSource;
        private DatReportTableAdapters.SP_TICKETSxVENDEDORTableAdapter sP_TICKETSxVENDEDORTableAdapter1;
    }
}