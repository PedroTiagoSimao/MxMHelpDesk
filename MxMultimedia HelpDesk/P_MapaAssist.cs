﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace MxMultimedia_HelpDesk
{
    public partial class P_MapaAssist : Form
    {
        string idLoja;
        public P_MapaAssist(string Loja)
        {
            InitializeComponent();
            idLoja = Loja;
        }

        private void P_MapaAssist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mxmultim_MapaAssist.mapaassist_view' table. You can move, or remove it, as needed.
            this.mapaassist_viewTableAdapter.Fill(this.mxmultim_MapaAssist.mapaassist_view);
            
            ReportParameter Loja;

            if (idLoja == "5")
            {
                Loja = new ReportParameter("Loja", "0");
                this.reportViewer1.LocalReport.SetParameters(Loja);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                Loja = new ReportParameter("Loja", idLoja);
                this.reportViewer1.LocalReport.SetParameters(Loja);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
