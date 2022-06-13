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
    public partial class frmConsultarPedidos : Form
    {
        public frmConsultarPedidos()
        {
            InitializeComponent();
        }

        private void tmrFecha_Tick(object sender, EventArgs e)
        {
            tslFecha.Text = DateTime.Now.ToString();
        }

        private void frmConsultarPedidos_Load(object sender, EventArgs e)
        {
            tmrFecha.Enabled = true;

            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
            connection.Open();

            string sql;

            OleDbCommand command;

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();

            sql = "SELECT Clientes.IdCliente, Pedidos.CiudadDestinatario, Pedidos.RegiónDestinatario, Pedidos.CódPostalDestinatario," +
                " Pedidos.PaísDestinatario FROM Clientes, Pedidos";
            command = new OleDbCommand(sql, connection);

            OleDbDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                if (!cboCliente.Items.Contains(dataReader["IdCliente"].ToString()))
                {
                    cboCliente.Items.Add(dataReader["IdCliente"].ToString());
                }

                if(!cboCiudad.Items.Contains(dataReader["CiudadDestinatario"].ToString()))
                {
                    cboCiudad.Items.Add(dataReader["CiudadDestinatario"].ToString());
                }

                if (!cboRegion.Items.Contains(dataReader["RegiónDestinatario"].ToString()))
                {
                    cboRegion.Items.Add(dataReader["RegiónDestinatario"].ToString());
                }

                if (!cboCodPostal.Items.Contains(dataReader["CódPostalDestinatario"].ToString()))
                {
                    cboCodPostal.Items.Add(dataReader["CódPostalDestinatario"].ToString());
                }

                if (!cboPais.Items.Contains(dataReader["PaísDestinatario"].ToString()))
                {
                    cboPais.Items.Add(dataReader["PaísDestinatario"].ToString());
                }
            }

            connection.Close();

            DataSet dataSet;
            dataSet = new DataSet();
            sql = "Select *From Pedidos";
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dataSet.Tables.Add("Pedidos");
            dataAdapter.Fill(dataSet.Tables["Pedidos"]);
            dgvTablas.DataSource = dataSet.Tables["Pedidos"];
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                connection.Open();

                string sql;

                OleDbCommand command;

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();

                sql = "SELECT * FROM Pedidos WHERE IdCliente = @cliente";
                command = new OleDbCommand(sql, connection);

                command.Parameters.AddWithValue("@cliente", cboCliente.SelectedItem.ToString());

                dataAdapter.SelectCommand = command;

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "tabla");
                dgvTablas.DataSource = dataSet;
                dgvTablas.DataMember = "tabla";

                connection.Close();
            }
            catch (Exception)
            {
                if (dgvTablas.Rows.Count <= 0)
                {
                    MessageBox.Show("El cliente no realizo pedidos", "No existen pedidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                connection.Open();

                string sql;

                OleDbCommand command;

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();

                sql = "SELECT * FROM Pedidos WHERE CiudadDestinatario = @ciudad";
                command = new OleDbCommand(sql, connection);

                command.Parameters.AddWithValue("@ciudad", cboCiudad.SelectedItem.ToString());

                dataAdapter.SelectCommand = command;

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "tabla");
                dgvTablas.DataSource = dataSet;
                dgvTablas.DataMember = "tabla";

                connection.Close();
            }
            catch (Exception)
            {
                if (dgvTablas.Rows.Count <= 0)
                {
                    MessageBox.Show("No se realizaron pedidos en la ciudad indicada", "No existen pedidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDesde.Value <= dtpHasta.Value)
            {
                try
                {
                    OleDbConnection connection = new OleDbConnection();
                    connection.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                    connection.Open();

                    string sql;

                    OleDbCommand command;

                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter();

                    sql = "select * from Pedidos WHERE FechaPedido BETWEEN @fechadesde AND @fechahasta";
                    command = new OleDbCommand(sql, connection);
                    command.Parameters.AddWithValue("@fechadesde", dtpDesde.Value.Date);
                    command.Parameters.AddWithValue("@fechahasta", dtpHasta.Value.Date);

                    dataAdapter.SelectCommand = command;

                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "tabla");
                    dgvTablas.DataSource = dataSet;
                    dgvTablas.DataMember = "tabla";

                    connection.Close();
                }
                catch (Exception)
                {
                    if (dgvTablas.Rows.Count <= 0)
                    {
                        MessageBox.Show("No hay pedidos entre el rango de fechas seleccionado", "No existen pedidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("La fecha de DESDE debe ser menor a la fecha de HASTA", "Error en el rango de fechas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                connection.Open();

                string sql;

                OleDbCommand command;

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();

                sql = "SELECT * FROM Pedidos WHERE RegiónDestinatario = @region";
                command = new OleDbCommand(sql, connection);

                command.Parameters.AddWithValue("@region", cboRegion.SelectedItem.ToString());

                dataAdapter.SelectCommand = command;

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "tabla");
                dgvTablas.DataSource = dataSet;
                dgvTablas.DataMember = "tabla";

                connection.Close();
            }
            catch (Exception)
            {
                if (dgvTablas.Rows.Count <= 0)
                {
                    MessageBox.Show("No se realizaron pedidos en la region indicada", "No existen pedidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboCodPostal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                connection.Open();

                string sql;

                OleDbCommand command;

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();

                sql = "SELECT * FROM Pedidos WHERE CódPostalDestinatario = @codPostal";
                command = new OleDbCommand(sql, connection);

                command.Parameters.AddWithValue("@codPostal", cboCodPostal.SelectedItem.ToString());

                dataAdapter.SelectCommand = command;

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "tabla");
                dgvTablas.DataSource = dataSet;
                dgvTablas.DataMember = "tabla";

                connection.Close();
            }
            catch (Exception)
            {
                if (dgvTablas.Rows.Count <= 0)
                {
                    MessageBox.Show("No se realizaron pedidos en la region postal indicada", "No existen pedidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                connection.Open();

                string sql;

                OleDbCommand command;

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();

                sql = "SELECT * FROM Pedidos WHERE PaísDestinatario = @pais";
                command = new OleDbCommand(sql, connection);

                command.Parameters.AddWithValue("@pais", cboPais.SelectedItem.ToString());

                dataAdapter.SelectCommand = command;

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "tabla");
                dgvTablas.DataSource = dataSet;
                dgvTablas.DataMember = "tabla";

                connection.Close();
            }
            catch (Exception)
            {
                if (dgvTablas.Rows.Count <= 0)
                {
                    MessageBox.Show("No se realizaron pedidos en la region postal indicada", "No existen pedidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void nudMinimo_ValueChanged(object sender, EventArgs e)
        {
            if (nudMinimo.Value <= nudMaximo.Value)
            {
                try
                {
                    OleDbConnection connection = new OleDbConnection();
                    connection.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                    connection.Open();

                    string sql;

                    OleDbCommand command;

                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter();

                    sql = "select * from Pedidos WHERE Cargo BETWEEN @cargominimo AND @cargomaximo";
                    command = new OleDbCommand(sql, connection);
                    command.Parameters.AddWithValue("@cargominimo", nudMinimo.Value);
                    command.Parameters.AddWithValue("@cargomaximo", nudMaximo.Value);

                    dataAdapter.SelectCommand = command;

                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "tabla");
                    dgvTablas.DataSource = dataSet;
                    dgvTablas.DataMember = "tabla";

                    connection.Close();
                }
                catch (Exception)
                {
                    if (dgvTablas.Rows.Count <= 0)
                    {
                        MessageBox.Show("No hay pedidos entre el rango de cargos seleccionado", "No existen pedidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("El cargo MINIMO no debe ser mayor al cargo MAXIMO", "Error en el rango de cargos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
