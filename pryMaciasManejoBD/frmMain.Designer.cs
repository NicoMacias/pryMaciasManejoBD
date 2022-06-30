
namespace pryMaciasManejoBD
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mstMenu = new System.Windows.Forms.MenuStrip();
            this.tsmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBasesDeDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.sstFecha = new System.Windows.Forms.StatusStrip();
            this.tslFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrFecha = new System.Windows.Forms.Timer(this.components);
            this.rbtNormal = new System.Windows.Forms.RadioButton();
            this.rbtBoca = new System.Windows.Forms.RadioButton();
            this.rbtRiver = new System.Windows.Forms.RadioButton();
            this.rbtTalleres = new System.Windows.Forms.RadioButton();
            this.gpbInterfaz = new System.Windows.Forms.GroupBox();
            this.mstMenu.SuspendLayout();
            this.sstFecha.SuspendLayout();
            this.gpbInterfaz.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstMenu
            // 
            this.mstMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mstMenu.Font = new System.Drawing.Font("Arial", 12F);
            this.mstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenu,
            this.tsmConsultas,
            this.tsmSalir});
            this.mstMenu.Location = new System.Drawing.Point(0, 0);
            this.mstMenu.Name = "mstMenu";
            this.mstMenu.Size = new System.Drawing.Size(746, 30);
            this.mstMenu.TabIndex = 3;
            this.mstMenu.Text = "menuStrip1";
            // 
            // tsmMenu
            // 
            this.tsmMenu.BackColor = System.Drawing.Color.Transparent;
            this.tsmMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRegistrar});
            this.tsmMenu.Font = new System.Drawing.Font("Arial", 14F);
            this.tsmMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(136, 26);
            this.tsmMenu.Text = "REGISTRAR";
            // 
            // tsmRegistrar
            // 
            this.tsmRegistrar.Name = "tsmRegistrar";
            this.tsmRegistrar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsmRegistrar.Size = new System.Drawing.Size(323, 26);
            this.tsmRegistrar.Text = "Registrar Empleados";
            this.tsmRegistrar.Click += new System.EventHandler(this.registrarEmpleadoToolStripMenuItem_Click);
            // 
            // tsmConsultas
            // 
            this.tsmConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBasesDeDatos,
            this.tsmPedidos});
            this.tsmConsultas.Font = new System.Drawing.Font("Arial", 14F);
            this.tsmConsultas.Name = "tsmConsultas";
            this.tsmConsultas.Size = new System.Drawing.Size(137, 26);
            this.tsmConsultas.Text = "CONSULTAS";
            // 
            // tsmBasesDeDatos
            // 
            this.tsmBasesDeDatos.Name = "tsmBasesDeDatos";
            this.tsmBasesDeDatos.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmBasesDeDatos.Size = new System.Drawing.Size(368, 26);
            this.tsmBasesDeDatos.Text = "Consultar Bases De Datos";
            this.tsmBasesDeDatos.Click += new System.EventHandler(this.cONSULTARBASESDEDATOSToolStripMenuItem_Click);
            // 
            // tsmPedidos
            // 
            this.tsmPedidos.Name = "tsmPedidos";
            this.tsmPedidos.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsmPedidos.Size = new System.Drawing.Size(368, 26);
            this.tsmPedidos.Text = "Consultar Pedidos";
            this.tsmPedidos.Click += new System.EventHandler(this.tsmPedidos_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Font = new System.Drawing.Font("Arial", 14F);
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmSalir.Size = new System.Drawing.Size(79, 26);
            this.tsmSalir.Text = "SALIR";
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // sstFecha
            // 
            this.sstFecha.BackColor = System.Drawing.Color.White;
            this.sstFecha.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslFecha});
            this.sstFecha.Location = new System.Drawing.Point(0, 376);
            this.sstFecha.Name = "sstFecha";
            this.sstFecha.Size = new System.Drawing.Size(746, 22);
            this.sstFecha.TabIndex = 4;
            this.sstFecha.Text = "statusStrip1";
            // 
            // tslFecha
            // 
            this.tslFecha.Name = "tslFecha";
            this.tslFecha.Size = new System.Drawing.Size(0, 17);
            // 
            // tmrFecha
            // 
            this.tmrFecha.Tick += new System.EventHandler(this.tmrFecha_Tick);
            // 
            // rbtNormal
            // 
            this.rbtNormal.AutoSize = true;
            this.rbtNormal.Location = new System.Drawing.Point(14, 22);
            this.rbtNormal.Name = "rbtNormal";
            this.rbtNormal.Size = new System.Drawing.Size(58, 17);
            this.rbtNormal.TabIndex = 8;
            this.rbtNormal.TabStop = true;
            this.rbtNormal.Text = "Normal";
            this.rbtNormal.UseVisualStyleBackColor = true;
            this.rbtNormal.CheckedChanged += new System.EventHandler(this.rbtNormal_CheckedChanged);
            // 
            // rbtBoca
            // 
            this.rbtBoca.AutoSize = true;
            this.rbtBoca.Location = new System.Drawing.Point(14, 68);
            this.rbtBoca.Name = "rbtBoca";
            this.rbtBoca.Size = new System.Drawing.Size(80, 17);
            this.rbtBoca.TabIndex = 10;
            this.rbtBoca.TabStop = true;
            this.rbtBoca.Text = "Modo Boca";
            this.rbtBoca.UseVisualStyleBackColor = true;
            this.rbtBoca.CheckedChanged += new System.EventHandler(this.rbtBoca_CheckedChanged);
            // 
            // rbtRiver
            // 
            this.rbtRiver.AutoSize = true;
            this.rbtRiver.Location = new System.Drawing.Point(14, 91);
            this.rbtRiver.Name = "rbtRiver";
            this.rbtRiver.Size = new System.Drawing.Size(80, 17);
            this.rbtRiver.TabIndex = 12;
            this.rbtRiver.TabStop = true;
            this.rbtRiver.Text = "Modo River";
            this.rbtRiver.UseVisualStyleBackColor = true;
            this.rbtRiver.CheckedChanged += new System.EventHandler(this.rbtRiver_CheckedChanged);
            // 
            // rbtTalleres
            // 
            this.rbtTalleres.AutoSize = true;
            this.rbtTalleres.Location = new System.Drawing.Point(14, 45);
            this.rbtTalleres.Name = "rbtTalleres";
            this.rbtTalleres.Size = new System.Drawing.Size(92, 17);
            this.rbtTalleres.TabIndex = 13;
            this.rbtTalleres.TabStop = true;
            this.rbtTalleres.Text = "Modo Talleres";
            this.rbtTalleres.UseVisualStyleBackColor = true;
            this.rbtTalleres.CheckedChanged += new System.EventHandler(this.rbtTalleres_CheckedChanged);
            // 
            // gpbInterfaz
            // 
            this.gpbInterfaz.BackColor = System.Drawing.Color.Transparent;
            this.gpbInterfaz.Controls.Add(this.rbtTalleres);
            this.gpbInterfaz.Controls.Add(this.rbtRiver);
            this.gpbInterfaz.Controls.Add(this.rbtBoca);
            this.gpbInterfaz.Controls.Add(this.rbtNormal);
            this.gpbInterfaz.ForeColor = System.Drawing.Color.White;
            this.gpbInterfaz.Location = new System.Drawing.Point(617, 42);
            this.gpbInterfaz.Name = "gpbInterfaz";
            this.gpbInterfaz.Size = new System.Drawing.Size(117, 121);
            this.gpbInterfaz.TabIndex = 14;
            this.gpbInterfaz.TabStop = false;
            this.gpbInterfaz.Text = "Interfaz";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(746, 398);
            this.Controls.Add(this.gpbInterfaz);
            this.Controls.Add(this.sstFecha);
            this.Controls.Add(this.mstMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mstMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de Base de Datos";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mstMenu.ResumeLayout(false);
            this.mstMenu.PerformLayout();
            this.sstFecha.ResumeLayout(false);
            this.sstFecha.PerformLayout();
            this.gpbInterfaz.ResumeLayout(false);
            this.gpbInterfaz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mstMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmRegistrar;
        private System.Windows.Forms.StatusStrip sstFecha;
        private System.Windows.Forms.ToolStripStatusLabel tslFecha;
        private System.Windows.Forms.Timer tmrFecha;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultas;
        private System.Windows.Forms.ToolStripMenuItem tsmBasesDeDatos;
        private System.Windows.Forms.ToolStripMenuItem tsmPedidos;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.RadioButton rbtNormal;
        private System.Windows.Forms.RadioButton rbtBoca;
        private System.Windows.Forms.RadioButton rbtRiver;
        private System.Windows.Forms.RadioButton rbtTalleres;
        private System.Windows.Forms.GroupBox gpbInterfaz;
    }
}

