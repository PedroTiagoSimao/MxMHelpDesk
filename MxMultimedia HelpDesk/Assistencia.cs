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
using System.IO;

namespace MxMultimedia_HelpDesk
{
    public partial class Assistencia : Form
    {
        MySqlConnection cnn;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public string strConn;
        public string strRegisto;
        public string idLoja;
        public string strLoja;
        public string idCliente;
        public string idEquipamento;
        public string idTipoReparacao;
        public string strDescricao;
        public string SqlStr;
        public string strAction;
        public string strUserId;
        public string strIdCliente;
        public string strAcessorios;
        ListagemAssistencias frmListagemAssistencias;
        Clientes.ListagemClientes frmListagemClientes;
        Main frmMain;
        Clientes.FichaCliente frmFichaCliente;

        public Assistencia(string SQLConnection, string Loja, string Action, string Registo, ListagemAssistencias ListagemAssistencias, string UserId, Clientes.ListagemClientes ListagemClientes, string Cliente, Main Main, Clientes.FichaCliente FichaCliente)
        {
            InitializeComponent();
            idLoja = Loja;
            strConn = SQLConnection;
            strAction = Action;
            strRegisto = Registo;
            frmListagemAssistencias = ListagemAssistencias;
            strUserId = UserId;
            frmListagemClientes = ListagemClientes;
            strIdCliente = Cliente;
            frmMain = Main;
            frmFichaCliente = FichaCliente;
        }

        private void Assistencia_Load(object sender, EventArgs e)
        {
            cnn = new MySqlConnection(strConn);
            dgvLinhasAssist.Columns["date"].ReadOnly = true;

            if (strAction == "new")
            {
                GetNew();
            }


            //Edit
            if (strAction == "edit")
            {
                GetEdit();
            }
        }

        private void GetNew()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            txtRegisto.Text = builder.ToString();
            strRegisto = builder.ToString();

            GetLojas();
            GetUserLoja();
            GetTipoReparacao();
            GetExistingClients();
            txtNumCliente.Text = strIdCliente;
            txtNumCliente.Focus();
        }

        private void GetEdit()
        {
            txtRegisto.Text = strRegisto;

            GetCabecAssist(strRegisto);
            txtNumCliente.Text = idCliente;
            
            if (strAcessorios != "")
            {
                //Deixou de ser devido a alteração na gravação 25/09/2012
                /*string acc = strAcessorios.Substring(0, 6);
                if (acc == "Outros")
                {
                    txtAcessorios.Text = strAcessorios.Substring(9, strAcessorios.Length - 9);
                    cmbAcessorios.SelectedItem = "Outros";
                }
                else
                {
                    cmbAcessorios.SelectedItem = strAcessorios;
                }*/

                string[] acc = strAcessorios.Split(new char[] { '-' });
                if (acc.Count() > 1) txtAcessorios.Text = acc[1].ToString().Trim(); ;
                cmbAcessorios.SelectedItem = acc[0].ToString().Trim();
            }
            else
            {
                cmbAcessorios.SelectedItem = strAcessorios;
            }
            

            GetCliente();

            GetLojas();
            cmbLoja.SelectedValue = Convert.ToInt64(idLoja);

            cmbEquip.SelectedValue = Convert.ToInt64(idEquipamento);

            GetTipoReparacao();
            cmbTipoReparacao.SelectedValue = Convert.ToInt64(idTipoReparacao);
            txtDescricaoServico.Text = strDescricao;

            GetLinhasAssist(strRegisto);
        }

