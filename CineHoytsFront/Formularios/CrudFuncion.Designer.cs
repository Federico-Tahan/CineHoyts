namespace CineHoytsFront.Formularios
{
    partial class CrudFuncion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudFuncion));
            this.pnlControl = new System.Windows.Forms.Panel();
            this.pnlCrud = new System.Windows.Forms.Panel();
            this.numMonto = new System.Windows.Forms.NumericUpDown();
            this.Cbosala = new System.Windows.Forms.ComboBox();
            this.Cboidioma = new System.Windows.Forms.ComboBox();
            this.cboPel = new System.Windows.Forms.ComboBox();
            this.lbFechaNac = new System.Windows.Forms.Label();
            this.lbTipDoc = new System.Windows.Forms.Label();
            this.lbProvincia = new System.Windows.Forms.Label();
            this.lbLocalidad = new System.Windows.Forms.Label();
            this.lbBarrio = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.dtpFechaFun = new System.Windows.Forms.DateTimePicker();
            this.cboHorario = new System.Windows.Forms.ComboBox();
            this.dgvFuncion = new System.Windows.Forms.DataGridView();
            this.pnltop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCrud = new System.Windows.Forms.Label();
            this.idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.picdesplegar = new System.Windows.Forms.PictureBox();
            this.picLimpiar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlControl.SuspendLayout();
            this.pnlCrud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncion)).BeginInit();
            this.pnltop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picdesplegar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.pnlControl.Controls.Add(this.BtnGuardar);
            this.pnlControl.Controls.Add(this.btnBorrar);
            this.pnlControl.Controls.Add(this.btnMod);
            this.pnlControl.Controls.Add(this.btnNuevo);
            this.pnlControl.Controls.Add(this.pnlCrud);
            this.pnlControl.Controls.Add(this.dgvFuncion);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(0, 67);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(895, 597);
            this.pnlControl.TabIndex = 13;
            // 
            // pnlCrud
            // 
            this.pnlCrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(84)))), ((int)(((byte)(102)))));
            this.pnlCrud.Controls.Add(this.numMonto);
            this.pnlCrud.Controls.Add(this.Cbosala);
            this.pnlCrud.Controls.Add(this.Cboidioma);
            this.pnlCrud.Controls.Add(this.cboPel);
            this.pnlCrud.Controls.Add(this.picdesplegar);
            this.pnlCrud.Controls.Add(this.picLimpiar);
            this.pnlCrud.Controls.Add(this.lbFechaNac);
            this.pnlCrud.Controls.Add(this.lbTipDoc);
            this.pnlCrud.Controls.Add(this.lbProvincia);
            this.pnlCrud.Controls.Add(this.lbLocalidad);
            this.pnlCrud.Controls.Add(this.lbBarrio);
            this.pnlCrud.Controls.Add(this.lbDireccion);
            this.pnlCrud.Controls.Add(this.dtpFechaFun);
            this.pnlCrud.Controls.Add(this.cboHorario);
            this.pnlCrud.Location = new System.Drawing.Point(29, 38);
            this.pnlCrud.Name = "pnlCrud";
            this.pnlCrud.Size = new System.Drawing.Size(881, 402);
            this.pnlCrud.TabIndex = 7;
            this.pnlCrud.Visible = false;
            // 
            // numMonto
            // 
            this.numMonto.Location = new System.Drawing.Point(566, 224);
            this.numMonto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMonto.Name = "numMonto";
            this.numMonto.Size = new System.Drawing.Size(189, 20);
            this.numMonto.TabIndex = 63;
            // 
            // Cbosala
            // 
            this.Cbosala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbosala.FormattingEnabled = true;
            this.Cbosala.Location = new System.Drawing.Point(566, 126);
            this.Cbosala.Name = "Cbosala";
            this.Cbosala.Size = new System.Drawing.Size(189, 21);
            this.Cbosala.TabIndex = 62;
            // 
            // Cboidioma
            // 
            this.Cboidioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cboidioma.FormattingEnabled = true;
            this.Cboidioma.Location = new System.Drawing.Point(327, 126);
            this.Cboidioma.Name = "Cboidioma";
            this.Cboidioma.Size = new System.Drawing.Size(189, 21);
            this.Cboidioma.TabIndex = 61;
            // 
            // cboPel
            // 
            this.cboPel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPel.FormattingEnabled = true;
            this.cboPel.Location = new System.Drawing.Point(75, 126);
            this.cboPel.Name = "cboPel";
            this.cboPel.Size = new System.Drawing.Size(196, 21);
            this.cboPel.TabIndex = 60;
            // 
            // lbFechaNac
            // 
            this.lbFechaNac.AutoSize = true;
            this.lbFechaNac.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaNac.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFechaNac.Location = new System.Drawing.Point(71, 194);
            this.lbFechaNac.Name = "lbFechaNac";
            this.lbFechaNac.Size = new System.Drawing.Size(143, 23);
            this.lbFechaNac.TabIndex = 55;
            this.lbFechaNac.Text = "Fecha Funcion";
            // 
            // lbTipDoc
            // 
            this.lbTipDoc.AutoSize = true;
            this.lbTipDoc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipDoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTipDoc.Location = new System.Drawing.Point(323, 197);
            this.lbTipDoc.Name = "lbTipDoc";
            this.lbTipDoc.Size = new System.Drawing.Size(77, 23);
            this.lbTipDoc.TabIndex = 53;
            this.lbTipDoc.Text = "Horario";
            // 
            // lbProvincia
            // 
            this.lbProvincia.AutoSize = true;
            this.lbProvincia.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProvincia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbProvincia.Location = new System.Drawing.Point(71, 86);
            this.lbProvincia.Name = "lbProvincia";
            this.lbProvincia.Size = new System.Drawing.Size(84, 23);
            this.lbProvincia.TabIndex = 49;
            this.lbProvincia.Text = "Pelicula";
            // 
            // lbLocalidad
            // 
            this.lbLocalidad.AutoSize = true;
            this.lbLocalidad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbLocalidad.Location = new System.Drawing.Point(325, 87);
            this.lbLocalidad.Name = "lbLocalidad";
            this.lbLocalidad.Size = new System.Drawing.Size(76, 23);
            this.lbLocalidad.TabIndex = 48;
            this.lbLocalidad.Text = "Idioma";
            // 
            // lbBarrio
            // 
            this.lbBarrio.AutoSize = true;
            this.lbBarrio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBarrio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbBarrio.Location = new System.Drawing.Point(573, 87);
            this.lbBarrio.Name = "lbBarrio";
            this.lbBarrio.Size = new System.Drawing.Size(51, 23);
            this.lbBarrio.TabIndex = 46;
            this.lbBarrio.Text = "Sala";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDireccion.Location = new System.Drawing.Point(562, 197);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(68, 23);
            this.lbDireccion.TabIndex = 45;
            this.lbDireccion.Text = "Monto";
            // 
            // dtpFechaFun
            // 
            this.dtpFechaFun.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFun.Location = new System.Drawing.Point(75, 220);
            this.dtpFechaFun.Name = "dtpFechaFun";
            this.dtpFechaFun.Size = new System.Drawing.Size(196, 20);
            this.dtpFechaFun.TabIndex = 11;
            // 
            // cboHorario
            // 
            this.cboHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHorario.FormattingEnabled = true;
            this.cboHorario.Location = new System.Drawing.Point(327, 223);
            this.cboHorario.Name = "cboHorario";
            this.cboHorario.Size = new System.Drawing.Size(189, 21);
            this.cboHorario.TabIndex = 6;
            // 
            // dgvFuncion
            // 
            this.dgvFuncion.AllowUserToAddRows = false;
            this.dgvFuncion.AllowUserToDeleteRows = false;
            this.dgvFuncion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dgvFuncion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFuncion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcliente,
            this.Nombre,
            this.nro_doc,
            this.tipo_doc,
            this.Direccion,
            this.Fecha_nac,
            this.Sexo});
            this.dgvFuncion.EnableHeadersVisualStyles = false;
            this.dgvFuncion.Location = new System.Drawing.Point(29, 38);
            this.dgvFuncion.Name = "dgvFuncion";
            this.dgvFuncion.ReadOnly = true;
            this.dgvFuncion.RowHeadersVisible = false;
            this.dgvFuncion.Size = new System.Drawing.Size(881, 402);
            this.dgvFuncion.TabIndex = 1;
            this.dgvFuncion.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncion_CellContentDoubleClick);
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.pnltop.Controls.Add(this.panel1);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(895, 67);
            this.pnltop.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbCrud);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 59);
            this.panel1.TabIndex = 3;
            // 
            // lbCrud
            // 
            this.lbCrud.AutoSize = true;
            this.lbCrud.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrud.ForeColor = System.Drawing.SystemColors.Control;
            this.lbCrud.Location = new System.Drawing.Point(75, 9);
            this.lbCrud.Name = "lbCrud";
            this.lbCrud.Size = new System.Drawing.Size(232, 38);
            this.lbCrud.TabIndex = 0;
            this.lbCrud.Text = "CRUD Funcion";
            // 
            // idcliente
            // 
            this.idcliente.HeaderText = "Nro Funcion";
            this.idcliente.Name = "idcliente";
            this.idcliente.ReadOnly = true;
            this.idcliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idcliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Pelicula";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nombre.Width = 150;
            // 
            // nro_doc
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nro_doc.DefaultCellStyle = dataGridViewCellStyle8;
            this.nro_doc.HeaderText = "Idioma";
            this.nro_doc.Name = "nro_doc";
            this.nro_doc.ReadOnly = true;
            this.nro_doc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nro_doc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nro_doc.Width = 110;
            // 
            // tipo_doc
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tipo_doc.DefaultCellStyle = dataGridViewCellStyle9;
            this.tipo_doc.HeaderText = "Sala";
            this.tipo_doc.Name = "tipo_doc";
            this.tipo_doc.ReadOnly = true;
            this.tipo_doc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tipo_doc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tipo_doc.Width = 140;
            // 
            // Direccion
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Direccion.DefaultCellStyle = dataGridViewCellStyle10;
            this.Direccion.HeaderText = "Fecha";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Direccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Direccion.Width = 175;
            // 
            // Fecha_nac
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Fecha_nac.DefaultCellStyle = dataGridViewCellStyle11;
            this.Fecha_nac.HeaderText = "Horario";
            this.Fecha_nac.Name = "Fecha_nac";
            this.Fecha_nac.ReadOnly = true;
            this.Fecha_nac.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fecha_nac.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Fecha_nac.Width = 120;
            // 
            // Sexo
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Sexo.DefaultCellStyle = dataGridViewCellStyle12;
            this.Sexo.HeaderText = "Monto";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sexo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Sexo.Width = 80;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.Enabled = false;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardar.Image = global::CineHoytsFront.Properties.Resources.guardar_el_archivo;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(635, 500);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(119, 36);
            this.BtnGuardar.TabIndex = 79;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.Enabled = false;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBorrar.Image = global::CineHoytsFront.Properties.Resources.remover_archivo__1_;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(490, 500);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(119, 36);
            this.btnBorrar.TabIndex = 78;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMod.Enabled = false;
            this.btnMod.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMod.Image = global::CineHoytsFront.Properties.Resources.actualizar;
            this.btnMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMod.Location = new System.Drawing.Point(330, 500);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(128, 36);
            this.btnMod.TabIndex = 77;
            this.btnMod.Text = "Modificar";
            this.btnMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(171, 500);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(129, 36);
            this.btnNuevo.TabIndex = 76;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // picdesplegar
            // 
            this.picdesplegar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picdesplegar.Image = ((System.Drawing.Image)(resources.GetObject("picdesplegar.Image")));
            this.picdesplegar.Location = new System.Drawing.Point(817, 13);
            this.picdesplegar.Name = "picdesplegar";
            this.picdesplegar.Size = new System.Drawing.Size(43, 39);
            this.picdesplegar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picdesplegar.TabIndex = 57;
            this.picdesplegar.TabStop = false;
            this.picdesplegar.Click += new System.EventHandler(this.picdesplegar_Click);
            // 
            // picLimpiar
            // 
            this.picLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("picLimpiar.Image")));
            this.picLimpiar.Location = new System.Drawing.Point(815, 332);
            this.picLimpiar.Name = "picLimpiar";
            this.picLimpiar.Size = new System.Drawing.Size(45, 50);
            this.picLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLimpiar.TabIndex = 56;
            this.picLimpiar.TabStop = false;
            this.picLimpiar.Click += new System.EventHandler(this.picLimpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CineHoytsFront.Properties.Resources.tiempo_de_la_funcion__1_;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CrudFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 664);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrudFuncion";
            this.Text = "CrudFuncion";
            this.Load += new System.EventHandler(this.CrudFuncion_Load);
            this.pnlControl.ResumeLayout(false);
            this.pnlCrud.ResumeLayout(false);
            this.pnlCrud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncion)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picdesplegar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel pnlCrud;
        private System.Windows.Forms.ComboBox Cbosala;
        private System.Windows.Forms.ComboBox Cboidioma;
        private System.Windows.Forms.ComboBox cboPel;
        private System.Windows.Forms.PictureBox picdesplegar;
        private System.Windows.Forms.PictureBox picLimpiar;
        private System.Windows.Forms.Label lbFechaNac;
        private System.Windows.Forms.Label lbTipDoc;
        private System.Windows.Forms.Label lbProvincia;
        private System.Windows.Forms.Label lbLocalidad;
        private System.Windows.Forms.Label lbBarrio;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.DateTimePicker dtpFechaFun;
        private System.Windows.Forms.ComboBox cboHorario;
        private System.Windows.Forms.DataGridView dgvFuncion;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbCrud;
        private System.Windows.Forms.NumericUpDown numMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_nac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
    }
}