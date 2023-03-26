using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenU2_HernandezAnahi
{
    public partial class frmInformacion : Form
    {
       frmPrincipal frmP;
        public frmInformacion()
        {
            InitializeComponent();
            this.pnl2.Anchor = System.Windows.Forms.AnchorStyles.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
             frmP = new frmPrincipal();
            frmP.Show();

        }
    }
}
