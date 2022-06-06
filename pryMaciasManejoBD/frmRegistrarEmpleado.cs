using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Imaging;
using System.IO;

namespace pryMaciasManejoBD
{
    public partial class frmRegistrarEmpleado : Form
    {
        public frmRegistrarEmpleado()
        {
            InitializeComponent();
        }
        private void frmRegistrarEmpleado_Load(object sender, EventArgs e)
        {
            btnRegistrar.Enabled = false;
            tmrFecha.Enabled = true;
        }

        OleDbConnection objConexion;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            OleDbConnection objConexion = new OleDbConnection();

            //MemoryStream ms = new MemoryStream();
            //ptbFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //byte[] foto = ms.ToArray();

            DialogResult resultado = MessageBox.Show("Seguro que quiere registrar los siguientes datos?" + "\n" + "\n" +
                "- Apellido: " + txtApellido.Text + "\n" + "- Nombre: " + txtNombre.Text + "\n" + "- Cargo: " +
                txtCargo.Text + "\n" + "- Tratamiento: " + txtTratamiento.Text + "\n" + "- Fecha de nacimiento: " + dtpNacimiento.Value + "\n"
                 + "- Fecha de contratacion: " + dtpContratacion.Value + "\n" + "- Jefe: " + cboJefe.Text + "\n" + "- Notas: " +
                 txtNotas.Text + "\n" + "- Direccion: " + txtDireccion.Text + "\n" + "- Ciudad: " + txtCiudad.Text + "\n"
                    + "- Region: " + txtRegion.Text + "\n" + "- Codigo Postal: " + txtCodigoPostal.Text + "\n" + "- Pais: " + txtPais.Text +
                    "\n" + "- Telefono: " + txtTelefono.Text + "\n" + "- Extension: " + txtExtension.Text + "\n", "Datos correctos",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                try
                {
                    string Ruta = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                    objConexion.ConnectionString = Ruta;
                    objConexion.Open();

                    string sql = "INSERT INTO Empleados (Apellidos, Nombre, Cargo, Tratamiento, FechaNacimiento, FechaContratación," +
                        "Dirección, Ciudad, Región, CódPostal, País, TelDomicilio, Extensión, Foto, Notas, Jefe) VALUES(";
                    sql += "'" + txtApellido.Text + "', ";
                    sql += "'" + txtNombre.Text + "', ";
                    sql += "'" + txtCargo.Text + "', ";
                    sql += "'" + txtTratamiento.Text + "', ";
                    sql += "'" + dtpNacimiento.Value + "', ";
                    sql += "'" + dtpContratacion.Value + "', ";
                    sql += "'" + txtDireccion.Text + "', ";
                    sql += "'" + txtCiudad.Text + "', ";
                    sql += "'" + txtRegion.Text + "', ";
                    sql += "'" + txtCodigoPostal.Text + "', ";
                    sql += "'" + txtPais.Text + "', ";
                    sql += "'" + txtTelefono.Text + "', ";
                    sql += "'" + txtExtension.Text + "', ";
                    sql += "'" + ptbFoto + "', ";
                    sql += "'" + txtNotas.Text + "', ";
                    sql += "'" + cboJefe.SelectedIndex + "') ";

                    OleDbCommand objComando = new OleDbCommand();
                    objComando.Connection = objConexion;
                    objComando.CommandText = @sql;

                    if (objComando.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("El empleado se ha registrado exitosamente!", "Empleado registrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se han podido agregar el empleado", "Error", MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                    }

                    objConexion.Close();

                    txtApellido.Text = "";
                    txtNombre.Text = "";
                    txtCargo.Text = "";
                    txtTratamiento.Text = "";
                    dtpNacimiento.Value = DateTime.Today;
                    dtpContratacion.Value = DateTime.Today;
                    cboJefe.SelectedIndex = -1;
                    ptbFoto.Image = null;
                    txtNotas.Text = "";
                    txtDireccion.Text = "";
                    txtCiudad.Text = "";
                    txtRegion.Text = "";
                    txtCodigoPostal.Text = "";
                    txtPais.Text = "";
                    txtTelefono.Text = "";
                    txtExtension.Text = "";
                    tbcRegistro.SelectedIndex = 0;
                    txtApellido.Select();

                }
                catch (Exception mensaje)
                {
                    MessageBox.Show(mensaje.Message);
                    throw;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptbFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofbFoto = new OpenFileDialog();
            ofdFoto.Filter = "Imagenes |*.jpg; *.jpeg; *.png";
            ofdFoto.Title = "Seleccionar Foto del Empleado";
            ofdFoto.InitialDirectory = Application.StartupPath;

            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                ptbFoto.ImageLocation = ofdFoto.FileName;
                ptbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text == "" | txtNombre.Text == "" | txtCargo.Text == "" | txtTratamiento.Text == ""
                 | cboJefe.SelectedItem == null | txtNotas.Text == "" | txtDireccion.Text == "" | txtCiudad.Text == ""
                 | txtRegion.Text == "" | txtCodigoPostal.Text == "" | txtPais.Text == "" | txtTelefono.MaskFull == false
                 | txtExtension.Text == "")
            {
                btnRegistrar.Enabled = false;
            }
            else
            {
                btnRegistrar.Enabled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtCargo.Text = "";
            txtTratamiento.Text = "";
            dtpNacimiento.Value = DateTime.Today;
            dtpContratacion.Value = DateTime.Today;
            cboJefe.SelectedIndex = -1;
            ptbFoto.Image = null;
            txtNotas.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtRegion.Text = "";
            txtCodigoPostal.Text = "";
            txtPais.Text = "";
            txtTelefono.Text = "";
            txtExtension.Text = "";
            tbcRegistro.SelectedIndex = 0;
            txtApellido.Select();
        }

        private void tmrFecha_Tick(object sender, EventArgs e)
        {
            tslFecha.Text = DateTime.Now.ToString();
        }
    }
}
