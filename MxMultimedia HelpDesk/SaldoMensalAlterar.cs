using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MxMultimedia_HelpDesk
{
    public partial class SaldoMensalAlterar : Form
    {
        MySqlConnection cnn;
        MySqlCommand cmd;
        MySqlDataReader dr;
        SaldoMensal frmSaldoMensal;

        private string sqlStr;
        private string strConn;
        private string m;
        private string y;
        private string strAction;

        public SaldoMensalAlterar(string connectionString, SaldoMensal saldoMensal)
        {
            InitializeComponent();
            strConn = connectionString;
            frmSaldoMensal = saldoMensal;
        }

        private void SaldoMensalAlterar_Load(object sender, EventArgs e)
        {
            cnn = new MySqlConnection(strConn);

            DateTime dtToday = DateTime.Today;
            string strToday = dtToday.ToShortDateString();
            string[] arrToday = strToday.Split(new char[] { '-' });

            m = arrToday[1].ToString();
            y = arrToday[2].ToString();

            strAction = "update";

            getSaldo();
        }

        public void getSaldo()
        {
            sqlStr = "SELECT target FROM SaldoMensal where month='" + m + "-" + y + "'";
            cmd = new MySqlCommand(sqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtSaldo.Text = dr[0].ToString().Replace(",", ".");
                }
            }
            else
            {
                txtSaldo.Text = "0.00";
                strAction = "insert";
            }

            dr.Close();
            cnn.Close();
        }

        private void setTarget()
        {
            if (strAction == "update") sqlStr = "UPDATE SaldoMensal SET target='" + txtSaldo.Text + "' WHERE month='" + m + "-" + y + "'";

            if (strAction == "insert") sqlStr = "INSERT INTO SaldoMensal (target, month) VALUES ('" + txtSaldo.Text + "','" + m + "-" + y + "')";

            cmd = new MySqlCommand(sqlStr, cnn);
            try
            {
                if (cnn.State == ConnectionState.Closed) cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
                frmSaldoMensal.setSaldo();
                MessageBox.Show("Alterado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (MySqlException se)
            {
                MessageBox.Show(se.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            setTarget();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSaldo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                setTarget();
            }
        }
    }
}
