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
    public partial class frmPacientes : Form
    {
        //instancia del formulario principal
        frmPrincipal frmPrincipal = new frmPrincipal();
        int[] entradaDatos = {0,0,0,0};

        //variables globales

        public frmPacientes()
        {
            InitializeComponent();

            cmbDiagnostico.SelectedIndex = 0;

            this.grdp.Anchor = System.Windows.Forms.AnchorStyles.None;
        }

        //evento click del boton "salir"
        private void btnSalir_Click(object sender, EventArgs e)
        {
            ControlarCerradoFormulario("Button");
        }

        private void frmPacientes_FormClosing(object sender, FormClosingEventArgs e)
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

        //evento keypress del textbox "codigo"
        private void txtboxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //evento keypress del textbox "nombre"
        private void txtboxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //evento keypress del textbox "edad"
        private void txtboxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtboxCodigo_Enter(object sender, EventArgs e)
        {
            borrarIntruccion(sender, 0);
        }

        private void txtboxNombre_Enter(object sender, EventArgs e)
        {
            borrarIntruccion(sender, 1);
        }
        
        private void txtboxEdad_Enter(object sender, EventArgs e)
        {
            borrarIntruccion(sender, 2);
        }

        private void cmbDiagnostico_Enter(object sender, EventArgs e)
        {
            borrarIntruccion(sender, 3);
            
        }

        private void borrarIntruccion(object sender, int indiceEntradaDatos)
        {

            try
            {
                if (entradaDatos[3] == 0 && sender.GetType() == ((ComboBox)sender).GetType())
                {
                    cmbDiagnostico.Items.RemoveAt(cmbDiagnostico.SelectedIndex);
                    cmbDiagnostico.SelectedIndex = 0;
                }
            }catch(Exception ex)
            {

            }
            

            if (entradaDatos[indiceEntradaDatos] == 0)
            {
                ((Control)sender).Text = "";
                ((Control)sender).ForeColor = Color.LightSteelBlue;
                ((Control)sender).Font = new Font(((Control)sender).Font.FontFamily, 22);
            }
        }

        private void txtboxCodigo_Leave(object sender, EventArgs e)
        {
            ValidarEntradaDatos(sender, 0);
        }
        
        private void txtboxNombre_Leave(object sender, EventArgs e)
        {
            ValidarEntradaDatos(sender, 1);
        }
        
        private void txtboxEdad_Leave(object sender, EventArgs e)
        {
            ValidarEntradaDatos(sender, 2);
        }

        private void cmbDiagnostico_Leave(object sender, EventArgs e)
        {
            ValidarEntradaDatos(sender, 3);
        }

        private void ValidarEntradaDatos(object sender, int indiceEntradaDatos)
        {
            switch(indiceEntradaDatos)
            {
                case 0:
                    {
                        if (((TextBox)sender).Text.Length < txtboxCodigo.MaxLength)
                        {
                            entradaDatos[0] = 0;

                            ((TextBox)sender).Text = "INTRODUCE UN CODIGO VALIDO";
                            ((TextBox)sender).ForeColor = Color.Red;
                            ((TextBox)sender).Font = new Font(((TextBox)sender).Font.FontFamily, 12);

                            MessageBox.Show("Por favor: Introduce un codigo valido\n" +
                                "Debe contener:\n" +
                                "-Número de 6 digitos",
                                "Código erroneo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else
                        {
                            entradaDatos[0] = 1;
                        }

                        break;
                    }
                case 1:
                    {
                        if (((TextBox)sender).Text.Length < 12)
                        {
                            entradaDatos[1] = 0;

                            ((TextBox)sender).Text = "INTRODUCE UN NOMBRE VALIDO";
                            ((TextBox)sender).ForeColor = Color.Red;
                            ((TextBox)sender).Font = new Font(((TextBox)sender).Font.FontFamily, 12);

                            MessageBox.Show("Por favor: Introduce un nombre valido\n" +
                                "Debe contener:\n" +
                                "-Minimo 12 caracteres",
                                "Nombre erroneo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else
                        {
                            entradaDatos[1] = 1;
                        }

                        break;
                    }
                case 2:
                    {
                        if (((TextBox)sender).Text == "" || int.Parse(((TextBox)sender).Text) <= 0 || int.Parse(((TextBox)sender).Text) >= 100)
                        {
                            entradaDatos[2] = 0;

                            ((TextBox)sender).Text = "INTRODUCE UNA EDAD VALIDA";
                            ((TextBox)sender).ForeColor = Color.Red;
                            ((TextBox)sender).Font = new Font(((TextBox)sender).Font.FontFamily, 12);

                            MessageBox.Show("Por favor: Introduce una edad valida \n" +
                                "Debe contener:\n" +
                                "-Edad entre 0 años y 100 años",
                                "Edad erronea",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else
                        {
                            entradaDatos[2] = 1;
                        }

                        break;
                    }
                case 3:
                    {
                        if (((ComboBox)sender).SelectedIndex < 0)
                        {
                            entradaDatos[3] = 0;

                            ((ComboBox)sender).Text = "SELEECIONE UNA OPCION VALIDA";
                            ((ComboBox)sender).ForeColor = Color.Red;
                            ((ComboBox)sender).Font = new Font(((ComboBox)sender).Font.FontFamily, 12);

                            MessageBox.Show("Por favor: Seleccione una opción valida\n" +
                                "Debe contener:\n" +
                                "-Una opción de las listadas",
                                "Opción no valida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else
                        {
                            entradaDatos[3] = 1;
                        }

                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (entradaDatos[0] == 1 && entradaDatos[1] == 1 && entradaDatos[2] == 1 && entradaDatos[3] == 1)
            {
                dtgvRegistros.Rows.Add(txtboxCodigo.Text, txtboxNombre.Text, txtboxEdad.Text, cmbDiagnostico.Text);

                MessageBox.Show("Paciente:\n" +
                    "Su cita ha sido registrada\n" +
                    "con el código: " + txtboxCodigo.Text, 
                    "Cita realizada correctamente",
                MessageBoxButtons.OK,
                MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("Por favor:\n" +
                    "Ingrese correctamente la informacion solicitada\n" +
                    "antes de agregarla a los registros\n",
                    "Completar información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }
        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CalcularPromedioEdad(dtgvRegistros.Rows.Count);
        }

        private void CalcularPromedioEdad(int cantidadRegistros)
        {
            int suma = 0;

            try
            {
                for (int i = 0; i < cantidadRegistros; ++i)
                {
                    suma += Convert.ToInt32(dtgvRegistros.Rows[i].Cells[2].Value);
                }

                int promedio = suma / cantidadRegistros;

                lblPromedio.Text = "Promedio: " + Convert.ToString(promedio);
            }
            catch(Exception)
            {

            }
            
        }

        private void btnVerOcultar_Click(object sender, EventArgs e)
        {
            if(btnVerOcultar.Text == "Ver")
            {
                btnVerOcultar.Text = "Ocultar";
                dtgvRegistros.Visible = true;
                lblPromedio.Visible = true;
            }
            else if(btnVerOcultar.Text == "Ocultar")
            {
                btnVerOcultar.Text = "Ver";
                dtgvRegistros.Visible = false;
                lblPromedio.Visible = false;
            }
        }

        private void txtboxCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
