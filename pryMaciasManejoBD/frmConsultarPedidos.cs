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

        private void btnMostrarDGV_Click(object sender, EventArgs e)
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
                    command.Parameters.AddWithValue("@fechadesde", dtpDesde.Value);
                    command.Parameters.AddWithValue("@fechahasta", dtpHasta.Value);

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
            } else
            {
                MessageBox.Show("En HASTA inserte una fecha mayor a la fecha que inserto en DESDE", "Error en el rango de fechas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tmrFecha_Tick(object sender, EventArgs e)
        {
            tslFecha.Text = DateTime.Now.ToString();
        }

        private void frmConsultarPedidos_Load(object sender, EventArgs e)
        {
            tmrFecha.Enabled = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
