namespace Cine_Project
{
    partial class ConCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pctFilter = new System.Windows.Forms.PictureBox();
            this.pnltop = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.rbtGenFem = new System.Windows.Forms.RadioButton();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.dtpNac = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.picreset = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CboTipoDoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pctFilter)).BeginInit();
            this.pnltop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.pnlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picreset)).BeginInit();
            this.SuspendLayout();
            // 
            // pctFilter
            // 
            this.pctFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctFilter.Image = ((System.Drawing.Image)(resources.GetObject("pctFilter.Image")));
            this.pctFilter.Location = new System.Drawing.Point(878, 107);
            this.pctFilter.Name = "pctFilter";
            this.pctFilter.Size = new System.Drawing.Size(42, 41);
            this.pctFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFilter.TabIndex = 3;
            this.pctFilter.TabStop = false;
            this.pctFilter.Click += new System.EventHandler(this.pctFilter_Click);
            // 
            // pnltop
            // 
            this.pnltop.Controls.Add(this.btnBuscar);
            this.pnltop.Controls.Add(this.label4);
            this.pnltop.Controls.Add(this.label3);
            this.pnltop.Controls.Add(this.lbCodigo);
            this.pnltop.Controls.Add(this.pctFilter);
            this.pnltop.Controls.Add(this.rdbMasc);
            this.pnltop.Controls.Add(this.rbtGenFem);
            this.pnltop.Controls.Add(this.txbNombre);
            this.pnltop.Controls.Add(this.dtpNac);
            this.pnltop.Controls.Add(this.panel1);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(895, 160);
            this.pnltop.TabIndex = 8;
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
            this.btnBuscar.Location = new System.Drawing.Point(754, 110);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 36);
            this.btnBuscar.TabIndex = 74;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(518, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 23);
            this.label4.TabIndex = 41;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(276, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "Genero";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCodigo.Location = new System.Drawing.Point(44, 98);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(85, 23);
            this.lbCodigo.TabIndex = 38;
            this.lbCodigo.Text = "Nombre";
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMasc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdbMasc.Location = new System.Drawing.Point(380, 131);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(97, 17);
            this.rdbMasc.TabIndex = 9;
            this.rdbMasc.TabStop = true;
            this.rdbMasc.Text = "2- Masculino";
            this.rdbMasc.UseVisualStyleBackColor = true;
            // 
            // rbtGenFem
            // 
            this.rbtGenFem.AutoSize = true;
            this.rbtGenFem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtGenFem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtGenFem.Location = new System.Drawing.Point(280, 130);
            this.rbtGenFem.Name = "rbtGenFem";
            this.rbtGenFem.Size = new System.Drawing.Size(94, 17);
            this.rbtGenFem.TabIndex = 8;
            this.rbtGenFem.TabStop = true;
            this.rbtGenFem.Text = "1- Femenino";
            this.rbtGenFem.UseVisualStyleBackColor = true;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(48, 127);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(197, 20);
            this.txbNombre.TabIndex = 11;
            // 
            // dtpNac
            // 
            this.dtpNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNac.Location = new System.Drawing.Point(522, 123);
            this.dtpNac.Name = "dtpNac";
            this.dtpNac.Size = new System.Drawing.Size(204, 20);
            this.dtpNac.TabIndex = 10;
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
            this.label1.Size = new System.Drawing.Size(141, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvCliente);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 264);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(895, 400);
            this.panel3.TabIndex = 10;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcliente,
            this.Nombre,
            this.nro_doc,
            this.Fecha_nac,
            this.genero,
            this.Tipo_cliente,
            this.total});
            this.dgvCliente.EnableHeadersVisualStyles = false;
            this.dgvCliente.Location = new System.Drawing.Point(48, 16);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.Size = new System.Drawing.Size(872, 348);
            this.dgvCliente.TabIndex = 1;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(89)))), ((int)(((byte)(108)))));
            this.pnlFiltro.Controls.Add(this.picreset);
            this.pnlFiltro.Controls.Add(this.label8);
            this.pnlFiltro.Controls.Add(this.label6);
            this.pnlFiltro.Controls.Add(this.CboTipoDoc);
            this.pnlFiltro.Controls.Add(this.label2);
            this.pnlFiltro.Controls.Add(this.dtpFin);
            this.pnlFiltro.Controls.Add(this.label5);
            this.pnlFiltro.Controls.Add(this.dtpInicio);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltro.Location = new System.Drawing.Point(0, 160);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(895, 104);
            this.pnlFiltro.TabIndex = 9;
            // 
            // picreset
            // 
            this.picreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picreset.Image = ((System.Drawing.Image)(resources.GetObject("picreset.Image")));
            this.picreset.Location = new System.Drawing.Point(833, 46);
            this.picreset.Name = "picreset";
            this.picreset.Size = new System.Drawing.Size(50, 49);
            this.picreset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picreset.TabIndex = 42;
            this.picreset.TabStop = false;
            this.picreset.Click += new System.EventHandler(this.picreset_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(44, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(275, 23);
            this.label8.TabIndex = 54;
            this.label8.Text = "Rango de Fechas facturadas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(469, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 23);
            this.label6.TabIndex = 42;
            this.label6.Text = "Tipo Documento";
            // 
            // CboTipoDoc
            // 
            this.CboTipoDoc.FormattingEnabled = true;
            this.CboTipoDoc.Location = new System.Drawing.Point(473, 74);
            this.CboTipoDoc.Name = "CboTipoDoc";
            this.CboTipoDoc.Size = new System.Drawing.Size(185, 21);
            this.CboTipoDoc.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(276, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 49;
            this.label2.Text = "Fecha de Fin";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(280, 75);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(139, 20);
            this.dtpFin.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(50, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 23);
            this.label5.TabIndex = 47;
            this.label5.Text = "Fecha de Inicio";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(54, 75);
            this.dtpInicio.MaxDate = new System.DateTime(2033, 11, 6, 0, 0, 0, 0);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(148, 20);
            this.dtpInicio.TabIndex = 46;
            this.dtpInicio.Value = new System.DateTime(2000, 1, 25, 0, 0, 0, 0);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // idcliente
            // 
            this.idcliente.HeaderText = "Nro Cliente";
            this.idcliente.Name = "idcliente";
            this.idcliente.ReadOnly = true;
            this.idcliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Completo";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 150;
            // 
            // nro_doc
            // 
            this.nro_doc.HeaderText = "Documento";
            this.nro_doc.Name = "nro_doc";
            this.nro_doc.ReadOnly = true;
            this.nro_doc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nro_doc.Width = 103;
            // 
            // Fecha_nac
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Fecha_nac.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fecha_nac.HeaderText = "Fecha Nacimiento";
            this.Fecha_nac.Name = "Fecha_nac";
            this.Fecha_nac.ReadOnly = true;
            this.Fecha_nac.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fecha_nac.Width = 140;
            // 
            // genero
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.genero.DefaultCellStyle = dataGridViewCellStyle3;
            this.genero.HeaderText = "Genero";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            this.genero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.genero.Width = 120;
            // 
            // Tipo_cliente
            // 
            this.Tipo_cliente.HeaderText = "Tipo Documento";
            this.Tipo_cliente.Name = "Tipo_cliente";
            this.Tipo_cliente.ReadOnly = true;
            this.Tipo_cliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tipo_cliente.Width = 140;
            // 
            // total
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.total.DefaultCellStyle = dataGridViewCellStyle4;
            this.total.HeaderText = "Monto Gastado";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ConCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(895, 664);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlFiltro);
            this.Controls.Add(this.pnltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConCliente";
            this.Text = "ConCliente";
            this.Load += new System.EventHandler(this.ConCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctFilter)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picreset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pctFilter;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.RadioButton rbtGenFem;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.DateTimePicker dtpNac;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboTipoDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picreset;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_nac;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}