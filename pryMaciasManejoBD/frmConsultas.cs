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

        OleDbConnection connection;
        OleDbDataAdapter dataAdapter;
        DataSet dataSet;

        private void btnMostrarDGV_Click(object sender, EventArgs e)
        {
            connection = new OleDbConnection();

            try
            {
                connection.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                connection.Open();

                dataAdapter = new OleDbDataAdapter();
                dataSet = new DataSet();
                string sql;

                if (cboTablas.SelectedIndex == 0)
                {
                    sql = "Select *From Categorías";
                    dataAdapter = new OleDbDataAdapter(sql, connection);
                    dataSet.Tables.Add("Categorías");
                    dataAdapter.Fill(dataSet.Tables["Categorías"]);
                    dgvTablas.DataSource = dataSet.Tables["Categorías"];
                }
                else if (cboTablas.SelectedIndex == 1)
                {
                    sql = "Select *From Clientes";
                    dataAdapter = new OleDbDataAdapter(sql, connection);
                    dataSet.Tables.Add("Clientes");
                    dataAdapter.Fill(dataSet.Tables["Clientes"]);
                    dgvTablas.DataSource = dataSet.Tables["Clientes"];
                }
                else if (cboTablas.SelectedIndex == 2)
                {
                    sql = "Select *From [Detalles de pedidos]";
                    dataAdapter = new OleDbDataAdapter(sql, connection);
                    dataSet.Tables.Add("Detalles de pedidos");
                    dataAdapter.Fill(dataSet.Tables["Detalles de pedidos"]);
                    dgvTablas.DataSource = dataSet.Tables["Detalles de pedidos"];
                }
                else if (cboTablas.SelectedIndex == 3)
                {
                    sql = "Select IdEmpleado, Apellidos, Nombre, Cargo, Tratamiento, FechaNacimiento, " +
                        "FechaContratación, Dirección, Ciudad, Región, CódPostal, País, TelDomicilio, Extensión, " +
                        "Notas, Jefe From Empleados";
                    dataAdapter = new OleDbDataAdapter(sql, connection);
                    dataSet.Tables.Add("Empleados");
                    dataAdapter.Fill(dataSet.Tables["Empleados"]);
                    dgvTablas.DataSource = dataSet.Tables["Empleados"];
                }
                else if (cboTablas.SelectedIndex == 4)
                {
                    sql = "Select *From Pedidos";
                    dataAdapter = new OleDbDataAdapter(sql, connection);
                    dataSet.Tables.Add("Pedidos");
                    dataAdapter.Fill(dataSet.Tables["Pedidos"]);
                    dgvTablas.DataSource = dataSet.Tables["Pedidos"];
                }
                else if (cboTablas.SelectedIndex == 5)
                {
                    sql = "Select *From Productos";
                    dataAdapter = new OleDbDataAdapter(sql, connection);
                    dataSet.Tables.Add("Productos");
                    dataAdapter.Fill(dataSet.Tables["Productos"]);
                    dgvTablas.DataSource = dataSet.Tables["Productos"];
                }
                else if (cboTablas.SelectedIndex == 6)
                {
                    sql = "Select *From Proveedores";
                    dataAdapter = new OleDbDataAdapter(sql, connection);
                    dataSet.Tables.Add("Proveedores");
                    dataAdapter.Fill(dataSet.Tables["Proveedores"]);
                    dgvTablas.DataSource = dataSet.Tables["Proveedores"];
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

        private void cboTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection = new OleDbConnection();

            try
            {
                connection.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                connection.Open();

                dataAdapter = new OleDbDataAdapter();
                dataSet = new DataSet();
                string sql;

                if (cboTablas.SelectedIndex == 0)
                {
                    sql = "Select *From Categorías";
                    dataAdapter = new OleDbDataAdapter(sql, connection);
                    dataSet.Tables.Add("Categorías");
                    dataAdapter.Fill(dataSet.Tables["Categorías"]);
                    dgvTablas.DataSource = dataSet.Tables["Categorías"];
                }
                else if (cboTablas.SelectedIndex == 1)
                {
                    sql = "Select *From Clientes";
                    dataAdapter = new OleDbDataAdapter(sql, connection);
                    dataSet.Tables.Add("Clientes");
                    dataAdapter.Fill(dataSet.Tables["Clientes"]);
                    dgvTablas.DataSource = dataSet.Tables["Clientes"];
                }
                else if (cboTablas.SelectedIndex == 2)
                {
                    sql = "Select *From [Detalles de pedidos]";
                    dataAdapter = new OleDbDataAdapter(sql, connection);
                    dataSet.Tables.Add("Detalles de pedidos");
                    dataAdapter.Fill(dataSet.Tables["Detalles de pedidos"]);
                    dgvTablas.DataSource = dataSet.Tables["Detalles de pedidos"];
                }
                else if (cboTablas.SelectedIndex == 3)
                {
                    sql = "Select IdEmpleado, Apellidos, Nombre, Cargo, Tratamiento, FechaNacimiento, " +
                        "FechaContratación, Dirección, Ciudad, Región, CódPostal, País, TelDomicilio, Extensión, " +
                        "Notas, Jefe From Empleados";
                    dataAdapter = new OleDbDataAdapter(sql, connection);
                    dataSet.Tables.Add("Empleados");
                    dataAdapter.Fill(dataSet.Tables["Empleados"]);
                    dgvTablas.DataSource = dataSet.Tables["Empleados"];
                }
                else if (cboTablas.SelectedIndex == 4)
                {
                    sql = "Select *From Pedidos";
                    dataAdapter = new OleDbDataAdapter(sql, connection);
                    dataSet.Tables.Add("Pedidos");
                    dataAdapter.Fill(dataSet.Tables["Pedidos"]);
                    dgvTablas.DataSource = dataSet.Tables["Pedidos"];
                }
                else if (cboTablas.SelectedIndex == 5)
                {
                    sql = "Select *From Productos";
                    dataAdapter = new OleDbDataAdapter(sql, connection);
                    dataSet.Tables.Add("Productos");
                    dataAdapter.Fill(dataSet.Tables["Productos"]);
                    dgvTablas.DataSource = dataSet.Tables["Productos"];
                }
                else if (cboTablas.SelectedIndex == 6)
                {
                    sql = "Select *From Proveedores";
                    dataAdapter = new OleDbDataAdapter(sql, connection);
                    dataSet.Tables.Add("Proveedores");
                    dataAdapter.Fill(dataSet.Tables["Proveedores"]);
                    dgvTablas.DataSource = dataSet.Tables["Proveedores"];
                }
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);
                throw;
            }
        }
    }
}
