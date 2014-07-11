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
    public partial class P_CLientesFiltro : Form
    {
        string strFilterType;
        string strFilterValue;

        public P_CLientesFiltro()
        {
            InitializeComponent();
        }

        private void P_FiltroCliente_Load(object sender, EventArgs e)
        {

        }

        private void cAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cAll.Checked == true)
            {
                txtLocalidade.Enabled = false;
            }
        }

        private void Localidade_CheckedChanged(object sender, EventArgs e)
        {
            if (rLocal.Checked == true)
            {
                txtLocalidade.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rLocal.Checked == true)
            {
                strFilterType = "localidade";
                strFilterValue = txtLocalidade.Text;
            }

            if (cAll.Checked == true)
            {
                strFilterType = "todos";
                strFilterValue = "*";
            }

            P_Clientes pc = new P_Clientes(strFilterType, strFilterValue);
            pc.MdiParent = this.MdiParent;
            pc.Show();
        }
    }
}
