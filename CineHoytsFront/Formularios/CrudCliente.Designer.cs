namespace Cine_Hoyts.Formularios
{
    partial class CrudCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnlCrud = new System.Windows.Forms.Panel();
            this.CboBarrio = new System.Windows.Forms.ComboBox();
            this.CboLocalidad = new System.Windows.Forms.ComboBox();
            this.cboProv = new System.Windows.Forms.ComboBox();
            this.lbid_cliente = new System.Windows.Forms.Label();
            this.txbNro_cliente = new System.Windows.Forms.TextBox();
            this.picdesplegar = new System.Windows.Forms.PictureBox();
            this.picLimpiar = new System.Windows.Forms.PictureBox();
            this.lbFechaNac = new System.Windows.Forms.Label();
            this.RbSexo = new System.Windows.Forms.Label();
            this.lbTipDoc = new System.Windows.Forms.Label();
            this.lbDoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numDireccion = new System.Windows.Forms.NumericUpDown();
            this.lbProvincia = new System.Windows.Forms.Label();
            this.lbLocalidad = new System.Windows.Forms.Label();
            this.lbBarrio = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.txbDocumento = new System.Windows.Forms.TextBox();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.TxbApellido = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnltop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCrud = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlControl.SuspendLayout();
            this.pnlCrud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picdesplegar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.pnltop.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pnlControl.Controls.Add(this.dgvCliente);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(0, 67);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(895, 597);
            this.pnlControl.TabIndex = 11;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardar.Image = global::CineHoytsFront.Properties.Resources.guardar_el_archivo;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(641, 506);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(119, 36);
            this.BtnGuardar.TabIndex = 79;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click_1);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBorrar.Image = global::CineHoytsFront.Properties.Resources.remover_archivo__1_;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(496, 506);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(119, 36);
            this.btnBorrar.TabIndex = 78;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click_1);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMod.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMod.Image = global::CineHoytsFront.Properties.Resources.actualizar;
            this.btnMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMod.Location = new System.Drawing.Point(336, 506);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(128, 36);
            this.btnMod.TabIndex = 77;
            this.btnMod.Text = "Modificar";
            this.btnMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click_1);
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
            this.btnNuevo.Location = new System.Drawing.Point(177, 506);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(129, 36);
            this.btnNuevo.TabIndex = 76;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // pnlCrud
            // 
            this.pnlCrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(84)))), ((int)(((byte)(102)))));
            this.pnlCrud.Controls.Add(this.CboBarrio);
            this.pnlCrud.Controls.Add(this.CboLocalidad);
            this.pnlCrud.Controls.Add(this.cboProv);
            this.pnlCrud.Controls.Add(this.lbid_cliente);
            this.pnlCrud.Controls.Add(this.txbNro_cliente);
            this.pnlCrud.Controls.Add(this.picdesplegar);
            this.pnlCrud.Controls.Add(this.picLimpiar);
            this.pnlCrud.Controls.Add(this.lbFechaNac);
            this.pnlCrud.Controls.Add(this.RbSexo);
            this.pnlCrud.Controls.Add(this.lbTipDoc);
            this.pnlCrud.Controls.Add(this.lbDoc);
            this.pnlCrud.Controls.Add(this.label1);
            this.pnlCrud.Controls.Add(this.numDireccion);
            this.pnlCrud.Controls.Add(this.lbProvincia);
            this.pnlCrud.Controls.Add(this.lbLocalidad);
            this.pnlCrud.Controls.Add(this.lbBarrio);
            this.pnlCrud.Controls.Add(this.lbDireccion);
            this.pnlCrud.Controls.Add(this.lbApellido);
            this.pnlCrud.Controls.Add(this.lbNombre);
            this.pnlCrud.Controls.Add(this.dtpFechaNac);
            this.pnlCrud.Controls.Add(this.rbtMasculino);
            this.pnlCrud.Controls.Add(this.rbtFemenino);
            this.pnlCrud.Controls.Add(this.txbDocumento);
            this.pnlCrud.Controls.Add(this.cboTipoDoc);
            this.pnlCrud.Controls.Add(this.txbDireccion);
            this.pnlCrud.Controls.Add(this.TxbApellido);
            this.pnlCrud.Controls.Add(this.txbNombre);
            this.pnlCrud.Location = new System.Drawing.Point(32, 71);
            this.pnlCrud.Name = "pnlCrud";
            this.pnlCrud.Size = new System.Drawing.Size(881, 402);
            this.pnlCrud.TabIndex = 7;
            // 
            // CboBarrio
            // 
            this.CboBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBarrio.FormattingEnabled = true;
            this.CboBarrio.Location = new System.Drawing.Point(543, 212);
            this.CboBarrio.Name = "CboBarrio";
            this.CboBarrio.Size = new System.Drawing.Size(189, 21);
            this.CboBarrio.TabIndex = 62;
            // 
            // CboLocalidad
            // 
            this.CboLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboLocalidad.FormattingEnabled = true;
            this.CboLocalidad.Location = new System.Drawing.Point(304, 212);
            this.CboLocalidad.Name = "CboLocalidad";
            this.CboLocalidad.Size = new System.Drawing.Size(189, 21);
            this.CboLocalidad.TabIndex = 61;
            this.CboLocalidad.SelectionChangeCommitted += new System.EventHandler(this.CboLocalidad_SelectionChangeCommitted);
            // 
            // cboProv
            // 
            this.cboProv.FormattingEnabled = true;
            this.cboProv.Location = new System.Drawing.Point(52, 212);
            this.cboProv.Name = "cboProv";
            this.cboProv.Size = new System.Drawing.Size(196, 21);
            this.cboProv.TabIndex = 60;
            this.cboProv.SelectionChangeCommitted += new System.EventHandler(this.cboProv_SelectionChangeCommitted);
            // 
            // lbid_cliente
            // 
            this.lbid_cliente.AutoSize = true;
            this.lbid_cliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid_cliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbid_cliente.Location = new System.Drawing.Point(539, 29);
            this.lbid_cliente.Name = "lbid_cliente";
            this.lbid_cliente.Size = new System.Drawing.Size(113, 23);
            this.lbid_cliente.TabIndex = 59;
            this.lbid_cliente.Text = "Nro Cliente";
            // 
            // txbNro_cliente
            // 
            this.txbNro_cliente.Enabled = false;
            this.txbNro_cliente.Location = new System.Drawing.Point(543, 55);
            this.txbNro_cliente.Name = "txbNro_cliente";
            this.txbNro_cliente.Size = new System.Drawing.Size(189, 20);
            this.txbNro_cliente.TabIndex = 58;
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
            // lbFechaNac
            // 
            this.lbFechaNac.AutoSize = true;
            this.lbFechaNac.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaNac.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFechaNac.Location = new System.Drawing.Point(48, 99);
            this.lbFechaNac.Name = "lbFechaNac";
            this.lbFechaNac.Size = new System.Drawing.Size(180, 23);
            this.lbFechaNac.TabIndex = 55;
            this.lbFechaNac.Text = "Fecha Nacimiento";
            // 
            // RbSexo
            // 
            this.RbSexo.AutoSize = true;
            this.RbSexo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbSexo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RbSexo.Location = new System.Drawing.Point(294, 99);
            this.RbSexo.Name = "RbSexo";
            this.RbSexo.Size = new System.Drawing.Size(55, 23);
            this.RbSexo.TabIndex = 54;
            this.RbSexo.Text = "Sexo";
            // 
            // lbTipDoc
            // 
            this.lbTipDoc.AutoSize = true;
            this.lbTipDoc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipDoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTipDoc.Location = new System.Drawing.Point(300, 324);
            this.lbTipDoc.Name = "lbTipDoc";
            this.lbTipDoc.Size = new System.Drawing.Size(160, 23);
            this.lbTipDoc.TabIndex = 53;
            this.lbTipDoc.Text = "Tipo Documento";
            // 
            // lbDoc
            // 
            this.lbDoc.AutoSize = true;
            this.lbDoc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDoc.Location = new System.Drawing.Point(46, 324);
            this.lbDoc.Name = "lbDoc";
            this.lbDoc.Size = new System.Drawing.Size(117, 23);
            this.lbDoc.TabIndex = 52;
            this.lbDoc.Text = "Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(300, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 51;
            this.label1.Text = "Num";
            // 
            // numDireccion
            // 
            this.numDireccion.Location = new System.Drawing.Point(304, 280);
            this.numDireccion.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDireccion.Name = "numDireccion";
            this.numDireccion.Size = new System.Drawing.Size(63, 20);
            this.numDireccion.TabIndex = 50;
            // 
            // lbProvincia
            // 
            this.lbProvincia.AutoSize = true;
            this.lbProvincia.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProvincia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbProvincia.Location = new System.Drawing.Point(48, 172);
            this.lbProvincia.Name = "lbProvincia";
            this.lbProvincia.Size = new System.Drawing.Size(96, 23);
            this.lbProvincia.TabIndex = 49;
            this.lbProvincia.Text = "Provincia";
            // 
            // lbLocalidad
            // 
            this.lbLocalidad.AutoSize = true;
            this.lbLocalidad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbLocalidad.Location = new System.Drawing.Point(302, 173);
            this.lbLocalidad.Name = "lbLocalidad";
            this.lbLocalidad.Size = new System.Drawing.Size(104, 23);
            this.lbLocalidad.TabIndex = 48;
            this.lbLocalidad.Text = "Localidad";
            // 
            // lbBarrio
            // 
            this.lbBarrio.AutoSize = true;
            this.lbBarrio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBarrio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbBarrio.Location = new System.Drawing.Point(550, 173);
            this.lbBarrio.Name = "lbBarrio";
            this.lbBarrio.Size = new System.Drawing.Size(63, 23);
            this.lbBarrio.TabIndex = 46;
            this.lbBarrio.Text = "Barrio";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDireccion.Location = new System.Drawing.Point(46, 253);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(98, 23);
            this.lbDireccion.TabIndex = 45;
            this.lbDireccion.Text = "Direccion";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbApellido.Location = new System.Drawing.Point(300, 29);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(89, 23);
            this.lbApellido.TabIndex = 44;
            this.lbApellido.Text = "Apellido";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNombre.Location = new System.Drawing.Point(46, 29);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(85, 23);
            this.lbNombre.TabIndex = 43;
            this.lbNombre.Text = "Nombre";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(52, 125);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(196, 20);
            this.dtpFechaNac.TabIndex = 11;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMasculino.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtMasculino.Location = new System.Drawing.Point(298, 125);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(95, 20);
            this.rbtMasculino.TabIndex = 10;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFemenino.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtFemenino.Location = new System.Drawing.Point(418, 124);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(93, 20);
            this.rbtFemenino.TabIndex = 9;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // txbDocumento
            // 
            this.txbDocumento.Location = new System.Drawing.Point(50, 350);
            this.txbDocumento.Name = "txbDocumento";
            this.txbDocumento.Size = new System.Drawing.Size(198, 20);
            this.txbDocumento.TabIndex = 8;
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(304, 350);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(189, 21);
            this.cboTipoDoc.TabIndex = 6;
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(50, 279);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(198, 20);
            this.txbDireccion.TabIndex = 3;
            // 
            // TxbApellido
            // 
            this.TxbApellido.Location = new System.Drawing.Point(304, 55);
            this.TxbApellido.Name = "TxbApellido";
            this.TxbApellido.Size = new System.Drawing.Size(189, 20);
            this.TxbApellido.TabIndex = 1;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(50, 55);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(198, 20);
            this.txbNombre.TabIndex = 0;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tipo_doc,
            this.Direccion,
            this.Fecha_nac,
            this.Sexo});
            this.dgvCliente.EnableHeadersVisualStyles = false;
            this.dgvCliente.Location = new System.Drawing.Point(32, 71);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.Size = new System.Drawing.Size(881, 402);
            this.dgvCliente.TabIndex = 1;
            this.dgvCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellDoubleClick);
            // 
            // idcliente
            // 
            this.idcliente.HeaderText = "Nro Cliente";
            this.idcliente.Name = "idcliente";
            this.idcliente.ReadOnly = true;
            this.idcliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idcliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Completo";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nombre.Width = 150;
            // 
            // nro_doc
            // 
            this.nro_doc.HeaderText = "Documento";
            this.nro_doc.Name = "nro_doc";
            this.nro_doc.ReadOnly = true;
            this.nro_doc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nro_doc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nro_doc.Width = 110;
            // 
            // tipo_doc
            // 
            this.tipo_doc.HeaderText = "Tipo Documento";
            this.tipo_doc.Name = "tipo_doc";
            this.tipo_doc.ReadOnly = true;
            this.tipo_doc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tipo_doc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tipo_doc.Width = 140;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Direccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Direccion.Width = 175;
            // 
            // Fecha_nac
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Fecha_nac.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fecha_nac.HeaderText = "Fecha Nacimiento";
            this.Fecha_nac.Name = "Fecha_nac";
            this.Fecha_nac.ReadOnly = true;
            this.Fecha_nac.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fecha_nac.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Fecha_nac.Width = 120;
            // 
            // Sexo
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Sexo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sexo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Sexo.Width = 80;
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.pnltop.Controls.Add(this.panel1);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(895, 67);
            this.pnltop.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbCrud);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 59);
            this.panel1.TabIndex = 3;
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
            // lbCrud
            // 
            this.lbCrud.AutoSize = true;
            this.lbCrud.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrud.ForeColor = System.Drawing.SystemColors.Control;
            this.lbCrud.Location = new System.Drawing.Point(75, 9);
            this.lbCrud.Name = "lbCrud";
            this.lbCrud.Size = new System.Drawing.Size(222, 38);
            this.lbCrud.TabIndex = 0;
            this.lbCrud.Text = "CRUD Cliente";
            // 
            // CrudCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 664);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrudCliente";
            this.Text = "CrudCliente";
            this.Load += new System.EventHandler(this.CrudCliente_Load);
            this.pnlControl.ResumeLayout(false);
            this.pnlCrud.ResumeLayout(false);
            this.pnlCrud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picdesplegar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbCrud;
        private System.Windows.Forms.Panel pnlCrud;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.TextBox txbDocumento;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.TextBox TxbApellido;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lbFechaNac;
        private System.Windows.Forms.Label RbSexo;
        private System.Windows.Forms.Label lbTipDoc;
        private System.Windows.Forms.Label lbDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDireccion;
        private System.Windows.Forms.Label lbProvincia;
        private System.Windows.Forms.Label lbLocalidad;
        private System.Windows.Forms.Label lbBarrio;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.PictureBox picdesplegar;
        private System.Windows.Forms.PictureBox picLimpiar;
        private System.Windows.Forms.Label lbid_cliente;
        private System.Windows.Forms.TextBox txbNro_cliente;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox CboLocalidad;
        private System.Windows.Forms.ComboBox cboProv;
        private System.Windows.Forms.ComboBox CboBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_nac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
    }
}