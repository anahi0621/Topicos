using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.U1
{
    public partial class frmCitas : Form
    {
        //instancia del formulario principal
        frmPrincipal frmPrincipal = new frmPrincipal();
        int i = 0;
        Boolean encontro = false;
        public frmCitas()
        {
            InitializeComponent();

            this.grdp.Anchor = System.Windows.Forms.AnchorStyles.None;
            dtpFecha.MinDate = DateTime.Now;
            dtpHora.Value = DateTime.Now;
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
            }
            else if (forma == "FormClosing")
            {

            }

            frmPrincipal.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void dtpFecha_Enter(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            dtgv.Rows.Add(txtboxCodigo.Text, txtboxNombre.Text, dtpFecha.Text, dtpHora.Text);

            Random Random = new Random();
            int codigo = Random.Next(100000,999999);

            lblConfirmacion.Text = Convert.ToString(codigo);

            MessageBox.Show("Paciente:\n" +
                "Su cita ha sido registrada\n" +
                "con el código de confirmacion: " + codigo,
                "Cita realizada correctamente",
                MessageBoxButtons.OK,
                MessageBoxIcon.Question);
        }

        private void txtboxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtboxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            //Se elimina  
            dtgv.Rows.Remove(dtgv.Rows[i]);
            MessageBox.Show("Su cita se cancelo");

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtboxCodigo.Text == "" || txtboxCodigo.Text == null)
            {
                MessageBox.Show("Se requiere código");
            }
            else
            {
                //vamos a buscar
                encontro = false;
                i = 0;
            }

            while (i < dtgv.Rows.Count - 1)
            {
                if (txtboxCodigo.Text == dtgv.Rows[i].Cells[0].Value.ToString())
                {
                    encontro = true;
                    //colocar los valores del gridview
                    txtboxCodigo.Text = dtgv.Rows[i].Cells[0].Value.ToString();
                    txtboxNombre.Text = dtgv.Rows[i].Cells[1].Value.ToString();
                    dtpFecha.Text = dtgv.Rows[i].Cells[2].Value.ToString();
                    dtpHora.Text = dtgv.Rows[i].Cells[3].Value.ToString();


                    i = dtgv.Rows.Count;
                }
                else
                {
                    i++;
                }//fin del else
            }//fin del while
             //preguntar por el valor de boolean que sea false
            if (encontro == false)
            {
                MessageBox.Show("Código no existe");
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDescripcion.SelectedIndex == 0)
            {
                lblCostos.Text = "120,000";
            }
            else if(cmbDescripcion.SelectedIndex == 1)
            {
                lblCostos.Text = "500";
            }
            else if (cmbDescripcion.SelectedIndex == 2)
            {
                lblCostos.Text = "200";
            }
            else if (cmbDescripcion.SelectedIndex == 3)
            {
                lblCostos.Text = "100";
            }

            CalcularTotal();
        }

        private void nudUnidades_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            try
            {
                decimal costo = Convert.ToDecimal(lblCostos.Text);
                decimal unidades = Convert.ToDecimal(txtboxUnidades.Text);

                decimal total = costo * unidades;

                lblTotal.Text = Convert.ToString(total);
            }
            catch (Exception)
            {
                lblTotal.Text = "";
            }
        }

        private void txtboxUnidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtboxUnidades_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal costo = Convert.ToDecimal(lblCostos.Text);
                decimal unidades = Convert.ToDecimal(txtboxUnidades.Text);

                CalcularTotal();
            }
            catch(Exception)
            {

            }

            
        }
    }
 }
    





