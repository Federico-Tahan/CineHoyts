namespace Cine_Hoyts.Formularios
{
    partial class ConFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConFactura));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnltop = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboFormapago = new System.Windows.Forms.ComboBox();
            this.cbovendedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.pctFilter = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.picreset = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTipocompra = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.nro_fac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipocompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formapago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFilter)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picreset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.pnltop.Controls.Add(this.txbCliente);
            this.pnltop.Controls.Add(this.btnBuscar);
            this.pnltop.Controls.Add(this.cboFormapago);
            this.pnltop.Controls.Add(this.cbovendedor);
            this.pnltop.Controls.Add(this.label6);
            this.pnltop.Controls.Add(this.label3);
            this.pnltop.Controls.Add(this.lbCodigo);
            this.pnltop.Controls.Add(this.pctFilter);
            this.pnltop.Controls.Add(this.panel1);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(895, 160);
            this.pnltop.TabIndex = 9;
            this.pnltop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnltop_Paint);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(742, 118);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 36);
            this.btnBuscar.TabIndex = 75;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // cboFormapago
            // 
            this.cboFormapago.FormattingEnabled = true;
            this.cboFormapago.Location = new System.Drawing.Point(517, 133);
            this.cboFormapago.Name = "cboFormapago";
            this.cboFormapago.Size = new System.Drawing.Size(159, 21);
            this.cboFormapago.TabIndex = 49;
            // 
            // cbovendedor
            // 
            this.cbovendedor.FormattingEnabled = true;
            this.cbovendedor.Location = new System.Drawing.Point(288, 133);
            this.cbovendedor.Name = "cbovendedor";
            this.cbovendedor.Size = new System.Drawing.Size(159, 21);
            this.cbovendedor.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(513, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 23);
            this.label6.TabIndex = 48;
            this.label6.Text = "Forma Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(284, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "Vendedor";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCodigo.Location = new System.Drawing.Point(44, 98);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(76, 23);
            this.lbCodigo.TabIndex = 38;
            this.lbCodigo.Text = "Cliente";
            // 
            // pctFilter
            // 
            this.pctFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctFilter.Image = ((System.Drawing.Image)(resources.GetObject("pctFilter.Image")));
            this.pctFilter.Location = new System.Drawing.Point(878, 113);
            this.pctFilter.Name = "pctFilter";
            this.pctFilter.Size = new System.Drawing.Size(42, 41);
            this.pctFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFilter.TabIndex = 3;
            this.pctFilter.TabStop = false;
            this.pctFilter.Click += new System.EventHandler(this.pctFilter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 59);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(78, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facturas";
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(89)))), ((int)(((byte)(108)))));
            this.pnlFiltro.Controls.Add(this.picreset);
            this.pnlFiltro.Controls.Add(this.label8);
            this.pnlFiltro.Controls.Add(this.numeric);
            this.pnlFiltro.Controls.Add(this.label7);
            this.pnlFiltro.Controls.Add(this.cboTipocompra);
            this.pnlFiltro.Controls.Add(this.label4);
            this.pnlFiltro.Controls.Add(this.label2);
            this.pnlFiltro.Controls.Add(this.dtpFin);
            this.pnlFiltro.Controls.Add(this.label5);
            this.pnlFiltro.Controls.Add(this.dtpInicio);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltro.Location = new System.Drawing.Point(0, 160);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(895, 104);
            this.pnlFiltro.TabIndex = 10;
            // 
            // picreset
            // 
            this.picreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picreset.Image = ((System.Drawing.Image)(resources.GetObject("picreset.Image")));
            this.picreset.Location = new System.Drawing.Point(833, 46);
            this.picreset.Name = "picreset";
            this.picreset.Size = new System.Drawing.Size(50, 49);
            this.picreset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picreset.TabIndex = 50;
            this.picreset.TabStop = false;
            this.picreset.Click += new System.EventHandler(this.picreset_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(44, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(275, 23);
            this.label8.TabIndex = 53;
            this.label8.Text = "Rango de Fechas facturadas";
            // 
            // numeric
            // 
            this.numeric.Location = new System.Drawing.Point(624, 75);
            this.numeric.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numeric.Name = "numeric";
            this.numeric.Size = new System.Drawing.Size(137, 20);
            this.numeric.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(620, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 23);
            this.label7.TabIndex = 50;
            this.label7.Text = "Monto Minimo";
            // 
            // cboTipocompra
            // 
            this.cboTipocompra.FormattingEnabled = true;
            this.cboTipocompra.Location = new System.Drawing.Point(422, 74);
            this.cboTipocompra.Name = "cboTipocompra";
            this.cboTipocompra.Size = new System.Drawing.Size(159, 21);
            this.cboTipocompra.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(418, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 46;
            this.label4.Text = "Tipo Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(243, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 45;
            this.label2.Text = "Fecha de Fin";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(247, 75);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(139, 20);
            this.dtpFin.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(44, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 23);
            this.label5.TabIndex = 43;
            this.label5.Text = "Fecha de Inicio";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(48, 75);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(148, 20);
            this.dtpInicio.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel3.Controls.Add(this.dgvFactura);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 264);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(895, 400);
            this.panel3.TabIndex = 11;
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.AllowUserToDeleteRows = false;
            this.dgvFactura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dgvFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nro_fac,
            this.vendedor,
            this.cliente,
            this.fecha,
            this.tipocompra,
            this.Formapago,
            this.total});
            this.dgvFactura.EnableHeadersVisualStyles = false;
            this.dgvFactura.Location = new System.Drawing.Point(48, 16);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.ReadOnly = true;
            this.dgvFactura.RowHeadersVisible = false;
            this.dgvFactura.Size = new System.Drawing.Size(872, 348);
            this.dgvFactura.TabIndex = 1;
            // 
            // nro_fac
            // 
            this.nro_fac.HeaderText = "Nro Factura";
            this.nro_fac.Name = "nro_fac";
            this.nro_fac.ReadOnly = true;
            this.nro_fac.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // vendedor
            // 
            this.vendedor.HeaderText = "Vendedor";
            this.vendedor.Name = "vendedor";
            this.vendedor.ReadOnly = true;
            this.vendedor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.vendedor.Width = 150;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cliente.Width = 150;
            // 
            // fecha
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fecha.DefaultCellStyle = dataGridViewCellStyle2;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fecha.Width = 115;
            // 
            // tipocompra
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tipocompra.DefaultCellStyle = dataGridViewCellStyle3;
            this.tipocompra.HeaderText = "Tipo Compra";
            this.tipocompra.Name = "tipocompra";
            this.tipocompra.ReadOnly = true;
            this.tipocompra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tipocompra.Width = 120;
            // 
            // Formapago
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Formapago.DefaultCellStyle = dataGridViewCellStyle4;
            this.Formapago.HeaderText = "Forma Pago";
            this.Formapago.Name = "Formapago";
            this.Formapago.ReadOnly = true;
            this.Formapago.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Formapago.Width = 120;
            // 
            // total
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.total.DefaultCellStyle = dataGridViewCellStyle5;
            this.total.HeaderText = "Monto Gastado";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // txbCliente
            // 
            this.txbCliente.Location = new System.Drawing.Point(48, 134);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(163, 20);
            this.txbCliente.TabIndex = 76;
            // 
            // ConFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 664);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlFiltro);
            this.Controls.Add(this.pnltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConFactura";
            this.Load += new System.EventHandler(this.ConFactura_Load);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFilter)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picreset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.PictureBox pctFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.ComboBox cboFormapago;
        private System.Windows.Forms.ComboBox cbovendedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numeric;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboTipocompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picreset;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_fac;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipocompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formapago;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.TextBox txbCliente;
    }
}