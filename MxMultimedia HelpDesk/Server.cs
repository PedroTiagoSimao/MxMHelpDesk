using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MxMultimedia_HelpDesk
{
    public partial class Server : Form
    {
        Main frmMain;
        public string strServer;
        public string strUID;
        public string strPWD;
        public string strDatabase;

        public Server(Main mainForm)
        {
            InitializeComponent();
            frmMain = mainForm;
        }

        private void Server_Load(object sender, EventArgs e)
        {
            GetServerDetails();
            txtServidor.Text = strServer;
            txtDatabase.Text = strDatabase;
            txtUID.Text = strUID;
            txtPWD.Text = strPWD;
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

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string[] lines = { txtServidor.Text, txtUID.Text, txtPWD.Text, txtDatabase.Text };
            File.WriteAllLines(Application.StartupPath + @"\\server.txt", lines);
            Application.Restart();
        }
    }
}
