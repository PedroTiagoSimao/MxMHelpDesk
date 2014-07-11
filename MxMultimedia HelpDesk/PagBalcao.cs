using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Threading;

namespace MxMultimedia_HelpDesk
{
    public partial class PagBalcao : Form
    {
        public string strConn;
        MySqlConnection cnn;
        MySqlDataAdapter da;
        MySqlCommandBuilder cb;
        DataTable dt;
        public string year;
        public string month;
        public string day;
        public string strLoja;
        public string strFilterType;
        public string strFilterValue;
        SaldoMensal frmSaldoMensal;

        int rowIndex;

        public PagBalcao(string SQLConnection, string Loja, SaldoMensal saldoMensal)
        {
            InitializeComponent();
            strConn = SQLConnection;
            strLoja = Loja;
            frmSaldoMensal = saldoMensal;
        }

        private void PagBalcao_Load(object sender, EventArgs e)
        {
            CultureInfo newCulture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            newCulture.NumberFormat.CurrencyDecimalSeparator = ",";
            System.Threading.Thread.CurrentThread.CurrentCulture = newCulture;

            dtp = new DateTimePicker();
            this.dtp.CloseUp += new System.EventHandler(dtp_Closeup);

            //dgvPagBalcao.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(dgvPagBalcao_CellEndEdit);

            ToolStripLabel dtpLabel = new ToolStripLabel();
            dtpLabel.Text = "Data";

            ToolStripButton btnPrint = new ToolStripButton();
            btnPrint.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnPrint.Text = "Imprimir";
            btnPrint.Click += new System.EventHandler(btnPrint_Click);

            ToolStripLabel monthLabel = new ToolStripLabel();
            monthLabel.Text = "Mês";

            comboMonth = new ToolStripComboBox();
            comboMonth.ComboBox.DropDownClosed += new System.EventHandler(comboMonth_DropDownClosed);

            ArrayList mes = new ArrayList();

            mes.Add(new AddValue("Janeiro", 1));
            mes.Add(new AddValue("Fevereiro", 2));
            mes.Add(new AddValue("Março", 3));
            mes.Add(new AddValue("Abril", 4));
            mes.Add(new AddValue("Maio", 5));
            mes.Add(new AddValue("Junho", 6));
            mes.Add(new AddValue("Julho", 7));
            mes.Add(new AddValue("Agosto", 8));
            mes.Add(new AddValue("Setembro", 9));
            mes.Add(new AddValue("Outubro", 10));
            mes.Add(new AddValue("Novembro", 11));
            mes.Add(new AddValue("Dezembro", 12));

            comboMonth.ComboBox.DataSource = mes;
            comboMonth.ComboBox.DisplayMember = "Display";
            comboMonth.ComboBox.ValueMember = "Value";

            ToolStripSeparator sep = new ToolStripSeparator();

            toolStrip.Items.Add(dtpLabel);
            toolStrip.Items.Add(new ToolStripControlHost(dtp));
            toolStrip.Items.Add(sep);
            toolStrip.Items.Add(monthLabel);
            toolStrip.Items.Add(comboMonth);
            toolStrip.Items.Add(sep);
            toolStrip.Items.Add(btnPrint);

            string[] strDate = dtp.Value.ToString().Substring(0, 10).Split(new Char[] { '-' });
            year = strDate[2];
            month = strDate[1];
            day = strDate[0];

            GetPagamentos("day");
            
            //Estruturação das colunas
            dgvPagBalcao.Columns["id"].Visible = false;
            dgvPagBalcao.Columns["data"].HeaderText = "Data";
            dgvPagBalcao.Columns["data"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPagBalcao.Columns["data"].ReadOnly = true;

            dgvPagBalcao.Columns["nome"].HeaderText = "Nome";
            dgvPagBalcao.Columns["nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgvPagBalcao.Columns["descr"].HeaderText = "Descrição";
            dgvPagBalcao.Columns["descr"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvPagBalcao.Columns["receita"].HeaderText = "Receita";
            dgvPagBalcao.Columns["receita"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPagBalcao.Columns["receita"].DefaultCellStyle.Format = "n2";

            dgvPagBalcao.Columns["despesa"].HeaderText = "Despesa";
            dgvPagBalcao.Columns["despesa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPagBalcao.Columns["despesa"].DefaultCellStyle.Format = "n2";

            dgvPagBalcao.Columns["lucro"].HeaderText = "Lucro";
            dgvPagBalcao.Columns["lucro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPagBalcao.Columns["lucro"].DefaultCellStyle.Format = "n2";
            dgvPagBalcao.Columns["lucro"].ReadOnly = true;

            dgvPagBalcao.Columns["loja"].HeaderText = "Loja";
            dgvPagBalcao.Columns["loja"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void GetPagamentos(string Filter)
        {
            cnn = new MySqlConnection(strConn);
            if (strLoja == "5")
            {
                if (Filter == "day") da = new MySqlDataAdapter("SELECT id, data,nome,descr,receita,despesa,lucro,loja FROM PagBalcao where data='" + year + "-" + month + "-" + day + "'", cnn);
                if (Filter == "month") da = new MySqlDataAdapter("SELECT id, data,nome,descr,receita,despesa,lucro,loja FROM PagBalcao where Month(data)='" + month + "'", cnn);
            }
            else
            {
                if (Filter == "day") da = new MySqlDataAdapter("SELECT id, data,nome,descr,receita,despesa,lucro,loja FROM PagBalcao where loja='" + strLoja + "' and data='" + year + "-" + month + "-" + day + "'", cnn);
                if (Filter == "month") da = new MySqlDataAdapter("SELECT id, data,nome,descr,receita,despesa,lucro,loja FROM PagBalcao where loja='" + strLoja + "' and Month(data)='" + month + "'", cnn);
            }
            cb = new MySqlCommandBuilder(da);
            dt = new DataTable();
            da.Fill(dt);

            /*if (Filter == "day") da = new MySqlDataAdapter("SELECT id, data,nome,descr,receita,despesa,lucro,loja FROM PagBalcao where data='" + year + "-" + month + "-" + day + "'", cnn);
            if (Filter == "month") da = new MySqlDataAdapter("SELECT id, data,nome,descr,receita,despesa,lucro,loja FROM PagBalcao where Month(data)='" + month + "'", cnn);
            da.UpdateCommand = new MySqlCommand("UPDATE PagBalcao SET data");*/

            dgvPagBalcao.DataSource = dt;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (strFilterType == null) strFilterType = "day";
            if (strFilterValue == null) strFilterValue = dtp.Value.ToString().Substring(0, 10);
            P_PagBalcao pb = new P_PagBalcao(strFilterType, strFilterValue);
            pb.MdiParent = this.MdiParent;
            pb.Show();
        }

        private void comboMonth_DropDownClosed(object sender, EventArgs e)
        {
            month = comboMonth.ComboBox.SelectedValue.ToString();
            strFilterType = "month";
            strFilterValue = month;
            GetPagamentos(strFilterType);
        }

        private void dgvPagBalco_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvPagBalcao.Rows[e.RowIndex].Cells["lucro"].Value = 0;
            DataGridViewCell cellReceita = dgvPagBalcao.Rows[e.RowIndex].Cells["receita"];
            DataGridViewCell cellDespesa = dgvPagBalcao.Rows[e.RowIndex].Cells["despesa"];
            DataGridViewCell cellLoja = dgvPagBalcao.Rows[e.RowIndex].Cells["loja"];
            DataGridViewCell cellNome = dgvPagBalcao.Rows[e.RowIndex].Cells["nome"];
            DataGridViewCell cellDescr = dgvPagBalcao.Rows[e.RowIndex].Cells["descr"];

            double receita = 0;
            double despesa = 0;
            double lucro = 0;

            if (cellReceita.Value != null)
            {
                if (cellReceita.Value.ToString() != "") receita = Convert.ToDouble(cellReceita.Value.ToString());
            }

            if (cellDespesa.Value != null)
            {
                if (cellDespesa.Value.ToString() != "") despesa = Convert.ToDouble(cellDespesa.Value.ToString());
            }
            else
            {
                cellDespesa.Value = 0;
            }

            lucro = receita - despesa;

            if (lucro > 0) dgvPagBalcao.Rows[e.RowIndex].Cells["lucro"].Value = lucro;

            da.Update(dt);

            //if (cellLoja.Value != null && cellNome.Value != null && cellDescr.Value != null) da.Update(dt);

            if (frmSaldoMensal != null)
            {
                Thread t = new Thread(frmSaldoMensal.setSaldo);
                t.Start();
            }
        }

        private void dtp_Closeup(Object sender, EventArgs e)
        {
            string[] strDate = dtp.Value.ToString().Substring(0, 10).Split(new Char[] { '-' });
            year = strDate[2];
            month = strDate[1];
            day = strDate[0];

            strFilterType = "day";
            strFilterValue = day + "-" + month + "-" + year;
            GetPagamentos(strFilterType);
        }

        private void dgvPagBalcao_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["data"].Value = dtp.Value.ToString().Substring(0, 10);
            e.Row.Cells["loja"].Value = strLoja;
        }

        private void dgvPagBalcao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                rowIndex = e.RowIndex;
            }
            else
            {
                rowIndex = 0;
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tem a certeza que pretende eliminar este registo?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                DataGridViewCell cellDescr = dgvPagBalcao.Rows[rowIndex].Cells["descr"];

                DataGridViewCell cellTipo = dgvPagBalcao.Rows[rowIndex].Cells["Nome"];

                string[] arrDescr = cellDescr.Value.ToString().Split(new char[] { '-' });

                string Registo = "";

                if (cellTipo.Value.ToString() == "Assistência")
                {
                    if (arrDescr[0] != "") Registo = arrDescr[0].Substring(3, 6);
                    clearPagamento(Registo);
                }

                dgvPagBalcao.Rows.RemoveAt(rowIndex);

                da.Update(dt);

                if (frmSaldoMensal != null)
                {
                    Thread t = new Thread(frmSaldoMensal.setSaldo);
                    t.Start();
                }

            }
        }

        private void clearPagamento(string Registo)
        {
            string SqlStr = "UPDATE Assistencias SET pago=0 WHERE registo='" + Registo + "'";

            MySqlCommand cmd = new MySqlCommand(SqlStr, cnn);

            try
            {
                if (cnn.State == ConnectionState.Closed) cnn.Open();

                cmd.ExecuteNonQuery();

                cnn.Close();
            }
            catch(MySqlException me)
            {
                MessageBox.Show(me.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
