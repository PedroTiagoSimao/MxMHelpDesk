using System;
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
    public partial class P_Clientes : Form
    {
        string strFilterType;
        string strFilterValue;

        public P_Clientes(string FilterType, string FilterValue)
        {
            InitializeComponent();
            strFilterType = FilterType;
            strFilterValue = FilterValue;
        }

        private void P_Clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mxmultim_Clientes.Clientes' table. You can move, or remove it, as needed.
            this.ClientesTableAdapter.Fill(this.mxmultim_Clientes.Clientes);

            ReportParameter localidade = new ReportParameter();
            ReportParameter filtro = new ReportParameter();
            

            if (strFilterValue != null)
            {
                if (strFilterType == "localidade")
                {
                    localidade = new ReportParameter("localidade", strFilterValue);
                    filtro = new ReportParameter("filtro", "Localidade: " + strFilterValue);
                }

                if (strFilterType == "todos")
                {
                    localidade = new ReportParameter("localidade", strFilterValue);
                    filtro = new ReportParameter("filtro", "Localidade: Todas");
                }

                this.reportViewer1.LocalReport.SetParameters(localidade);
                this.reportViewer1.LocalReport.SetParameters(filtro);
            }

            this.reportViewer1.RefreshReport();
        }
    }
}
