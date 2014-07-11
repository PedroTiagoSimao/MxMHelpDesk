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
    public partial class Login : Form
    {
        MySqlConnection cnn;
        MySqlCommand cmd;
        MySqlDataReader dr;
        Main mainForm;
        public string StrConn;
        public string UserID;
        public string SqlStr;

        public Login(string SQLConnection, Main MainF)
        {
            InitializeComponent();
            StrConn = SQLConnection;
            mainForm = MainF;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cnn = new MySqlConnection(StrConn);
            GetEmails();
        }

        private void GetEmails()
        {
            AutoCompleteStringCollection emails = new AutoCompleteStringCollection();
            SqlStr = "SELECT email FROM Users";
            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    emails.Add(dr[0].ToString());
                }
            }
            dr.Close();
            cnn.Close();
            txtEmail.AutoCompleteCustomSource = emails;
        }

        public void VerifyCredentials()
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string strTargetMensal = "";

            SqlStr = "SELECT * FROM Users WHERE email='" + email + "' and password='" + password + "'";
            cmd = new MySqlCommand(SqlStr, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    mainForm.getUserID(dr[0].ToString(), dr[1].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                    strTargetMensal = dr[5].ToString();
                }
                dr.Close();
                cnn.Close();
                if (strTargetMensal == "5") mainForm.openChilds();
                this.Close();
            }
            else
            {
                MessageBox.Show("Email ou password errado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dr.Close();
                cnn.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            VerifyCredentials();
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VerifyCredentials();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}
