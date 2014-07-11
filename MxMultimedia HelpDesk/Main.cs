using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Reflection;
using System.Deployment.Application;
using System.Net.Mail;
using System.Net;
using System.Diagnostics;
using System.Threading;

namespace MxMultimedia_HelpDesk
{
    public partial class Main : Form
    {
        MySqlConnection cnn;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public string StrConn;
        public string SqlStr;
        public string strUserID;
        public string strUsername;
        public string strEmail;
        public string strIdLoja;
        public string strServer;
        public string strUID;
        public string strPWD;
        public string strDatabase;
        public string strTargetMensal;

        DateTime dataAviso;
        Assistencia frmAssistencia;
        ListagemAssistencias frmListagemAssistencias;
        Clientes.ListagemClientes frmListagemClientes;

        SaldoMensal frmSaldoMensal;


        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Application.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("pt-PT");
            /*
            string Version = Assembly.GetExecutingAssembly().GetName().Version.ToString().Substring(0,3);
            ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
            this.Text = "MxMultimedia HelpDesk - v" + Version + " (build " + ad.CurrentVersion.Build.ToString() + ")";
            */
            frmListagemClientes = new Clientes.ListagemClientes(StrConn, strUserID, strIdLoja, this, frmSaldoMensal);
            frmListagemAssistencias = new ListagemAssistencias(StrConn, strIdLoja, strUserID, frmListagemClientes, this);
            frmAssistencia = new Assistencia(StrConn, strIdLoja, "", "", frmListagemAssistencias, strUserID, frmListagemClientes, "", this, null);
            GetServerDetails();
        }



        public void openChilds()
        {
            //Saldo
            frmSaldoMensal = new SaldoMensal(StrConn, strUserID);
            frmSaldoMensal.MdiParent = this;
            frmSaldoMensal.StartPosition = FormStartPosition.Manual;
            int x = this.ClientSize.Width - (frmSaldoMensal.Width + 20);
            int y = 0;
            Point loc = new Point(x, y);
            frmSaldoMensal.Location = this.PointToScreen(new Point(x, y));

            SaldoBackgroundWorker.RunWorkerAsync(frmSaldoMensal);
            frmSaldoMensal.Show();

            //Lista de Assistencias
            //ListagemAssistencias la = new ListagemAssistencias(StrConn, strIdLoja, strUserID, frmListagemClientes, this);
            //la.MdiParent = this;
            //la.Show();
        }

        private void GetServerDetails()
        {
            string line;
            ArrayList ServerDetails = new ArrayList();
            System.IO.StreamReader file =
               new System.IO.StreamReader(Application.StartupPath + "\\server.txt");
            while ((line = file.ReadLine()) != null)
            {
                ServerDetails.Add(line);
            }

            file.Close();

            strServer = ServerDetails[0].ToString();
            strUID = ServerDetails[1].ToString();
            strPWD = ServerDetails[2].ToString();
            strDatabase = ServerDetails[3].ToString();

            ConnectMySql(strServer, strUID, strPWD, strDatabase);
        }

