using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;

namespace MxMultimedia_HelpDesk
{
    public partial class SaldoMensal : Form
    {
        private string strConn;
        private double saldoMensal = 0;
        private double lucroMensal = 0;
        private string sqlStr;
        private string m;
        private string y;
        private string strUserID;

        MySqlConnection cnn;
        MySqlCommand cmd;
        MySqlDataReader dr;


        public SaldoMensal(string connectionString, string userID)
        {
            InitializeComponent();
            strConn = connectionString;
            strUserID = userID;
        }

        private void SaldoMensal_Load(object sender, EventArgs e)
        {
            cnn = new MySqlConnection(strConn);

            if (strUserID == "10")
            {
                btnChangeTarget.Visible = true;
            }

            Thread t = new Thread(setSaldo);
            t.Start();
        }

        public void setSaldo()
        {
            DateTime dtToday = DateTime.Today;
            string strToday = dtToday.ToShortDateString();
            string[] arrToday = strToday.Split(new Char[] { '-' });
            //if (arrToday.Count() < 2) arrToday = strToday.Split(new Char[] { '/' });

            m = arrToday[1].ToString();
            y = arrToday[2].ToString();

            getSaldo();
            getVendas();

            double totalMensal = lucroMensal - saldoMensal;

            if (totalMensal > 0) txtSaldo.ForeColor = Color.Green;

            lblMes.Invoke(new MethodInvoker(delegate { lblMes.Text = dtToday.ToString("MMMM") + " - " + saldoMensal.ToString(); }));

            txtSaldo.Invoke(new MethodInvoker(delegate { txtSaldo.Text = totalMensal.ToString("N2").Replace(",", "."); }));
        }

        private void getSaldo()
        {
            if (cnn == null) cnn = new MySqlConnection(strConn);
            sqlStr = "SELECT target FROM SaldoMensal where month='" + m + "-" + y + "'";
            cmd = new MySqlCommand(sqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    saldoMensal = Convert.ToDouble(dr[0]);
                }
            }
            dr.Close();
            cnn.Close();
        }

        private void getVendas()
        {
            sqlStr = "select sum(lucro) from PagBalcao where month(data)='" + m + "'";
            cmd = new MySqlCommand(sqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (!DBNull.Value.Equals(dr[0]))
                    {
                        lucroMensal = Convert.ToDouble(dr[0]);
                    }
                }
            }
            dr.Close();
            cnn.Close();
        }

        private void btnChangeTarget_Click(object sender, EventArgs e)
        {
            SaldoMensalAlterar sma = new SaldoMensalAlterar(strConn, this);
            sma.StartPosition = FormStartPosition.Manual;
            int x = this.ClientSize.Width - (sma.Width + 20);
            int y = 0;
            Point loc = new Point(x, y);
            sma.Location = this.PointToScreen(new Point(x, y));
            sma.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            setSaldo();
        }
    }
}
