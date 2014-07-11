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
using System.Globalization;
using System.Threading;

namespace MxMultimedia_HelpDesk
{
    public partial class Income : Form
    {
        public string strConn;
        MySqlConnection cnn;
        MySqlDataAdapter da;
        MySqlCommandBuilder cb;
        DataTable dt;
        BindingSource source;
        public string year;
        public string month;
        public string day;
        public string strLoja;
        public string strFilterType;
        public string strFilterValue;
        public string strUser;
        SaldoMensal frmSaldoMensal;
        Main frmMain;

        int rowIndex;
        public string idIncome;

        public Income(Main main, SaldoMensal saldoMensal)
        {
            InitializeComponent();
            frmMain = main;
            frmSaldoMensal = saldoMensal;
        }

        private void Income_Load(object sender, EventArgs e)
        {
            strConn = frmMain.StrConn;
            strLoja = frmMain.strIdLoja;
            strUser = frmMain.strUserID;

            CultureInfo newCulture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            newCulture.NumberFormat.CurrencyDecimalSeparator = ",";
            System.Threading.Thread.CurrentThread.CurrentCulture = newCulture;

            setupToolBar();
            GetPagamentos("day");
            setupDataGrid();
        }

        private void setupDataGrid()
        {
            //Estruturação das colunas
            dgvIncome.Columns["idIncome"].Visible = false;
            dgvIncome.Columns["lojaIncome"].Visible = false;
            dgvIncome.Columns["userIncome"].Visible = false;

            dgvIncome.Columns["numIncome"].HeaderText = "Nº Cliente";
            dgvIncome.Columns["numIncome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgvIncome.Columns["yearIncome"].HeaderText = "Nº Cliente";
            dgvIncome.Columns["yearIncome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgvIncome.Columns["dateIncome"].HeaderText = "Data";
            dgvIncome.Columns["dateIncome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvIncome.Columns["dateIncome"].ReadOnly = true;

            dgvIncome.Columns["numcliente"].HeaderText = "Nº Cliente";
            dgvIncome.Columns["numcliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgvIncome.Columns["nomecliente"].HeaderText = "Nome";
            dgvIncome.Columns["nomecliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //dgvIncome.Columns["artIncome"].HeaderText = "Artigo";
            //dgvIncome.Columns["artIncome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            //dgvIncome.Columns["descrIncome"].HeaderText = "Descrição";
            //dgvIncome.Columns["descrIncome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //dgvIncome.Columns["quantIncome"].HeaderText = "Quant";
            //dgvIncome.Columns["quantIncome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dgvIncome.Columns["quantIncome"].DefaultCellStyle.Format = "n2";

            //dgvIncome.Columns["valueIncome"].HeaderText = "Valor";
            //dgvIncome.Columns["valueIncome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dgvIncome.Columns["valueIncome"].DefaultCellStyle.Format = "n2";

            dgvIncome.Columns["totalIncome"].HeaderText = "Total Documento";
            dgvIncome.Columns["totalIncome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvIncome.Columns["totalIncome"].DefaultCellStyle.Format = "C2";
            dgvIncome.Columns["totalIncome"].ReadOnly = true;
        }

        private void dgvIncome_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["dateIncome"].Value = dtp.Value.ToString().Substring(0, 10);
            e.Row.Cells["lojaIncome"].Value = strLoja;
            e.Row.Cells["userIncome"].Value = strLoja;
        }

        private void setupToolBar()
        {
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

            this.toolStrip1.Items.Add(dtpLabel);
            this.toolStrip1.Items.Add(new ToolStripControlHost(dtp));
            this.toolStrip1.Items.Add(sep);
            this.toolStrip1.Items.Add(monthLabel);
            this.toolStrip1.Items.Add(comboMonth);
            this.toolStrip1.Items.Add(sep);
            this.toolStrip1.Items.Add(btnPrint);

            string[] strDate = dtp.Value.ToString().Substring(0, 10).Split(new Char[] { '-' });
            year = strDate[2];
            month = strDate[1];
            day = strDate[0];
        }

        public void GetPagamentos(string Filter)
        {
            cnn = new MySqlConnection(strConn);
            //if (Filter == "day") da = new MySqlDataAdapter("SELECT idIncome, dateIncome, artIncome, descrIncome, quantIncome, valueIncome, totalIncome, lojaIncome, userIncome FROM Income where dateIncome='" + year + "-" + month + "-" + day + "'", cnn);
            if (Filter == "day") da = new MySqlDataAdapter("SELECT I.idIncome, I.numIncome, I.yearIncome, I.dateIncome, C.numcliente, C.nomecliente, sum(I.totalIncome) as totalIncome, I.lojaIncome, I.userIncome FROM Income as I left join Clientes as C on C.numcliente = I.clientIncome where I.dateIncome='" + year + "-" + month + "-" + day + "' group by I.yearIncome, I.numIncome", cnn);
            //if (Filter == "month") da = new MySqlDataAdapter("SELECT idIncome, dateIncome, artIncome, descrIncome, quantIncome, valueIncome, totalIncome, lojaIncome, userIncome FROM Income where Month(dateIncome)='" + month + "'", cnn);
            if (Filter == "month") da = new MySqlDataAdapter("SELECT I.idIncome, I.numIncome, I.yearIncome, I.dateIncome, C.numcliente, C.nomecliente, sum(I.totalIncome) as totalIncome, I.lojaIncome, I.userIncome FROM Income as I left join Clientes as C on C.numcliente = I.clientIncome where Month(dateIncome)='" + month + "' group by I.yearIncome, I.numIncome", cnn);
            cb = new MySqlCommandBuilder(da);
            dt = new DataTable();
            da.Fill(dt);
            source = new BindingSource();
            source.DataSource = dt;
            dgvIncome.DataSource = source;
        }

        private void dgvIncome_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                rowIndex = e.RowIndex;
                idIncome = dgvIncome.Rows[e.RowIndex].Cells["idIncome"].Value.ToString();

            }
            else
            {
                rowIndex = 0;
            }
        }

        private void dgvIncome_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IncomeAdd i = new IncomeAdd(frmMain, this, "edit", idIncome, frmMain.strUsername, frmMain.strIdLoja);
            i.MdiParent = this.MdiParent;
            i.Show();
        }

        private void comboMonth_DropDownClosed(object sender, EventArgs e)
        {
            month = comboMonth.ComboBox.SelectedValue.ToString();
            strFilterType = "month";
            strFilterValue = month;
            GetPagamentos(strFilterType);
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (strFilterType == null) strFilterType = "day";
            if (strFilterValue == null) strFilterValue = dtp.Value.ToString().Substring(0, 10);
            P_PagBalcao pb = new P_PagBalcao(strFilterType, strFilterValue);
            pb.MdiParent = this.MdiParent;
            pb.Show();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            IncomeAdd iadd = new IncomeAdd(frmMain, this, "novo", "", frmMain.strUsername, frmMain.strIdLoja);
            iadd.MdiParent = this.MdiParent;
            iadd.Show();
        }

    }
}
