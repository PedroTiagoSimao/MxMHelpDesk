using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace MxMultimedia_HelpDesk
{
    public partial class IncomeAdd : Form
    {
        Main mainForm;
        Income incomeForm;
        MySqlConnection cnn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public string SqlStr;

        public string strNum;
        public string strNome;

        public string strAction;
        public string strIncome;
        public string strYearIncome;
        public string strUser;
        public string strLoja;

        public IncomeAdd(Main formMain, Income frmIncome, string Action, string NumIncome, string Username, string Loja)
        {
            InitializeComponent();
            mainForm = formMain;
            incomeForm = frmIncome;
            strAction = Action;
            strIncome = NumIncome;
            strUser = Username;
            strLoja = Loja;
        }

        private void IncomeAdd_Load(object sender, EventArgs e)
        {
            cnn = new MySqlConnection(mainForm.StrConn);
            getClientes();

            if (strAction == "edit")
            {

            }
            else
            {
                strYearIncome = DateTime.Parse(DateTime.Now.ToShortDateString()).Year.ToString();
                GetNumIncome(strYearIncome);
                txtNumIncome.Text = strYearIncome + "-" + strIncome;
            }

        }

        private void GetNumIncome(string YearIncome)
        {
            SqlStr = "SELECT numIncome FROM Income WHERE yearIncome='" + YearIncome + "'";
            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    strIncome = Convert.ToString(Convert.ToInt32(dr[0].ToString()) + 1);
                }
            }
            else
            {
                strIncome = "1";
            }
            dr.Close();
            cnn.Close();
        }

        private void IncomeAdd_Populate()
        {

        }

        private void dgvIncomeAdd_DefaulValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewComboBoxCell cellArtigo = (DataGridViewComboBoxCell)e.Row.Cells["artigo"];
            cellArtigo.Items.Clear();

            //Add items
            SqlStr = "SELECT Artigo FROM Artigos";
            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cellArtigo.Items.Add(dr[0].ToString());
                }
            }
            dr.Close();
            cnn.Close();
        }

        private void getClientes()
        {
            AutoCompleteStringCollection numcliente = new AutoCompleteStringCollection();
            AutoCompleteStringCollection nomecliente = new AutoCompleteStringCollection();
            SqlStr = "SELECT numcliente, nomecliente FROM Clientes";
            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    numcliente.Add(dr[0].ToString());
                    nomecliente.Add(dr[1].ToString());
                }
            }
            dr.Close();
            cnn.Close();
            txtNumCliente.AutoCompleteCustomSource = numcliente;
            txtNomeCliente.AutoCompleteCustomSource = nomecliente;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveIncome();
        }

        private void SaveIncome()
        {
            string numIncome = strIncome;
            string yearIncome = strYearIncome;
            DateTime dateToday = DateTime.Now;
            string yearToday = dateToday.Year.ToString();
            string monthToday = dateToday.Month.ToString();
            string dayToday = dateToday.Day.ToString();
            string dateIncome = yearToday + "-" + monthToday + "-" + dayToday;
            string clientIncome = txtNumCliente.Text.ToString();
            string artIncome;
            string descrIncome;
            string quantIncome;
            string valueIncome;
            string totalIncome;
            string lojaIncome = "Loja";
            string userIncome = "User";
            string typeIncome = "Income";

            foreach (DataGridViewRow row in dgvIncomeAdd.Rows)
            {
                if (row.Cells["artigo"].Value != null)
                {
                    artIncome = row.Cells["artigo"].Value.ToString();
                    descrIncome = row.Cells["descr"].Value.ToString();
                    quantIncome = row.Cells["quant"].Value.ToString();
                    quantIncome = quantIncome.Replace(',', '.');
                    valueIncome = row.Cells["value"].Value.ToString();
                    valueIncome = valueIncome.Replace(',', '.');
                    totalIncome = row.Cells["total"].Value.ToString();
                    totalIncome = totalIncome.Replace(',', '.');

                    SqlStr = "INSERT INTO Income (numIncome, yearIncome, dateIncome, artIncome, descrIncome, " +
                        @"quantIncome, valueIncome, totalIncome, lojaIncome, userIncome, typeIncome, clientIncome) VALUES (" +
                        @"'" + numIncome + "', '" + yearIncome + "', '" + dateIncome + "', '" + artIncome + "', " +
                        @"'" + descrIncome + "', '" + quantIncome + "', '" + valueIncome + "', '" + totalIncome + "', " +
                        @"'" + lojaIncome + "', '" + userIncome + "', '" + typeIncome + "', '" + clientIncome + "')";

                    cmd = new MySqlCommand(SqlStr, cnn);
                    if (cnn.State == ConnectionState.Closed) cnn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        incomeForm.GetPagamentos("day");

                    }
                    catch (MySqlException se)
                    {
                        MessageBox.Show(se.Message, "Erro na Query", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtNumCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                SqlStr = "SELECT nomecliente FROM Clientes WHERE numcliente='" + txtNumCliente.Text + "'";
                cmd = new MySqlCommand(SqlStr, cnn);
                if (cnn.State == ConnectionState.Closed) cnn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtNomeCliente.Text = dr[0].ToString();
                    }
                }
                dr.Close();
                cnn.Close();
            }
        }

        private void txtNomeCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                SqlStr = "SELECT numcliente FROM Clientes WHERE nomecliente='" + txtNomeCliente.Text + "'";
                cmd = new MySqlCommand(SqlStr, cnn);
                if (cnn.State == ConnectionState.Closed) cnn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtNumCliente.Text = dr[0].ToString();
                    }
                }
                dr.Close();
                cnn.Close();
            }
        }

        private void dgvIncome_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvIncomeAdd.Columns[dgvIncomeAdd.CurrentCell.ColumnIndex].Name.Equals("artigo"))
            {
                ComboBox cmbArtigo = e.Control as ComboBox;
                cmbArtigo.SelectedIndexChanged += new EventHandler(cmbArtigo_SelectedIndexChanged);
            }
        }

        private void cmbArtigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmbArtigo = (ComboBox)sender;

            if (cmbArtigo.SelectedItem != null)
            {
                ArtigoPopulateCell(dgvIncomeAdd.CurrentCell.RowIndex, cmbArtigo.SelectedItem.ToString());
            }
        }

        private void ArtigoPopulateCell(int strRow, string strArtigo)
        {
            SqlStr = "SELECT Descricao, PVP FROM Artigos where Artigo = '" + strArtigo + "'";
            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dgvIncomeAdd.Rows[strRow].Cells["descr"].Value = dr[0].ToString();
                    dgvIncomeAdd.Rows[strRow].Cells["value"].Value = dr[1].ToString();
                    dgvIncomeAdd.Rows[strRow].Cells["quant"].Value = "1";
                    dgvIncomeAdd.Rows[strRow].Cells["total"].Value = dr[1].ToString();
                }
            }
            dr.Close();
            cnn.Close();
        }

        private void dgvIncome_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (dgvIncomeAdd.Rows[e.RowIndex].Cells["quant"].Value != null)
                {
                    string strValue = dgvIncomeAdd.Rows[e.RowIndex].Cells["value"].Value.ToString();
                    string strQuant = dgvIncomeAdd.Rows[e.RowIndex].Cells["quant"].Value.ToString();

                    double value = Convert.ToDouble(strValue.Replace(".",","));
                    double quant = Convert.ToDouble(strQuant.Replace(".", ","));

                    dgvIncomeAdd.Rows[e.RowIndex].Cells["value"].Value = value;
                    dgvIncomeAdd.Rows[e.RowIndex].Cells["total"].Value = value * quant;
                }
            }
        }
    }
}