        private void GetExistingClients()
        {
            AutoCompleteStringCollection clientes = new AutoCompleteStringCollection();
            SqlStr = "SELECT * FROM Clientes";
            cmd = new MySqlCommand(SqlStr, cnn);
            if(cnn.State == ConnectionState.Closed)cnn.Open();
            dr=cmd.ExecuteReader();
            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    clientes.Add(dr[1].ToString());
                }
            }
            dr.Close();
            cnn.Close();
            txtNumCliente.AutoCompleteCustomSource = clientes;
        }

        public class AddValue
        {
            private string m_Display;
            private long m_Value;
            public AddValue(string Display, long Value)
            {
                m_Display = Display;
                m_Value = Value;
            }
            public string Display
            {
                get { return m_Display; }
            }
            public long Value
            {
                get { return m_Value; }
            }
        }

        private void GetLojas()
        {
            ArrayList Lojas = new ArrayList();
            //Lojas.Add(new AddValue("", 0));

            if (idLoja == "5")
            {
                SqlStr = "SELECT * FROM Lojas";
            }
            else
            {
                SqlStr = "SELECT * FROM Lojas where id=" + idLoja;
            }

            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                   Lojas.Add(new AddValue(dr[4].ToString(), Convert.ToInt32(dr[0].ToString())));
                }
            }
            dr.Close();
            cnn.Close();

            cmbLoja.DataSource = Lojas;
            cmbLoja.DisplayMember = "Display";
            cmbLoja.ValueMember = "Value";
        }

        private void GetUserLoja()
        {
            SqlStr = "SELECT * FROM Lojas WHERE id=" + idLoja;
            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    strLoja = dr[5].ToString();
                    cmbLoja.SelectedValue = Convert.ToInt64(idLoja);
                }
            }
            dr.Close();
            cnn.Close();
        }

        private void GetCliente()
        {
            string strNumCliente = txtNumCliente.Text;
            SqlStr = "SELECT * FROM Clientes WHERE numcliente='" + strNumCliente + "'";
            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtNomeCliente.Text = dr[3].ToString();
                    txtEmailCliente.Text = dr[7].ToString();
                    txtMoradaCliente.Text = dr[9].ToString() + " - " + dr[10].ToString() + " " + dr[11].ToString() ;
                    txtTelefoneCliente.Text = dr[5].ToString() + "/" + dr[6].ToString();
                    idCliente = strNumCliente;
                }
            }
            dr.Close();
            cnn.Close();
            GetEquipamentos();
            /*else
            {
                MessageBox.Show("Cliente inexistente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dr.Close();
                cnn.Close();
                txtNumCliente.SelectAll();
            }*/
        }

        public void GetEquipamentos()
        {
            ArrayList Equipamentos = new ArrayList();

            SqlStr = "SELECT * FROM Equipamentos WHERE idcliente='" + idCliente + "'";
            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Equipamentos.Add(new AddValue(dr[3].ToString()+" - "+dr[4].ToString(), Convert.ToInt32(dr[1].ToString())));
                }
            }
            dr.Close();
            cnn.Close();
            cmbEquip.DataSource = Equipamentos;
            if (Equipamentos.Count > 0)
            {
                cmbEquip.DisplayMember = "Display";
                cmbEquip.ValueMember = "Value";
            }
        }

        private void GetTipoReparacao()
        {
            ArrayList TipoReparacao = new ArrayList();

            SqlStr = "SELECT * FROM TipoReparacao";
            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    TipoReparacao.Add(new AddValue(dr[1].ToString(), Convert.ToInt32(dr[0].ToString())));
                }
            }
            dr.Close();
            cnn.Close();
            
            cmbTipoReparacao.DataSource = TipoReparacao;
            cmbTipoReparacao.DisplayMember = "Display";
            cmbTipoReparacao.ValueMember = "Value";
        }

        public void Gravar()
        {
            DateTime dt1 = dtDataInicio.Value;
            string strDataInicio = dt1.Year.ToString() + "-" + dt1.Month.ToString() + "-" + dt1.Day.ToString();

            idEquipamento = cmbEquip.SelectedValue.ToString();
            idLoja = cmbLoja.SelectedValue.ToString();
            idTipoReparacao = cmbTipoReparacao.SelectedValue.ToString();

            //Passou a gravar sempre a caixa de texto a 25/09/2012 segundo email
            /*if (cmbAcessorios.SelectedItem.ToString() == "Outros")
            {
                strAcessorios = "Outros - " + txtAcessorios.Text.ToString();
            }
            else
            {
                strAcessorios = cmbAcessorios.SelectedItem.ToString();
            }*/

            strAcessorios = cmbAcessorios.SelectedItem.ToString() + " - " + txtAcessorios.Text.ToString();

            //GRAVA CABEÇALHO SE NOVO
            if (strAction == "new")
            {                

                SqlStr = "INSERT INTO Assistencias (datainicio, registo, idloja, idcliente, idequipamento, idtipo, " +
                    @"descricaoassist, userid, acessorios) VALUES ('" + strDataInicio + "', '" + txtRegisto.Text + "', " + idLoja + ", " +
                    @"'" + idCliente + "', " + idEquipamento + ", " + idTipoReparacao + ", " +
                    @"'" + txtDescricaoServico.Text + "', " + strUserId + ", '" + strAcessorios + "')";

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
                    if (cnn.State == ConnectionState.Open) cnn.Close();
                }
                //frmMain.AvisoEmail(txtRegisto.Text, "ruivieira@mxmultimedia.com", "NovaAssistencia", "", "");
                frmMain.AvisoEmail(txtRegisto.Text, "pedrosimao@gmail.com", "NovaAssistencia", "", "");
            }

            //GRAVA CABEÇALHO SE EDITAR
            if (strAction == "edit")
            {
                SqlStr = "UPDATE Assistencias SET " +
                    @"idloja=" + idLoja + ", idcliente='" + idCliente + "', idequipamento=" + idEquipamento + ", " +
                    @"idtipo=" + idTipoReparacao + ", descricaoassist='" + txtDescricaoServico.Text + "', " +
                    @"userid=" + strUserId + ", acessorios='" + strAcessorios + "' WHERE registo='" + strRegisto + "'";

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
                    if (cnn.State == ConnectionState.Open) cnn.Close();
                }
            }
            
            //GRAVA LINHAS
            SqlStr = "DELETE FROM AssLinhas WHERE registo='" + strRegisto + "'";
            cmd = new MySqlCommand(SqlStr, cnn);
            try
            {
                if (cnn.State == ConnectionState.Closed) cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Clone();
            }
            catch (MySqlException se)
            {
                MessageBox.Show(se.Message);
                if (cnn.State == ConnectionState.Open) cnn.Close();
            }

            if (cnn.State == ConnectionState.Closed) cnn.Open();
            foreach (DataGridViewRow row in dgvLinhasAssist.Rows)
            {
                string descr = "";
                if (row.Cells["descr"].Value != null)
                {
                    descr = row.Cells["descr"].Value.ToString();
                }

                double quant = 1;
                if (row.Cells["quant"].Value != null)
                {
                    quant = Convert.ToDouble(row.Cells["quant"].Value);
                }

                double custo = 0;
                string strcusto = "";
                if (row.Cells["custo"].Value != null)
                {
                    custo = Convert.ToDouble(row.Cells["custo"].Value.ToString().Replace(".",","));
                    strcusto = custo.ToString().Replace(",",".");
                }

                string strDate = "";
                if (row.Cells["date"].Value != null)
                {
                    DateTime d = DateTime.Parse(row.Cells["date"].Value.ToString());
                    strDate = d.Year.ToString() + "-" + d.Month.ToString() + "-" + d.Day.ToString();
                }

                SqlStr = "INSERT INTO AssLinhas (registo, descricaolinha, quant, custo, dataassist, userid) VALUES (" +
                    @"'" + strRegisto + "', '" + descr + "', " + quant + ", " +
                    @"'" + strcusto + "', '" + strDate + "', " + strUserId + ")";
                cmd = new MySqlCommand(SqlStr, cnn);
                if(descr != "") cmd.ExecuteNonQuery();
            }
            cnn.Close();
            strAction = "edit";
            GetEdit();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Gravar();

            if (frmListagemAssistencias != null) frmListagemAssistencias.GetAssistencias();

            if (frmFichaCliente != null) frmFichaCliente.GetAssistencias();

            MessageBox.Show("Gravado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtNumCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetCliente();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Gravar();
            this.Close();
        }

        private void GetCabecAssist(string Registo)
        {
            SqlStr = "SELECT * FROM Assistencias WHERE registo='" + strRegisto + "'";
            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    idCliente = dr[4].ToString();
                    idLoja = dr[2].ToString();
                    idEquipamento = dr[5].ToString();
                    idTipoReparacao = dr[6].ToString();
                    strDescricao = dr[7].ToString();
                    strAcessorios = dr[13].ToString();
                    string strDataInicio = dr[1].ToString();
                    string[] DataInicio = strDataInicio.Split(new char[] { '-' });
                    int year = Convert.ToInt32(DataInicio[2].ToString().Substring(0, 4));
                    int month = Convert.ToInt32(DataInicio[1].ToString());
                    int day = Convert.ToInt32(DataInicio[0].ToString());
                    dtDataInicio.Value = new DateTime(year, month, day);
                }
            }
            dr.Close();
            cnn.Close();
        }

        private void GetLinhasAssist(string Registo)
        {
            double unit;
            double quant;
            double subtotal;
            double total = 0;
            dgvLinhasAssist.Rows.Clear();
            SqlStr = "SELECT * FROM AssLinhas WHERE registo='" + Registo + "'";
            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    unit = Convert.ToDouble(dr[4]);
                    quant = Convert.ToDouble(dr[3]);
                    dgvLinhasAssist.Rows.Add(dr[5],dr[2], quant, unit);
                    subtotal = unit * quant;
                    total = total + subtotal;
                }
            }
            dr.Close();
            cnn.Close();
            txtTotal.Text = String.Format("{0:N2}", total)+" €";
        }

        private void dgvLinhasAssist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvLinhasAssist.CurrentCell.ReadOnly = false;
        }

        private void dgvLinhasAssist_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DateTime today = DateTime.Today;
                string strDate = today.Day.ToString() + "-" + today.Month.ToString() + "-" + today.Year.ToString();
                dgvLinhasAssist.Rows[e.RowIndex].Cells["date"].Value = strDate;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Preview p = new Preview(strRegisto);
            p.MdiParent = this.MdiParent;
            p.Show();
        }

        private void btnNovoEquipamento_Click(object sender, EventArgs e)
        {
            Clientes.FichaCliente ficha = new Clientes.FichaCliente(strConn, idCliente, "edit", this, "Assist", strUserId, frmListagemClientes, idLoja, frmMain, null);
            ficha.MdiParent = this.MdiParent;
            ficha.Show();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            GetCliente();
        }

        private void btnAssistencia_Click(object sender, EventArgs e)
        {
            
        }

    }
}
