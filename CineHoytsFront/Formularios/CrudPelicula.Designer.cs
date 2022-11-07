namespace CineHoytsFront.Formularios
{
    partial class CrudPelicula
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudPelicula));
            this.pnlControl = new System.Windows.Forms.Panel();
            this.pnlCrud = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.numDuracion = new System.Windows.Forms.NumericUpDown();
            this.btnSubirImagen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.cboprod = new System.Windows.Forms.ComboBox();
            this.cborestrc = new System.Windows.Forms.ComboBox();
            this.lbFechaNac = new System.Windows.Forms.Label();
            this.lbProvincia = new System.Windows.Forms.Label();
            this.lbLocalidad = new System.Windows.Forms.Label();
            this.lbBarrio = new System.Windows.Forms.Label();
            this.dgvPel = new System.Windows.Forms.DataGridView();
            this.ID_PELICULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restriccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnltop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCrud = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.picdesplegar = new System.Windows.Forms.PictureBox();
            this.picLimpiar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlControl.SuspendLayout();
            this.pnlCrud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPel)).BeginInit();
            this.pnltop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
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
            this.pnlControl.Controls.Add(this.dgvPel);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(0, 67);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(895, 597);
            this.pnlControl.TabIndex = 15;
            // 
            // pnlCrud
            // 
            this.pnlCrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(84)))), ((int)(((byte)(102)))));
            this.pnlCrud.Controls.Add(this.label2);
            this.pnlCrud.Controls.Add(this.numDuracion);
            this.pnlCrud.Controls.Add(this.picImage);
            this.pnlCrud.Controls.Add(this.btnSubirImagen);
            this.pnlCrud.Controls.Add(this.label1);
            this.pnlCrud.Controls.Add(this.TxtDesc);
            this.pnlCrud.Controls.Add(this.txbTitulo);
            this.pnlCrud.Controls.Add(this.cboprod);
            this.pnlCrud.Controls.Add(this.cborestrc);
            this.pnlCrud.Controls.Add(this.picdesplegar);
            this.pnlCrud.Controls.Add(this.picLimpiar);
            this.pnlCrud.Controls.Add(this.lbFechaNac);
            this.pnlCrud.Controls.Add(this.lbProvincia);
            this.pnlCrud.Controls.Add(this.lbLocalidad);
            this.pnlCrud.Controls.Add(this.lbBarrio);
            this.pnlCrud.Location = new System.Drawing.Point(29, 42);
            this.pnlCrud.Name = "pnlCrud";
            this.pnlCrud.Size = new System.Drawing.Size(881, 399);
            this.pnlCrud.TabIndex = 7;
            this.pnlCrud.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(318, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 80;
            this.label2.Text = "Duracion";
            // 
            // numDuracion
            // 
            this.numDuracion.Location = new System.Drawing.Point(320, 160);
            this.numDuracion.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDuracion.Name = "numDuracion";
            this.numDuracion.Size = new System.Drawing.Size(118, 20);
            this.numDuracion.TabIndex = 79;
            // 
            // btnSubirImagen
            // 
            this.btnSubirImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnSubirImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirImagen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubirImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSubirImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirImagen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirImagen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubirImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubirImagen.Location = new System.Drawing.Point(615, 332);
            this.btnSubirImagen.Name = "btnSubirImagen";
            this.btnSubirImagen.Size = new System.Drawing.Size(71, 26);
            this.btnSubirImagen.TabIndex = 77;
            this.btnSubirImagen.Text = "Subir";
            this.btnSubirImagen.UseVisualStyleBackColor = false;
            this.btnSubirImagen.Click += new System.EventHandler(this.btnSubirImagen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(611, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 67;
            this.label1.Text = "Imagen";
            // 
            // TxtDesc
            // 
            this.TxtDesc.Location = new System.Drawing.Point(68, 160);
            this.TxtDesc.Multiline = true;
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(196, 198);
            this.TxtDesc.TabIndex = 65;
            // 
            // txbTitulo
            // 
            this.txbTitulo.Location = new System.Drawing.Point(68, 71);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(196, 20);
            this.txbTitulo.TabIndex = 64;
            // 
            // cboprod
            // 
            this.cboprod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboprod.FormattingEnabled = true;
            this.cboprod.Location = new System.Drawing.Point(559, 70);
            this.cboprod.Name = "cboprod";
            this.cboprod.Size = new System.Drawing.Size(189, 21);
            this.cboprod.TabIndex = 62;
            // 
            // cborestrc
            // 
            this.cborestrc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cborestrc.FormattingEnabled = true;
            this.cborestrc.Location = new System.Drawing.Point(320, 70);
            this.cborestrc.Name = "cborestrc";
            this.cborestrc.Size = new System.Drawing.Size(189, 21);
            this.cborestrc.TabIndex = 61;
            // 
            // lbFechaNac
            // 
            this.lbFechaNac.AutoSize = true;
            this.lbFechaNac.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaNac.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFechaNac.Location = new System.Drawing.Point(64, 134);
            this.lbFechaNac.Name = "lbFechaNac";
            this.lbFechaNac.Size = new System.Drawing.Size(119, 23);
            this.lbFechaNac.TabIndex = 55;
            this.lbFechaNac.Text = "Descripcion";
            // 
            // lbProvincia
            // 
            this.lbProvincia.AutoSize = true;
            this.lbProvincia.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProvincia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbProvincia.Location = new System.Drawing.Point(64, 29);
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
            this.lbLocalidad.Location = new System.Drawing.Point(318, 29);
            this.lbLocalidad.Name = "lbLocalidad";
            this.lbLocalidad.Size = new System.Drawing.Size(110, 23);
            this.lbLocalidad.TabIndex = 48;
            this.lbLocalidad.Text = "Restriccion";
            // 
            // lbBarrio
            // 
            this.lbBarrio.AutoSize = true;
            this.lbBarrio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBarrio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbBarrio.Location = new System.Drawing.Point(555, 29);
            this.lbBarrio.Name = "lbBarrio";
            this.lbBarrio.Size = new System.Drawing.Size(99, 23);
            this.lbBarrio.TabIndex = 46;
            this.lbBarrio.Text = "Productor";
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
            this.Restriccion});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPel.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPel.EnableHeadersVisualStyles = false;
            this.dgvPel.Location = new System.Drawing.Point(29, 42);
            this.dgvPel.Name = "dgvPel";
            this.dgvPel.ReadOnly = true;
            this.dgvPel.RowHeadersVisible = false;
            this.dgvPel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPel.Size = new System.Drawing.Size(881, 399);
            this.dgvPel.TabIndex = 80;
            this.dgvPel.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPel_CellContentDoubleClick);
            // 
            // ID_PELICULA
            // 
            this.ID_PELICULA.HeaderText = "Nro Pelicula";
            this.ID_PELICULA.Name = "ID_PELICULA";
            this.ID_PELICULA.ReadOnly = true;
            this.ID_PELICULA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_PELICULA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID_PELICULA.Width = 120;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Titulo";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.Duracion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Duracion.Width = 140;
            // 
            // Produccion
            // 
            this.Produccion.HeaderText = "Produccion";
            this.Produccion.Name = "Produccion";
            this.Produccion.ReadOnly = true;
            this.Produccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Produccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Produccion.Width = 220;
            // 
            // Restriccion
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Restriccion.DefaultCellStyle = dataGridViewCellStyle3;
            this.Restriccion.HeaderText = "Restriccion";
            this.Restriccion.Name = "Restriccion";
            this.Restriccion.ReadOnly = true;
            this.Restriccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Restriccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Restriccion.Width = 170;
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.pnltop.Controls.Add(this.panel1);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(895, 67);
            this.pnltop.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbCrud);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 59);
            this.panel1.TabIndex = 3;
            // 
            // lbCrud
            // 
            this.lbCrud.AutoSize = true;
            this.lbCrud.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrud.ForeColor = System.Drawing.SystemColors.Control;
            this.lbCrud.Location = new System.Drawing.Point(75, 9);
            this.lbCrud.Name = "lbCrud";
            this.lbCrud.Size = new System.Drawing.Size(234, 38);
            this.lbCrud.TabIndex = 0;
            this.lbCrud.Text = "CRUD Pelicula";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.BtnGuardar.Location = new System.Drawing.Point(644, 480);
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
            this.btnBorrar.Location = new System.Drawing.Point(499, 480);
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
            this.btnMod.Location = new System.Drawing.Point(339, 480);
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
            this.btnNuevo.Location = new System.Drawing.Point(180, 480);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(129, 36);
            this.btnNuevo.TabIndex = 76;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // picImage
            // 
            this.picImage.Image = global::CineHoytsFront.Properties.Resources.carrete_de_pelicula;
            this.picImage.Location = new System.Drawing.Point(570, 126);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(167, 175);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 78;
            this.picImage.TabStop = false;
            this.picImage.Tag = "NO";
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
            this.picLimpiar.Location = new System.Drawing.Point(817, 332);
            this.picLimpiar.Name = "picLimpiar";
            this.picLimpiar.Size = new System.Drawing.Size(45, 50);
            this.picLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLimpiar.TabIndex = 56;
            this.picLimpiar.TabStop = false;
            this.picLimpiar.Click += new System.EventHandler(this.picLimpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CineHoytsFront.Properties.Resources.claqueta1;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CrudPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 664);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrudPelicula";
            this.Text = "CrudPelicula";
            this.Load += new System.EventHandler(this.CrudPelicula_Load);
            this.pnlControl.ResumeLayout(false);
            this.pnlCrud.ResumeLayout(false);
            this.pnlCrud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPel)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
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
        private System.Windows.Forms.ComboBox cboprod;
        private System.Windows.Forms.ComboBox cborestrc;
        private System.Windows.Forms.PictureBox picdesplegar;
        private System.Windows.Forms.PictureBox picLimpiar;
        private System.Windows.Forms.Label lbFechaNac;
        private System.Windows.Forms.Label lbProvincia;
        private System.Windows.Forms.Label lbLocalidad;
        private System.Windows.Forms.Label lbBarrio;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbCrud;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnSubirImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numDuracion;
        private System.Windows.Forms.DataGridView dgvPel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PELICULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Restriccion;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}