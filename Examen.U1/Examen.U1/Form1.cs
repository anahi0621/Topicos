using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.U1
{
    public partial class frmPrincipal : Form
    {
        //instancias de formularios hijos
        frmPacientes frmPacientes;
        frmCitas frmCitas;

        public frmPrincipal()
        {
            InitializeComponent();

            this.grdp.Anchor = System.Windows.Forms.AnchorStyles.None;
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmPacientes = new frmPacientes();
            frmPacientes.Show();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmCitas = new frmCitas();
            frmCitas.Show();
        }

        private void btnNosotros_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gob.mx/imss");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
