namespace Cine_Project
{
    partial class ConPelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConPelicula));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnltop = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboprod = new System.Windows.Forms.ComboBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pctFilter = new System.Windows.Forms.PictureBox();
            this.cborestrc = new System.Windows.Forms.ComboBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.picreset = new System.Windows.Forms.PictureBox();
            this.nummin = new System.Windows.Forms.NumericUpDown();
            this.numespc = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvPel = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ID_PELICULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restriccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFilter)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picreset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nummin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numespc)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPel)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.pnltop.Controls.Add(this.btnBuscar);
            this.pnltop.Controls.Add(this.label4);
            this.pnltop.Controls.Add(this.cboprod);
            this.pnltop.Controls.Add(this.lbCodigo);
            this.pnltop.Controls.Add(this.label5);
            this.pnltop.Controls.Add(this.pctFilter);
            this.pnltop.Controls.Add(this.cborestrc);
            this.pnltop.Controls.Add(this.txbNombre);
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
            this.btnBuscar.Location = new System.Drawing.Point(745, 112);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 36);
            this.btnBuscar.TabIndex = 76;
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
            this.label4.Location = new System.Drawing.Point(290, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 47;
            this.label4.Text = "Producción";
            // 
            // cboprod
            // 
            this.cboprod.FormattingEnabled = true;
            this.cboprod.Location = new System.Drawing.Point(294, 126);
            this.cboprod.Name = "cboprod";
            this.cboprod.Size = new System.Drawing.Size(171, 21);
            this.cboprod.TabIndex = 46;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(506, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 23);
            this.label5.TabIndex = 45;
            this.label5.Text = "Restricción";
            // 
            // pctFilter
            // 
            this.pctFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctFilter.Image = ((System.Drawing.Image)(resources.GetObject("pctFilter.Image")));
            this.pctFilter.Location = new System.Drawing.Point(867, 107);
            this.pctFilter.Name = "pctFilter";
            this.pctFilter.Size = new System.Drawing.Size(42, 41);
            this.pctFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFilter.TabIndex = 3;
            this.pctFilter.TabStop = false;
            this.pctFilter.Click += new System.EventHandler(this.pctFilter_Click);
            // 
            // cborestrc
            // 
            this.cborestrc.FormattingEnabled = true;
            this.cborestrc.Location = new System.Drawing.Point(510, 126);
            this.cborestrc.Name = "cborestrc";
            this.cborestrc.Size = new System.Drawing.Size(197, 21);
            this.cborestrc.TabIndex = 44;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(48, 127);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(197, 20);
            this.txbNombre.TabIndex = 11;
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
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 54);
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
            this.label1.Size = new System.Drawing.Size(153, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peliculas";
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(89)))), ((int)(((byte)(108)))));
            this.pnlFiltro.Controls.Add(this.picreset);
            this.pnlFiltro.Controls.Add(this.nummin);
            this.pnlFiltro.Controls.Add(this.numespc);
            this.pnlFiltro.Controls.Add(this.label6);
            this.pnlFiltro.Controls.Add(this.label3);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltro.Location = new System.Drawing.Point(0, 160);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(895, 100);
            this.pnlFiltro.TabIndex = 10;
            // 
            // picreset
            // 
            this.picreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picreset.Image = ((System.Drawing.Image)(resources.GetObject("picreset.Image")));
            this.picreset.Location = new System.Drawing.Point(833, 28);
            this.picreset.Name = "picreset";
            this.picreset.Size = new System.Drawing.Size(50, 49);
            this.picreset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picreset.TabIndex = 51;
            this.picreset.TabStop = false;
            this.picreset.Click += new System.EventHandler(this.picreset_Click);
            // 
            // nummin
            // 
            this.nummin.Location = new System.Drawing.Point(48, 55);
            this.nummin.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nummin.Name = "nummin";
            this.nummin.Size = new System.Drawing.Size(194, 20);
            this.nummin.TabIndex = 49;
            // 
            // numespc
            // 
            this.numespc.Location = new System.Drawing.Point(294, 55);
            this.numespc.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numespc.Name = "numespc";
            this.numespc.Size = new System.Drawing.Size(171, 20);
            this.numespc.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(290, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 23);
            this.label6.TabIndex = 47;
            this.label6.Text = "Espectadores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(46, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "Duracion en Minutos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel3.Controls.Add(this.dgvPel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(895, 404);
            this.panel3.TabIndex = 11;
            // 
            // dgvPel
            // 
            this.dgvPel.AllowUserToAddRows = false;
            this.dgvPel.AllowUserToDeleteRows = false;
            this.dgvPel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dgvPel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PELICULA,
            this.Nombre,
            this.Duracion,
            this.Produccion,
            this.Restriccion,
            this.Total});
            this.dgvPel.EnableHeadersVisualStyles = false;
            this.dgvPel.Location = new System.Drawing.Point(48, 16);
            this.dgvPel.Name = "dgvPel";
            this.dgvPel.ReadOnly = true;
            this.dgvPel.RowHeadersVisible = false;
            this.dgvPel.Size = new System.Drawing.Size(847, 348);
            this.dgvPel.TabIndex = 1;
            // 
            // ID_PELICULA
            // 
            this.ID_PELICULA.HeaderText = "Nro Pelicula";
            this.ID_PELICULA.Name = "ID_PELICULA";
            this.ID_PELICULA.ReadOnly = true;
            this.ID_PELICULA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Titulo";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 230;
            // 
            // Duracion
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Duracion.DefaultCellStyle = dataGridViewCellStyle2;
            this.Duracion.HeaderText = "Duración";
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            this.Duracion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Duracion.Width = 105;
            // 
            // Produccion
            // 
            this.Produccion.HeaderText = "Produccion";
            this.Produccion.Name = "Produccion";
            this.Produccion.ReadOnly = true;
            this.Produccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Produccion.Width = 150;
            // 
            // Restriccion
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Restriccion.DefaultCellStyle = dataGridViewCellStyle3;
            this.Restriccion.HeaderText = "Restriccion";
            this.Restriccion.Name = "Restriccion";
            this.Restriccion.ReadOnly = true;
            this.Restriccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Restriccion.Width = 130;
            // 
            // Total
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Total.DefaultCellStyle = dataGridViewCellStyle4;
            this.Total.HeaderText = "Total Espectadores";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Total.Width = 130;
            // 
            // ConPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 664);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlFiltro);
            this.Controls.Add(this.pnltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConPelicula";
            this.Load += new System.EventHandler(this.ConPelicula_Load);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFilter)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picreset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nummin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numespc)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.PictureBox pctFilter;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvPel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cborestrc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboprod;
        private System.Windows.Forms.NumericUpDown nummin;
        private System.Windows.Forms.NumericUpDown numespc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picreset;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PELICULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Restriccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}