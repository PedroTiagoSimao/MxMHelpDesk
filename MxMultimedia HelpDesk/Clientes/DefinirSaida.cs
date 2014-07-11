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
using System.Globalization;

namespace MxMultimedia_HelpDesk.Clientes
{
    public partial class DefinirSaida : Form
    {
        MySqlCommand cmd;
        MySqlConnection cnn;
        MySqlDataReader dr;
        FichaCliente ficha;
        ListagemAssistencias lista;
        SaldoMensal frmSaldoMensal;
        public string StrConn;
        public string idAssistencia;
        public string SqlStr;
        public string strDate;

        public string strNumCliente;
        public string strNomeCliente;
        public string strLoja;
        public string strTipo;
        public string strDescr;

        public DefinirSaida(string SQLConnection, string IDAssistencia, FichaCliente FichaCliente, ListagemAssistencias ListagemAssistencias, SaldoMensal saldoMensal)
        {
            InitializeComponent();
            StrConn = SQLConnection;
            idAssistencia = IDAssistencia;
            ficha = FichaCliente;
            lista = ListagemAssistencias;
            frmSaldoMensal = saldoMensal;
        }

        private void DefinirSaida_Load(object sender, EventArgs e)
        {
            cnn = new MySqlConnection(StrConn);
        }

        private void DefineSaida()
        {
            DateTime d = DateTime.Parse(monthCalendar1.SelectionStart.ToShortDateString());
            strDate = d.Year.ToString() + "-" + d.Month.ToString() + "-" + d.Day.ToString();

            SqlStr = "UPDATE Assistencias SET datafim='" + strDate + "' WHERE registo='" + idAssistencia+"'";
            cmd = new MySqlCommand(SqlStr, cnn);
            try
            {
                if (cnn.State == ConnectionState.Closed) cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();

                DialogResult dr = MessageBox.Show("Efectuar recebimento?", "Pagamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == System.Windows.Forms.DialogResult.Yes) GravaPagamento(idAssistencia, "");

                if (ficha != null) ficha.GetAssistencias();
                if (lista != null) lista.GetAssistencias();
                this.Close();

            }
            catch (MySqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void GravaPagamento(string Registo, string Behaviour)
        {
            if (!isPaid(Registo))
            {
                if (Behaviour == "fecha")
                {
                    DateTime d = DateTime.Parse(monthCalendar1.SelectionStart.ToShortDateString());
                    strDate = d.Year.ToString() + "-" + d.Month.ToString() + "-" + d.Day.ToString();
                }

                getDadosAssistencia(Registo);

                double totalAssistencia = TotalAssistencia(Registo, Behaviour);
                
                string strDescrPagamento = "Nº " + Registo + " - " + strNumCliente + " - " + strNomeCliente + " - " + strTipo + " " + strDescr;

                SqlStr = "INSERT INTO PagBalcao (data, nome, descr, receita, despesa, lucro, loja) VALUES " +
                    @"('" + strDate + "', 'Assistência', '" + strDescrPagamento + "', " +
                    @"" + totalAssistencia.ToString(CultureInfo.InvariantCulture) + ", 0, " + totalAssistencia.ToString(CultureInfo.InvariantCulture) + ", '" + strLoja + "')";

                cmd = new MySqlCommand(SqlStr, cnn);
                try
                {
                    if (cnn.State == ConnectionState.Closed) cnn.Open();

                    cmd.ExecuteNonQuery();

                    cnn.Close();

                    RegistaPagamento(Registo);

                    if (frmSaldoMensal != null)
                    {
                        Thread t = new Thread(frmSaldoMensal.setSaldo);
                        t.Start();
                    }

                    if (Behaviour == "fecha") this.Close();
                }
                catch (MySqlException se)
                {
                    MessageBox.Show(se.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Já existe um registo de pagamento para esta assistencia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RegistaPagamento(string Registo)
        {
            DateTime dtTday = DateTime.Today;
            string[] arrDateToday = dtTday.ToShortDateString().Split(new char[] { '-' });
            string strDate = arrDateToday[2] + "-" + arrDateToday[1] + "-" + arrDateToday[0];

            SqlStr = "UPDATE Assistencias set pago=1, datapago='" + strDate + "' WHERE registo='" + Registo + "'";
            cmd = new MySqlCommand(SqlStr, cnn);
            try
            {
                if (cnn.State == ConnectionState.Closed) cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (MySqlException me)
            {
                MessageBox.Show(me.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isPaid(string Registo)
        {
            SqlStr = "SELECT pago FROM Assistencias WHERE pago=1 and registo='" + Registo + "'";
            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                cnn.Close();
                return true;
            }
            else
            {
                dr.Close();
                cnn.Close();
                return false;
            }
        }

        private double TotalAssistencia(string Registo, string Behaviour)
        {
            double totalAssistencia = 0;

            SqlStr = "SELECT SUM(quant * custo) FROM AssLinhas WHERE registo='" + Registo + "'";

            cmd = new MySqlCommand(SqlStr, cnn);

            try
            {
                if (cnn.State == ConnectionState.Closed) cnn.Open();

                totalAssistencia = Convert.ToDouble(cmd.ExecuteScalar());

                cnn.Close();

            }
            catch (MySqlException se)
            {
                MessageBox.Show(se.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return totalAssistencia;
        }

        private void getDadosAssistencia(string Registo)
        {
            SqlStr = "select * from selectAssistencias_view WHERE registo='" + Registo + "'";
            cmd = new MySqlCommand(SqlStr, cnn);
            MySqlDataReader dr;
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    strNumCliente = dr["numcliente"].ToString();
                    strNomeCliente = dr["nomecliente"].ToString();
                    strLoja = dr["localizacao"].ToString();
                    strTipo = dr["tiporeparacao"].ToString();
                    strDescr = dr["descricaoequip"].ToString();
                }
            }
            dr.Close();
            cnn.Close();
        }

        private void btnSetDate_Click(object sender, EventArgs e)
        {
            DefineSaida();
        }

        private void btnSetPayment_Click(object sender, EventArgs e)
        {
            GravaPagamento(idAssistencia, "fecha");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
