using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MxMultimedia_HelpDesk
{
    public partial class Preview : Form
    {
        public string strRegisto;

        public Preview(string Registo)
        {
            InitializeComponent();
            strRegisto = Registo;
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mxmultim_Assistencias.assistencias_view' table. You can move, or remove it, as needed.
            assistencias_viewBindingSource.Filter = String.Format("registo='{0}'", strRegisto);
            this.assistencias_viewTableAdapter.Fill(this.mxmultim_Assistencias.assistencias_view);
            this.reportViewer1.RefreshReport();
        }
    }
}
