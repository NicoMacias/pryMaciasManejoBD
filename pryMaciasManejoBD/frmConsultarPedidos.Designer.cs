namespace pryMaciasManejoBD
{
    partial class frmConsultarPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarPedidos));
            this.btnVolver = new System.Windows.Forms.Button();
            this.stsFecha = new System.Windows.Forms.StatusStrip();
            this.tslFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dgvTablas = new System.Windows.Forms.DataGridView();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.tmrFecha = new System.Windows.Forms.Timer(this.components);
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.cboCodPostal = new System.Windows.Forms.ComboBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.nudMinimo = new System.Windows.Forms.NumericUpDown();
            this.nudMaximo = new System.Windows.Forms.NumericUpDown();
            this.stsFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(1092, 588);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 29);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // stsFecha
            // 
            this.stsFecha.BackColor = System.Drawing.Color.White;
            this.stsFecha.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslFecha});
            this.stsFecha.Location = new System.Drawing.Point(0, 602);
            this.stsFecha.Name = "stsFecha";
            this.stsFecha.Size = new System.Drawing.Size(1179, 22);
            this.stsFecha.TabIndex = 16;
            this.stsFecha.Text = "statusStrip1";
            // 
            // tslFecha
            // 
            this.tslFecha.Name = "tslFecha";
            this.tslFecha.Size = new System.Drawing.Size(12, 17);
            this.tslFecha.Text = "-";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(32, 32);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(154, 21);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Filtrar por fecha";
            // 
            // dgvTablas
            // 
            this.dgvTablas.BackgroundColor = System.Drawing.Color.White;
            this.dgvTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablas.Location = new System.Drawing.Point(287, 12);
            this.dgvTablas.Name = "dgvTablas";
            this.dgvTablas.ReadOnly = true;
            this.dgvTablas.Size = new System.Drawing.Size(880, 570);
            this.dgvTablas.TabIndex = 12;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(110, 60);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(140, 26);
            this.dtpDesde.TabIndex = 17;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(110, 93);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(140, 26);
            this.dtpHasta.TabIndex = 18;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(35, 65);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(56, 20);
            this.lblDesde.TabIndex = 19;
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(35, 98);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(52, 20);
            this.lblHasta.TabIndex = 20;
            this.lblHasta.Text = "Hasta";
            // 
            // tmrFecha
            // 
            this.tmrFecha.Tick += new System.EventHandler(this.tmrFecha_Tick);
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(35, 164);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(215, 26);
            this.cboCliente.TabIndex = 22;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(32, 131);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(164, 21);
            this.lblCliente.TabIndex = 23;
            this.lblCliente.Text = "Filtrar por cliente";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(32, 203);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(164, 21);
            this.lblCiudad.TabIndex = 25;
            this.lblCiudad.Text = "Filtrar por ciudad";
            // 
            // cboCiudad
            // 
            this.cboCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCiudad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.Location = new System.Drawing.Point(35, 236);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(215, 26);
            this.cboCiudad.TabIndex = 24;
            this.cboCiudad.SelectedIndexChanged += new System.EventHandler(this.cboCiudad_SelectedIndexChanged);
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPostal.Location = new System.Drawing.Point(32, 347);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(223, 21);
            this.lblCodPostal.TabIndex = 29;
            this.lblCodPostal.Text = "Filtrar por codigo postal";
            // 
            // cboCodPostal
            // 
            this.cboCodPostal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodPostal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCodPostal.FormattingEnabled = true;
            this.cboCodPostal.Location = new System.Drawing.Point(35, 380);
            this.cboCodPostal.Name = "cboCodPostal";
            this.cboCodPostal.Size = new System.Drawing.Size(215, 26);
            this.cboCodPostal.TabIndex = 28;
            this.cboCodPostal.SelectedIndexChanged += new System.EventHandler(this.cboCodPostal_SelectedIndexChanged);
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegion.Location = new System.Drawing.Point(32, 275);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(161, 21);
            this.lblRegion.TabIndex = 27;
            this.lblRegion.Text = "Filtrar por region";
            // 
            // cboRegion
            // 
            this.cboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRegion.FormattingEnabled = true;
            this.cboRegion.Location = new System.Drawing.Point(35, 308);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(215, 26);
            this.cboRegion.TabIndex = 26;
            this.cboRegion.SelectedIndexChanged += new System.EventHandler(this.cboRegion_SelectedIndexChanged);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(32, 419);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(141, 21);
            this.lblPais.TabIndex = 31;
            this.lblPais.Text = "Filtrar por pais";
            // 
            // cboPais
            // 
            this.cboPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPais.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(35, 452);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(215, 26);
            this.cboPais.TabIndex = 30;
            this.cboPais.SelectedIndexChanged += new System.EventHandler(this.cboPais_SelectedIndexChanged);
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximo.Location = new System.Drawing.Point(35, 557);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(63, 20);
            this.lblMaximo.TabIndex = 36;
            this.lblMaximo.Text = "Maximo";
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimo.Location = new System.Drawing.Point(35, 524);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(59, 20);
            this.lblMinimo.TabIndex = 35;
            this.lblMinimo.Text = "Minimo";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(32, 491);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(156, 21);
            this.lblCargo.TabIndex = 32;
            this.lblCargo.Text = "Filtrar por cargo";
            // 
            // nudMinimo
            // 
            this.nudMinimo.DecimalPlaces = 2;
            this.nudMinimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinimo.Location = new System.Drawing.Point(110, 523);
            this.nudMinimo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMinimo.Name = "nudMinimo";
            this.nudMinimo.Size = new System.Drawing.Size(140, 26);
            this.nudMinimo.TabIndex = 37;
            this.nudMinimo.ValueChanged += new System.EventHandler(this.nudMinimo_ValueChanged);
            // 
            // nudMaximo
            // 
            this.nudMaximo.DecimalPlaces = 2;
            this.nudMaximo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaximo.Location = new System.Drawing.Point(110, 556);
            this.nudMaximo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMaximo.Name = "nudMaximo";
            this.nudMaximo.Size = new System.Drawing.Size(140, 26);
            this.nudMaximo.TabIndex = 38;
            this.nudMaximo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaximo.ValueChanged += new System.EventHandler(this.nudMinimo_ValueChanged);
            // 
            // frmConsultarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1179, 624);
            this.Controls.Add(this.nudMaximo);
            this.Controls.Add(this.nudMinimo);
            this.Controls.Add(this.lblMaximo);
            this.Controls.Add(this.lblMinimo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.cboPais);
            this.Controls.Add(this.lblCodPostal);
            this.Controls.Add(this.cboCodPostal);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.cboRegion);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.cboCiudad);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.stsFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dgvTablas);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConsultarPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Pedidos";
            this.Load += new System.EventHandler(this.frmConsultarPedidos_Load);
            this.stsFecha.ResumeLayout(false);
            this.stsFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.StatusStrip stsFecha;
        private System.Windows.Forms.ToolStripStatusLabel tslFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView dgvTablas;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Timer tmrFecha;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.ComboBox cboCiudad;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.ComboBox cboCodPostal;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.NumericUpDown nudMinimo;
        private System.Windows.Forms.NumericUpDown nudMaximo;
    }
}