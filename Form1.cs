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
    public partial class frmPrincipal : Form
    {
       

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtClaveProyecto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Random Random = new Random();
            int codigo = Random.Next(100000, 999999);

            lblLineaVerificacion.Text = Convert.ToString(codigo);

            MessageBox.Show("Paciente:\n" +
                "Su registro se realizo\n" +
                "con el código de confirmacion: " + codigo,
                "Prestamo realizada correctamente",
                MessageBoxButtons.OK,
                MessageBoxIcon.Question);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

