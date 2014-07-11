using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CarlosAg.ExcelXmlWriter;
using System.Threading;
using System.Diagnostics;

namespace MxMultimedia_HelpDesk.Clientes
{
    public partial class ListagemClientes : Form
    {
        MySqlCommand cmd;
        MySqlConnection cnn;
        MySqlDataReader dr;
        public string strUserId;
        public string StrConn;
        public string strNumCliente;
        public string strSearch;
        public string SqlStr;
        public string strIdLoja;
        Main frmMain;
        SaldoMensal frmSaldoMensal;

        public ListagemClientes(string SQLConnection, string UserId, string IdLoja, Main MainForm, SaldoMensal saldoMensal)
        {
            InitializeComponent();
            StrConn = SQLConnection;
            strUserId = UserId;
            strIdLoja = IdLoja;
            frmMain = MainForm;
            frmSaldoMensal = saldoMensal;
        }

        private void ListagemClientes_Load(object sender, EventArgs e)
        {
            cnn = new MySqlConnection(StrConn);
            GetClientes();
        }

        public void GetClientes()
        {
            if (dgvClientes.Columns != null)
            {
                dgvClientes.Rows.Clear();
                SqlStr = "select distinct Clientes.* from Clientes left join Equipamentos on Equipamentos.idcliente=Clientes.numcliente";
                cmd = new MySqlCommand(SqlStr, cnn);
                if (cnn.State == ConnectionState.Closed) cnn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dgvClientes.Rows.Add(dr[1], dr[3], dr[5], dr[6], dr[7], dr[11]);
                    }
                }
                dr.Close();
                cnn.Close();
            }
        }

        private void Search()
        {
            dgvClientes.Rows.Clear();

            SqlStr = "select distinct Clientes.* from Clientes left join Equipamentos "+
                @"on Equipamentos.idcliente=Clientes.numcliente where "+
                @"Clientes.numcliente like '%" + txtSearch.Text + "%'or "+
                @"Clientes.nomecliente like '%" + txtSearch.Text + "%' or "+
                @"Clientes.email like '%" + txtSearch.Text + "%' or "+
                @"Clientes.telemovel like '%" + txtSearch.Text + "%' or "+
                @"Clientes.telefone like '%" + txtSearch.Text + "%' or "+
                @"Clientes.localidade like '%" + txtSearch.Text + "%' or " +
                @"Equipamentos.serie like '%" + txtSearch.Text + "%'";
            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dgvClientes.Rows.Add(dr[1], dr[3], dr[5], dr[6], dr[7], dr[11]);
                }
            }
            dr.Close();
            cnn.Close();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewCell cellNumCliente = dgvClientes.Rows[e.RowIndex].Cells["numcliente"];
                strNumCliente = cellNumCliente.Value.ToString();
            }
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                FichaCliente ficha = new FichaCliente(StrConn, strNumCliente, "edit", null, "ListagemClientes", strUserId, this, strIdLoja, frmMain, frmSaldoMensal);
                ficha.MdiParent = this.MdiParent;
                ficha.Show();
            }
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            Clientes.FichaCliente ficha = new Clientes.FichaCliente(StrConn, "", "new", null, "ListagemClientes", strUserId, this, strIdLoja, frmMain, frmSaldoMensal);
            ficha.MdiParent = this.MdiParent;
            ficha.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void EliminarCliente(string NumCliente)
        {
            //ELIMINA ASSISTENCIAS
            SqlStr = "DELETE FROM Assistencias WHERE idcliente='" + NumCliente + "'";
            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (MySqlException se)
            {
                MessageBox.Show(se.Message);
            }

            //ELIMINA CLIENTE
            SqlStr = "DELETE FROM Clientes WHERE numcliente='" + NumCliente + "'";
            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (MySqlException se)
            {
                MessageBox.Show(se.Message);
            }

            GetClientes();
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que quer eliminar este cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                EliminarCliente(strNumCliente);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = GetExcelSaveFileDialog())
            {
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;

                    Workbook workbook = DataGridViewToExcel.ExcelGenerator.Generate(this.dgvClientes);
                    workbook.Save(fileName);

                    //Process.Start(fileName);
                }
            }
        }

        private SaveFileDialog GetExcelSaveFileDialog()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.AddExtension = true;
            saveFileDialog.ValidateNames = true;
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog.DefaultExt = ".xls";
            saveFileDialog.Filter = "Microsoft Excel Workbook (*.xls)|*.xls";
            return saveFileDialog;
        }
    }
}
