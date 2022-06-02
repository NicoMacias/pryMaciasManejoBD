namespace pryMaciasManejoBD
{
    partial class frmConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultas));
            this.cboTablas = new System.Windows.Forms.ComboBox();
            this.dgvTablas = new System.Windows.Forms.DataGridView();
            this.btnMostrarDGV = new System.Windows.Forms.Button();
            this.lblSeleccione = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.stsFecha = new System.Windows.Forms.StatusStrip();
            this.tslFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrFecha = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).BeginInit();
            this.stsFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboTablas
            // 
            this.cboTablas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTablas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTablas.FormattingEnabled = true;
            this.cboTablas.Items.AddRange(new object[] {
            "Categorías",
            "Clientes",
            "Detalles de pedidos",
            "Empleados",
            "Pedidos",
            "Productos",
            "Proveedores"});
            this.cboTablas.Location = new System.Drawing.Point(244, 45);
            this.cboTablas.Name = "cboTablas";
            this.cboTablas.Size = new System.Drawing.Size(158, 28);
            this.cboTablas.TabIndex = 5;
            // 
            // dgvTablas
            // 
            this.dgvTablas.BackgroundColor = System.Drawing.Color.White;
            this.dgvTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablas.Location = new System.Drawing.Point(12, 88);
            this.dgvTablas.Name = "dgvTablas";
            this.dgvTablas.Size = new System.Drawing.Size(776, 350);
            this.dgvTablas.TabIndex = 6;
            // 
            // btnMostrarDGV
            // 
            this.btnMostrarDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarDGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarDGV.Location = new System.Drawing.Point(418, 45);
            this.btnMostrarDGV.Name = "btnMostrarDGV";
            this.btnMostrarDGV.Size = new System.Drawing.Size(188, 28);
            this.btnMostrarDGV.TabIndex = 7;
            this.btnMostrarDGV.Text = "Mostrar Base de Datos";
            this.btnMostrarDGV.UseVisualStyleBackColor = true;
            this.btnMostrarDGV.Click += new System.EventHandler(this.btnMostrarDGV_Click);
            // 
            // lblSeleccione
            // 
            this.lblSeleccione.AutoSize = true;
            this.lblSeleccione.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccione.Location = new System.Drawing.Point(156, 9);
            this.lblSeleccione.Name = "lblSeleccione";
            this.lblSeleccione.Size = new System.Drawing.Size(508, 24);
            this.lblSeleccione.TabIndex = 8;
            this.lblSeleccione.Text = "Por favor seleccione la Base de Datos que desee consultar.";
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(713, 444);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 27);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // stsFecha
            // 
            this.stsFecha.BackColor = System.Drawing.Color.White;
            this.stsFecha.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslFecha});
            this.stsFecha.Location = new System.Drawing.Point(0, 457);
            this.stsFecha.Name = "stsFecha";
            this.stsFecha.Size = new System.Drawing.Size(800, 22);
            this.stsFecha.TabIndex = 10;
            this.stsFecha.Text = "statusStrip1";
            // 
            // tslFecha
            // 
            this.tslFecha.Name = "tslFecha";
            this.tslFecha.Size = new System.Drawing.Size(12, 17);
            this.tslFecha.Text = "-";
            // 
            // tmrFecha
            // 
            this.tmrFecha.Tick += new System.EventHandler(this.tmrFecha_Tick);
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.stsFecha);
            this.Controls.Add(this.lblSeleccione);
            this.Controls.Add(this.btnMostrarDGV);
            this.Controls.Add(this.dgvTablas);
            this.Controls.Add(this.cboTablas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas de Base de Datos";
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).EndInit();
            this.stsFecha.ResumeLayout(false);
            this.stsFecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTablas;
        private System.Windows.Forms.DataGridView dgvTablas;
        private System.Windows.Forms.Button btnMostrarDGV;
        private System.Windows.Forms.Label lblSeleccione;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.StatusStrip stsFecha;
        private System.Windows.Forms.ToolStripStatusLabel tslFecha;
        private System.Windows.Forms.Timer tmrFecha;
    }
}