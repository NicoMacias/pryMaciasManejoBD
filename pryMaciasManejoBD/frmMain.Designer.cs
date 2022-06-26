
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
            this.chbMusica = new System.Windows.Forms.CheckBox();
            this.lblMusica = new System.Windows.Forms.Label();
            this.mstMenu.SuspendLayout();
            this.sstFecha.SuspendLayout();
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
            // chbMusica
            // 
            this.chbMusica.Cursor = System.Windows.Forms.Cursors.No;
            this.chbMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMusica.Location = new System.Drawing.Point(178, 193);
            this.chbMusica.Name = "chbMusica";
            this.chbMusica.Size = new System.Drawing.Size(13, 12);
            this.chbMusica.TabIndex = 6;
            this.chbMusica.UseVisualStyleBackColor = true;
            this.chbMusica.CheckedChanged += new System.EventHandler(this.chbMusica_CheckedChanged);
            // 
            // lblMusica
            // 
            this.lblMusica.BackColor = System.Drawing.Color.Transparent;
            this.lblMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusica.ForeColor = System.Drawing.Color.White;
            this.lblMusica.Location = new System.Drawing.Point(26, 162);
            this.lblMusica.Name = "lblMusica";
            this.lblMusica.Size = new System.Drawing.Size(177, 56);
            this.lblMusica.TabIndex = 7;
            this.lblMusica.Text = "Pibe aca activas el modo boca ----->";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(746, 398);
            this.Controls.Add(this.chbMusica);
            this.Controls.Add(this.lblMusica);
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
        private System.Windows.Forms.CheckBox chbMusica;
        private System.Windows.Forms.Label lblMusica;
    }
}

