using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace pryMaciasManejoBD
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tmrFecha_Tick(object sender, EventArgs e)
        {
            tslFecha.Text = DateTime.Now.ToString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tmrFecha.Enabled = true;
        }

        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarEmpleado registrar = new frmRegistrarEmpleado();
            registrar.ShowDialog();
        }

        private void cONSULTARBASESDEDATOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultas consultas = new frmConsultas();
            consultas.ShowDialog();
        }

        private void tsmPedidos_Click(object sender, EventArgs e)
        {
            frmConsultarPedidos pedidos= new frmConsultarPedidos();
            pedidos.ShowDialog();
        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("Seguro que quieres salir de la aplicacion?",
                "Salir",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (salir == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void chbMusica_CheckedChanged(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = Application.StartupPath + "\\Dale-bo.wav";

            Bitmap fondoBoca = new Bitmap(Application.StartupPath + "\\messi-bostero.jpeg");
            Icon iconoBoca = new Icon(Application.StartupPath + "\\escudo-boca.ico");

            Bitmap fondoMessi = new Bitmap(Application.StartupPath + "\\messi-logo.jpg");
            Icon iconoMessi = new Icon(Application.StartupPath + "\\messi-icono.ico");

            if (chbMusica.Checked)
            {   
                player.Play();

                this.BackgroundImage = fondoBoca;
                this.Icon = iconoBoca;

                tmrFecha.Enabled = false;
                tslFecha.Text = "09/12/2018 07:02:00 p. m.";

                sstFecha.BackColor = Color.Yellow;
                tslFecha.ForeColor = Color.Blue;

                mstMenu.BackColor = Color.Yellow;
                mstMenu.ForeColor = Color.Blue;

                tsmMenu.ForeColor = Color.Blue;
                tsmRegistrar.ForeColor = Color.Yellow;
                tsmRegistrar.BackColor = Color.Blue;
                tsmBasesDeDatos.ForeColor = Color.Yellow;
                tsmBasesDeDatos.BackColor = Color.Blue;
                tsmPedidos.ForeColor = Color.Yellow;
                tsmPedidos.BackColor = Color.Blue;

                lblMusica.ForeColor = Color.Yellow;
            }
            else
            {
                player.Stop();

                this.BackgroundImage = fondoMessi;
                this.Icon = iconoMessi;

                tmrFecha.Enabled = true;
                tslFecha.Text = DateTime.Now.ToString();

                sstFecha.BackColor = Color.White;
                tslFecha.ForeColor = Color.Black;
                mstMenu.BackColor = Color.White;
                mstMenu.ForeColor = Color.Black;

                tsmMenu.ForeColor = Color.Black;

                tsmRegistrar.ForeColor = Color.Black;
                tsmRegistrar.BackColor = Color.White;
                tsmBasesDeDatos.ForeColor = Color.Black;
                tsmBasesDeDatos.BackColor = Color.White;
                tsmPedidos.ForeColor = Color.Black;
                tsmPedidos.BackColor = Color.White;

                lblMusica.BackColor = Color.Transparent;
                lblMusica.ForeColor = Color.White;
            }
        }
    }
}