        public void ConnectMySql(string Server, string UID, string PWD, string Database)
        {
            StrConn = String.Format("server={0};uid={1};pwd={2};database={3}",
                Server, UID, PWD, Database);
            cnn = new MySqlConnection(StrConn);

            try
            {
                cnn.Open();
                mainMenu.Enabled = false;
                lblStatusLojaLabel.Visible = false;
                lblStatusUserLabel.Visible = false;

                Login login = new Login(StrConn, this);
                login.MdiParent = this;
                login.Show();
            }
            catch (MySqlException se)
            {
                mainMenu.Enabled = false;
                lblStatusLojaLabel.Visible = false;
                lblStatusUserLabel.Visible = false;

                DialogResult dr = MessageBox.Show("Erro ao ligar ao Servidor.\n" + se.Message, "Erro MySql", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (dr == System.Windows.Forms.DialogResult.Retry)
                {
                    Server server = new Server(this);
                    server.MdiParent = this;
                    server.Show();
                }
            }
            GetDataUltimoAviso();
        }

        public void getUserID(string ID, string Username, string Email, string Loja, string TargetMensal)
        {
            strUserID = ID;
            strUsername = Username;
            strEmail = Email;
            lblUser.Text = strUsername;
            strIdLoja = Loja;
            strTargetMensal = TargetMensal;

            if (strIdLoja == "5")
            {
                SqlStr = "SELECT * FROM Lojas ";
            }
            else
            {
                SqlStr = "SELECT * FROM Lojas WHERE id=" + strIdLoja;
            }
            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lblLoja.Text = dr[4].ToString();
                }
                lblStatusLojaLabel.Visible = true;
                lblStatusUserLabel.Visible = true;
                mainMenu.Enabled = true;
            }
            dr.Close();
            cnn.Close();
        }

        private void GetDataUltimoAviso()
        {
            SqlStr = "SELECT dataaviso, id FROM Avisos WHERE id=1";
            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dataAviso = DateTime.Parse(dr[0].ToString());
                }
            }
            dr.Close();
            cnn.Close();

            double UltimoAviso = (DateTime.Now - dataAviso).TotalDays;
            int iAviso = Convert.ToInt32(Math.Round(UltimoAviso, 0));
            if (iAviso > 1)
            {
                SqlStr = "UPDATE Avisos SET registo='" + DateTime.Now.ToString() + "' WHERE id=1";
                cmd = new MySqlCommand(SqlStr, cnn);
                try
                {
                    if (cnn.State == ConnectionState.Closed) cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
                catch (MySqlException se)
                {
                    MessageBox.Show(se.ToString(), "Erro ao actualizar Data de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                AvisoReparacoesParadas("ruivieira@mxmultimedia.com");
                AvisoReparacoesParadas("pedrosimao@gmail.com");
            }
        }

        public void AvisoEmail(string Registo, string EmailDestino, string Tipo, string Body, string Desc)
        {
            string from = "helpdesk@mxmultimedia.com";
            string to = EmailDestino;
            string subject = "";
            string body = Body;
            SmtpClient client = new SmtpClient("mail.mxmultimedia.com");
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("helpdesk@mxmultimedia.com", "@12345");

            //AVISAR CLIENTE
            if (Tipo == "AvisarCliente")
            {
                subject = "O seu equipamento está pronto! Nº de Registo: " + Registo;

                MailMessage msg = new MailMessage(from, to, subject, body);
                msg.IsBodyHtml = true;
                try
                {
                    client.Send(msg);
                    SqlStr = "INSERT INTO Avisos (tipo, registo, email) VALUES "+
                        @"('Cliente', '" + Registo + "', '" + Desc + "')";
                    cmd = new MySqlCommand(SqlStr, cnn);
                    try
                    {
                        if (cnn.State == ConnectionState.Closed) cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                    catch (MySqlException se)
                    {
                        MessageBox.Show(se.ToString(), "Erro ao gravar aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MessageBox.Show("Cliente avisado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao enviar Aviso Email: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //REPARAÇÕES PARADAS
            if (Tipo == "AvisoReparacoesParadas")
            {
                subject = "Aviso de Repações Paradas - [" + DateTime.Now.ToString() + "]";
                MailMessage msg = new MailMessage(from, to, subject, body);
                msg.IsBodyHtml = true;
                try
                {
                    client.Send(msg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao enviar Aviso Email: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //NOVA ASSISTENCIA
            if (strEmail != "ruivieira@mxmultimedia.com" && Tipo == "NovaAssistencia")
            {
                string strEmailLoja = "";
                string strEmailNumCliente = "";
                string strEmailNomeCliente = "";
                string strEmailDataInicio = "";
                string strEmailDescricao = "";
                string strEmailTipoReparacao = "";

                SqlStr = "SELECT Clientes.numcliente, Clientes.nomecliente, Assistencias.datainicio, " +
                    @"Assistencias.descricaoassist, TipoReparacao.tiporeparacao, Lojas.Localizacao " +
                    @"FROM Assistencias " +
                    @"LEFT JOIN Clientes on Assistencias.idcliente=Clientes.numcliente " +
                    @"LEFT JOIN TipoReparacao on TipoReparacao.id=Assistencias.idtipo " +
                    @"LEFT JOIN Lojas on Lojas.id=Assistencias.idloja " +
                    @"WHERE registo='" + Registo + "'";

                cmd = new MySqlCommand(SqlStr, cnn);
                if (cnn.State == ConnectionState.Closed) cnn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        strEmailLoja = dr[5].ToString();
                        strEmailNumCliente = dr[0].ToString();
                        strEmailNomeCliente = dr[1].ToString();
                        strEmailDataInicio = dr[2].ToString();
                        strEmailDescricao = dr[3].ToString();
                        strEmailTipoReparacao = dr[4].ToString();
                    }
                }
                dr.Close();
                cnn.Close();

                subject = "Nova Assistência [" + Registo + "] " + strEmailLoja;
                body = "Registo: <a href='http://mxmultimedia.com/estado.php?rep=" + Registo + "'>" + Registo + "</a> - Loja: " + strEmailLoja + "<br><br>" +
                    "<strong>" + strEmailNumCliente + " - " + strEmailNomeCliente + "</strong><br>" +
                    "Data: " + strEmailDataInicio.Substring(0, 10) + "<br>" +
                    strEmailTipoReparacao + " - " + strEmailDescricao;

                MailMessage msg = new MailMessage(from, to, subject, body);
                msg.IsBodyHtml = true;
                try
                {
                    client.Send(msg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao enviar Aviso Email: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void AvisoReparacoesParadas(string EmailDestino)
        {
            DateTime dataAssist;
            DateTime dataHoje = DateTime.Now;
            ArrayList arrRegistos = new ArrayList();
            string strRegisto;
            string strBody2 = "";
            SqlStr = "SELECT Assistencias.registo, Assistencias.datainicio FROM Assistencias " +
                @"WHERE Assistencias.datafim='1999-01-01'";
            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    strRegisto = dr[0].ToString();
                    dataAssist = DateTime.Parse(dr[1].ToString());
                    double totalDias = (dataHoje-dataAssist).TotalDays;
                    if (totalDias > 2)
                    {
                        strBody2 += "Registo: "+
                            @"<a href='http://mxmultimedia.com/estado.php?rep=" + strRegisto + "'>" + 
                            @strRegisto + "</a> - " + Math.Round(totalDias, 0).ToString() + " dias<br>";
                    }
                }
            }
            dr.Close();
            cnn.Close();

            string strBody = "Os seguintes registos encontram-se parados há mais de 2 dias.<br>";
            strBody += strBody2;
            AvisoEmail("", EmailDestino, "AvisoReparacoesParadas", strBody, "");
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ficheiroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListagemAssistencias la = new ListagemAssistencias(StrConn, strIdLoja, strUserID, frmListagemClientes, this);
            la.MdiParent = this;
            la.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clientes.ListagemClientes lc = new Clientes.ListagemClientes(StrConn, strUserID, strIdLoja, this, frmSaldoMensal);
            lc.MdiParent = this;
            lc.Show();
        }

        private void detalheAssistênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P_MapaAssist ma = new P_MapaAssist(strIdLoja);
            ma.MdiParent = this;
            ma.Show();
        }

        private void totaisServiçosComponentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P_TotalServicos ps = new P_TotalServicos(strIdLoja);
            ps.MdiParent = this;
            ps.Show();
        }

        private void sairToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagBalcao pb = new PagBalcao(StrConn, lblLoja.Text, frmSaldoMensal);
            pb.MdiParent = this;
            pb.Show();
        }

        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            P_CLientesFiltro fc = new P_CLientesFiltro();
            fc.MdiParent = this;
            fc.Show();
        }

        private void pagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Income i = new Income(this, frmSaldoMensal);
            i.MdiParent = this;
            i.Show();
        }

        private void SaldoBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(5000);
            e.Result = e.Argument;
        }
    }
}
