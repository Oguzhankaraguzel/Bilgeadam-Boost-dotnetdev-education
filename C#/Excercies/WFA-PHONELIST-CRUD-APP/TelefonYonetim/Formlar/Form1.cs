using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelefonYonetim.Formlar;

namespace TelefonYonetim
{
    public partial class FRMTELEFONYONETIM : Form
    {
        public FRMTELEFONYONETIM()
        {
            InitializeComponent();
        }

        private void mnsTelDuzenle_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            TELEFONDUZENLEME tlfDuzenleme = new TELEFONDUZENLEME();
            tlfDuzenleme.MdiParent = this;
            tlfDuzenleme.WindowState= FormWindowState.Maximized;
            tlfDuzenleme.Show();
        }

        private void mnsTelListele_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            TELEFONLISTELEME tlfListeleme = new TELEFONLISTELEME();
            tlfListeleme.MdiParent = this;
            tlfListeleme.WindowState = FormWindowState.Maximized;
            tlfListeleme.Show();
        }
    }
}
