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
    public partial class Avisos : Form
    {
        Main frmMain;
        MySqlConnection cnn;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public string strRegisto;

        public Avisos(string Registo, Main MainForm)
        {
            InitializeComponent();
            frmMain = MainForm;
            strRegisto = Registo;
        }

        private void Avisos_Load(object sender, EventArgs e)
        {
            cnn = new MySqlConnection(frmMain.StrConn);
            GetAvisos();
        }

        private void GetAvisos()
        {
            string SqlStr = "SELECT * FROM Avisos WHERE registo='" + strRegisto + "'";
            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dgvAvisos.Rows.Add(dr[3], dr[2], dr[4]);
                }
            }
            dr.Close();
            cnn.Close();
        }
    }
}
