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
    public partial class P_PagBalcao : Form
    {
        public string strFilterType;
        public string strFilterValue;

        public P_PagBalcao(string FilterType, string FilterValue)
        {
            InitializeComponent();
            strFilterType = FilterType;
            strFilterValue = FilterValue;
        }

        private void P_PagBalcao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mxmultim_PagBalcao.PagBalcao' table. You can move, or remove it, as needed.
            this.PagBalcaoTableAdapter.Fill(this.mxmultim_PagBalcao.PagBalcao);
            
            ReportParameter[] parameters = new ReportParameter[2];

            if (strFilterType == "day")
            {
                parameters[0] = new ReportParameter("dataStart", strFilterValue);
                parameters[1] = new ReportParameter("dataStop", strFilterValue);
            }

            if (strFilterType == "month")
            {
                parameters[0] = new ReportParameter("dataStart", "1-" + strFilterValue + "-2012");
                parameters[1] = new ReportParameter("dataStop", "31-" + strFilterValue + "-2012");
            }
            
            this.reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.RefreshReport();
        }
    }
}
