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

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.P)
            {
                MessageBox.Show("CONTROL + P");

                this.Hide();

                frmPacientes = new frmPacientes();
                frmPacientes.Show();
            }

            if (e.Control && e.KeyCode == Keys.C)
            {
                MessageBox.Show("CONTROL + C");

                this.Hide();

                frmCitas = new frmCitas();
                frmCitas.Show();
            }

            if (e.Control && e.KeyCode == Keys.N)
            {
                MessageBox.Show("CONTROL + N");

                System.Diagnostics.Process.Start("https://www.gob.mx/imss");
            }

            if (e.Control && e.KeyCode == Keys.S)
            {
                DialogResult dialogResult = MessageBox.Show("CONTROL + S\n" +
                    "Estas seguro de que deseas salir:",
                    "¿Deseas salir?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);

                if (dialogResult == DialogResult.Yes)
                {
                    btnSalir_Click(sender, e);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void pacientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnPacientes_Click(sender, e);
        }

        private void tsmiCitas_Click(object sender, EventArgs e)
        {
            btnCitas_Click(sender, e);
        }

        private void tsmiNosotros_Click(object sender, EventArgs e)
        {
            btnNosotros_Click(sender, e);
        }

        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            btnSalir_Click(sender, e);
        }
    }
}
