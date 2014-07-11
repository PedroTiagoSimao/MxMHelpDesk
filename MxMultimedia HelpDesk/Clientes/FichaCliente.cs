using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MxMultimedia_HelpDesk.Clientes
{
    public partial class FichaCliente : Form
    {
        MySqlCommand cmd;
        MySqlConnection cnn;
        MySqlDataReader dr;
        public string strUserId;
        public string StrConn;
        public string SqlStr;
        public string strNumCliente;
        public string strAction;
        public string idAssistencia;
        public string strIdLoja;
        public string strEquip;
        public string postBack;
        public int iTotalAssistencias;
        public int numeroAssistencias;

        Assistencia frmAssistencia;
        ListagemClientes frmListagemClientes;
        Main frmMain;
        SaldoMensal frmSaldoMensal;

        public FichaCliente(string SQLConnection, string NumeroCliente, string Action, Assistencia Assistencia, string PostBackForm, string UserId, ListagemClientes ListagemClientes, string IdLoja, Main MainForm, SaldoMensal saldoMensal)
        {
            InitializeComponent();
            strNumCliente = NumeroCliente;
            strAction = Action;
            StrConn = SQLConnection;
            frmAssistencia = Assistencia;
            postBack = PostBackForm;
            strUserId = UserId;
            frmListagemClientes = ListagemClientes;
            strIdLoja = IdLoja;
            frmMain = MainForm;
            frmSaldoMensal = saldoMensal;
        }

        private void FichaCliente_Load(object sender, EventArgs e)
        {
            cnn = new MySqlConnection(StrConn);
            dgvEquipamentos.Columns["numequip"].ReadOnly = true;

            if (strAction == "new")
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(RandomNumber(1000, 9999));
                builder.Append(RandomString(2, false));
                txtNumCliente.Text = builder.ToString();
                strNumCliente = builder.ToString();

                DateTime d = DateTime.Today;
                txtDataRegisto.Text = d.Day.ToString() + "-" + d.Month.ToString() + "-" + d.Year.ToString();
            }

            if (strAction == "edit")
            {
                txtNumCliente.Text = strNumCliente;
                GetCliente();
                GetEquipamentos();
                GetAssistencias();
            }
        }

        private void GetCliente()
        {
            SqlStr = "SELECT * FROM Clientes WHERE numcliente='" + strNumCliente + "'";
            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtDataRegisto.Text = dr[2].ToString().Substring(0,10);
                    txtNomeCliente.Text = dr[3].ToString();
                    txtNIF.Text = dr[4].ToString();
                    txtTelefoneCliente.Text = dr[5].ToString();
                    txtTelemovelCliente.Text = dr[6].ToString();
                    txtEmailCliente.Text = dr[7].ToString();
                    txtSkypeCliente.Text = dr[8].ToString();
                    txtMoradaCliente.Text = dr[9].ToString();
                    txtCPCliente.Text = dr[10].ToString();
                    txtLocalidade.Text = dr[11].ToString();
                }
            }
            dr.Close();
            cnn.Close();
        }

        private void GetEquipamentos()
        {
            dgvEquipamentos.Rows.Clear();
            SqlStr = "SELECT * FROM Equipamentos WHERE idcliente='" + strNumCliente + "'";
            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dgvEquipamentos.Rows.Add(dr[1], dr[3], dr[4], dr[5], dr[7], dr[8], dr[9]);
                }
            }
            dr.Close();
            cnn.Close();
        }

        public void GetAssistencias()
        {
            iTotalAssistencias = 0;
            dgvAssistencias.Rows.Clear();
            SqlStr = "SELECT Lojas.localizacao, Equipamentos.tipoequip, Equipamentos.descricaoequip, "+
                @"Equipamentos.serie, TipoReparacao.tiporeparacao, Assistencias.datafim, Assistencias.registo, "+
                @"(select count(*) from Avisos where Avisos.registo=Assistencias.registo) as avisos, " +
                @"Assistencias.pago, Assistencias.datapago, Assistencias.registo " +
                @"FROM Assistencias " +
                @"LEFT JOIN Lojas on Lojas.id=Assistencias.idloja " +
                @"LEFT JOIN TipoReparacao on TipoReparacao.id=Assistencias.idtipo "+
                @"LEFT JOIN Equipamentos on Equipamentos.numequip=Assistencias.idequipamento "+
                @"WHERE Assistencias.idcliente='" + strNumCliente + "'";
            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string pago = "Não";

                    if (dr[8].ToString() == "1") pago = "Sim";

                    dgvAssistencias.Rows.Add(dr[10], dr[0] ,dr[1]+" "+dr[2]+" - "+dr[3], dr[4], dr[5].ToString().Substring(0,10), dr[6], dr[7], pago, dr[9].ToString().Substring(0,10));

                    iTotalAssistencias++;
                }
            }
            dr.Close();
            cnn.Close();
        }

        private void GravaCliente()
        {
            DateTime d = DateTime.Parse(txtDataRegisto.Text);
            string strData = d.Year.ToString() + "-" + d.Month.ToString() + "-" + d.Day.ToString();

            if (strAction == "new")
            {
                SqlStr = "INSERT INTO Clientes (numcliente, dataregisto, nomecliente, telefone," +
                @"telemovel, email, skype, morada, cp, userid, nif, localidade) VALUES ('" + strNumCliente + "', " +
                @"'" + strData + "', '" + txtNomeCliente.Text + "', '" + txtTelefoneCliente.Text + "', " +
                @"'" + txtTelemovelCliente.Text + "', '" + txtEmailCliente.Text + "', '" + txtSkypeCliente.Text + "', " +
                @"'" + txtMoradaCliente.Text + "', '" + txtCPCliente.Text + "', " + strUserId + ", " +
                @"'" + txtNIF.Text + "', '" + txtLocalidade.Text + "')";
            }

            if (strAction == "edit")
            {
                SqlStr = "UPDATE Clientes SET " +
                    @"dataregisto='" + strData + "', nomecliente='" + txtNomeCliente.Text + "', " +
                    @"telefone='" + txtTelefoneCliente.Text + "', telemovel='" + txtTelemovelCliente.Text + "', " +
                    @"email='" + txtEmailCliente.Text + "', skype='" + txtSkypeCliente.Text + "', " +
                    @"morada='" + txtMoradaCliente.Text + "', cp='" + txtCPCliente.Text + "', " +
                    @"userid=" + strUserId + ", nif='" + txtNIF.Text + "', localidade='" + txtLocalidade.Text + "' " +
                    @"WHERE numcliente='" + strNumCliente + "'";
            }

            cmd = new MySqlCommand(SqlStr, cnn);            
            try
            {
                if (cnn.State == ConnectionState.Closed) cnn.Open();
                if (txtNomeCliente.Text != "")
                {
                    cmd.ExecuteNonQuery();
                }
                cnn.Close();
                strAction = "edit";
                MessageBox.Show("Cliente gravado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (frmListagemClientes != null)
                {
                    frmListagemClientes.GetClientes();
                }
            }
            catch (MySqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void GravaEquipamentos()
        {
            //APAGA EXISTENTES
            SqlStr = "DELETE FROM Equipamentos WHERE idcliente='" + strNumCliente + "'";
            cmd = new MySqlCommand(SqlStr, cnn);
            try {
                if (cnn.State == ConnectionState.Closed) cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (MySqlException se) {
                MessageBox.Show(se.Message);
            }

            //INSERE TODOS
            foreach (DataGridViewRow row in dgvEquipamentos.Rows)
            {
                string strNum = "";
                if (row.Cells["numequip"].Value != null) strNum = row.Cells["numequip"].Value.ToString();

                string strTipo = "";
                if(row.Cells["tipoequip"].Value != null) strTipo = row.Cells["tipoequip"].Value.ToString();

                string strDescr = "";
                if (row.Cells["descr"].Value != null) strDescr = row.Cells["descr"].Value.ToString();

                string strSerie = "";
                if (row.Cells["serie"].Value != null) strSerie = row.Cells["serie"].Value.ToString();

                string strTvId = "";
                if (row.Cells["tvid"].Value != null) strTvId = row.Cells["tvid"].Value.ToString();

                string strTvPass = "";
                if (row.Cells["tvpass"].Value != null) strTvPass = row.Cells["tvpass"].Value.ToString();

                string strPass = "";
                if (row.Cells["pass"].Value != null) strPass = row.Cells["pass"].Value.ToString();
                if (strDescr != "")
                {
                    SqlStr = "INSERT INTO Equipamentos (idcliente, tipoequip, descricaoequip, " +
                        @"serie, numequip, pass, tvid, tvpass) VALUES " +
                        @"('" + strNumCliente + "','" + strTipo + "'," +
                        @"'" + strDescr + "', '" + strSerie + "', '" + strNum + "', " +
                        @"'" + strPass + "', '" + strTvId + "', '" + strTvPass + "')";

                    cmd = new MySqlCommand(SqlStr, cnn);
                    try
                    {
                        if (cnn.State == ConnectionState.Closed) cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                    catch (MySqlException se)
                    {
                        MessageBox.Show(se.Message);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GravaCliente();
        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAssistencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewCell cellRegistoAssist = dgvAssistencias.Rows[e.RowIndex].Cells["id"];
                idAssistencia = cellRegistoAssist.Value.ToString();
            }
        }

        private void btnDefinirSaida_Click(object sender, EventArgs e)
        {
            DefinirSaida saida = new DefinirSaida(StrConn, idAssistencia, this, null, frmSaldoMensal);
            saida.MdiParent = this.MdiParent;
            saida.Show();
        }

        private void btnSaveEquip_Click(object sender, EventArgs e)
        {
            GravaEquipamentos();
            MessageBox.Show("Equipamentos gravados com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetEquipamentos();
            if (postBack == "Assist")
            {
                frmAssistencia.GetEquipamentos();
            }
        }

        private void dgvAssistencias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Assistencia assist = new Assistencia(StrConn, "", "edit", idAssistencia, null, strUserId, frmListagemClientes, strNumCliente, frmMain, this);
                assist.MdiParent = this.MdiParent;
                assist.Show();
            }
        }

        private void btnSkype_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("skype:pedrotsimao?call");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvEquipamentos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string strNumEquip = "";
                StringBuilder builder = new StringBuilder();
                builder.Append(RandomNumber(100000, 999999));
                strNumEquip = builder.ToString();
                dgvEquipamentos.Rows[e.RowIndex].Cells["numequip"].Value = strNumEquip;
            }
        }

        private void btnAssistencia_Click(object sender, EventArgs e)
        {
            Assistencia assist = new Assistencia(StrConn, strIdLoja , "new", "", null, strUserId, frmListagemClientes, strNumCliente, frmMain, this);
            assist.MdiParent = this.MdiParent;
            assist.Show();
        }

        private void avisarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string EmailCliente = txtEmailCliente.Text;
            if (EmailCliente != "" && iTotalAssistencias > 0)
            {
                string Body = "Exmo(a) Sr.(a) " + txtNomeCliente.Text + "<br><br>" +
                    @"O seu equipamento está pronto para ser levantado na nossa loja.<br>" +
                    @"Pode verificar o estado do seu equipamento e valor da reparação " +
                    @"<a href='http://mxmultimedia.com/estado.php?rep=" + idAssistencia + "'>aqui</a>.<br><br>" +
                    @"Atentamente,<br>MxMultimedia HelpDesk";

                frmMain.AvisoEmail(idAssistencia, EmailCliente, "AvisarCliente", Body, EmailCliente);
            }
            else
            {
                MessageBox.Show("Morada de email do cliente ainda por definir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listaDeAvisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Avisos a = new Avisos(idAssistencia, frmMain);
            a.MdiParent = this.MdiParent;
            a.Show();
        }

        private void dgvEquipamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewCell cellEquip = dgvEquipamentos.Rows[e.RowIndex].Cells["numequip"];
                if(cellEquip.Value != null) strEquip = cellEquip.Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (strEquip != null)
            {
                if (strEquip != "")
                {
                    if (CheckAssistencias(strEquip) <= 0)
                    {
                        DialogResult dr = MessageBox.Show("Tem a certeza que quer eliminar este equipamento?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == System.Windows.Forms.DialogResult.Yes)
                        {
                            SqlStr = "DELETE FROM Equipamentos WHERE numequip='" + strEquip + "'";
                            cmd = new MySqlCommand(SqlStr, cnn);
                            try
                            {
                                if (cnn.State == ConnectionState.Closed) cnn.Open();
                                cmd.ExecuteNonQuery();
                                cnn.Close();
                            }
                            catch (MySqlException se)
                            {
                                MessageBox.Show(se.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Existe(m) " + numeroAssistencias + " assistência(s) para este equipamento.\nImpossível eliminar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private int CheckAssistencias(string NumEquipamento)
        {
            numeroAssistencias = 0;
            SqlStr = "SELECT COUNT(*) FROM Assistencias WHERE idequipamento='" + strEquip + "'";
            cmd = new MySqlCommand(SqlStr, cnn);
            try
            {
                if (cnn.State == ConnectionState.Closed) cnn.Open();
                numeroAssistencias = Convert.ToInt32(cmd.ExecuteScalar());
                cnn.Close();
            }
            catch (MySqlException se)
            {
                MessageBox.Show(se.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return numeroAssistencias;
        }
    }
}
