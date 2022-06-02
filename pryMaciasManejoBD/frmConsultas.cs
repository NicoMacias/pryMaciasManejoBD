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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        OleDbConnection objConexion;
        OleDbDataAdapter objAdaptador;
        DataSet objDataSet;

        private void btnMostrarDGV_Click(object sender, EventArgs e)
        {
            objConexion = new OleDbConnection();

            try
            {
                string Ruta = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                objConexion.ConnectionString = Ruta;
                objConexion.Open();

                objAdaptador = new OleDbDataAdapter();
                objDataSet = new DataSet();
                string consulta;

                if (cboTablas.SelectedIndex == 0)
                {
                    consulta = "Select *From Categorías";
                    objAdaptador = new OleDbDataAdapter(consulta, objConexion);
                    objDataSet.Tables.Add("Categorías");
                    objAdaptador.Fill(objDataSet.Tables["Categorías"]);
                    dgvTablas.DataSource = objDataSet.Tables["Categorías"];
                }
                else if (cboTablas.SelectedIndex == 1)
                {
                    consulta = "Select *From Clientes";
                    objAdaptador = new OleDbDataAdapter(consulta, objConexion);
                    objDataSet.Tables.Add("Clientes");
                    objAdaptador.Fill(objDataSet.Tables["Clientes"]);
                    dgvTablas.DataSource = objDataSet.Tables["Clientes"];
                }
                else if (cboTablas.SelectedIndex == 2)
                {
                    consulta = "Select *From [Detalles de pedidos]";
                    objAdaptador = new OleDbDataAdapter(consulta, objConexion);
                    objDataSet.Tables.Add("Detalles de pedidos");
                    objAdaptador.Fill(objDataSet.Tables["Detalles de pedidos"]);
                    dgvTablas.DataSource = objDataSet.Tables["Detalles de pedidos"];
                }
                else if (cboTablas.SelectedIndex == 3)
                {
                    consulta = "Select IdEmpleado, Apellidos, Nombre, Cargo, Tratamiento, FechaNacimiento, " +
                        "FechaContratación, Dirección, Ciudad, Región, CódPostal, País, TelDomicilio, Extensión, " +
                        "Notas, Jefe From Empleados";
                    objAdaptador = new OleDbDataAdapter(consulta, objConexion);
                    objDataSet.Tables.Add("Empleados");
                    objAdaptador.Fill(objDataSet.Tables["Empleados"]);
                    dgvTablas.DataSource = objDataSet.Tables["Empleados"];
                }
                else if (cboTablas.SelectedIndex == 4)
                {
                    consulta = "Select *From Pedidos";
                    objAdaptador = new OleDbDataAdapter(consulta, objConexion);
                    objDataSet.Tables.Add("Pedidos");
                    objAdaptador.Fill(objDataSet.Tables["Pedidos"]);
                    dgvTablas.DataSource = objDataSet.Tables["Pedidos"];
                }
                else if (cboTablas.SelectedIndex == 5)
                {
                    consulta = "Select *From Productos";
                    objAdaptador = new OleDbDataAdapter(consulta, objConexion);
                    objDataSet.Tables.Add("Productos");
                    objAdaptador.Fill(objDataSet.Tables["Productos"]);
                    dgvTablas.DataSource = objDataSet.Tables["Productos"];
                }
                else if (cboTablas.SelectedIndex == 6)
                {
                    consulta = "Select *From Proveedores";
                    objAdaptador = new OleDbDataAdapter(consulta, objConexion);
                    objDataSet.Tables.Add("Proveedores");
                    objAdaptador.Fill(objDataSet.Tables["Proveedores"]);
                    dgvTablas.DataSource = objDataSet.Tables["Proveedores"];
                }
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);
                throw;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrFecha_Tick(object sender, EventArgs e)
        {
            tslFecha.Text = DateTime.Now.ToString();
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            tmrFecha.Enabled = true;
        }
    }
}
