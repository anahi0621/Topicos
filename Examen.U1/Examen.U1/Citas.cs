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
    public partial class frmCitas : Form
    {
        //instancia del formulario principal
        frmPrincipal frmPrincipal;

        public frmCitas()
        {
            InitializeComponent();

            this.grdp.Anchor = System.Windows.Forms.AnchorStyles.None;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ControlarCerradoFormulario("Button");
        }

        private void frmCitas_FormClosing(object sender, FormClosingEventArgs e)
        {
            ControlarCerradoFormulario("FormClosing");
        }

        private void ControlarCerradoFormulario(string forma)
        {
            if (forma == "Button")
            {
                this.Close();
            }else if(forma == "FormClosing")
            {

            }

            frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
