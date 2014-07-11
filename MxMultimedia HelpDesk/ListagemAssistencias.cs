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
using CarlosAg.ExcelXmlWriter;
using System.Threading;
using System.Diagnostics;

namespace MxMultimedia_HelpDesk
{
    public partial class ListagemAssistencias : Form
    {
        MySqlConnection cnn;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public string strUserId;
        public string StrConn;
        public string SqlStr;
        public string IdLoja;
        public string strLoja;
        public string strRegisto;
        public string idAssistencia;
        public string strWhere;
        public string strOrder;
        Clientes.ListagemClientes frmListagemClientes;
        Main frmMain;

        public ListagemAssistencias(string SQlConnection, string Loja, string UserId, Clientes.ListagemClientes ListagemClientes, Main Main)
        {
            InitializeComponent();
            StrConn = SQlConnection;
            IdLoja = Loja;
            strUserId = UserId;
            frmListagemClientes = ListagemClientes;
            frmMain = Main;
        }

        private void ListagemAssistencias_Load(object sender, EventArgs e)
        {
            cnn = new MySqlConnection(StrConn);
            GetLojas();
            cmbLoja.ComboBox.SelectedValue = Convert.ToInt64(IdLoja);
            strWhere = "WHERE Assistencias.datafim like '1999-01-01' and idloja=" + IdLoja;
            strOrder = "ORDER by Assistencias.datainicio DESC";
            strWhere = " where Assistencias.idloja=" + IdLoja;
            GetAssistencias();
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
            Lojas.Add(new AddValue("", 0));
            
            if (IdLoja == "5")
            {
                SqlStr = "SELECT * FROM Lojas";
            }
            else
            {
                SqlStr = "SELECT * FROM Lojas where id=" + IdLoja;
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

            cmbLoja.ComboBox.DataSource = Lojas;
            cmbLoja.ComboBox.DisplayMember = "Display";
            cmbLoja.ComboBox.ValueMember = "Value";
        }

        public void GetAssistencias()
        {
            dgvAssistencias.Rows.Clear();

            SqlStr = "SELECT Assistencias.datainicio, Assistencias.registo, " +
                @"Clientes.nomecliente, Assistencias.datafim, Lojas.Localizacao, Equipamentos.serie " +
                @"FROM Assistencias " +
                @"LEFT JOIN Clientes on Clientes.numcliente = Assistencias.idcliente " +
                @"left join Equipamentos on Equipamentos.numequip=Assistencias.idequipamento " +
                @"LEFT JOIN Lojas on Assistencias.idloja=Lojas.id " + strWhere + " " + strOrder;

            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dgvAssistencias.Rows.Add(dr[0], dr[1], dr[2], dr[4], dr[3].ToString().Substring(0,10));
                }
            }
            dr.Close();
            cnn.Close();
        }

        private void EliminarAssistencia(string Registo)
        {
            DialogResult dr = MessageBox.Show("Tem a certeza que deseja eliminar esta Assistência?", "Confirme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
            if (dr == DialogResult.Yes)
            {
                string strDeleteAssist = "DELETE FROM Assistencias WHERE registo='" + Registo + "'";
                string strDeleteLinhas = "DELETE FROM AssLinhas WHERE registo='" + Registo + "'";
                cmd = new MySqlCommand(strDeleteAssist, cnn);

                try
                {
                    if (cnn.State == ConnectionState.Closed) cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
                catch (MySqlException se)
                {
                    MessageBox.Show(se.Message, "Erro ao eliminar Assistência", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cmd = new MySqlCommand(strDeleteLinhas, cnn);
                try
                {
                    if (cnn.State == ConnectionState.Closed) cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
                catch (MySqlException se)
                {
                    MessageBox.Show(se.Message, "Erro ao eliminar Serviços de Assistência", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                GetAssistencias();
            }
        }

        private void dgvAssistencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewCell cellRegisto = dgvAssistencias.Rows[e.RowIndex].Cells["registo"];
                strRegisto = cellRegisto.Value.ToString();
            }
        }

        private void dgvAssistencias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && strRegisto != null)
            {
                Assistencia a = new Assistencia(StrConn, IdLoja, "edit", strRegisto, this, strUserId, frmListagemClientes, "", null, null);
                a.MdiParent = this.MdiParent;
                a.Show();
            }
        }

        private void cmbLoja_DropDownClosed(object sender, EventArgs e)
        {
            IdLoja = cmbLoja.ComboBox.SelectedValue.ToString();
            if (IdLoja == "5")
            {
                strWhere = "";
            }
            else
            {
                strWhere = "WHERE idloja=" + IdLoja;
            }
            GetAssistencias();
        }

        private void btnAssistencia_Click(object sender, EventArgs e)
        {
            Assistencia A = new Assistencia(StrConn, IdLoja, "new", "", this, strUserId, frmListagemClientes, "", frmMain, null);
            A.MdiParent = this.MdiParent;
            A.Show();
        }

        private void definirSaídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes.DefinirSaida saida = new Clientes.DefinirSaida(StrConn, strRegisto, null, this, null);
            saida.MdiParent = this.MdiParent;
            saida.Show();
        }

        private void btnFilterAll_Click(object sender, EventArgs e)
        {
            if (IdLoja == "5")
            {
                strWhere = "";
            }
            else
            {
                strWhere = "WHERE idloja=" + IdLoja;
            }
            
            GetAssistencias();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (IdLoja == "5")
            {
                strWhere = "WHERE registo like '%" + txtRegisto.Text + "%' or serie like '%" + txtRegisto.Text + "%'";
            }
            else
            {
                strWhere = "WHERE registo like '%" + txtRegisto.Text + "%' or serie like '%" + txtRegisto.Text + "%' and idloja=" + IdLoja;
            }
            GetAssistencias();
        }

        private void txtRegisto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (IdLoja == "5")
                {
                    strWhere = "WHERE registo like '%" + txtRegisto.Text + "%' or serie like '%" + txtRegisto.Text + "%'";
                }
                else
                {
                    strWhere = "WHERE registo like '%" + txtRegisto.Text + "%' or serie like '%" + txtRegisto.Text + "%' and idloja=" + IdLoja;
                }
                GetAssistencias();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarAssistencia(strRegisto);
            //if (frmFichaCliente != null) frmFichaCliente.GetAssistencias();
            
        }

        private void btnPendentes_Click(object sender, EventArgs e)
        {
            if (IdLoja == "5")
            {
                strWhere = " WHERE Assistencias.datafim like '1999-01-01' ";
            }
            else
            {
                strWhere = " WHERE Assistencias.datafim like '1999-01-01' and idloja=" + IdLoja + " ";
            }
            
            GetAssistencias();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = GetExcelSaveFileDialog())
            {
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;

                    Workbook workbook = DataGridViewToExcel.ExcelGenerator.Generate(this.dgvAssistencias);
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
