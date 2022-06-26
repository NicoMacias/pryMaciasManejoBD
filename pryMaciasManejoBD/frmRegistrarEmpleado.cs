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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Dialog que pregunta si queres registrar el empleado con todos esos datos.
            DialogResult resultado = MessageBox.Show("Seguro que quiere registrar los siguientes datos?" + "\n" + "\n" +
                "- Apellido: " + txtApellido.Text + "\n" + "- Nombre: " + txtNombre.Text + "\n" + "- Cargo: " +
                txtCargo.Text + "\n" + "- Tratamiento: " + txtTratamiento.Text + "\n" + "- Fecha de nacimiento: " + dtpNacimiento.Value + "\n"
                 + "- Fecha de contratacion: " + dtpContratacion.Value + "\n" + "- Jefe: " + cboJefe.Text + "\n" + "- Notas: " +
                 txtNotas.Text + "\n" + "- Direccion: " + txtDireccion.Text + "\n" + "- Ciudad: " + txtCiudad.Text + "\n"
                    + "- Region: " + txtRegion.Text + "\n" + "- Codigo Postal: " + txtCodigoPostal.Text + "\n" + "- Pais: " + txtPais.Text +
                    "\n" + "- Telefono: " + txtTelefono.Text + "\n" + "- Extension: " + txtExtension.Text + "\n", "Datos correctos",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            // Si pusiste que si en el dialog se ejecuta esto.
            if (resultado == DialogResult.OK)
            {
                try
                {
                    OleDbConnection connection = new OleDbConnection();
                    connection.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                    connection.Open();

                    // Se agregar todos los valores al comando sql separados por renglon para que quede mas ordenado.
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

                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = @sql;

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("El empleado se ha registrado exitosamente!", "Empleado registrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se han podido agregar el empleado", "Error", MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                    }

                    connection.Close();

                    // Se limpia el formulario.
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
        private void btnVolver_Click(object sender, EventArgs e)
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
            // Para que no te habilite el boton registrar hasta que no esten todos los datos cargados
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

        private void dtpNacimiento_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNacimiento.Value >= DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser mayor al dia de hoy", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                dtpNacimiento.Value = DateTime.Now;
            }
        }

        private void ptbFlechaSiguiente_Click(object sender, EventArgs e)
        {
            tbcRegistro.SelectedIndex = 1;
        }

        private void lblSiguiente_Click(object sender, EventArgs e)
        {
            tbcRegistro.SelectedIndex = 1;
        }

        private void lblAnterior_Click(object sender, EventArgs e)
        {
            tbcRegistro.SelectedIndex = 0;
        }

        private void ptbFlechaAnterior_Click(object sender, EventArgs e)
        {
            tbcRegistro.SelectedIndex = 0;
        }
    }
}
