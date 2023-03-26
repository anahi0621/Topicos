using System;
using System.Windows.Forms;

namespace ExamenU2_HernandezAnahi
{
    public partial class frmPrincipal : Form
    {
        frmInformacion frm;

       

        public frmPrincipal()
        {
            InitializeComponent();

            this.pnl1.Anchor = System.Windows.Forms.AnchorStyles.None;
        }

        private void txtClaveProyecto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void txtCodigo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            MessageBox.Show("Usuario:\n" +
              "no ingrese letras\n" +
              MessageBoxButtons.OK);
        }

        private void txtNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtClaveProyecto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnVerificar_Click_1(object sender, EventArgs e)
        {
            Random Random = new Random();
            int codigo = Random.Next(100000, 999999);

            lblLineaVerificacion.Text = Convert.ToString(codigo);

            MessageBox.Show("Usuario:\n" +
                "Su registro se realizo\n" +
                "con el código de confirmacion: " + codigo,
                "Prestamo realizada correctamente",
                MessageBoxButtons.OK,
                MessageBoxIcon.Question);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTiposUsuario.SelectedIndex == 0)
            {
               
            }
            else if (cmbTiposUsuario.SelectedIndex == 1)
            {
               
            }
            else if (cmbTiposUsuario.SelectedIndex == 2)
            {
                
           
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario:\n" +
                "Se cerrara la aplicacion\n" +
                MessageBoxButtons.OK);

            this.Close();
        }

        private void btninformacionusuarios_Click(object sender, EventArgs e)
        {
            
           this.Hide();
            frm = new frmInformacion();
            frm.Show();
        }
    }
}

