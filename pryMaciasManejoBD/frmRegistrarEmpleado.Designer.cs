namespace pryMaciasManejoBD
{
    partial class frmRegistrarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarEmpleado));
            this.lblRegistro = new System.Windows.Forms.Label();
            this.tbcRegistro = new System.Windows.Forms.TabControl();
            this.tbcInformacion = new System.Windows.Forms.TabPage();
            this.cboJefe = new System.Windows.Forms.ComboBox();
            this.ptbFoto = new System.Windows.Forms.PictureBox();
            this.dtpContratacion = new System.Windows.Forms.DateTimePicker();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.lblNotas = new System.Windows.Forms.Label();
            this.lblFoto = new System.Windows.Forms.Label();
            this.lblJefe = new System.Windows.Forms.Label();
            this.lblContratacion = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbcDireccion = new System.Windows.Forms.TabPage();
            this.txtCodigoPostal = new System.Windows.Forms.MaskedTextBox();
            this.txtExtension = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblExtension = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.tmrFecha = new System.Windows.Forms.Timer(this.components);
            this.sstFecha = new System.Windows.Forms.StatusStrip();
            this.tslFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbcRegistro.SuspendLayout();
            this.tbcInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).BeginInit();
            this.tbcDireccion.SuspendLayout();
            this.sstFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(125, 15);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(466, 24);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Complete todos los campos para registrar al empleado";
            // 
            // tbcRegistro
            // 
            this.tbcRegistro.Controls.Add(this.tbcInformacion);
            this.tbcRegistro.Controls.Add(this.tbcDireccion);
            this.tbcRegistro.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbcRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcRegistro.Location = new System.Drawing.Point(12, 54);
            this.tbcRegistro.Name = "tbcRegistro";
            this.tbcRegistro.SelectedIndex = 0;
            this.tbcRegistro.Size = new System.Drawing.Size(761, 401);
            this.tbcRegistro.TabIndex = 12;
            // 
            // tbcInformacion
            // 
            this.tbcInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbcInformacion.Controls.Add(this.cboJefe);
            this.tbcInformacion.Controls.Add(this.ptbFoto);
            this.tbcInformacion.Controls.Add(this.dtpContratacion);
            this.tbcInformacion.Controls.Add(this.dtpNacimiento);
            this.tbcInformacion.Controls.Add(this.txtNotas);
            this.tbcInformacion.Controls.Add(this.lblNotas);
            this.tbcInformacion.Controls.Add(this.lblFoto);
            this.tbcInformacion.Controls.Add(this.lblJefe);
            this.tbcInformacion.Controls.Add(this.lblContratacion);
            this.tbcInformacion.Controls.Add(this.lblNacimiento);
            this.tbcInformacion.Controls.Add(this.txtTratamiento);
            this.tbcInformacion.Controls.Add(this.lblTratamiento);
            this.tbcInformacion.Controls.Add(this.txtCargo);
            this.tbcInformacion.Controls.Add(this.lblCargo);
            this.tbcInformacion.Controls.Add(this.txtNombre);
            this.tbcInformacion.Controls.Add(this.lblNombre);
            this.tbcInformacion.Controls.Add(this.txtApellido);
            this.tbcInformacion.Controls.Add(this.lblApellido);
            this.tbcInformacion.Location = new System.Drawing.Point(4, 29);
            this.tbcInformacion.Name = "tbcInformacion";
            this.tbcInformacion.Padding = new System.Windows.Forms.Padding(3);
            this.tbcInformacion.Size = new System.Drawing.Size(753, 368);
            this.tbcInformacion.TabIndex = 0;
            this.tbcInformacion.Text = "Informacion Personal";
            this.tbcInformacion.UseVisualStyleBackColor = true;
            this.tbcInformacion.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // cboJefe
            // 
            this.cboJefe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboJefe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJefe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboJefe.FormattingEnabled = true;
            this.cboJefe.Items.AddRange(new object[] {
            "Buchanan, Steven",
            "Callahan, Laura",
            "Davolio, Nancy",
            "Dodsworth, Anne",
            "Fuller, Andrew",
            "King, Robert",
            "Leverling, Janet",
            "Peacock, Margaret",
            "Suyama, Michael"});
            this.cboJefe.Location = new System.Drawing.Point(280, 224);
            this.cboJefe.Name = "cboJefe";
            this.cboJefe.Size = new System.Drawing.Size(200, 28);
            this.cboJefe.TabIndex = 7;
            this.cboJefe.SelectedIndexChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // ptbFoto
            // 
            this.ptbFoto.BackColor = System.Drawing.Color.Black;
            this.ptbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbFoto.Location = new System.Drawing.Point(518, 69);
            this.ptbFoto.Name = "ptbFoto";
            this.ptbFoto.Size = new System.Drawing.Size(200, 103);
            this.ptbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbFoto.TabIndex = 25;
            this.ptbFoto.TabStop = false;
            this.ptbFoto.Click += new System.EventHandler(this.ptbFoto_Click);
            // 
            // dtpContratacion
            // 
            this.dtpContratacion.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpContratacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpContratacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpContratacion.Location = new System.Drawing.Point(280, 146);
            this.dtpContratacion.Name = "dtpContratacion";
            this.dtpContratacion.Size = new System.Drawing.Size(200, 26);
            this.dtpContratacion.TabIndex = 6;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimiento.Location = new System.Drawing.Point(280, 69);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(200, 26);
            this.dtpNacimiento.TabIndex = 5;
            // 
            // txtNotas
            // 
            this.txtNotas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotas.Location = new System.Drawing.Point(518, 224);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(200, 103);
            this.txtNotas.TabIndex = 8;
            this.txtNotas.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotas.Location = new System.Drawing.Point(535, 197);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(51, 20);
            this.lblNotas.TabIndex = 21;
            this.lblNotas.Text = "Notas";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(538, 37);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(42, 20);
            this.lblFoto.TabIndex = 19;
            this.lblFoto.Text = "Foto";
            // 
            // lblJefe
            // 
            this.lblJefe.AutoSize = true;
            this.lblJefe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJefe.Location = new System.Drawing.Point(299, 197);
            this.lblJefe.Name = "lblJefe";
            this.lblJefe.Size = new System.Drawing.Size(40, 20);
            this.lblJefe.TabIndex = 17;
            this.lblJefe.Text = "Jefe";
            // 
            // lblContratacion
            // 
            this.lblContratacion.AutoSize = true;
            this.lblContratacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContratacion.Location = new System.Drawing.Point(299, 117);
            this.lblContratacion.Name = "lblContratacion";
            this.lblContratacion.Size = new System.Drawing.Size(171, 20);
            this.lblContratacion.TabIndex = 15;
            this.lblContratacion.Text = "Fecha de Contratacion";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.Location = new System.Drawing.Point(299, 37);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(159, 20);
            this.lblNacimiento.TabIndex = 13;
            this.lblNacimiento.Text = "Fecha de Nacimiento";
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTratamiento.Location = new System.Drawing.Point(42, 301);
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Size = new System.Drawing.Size(200, 26);
            this.txtTratamiento.TabIndex = 4;
            this.txtTratamiento.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratamiento.Location = new System.Drawing.Point(58, 274);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(94, 20);
            this.lblTratamiento.TabIndex = 11;
            this.lblTratamiento.Text = "Tratamiento";
            // 
            // txtCargo
            // 
            this.txtCargo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(42, 226);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(200, 26);
            this.txtCargo.TabIndex = 3;
            this.txtCargo.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(58, 199);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(52, 20);
            this.lblCargo.TabIndex = 9;
            this.lblCargo.Text = "Cargo";
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(42, 146);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 26);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(58, 119);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(42, 71);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 26);
            this.txtApellido.TabIndex = 0;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(58, 44);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 20);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido";
            // 
            // tbcDireccion
            // 
            this.tbcDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbcDireccion.Controls.Add(this.txtCodigoPostal);
            this.tbcDireccion.Controls.Add(this.txtExtension);
            this.tbcDireccion.Controls.Add(this.txtTelefono);
            this.tbcDireccion.Controls.Add(this.lblExtension);
            this.tbcDireccion.Controls.Add(this.lblTelefono);
            this.tbcDireccion.Controls.Add(this.txtPais);
            this.tbcDireccion.Controls.Add(this.lblPais);
            this.tbcDireccion.Controls.Add(this.lblCodigoPostal);
            this.tbcDireccion.Controls.Add(this.txtRegion);
            this.tbcDireccion.Controls.Add(this.lblRegion);
            this.tbcDireccion.Controls.Add(this.txtCiudad);
            this.tbcDireccion.Controls.Add(this.lblCiudad);
            this.tbcDireccion.Controls.Add(this.txtDireccion);
            this.tbcDireccion.Controls.Add(this.lblDireccion);
            this.tbcDireccion.Location = new System.Drawing.Point(4, 29);
            this.tbcDireccion.Name = "tbcDireccion";
            this.tbcDireccion.Padding = new System.Windows.Forms.Padding(3);
            this.tbcDireccion.Size = new System.Drawing.Size(753, 368);
            this.tbcDireccion.TabIndex = 1;
            this.tbcDireccion.Text = "Direccion";
            this.tbcDireccion.UseVisualStyleBackColor = true;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPostal.Location = new System.Drawing.Point(281, 105);
            this.txtCodigoPostal.Mask = "00000";
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(200, 26);
            this.txtCodigoPostal.TabIndex = 16;
            this.txtCodigoPostal.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtExtension
            // 
            this.txtExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtension.Location = new System.Drawing.Point(520, 179);
            this.txtExtension.Mask = "00000";
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(200, 26);
            this.txtExtension.TabIndex = 19;
            this.txtExtension.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(520, 107);
            this.txtTelefono.Mask = "(999)000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 26);
            this.txtTelefono.TabIndex = 18;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtension.Location = new System.Drawing.Point(536, 154);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(69, 17);
            this.lblExtension.TabIndex = 21;
            this.lblExtension.Text = "Extension";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(536, 78);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(71, 20);
            this.lblTelefono.TabIndex = 19;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtPais
            // 
            this.txtPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.Location = new System.Drawing.Point(281, 179);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(200, 26);
            this.txtPais.TabIndex = 17;
            this.txtPais.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(300, 152);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(39, 20);
            this.lblPais.TabIndex = 17;
            this.lblPais.Text = "Pais";
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPostal.Location = new System.Drawing.Point(300, 78);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(107, 20);
            this.lblCodigoPostal.TabIndex = 15;
            this.lblCodigoPostal.Text = "Codigo Postal";
            // 
            // txtRegion
            // 
            this.txtRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegion.Location = new System.Drawing.Point(42, 255);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(200, 26);
            this.txtRegion.TabIndex = 15;
            this.txtRegion.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegion.Location = new System.Drawing.Point(58, 228);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(60, 20);
            this.lblRegion.TabIndex = 13;
            this.lblRegion.Text = "Region";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.Location = new System.Drawing.Point(42, 179);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(200, 26);
            this.txtCiudad.TabIndex = 14;
            this.txtCiudad.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(58, 152);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(59, 20);
            this.lblCiudad.TabIndex = 11;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(42, 105);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(200, 26);
            this.txtDireccion.TabIndex = 13;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(58, 78);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 20);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Direccion";
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(562, 461);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(88, 29);
            this.btnVolver.TabIndex = 22;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(449, 461);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 29);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(672, 461);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(88, 29);
            this.btnRegistrar.TabIndex = 20;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // tmrFecha
            // 
            this.tmrFecha.Tick += new System.EventHandler(this.tmrFecha_Tick);
            // 
            // sstFecha
            // 
            this.sstFecha.BackColor = System.Drawing.Color.White;
            this.sstFecha.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslFecha});
            this.sstFecha.Location = new System.Drawing.Point(0, 476);
            this.sstFecha.Name = "sstFecha";
            this.sstFecha.Size = new System.Drawing.Size(783, 22);
            this.sstFecha.TabIndex = 23;
            this.sstFecha.Text = "statusStrip1";
            // 
            // tslFecha
            // 
            this.tslFecha.Name = "tslFecha";
            this.tslFecha.Size = new System.Drawing.Size(12, 17);
            this.tslFecha.Text = "-";
            // 
            // frmRegistrarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(783, 498);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.sstFecha);
            this.Controls.Add(this.tbcRegistro);
            this.Controls.Add(this.lblRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRegistrarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Empleado Nuevo";
            this.Load += new System.EventHandler(this.frmRegistrarEmpleado_Load);
            this.tbcRegistro.ResumeLayout(false);
            this.tbcInformacion.ResumeLayout(false);
            this.tbcInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).EndInit();
            this.tbcDireccion.ResumeLayout(false);
            this.tbcDireccion.PerformLayout();
            this.sstFecha.ResumeLayout(false);
            this.sstFecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.TabControl tbcRegistro;
        private System.Windows.Forms.TabPage tbcInformacion;
        private System.Windows.Forms.PictureBox ptbFoto;
        private System.Windows.Forms.DateTimePicker dtpContratacion;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Label lblJefe;
        private System.Windows.Forms.Label lblContratacion;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.TextBox txtTratamiento;
        private System.Windows.Forms.Label lblTratamiento;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TabPage tbcDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.MaskedTextBox txtCodigoPostal;
        private System.Windows.Forms.MaskedTextBox txtExtension;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.ComboBox cboJefe;
        private System.Windows.Forms.Timer tmrFecha;
        private System.Windows.Forms.StatusStrip sstFecha;
        private System.Windows.Forms.ToolStripStatusLabel tslFecha;
    }
}