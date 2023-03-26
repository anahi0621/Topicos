using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenU2_HernandezAnahi_
{
    public partial class Prestamo : Form
    {

    //-------------------------------------------------------CARGANDO EL FORMULARIO---------------------------------------------------------------
        public Prestamo()
        {
            InitializeComponent();

            ValoresIniciales();
        }

        //metodo para establecer los valores inciales de los controles donde aplique
        private void ValoresIniciales()
        {
            //selecciona la opcion 1 del combobox "tipo"
            cmbBoxTipo.SelectedIndex = 0;

            dtpFecha.MinDate = DateTime.Now;
            dtpHoraSalida.Value = DateTime.Now;
            dtpHoraRegreso.Value = DateTime.Now;
        }
    //--------------------------------------------------------------------------------------------------------------------------------------------



    //------------------------------------------------------------BOTON PRESTAR-------------------------------------------------------------------
        private void btnPrestar_Click(object sender, EventArgs e)
        {
            //llama al metodo apra comprobar los valores nulos
            ComprobarValoresNulos();
        }

        //metodo para comprobar los valores nulos en los campos requeridos
        private void ComprobarValoresNulos()
        {
            // variable para saber que campos se dejaron vacios
            string valoresNulos = "";

            //si no se selecciona una opcion distinta en el comboBox entonces se deduce que quedo vacio el campo
            if (cmbBoxTipo.Text == "SELECCIONE UNA OPCIÓN")
            {
                valoresNulos += "Tipo de usuario\n";
            }

            //si no se introduce nada en codigo, entonces quedo vacio el campo
            if (txtBoxCodigo.Text == "")
            {
                valoresNulos += "Codigó\n";
            }

            //si no se introduce nada en nombre, entonces quedo vacio el campo
            if (txtBoxNombre.Text == "")
            {
                valoresNulos += "Nombre\n";
            }

            //si no se introduce nada en clave, entonces quedo vacio el campo
            if (txtBoxClave.Text == "")
            {
                valoresNulos += "Clave";
            }

            //si la variable valoresNulos tiene un valor distinto de vacio, entonces significa que quedaron campos vacios
            //despues se muestran en un messageBox
            if (valoresNulos != "")
            {
                MessageBox.Show("No ingrese valores nulos en los siguientes campos:\n" +
                    valoresNulos);

                lblVerificacion.Text = "Verificación: ";
            }
            else
            {
                ImprimirVerificacion(valoresNulos);
            }
        }

    //metodo para imprimir el numero de verificacion
        private void ImprimirVerificacion(string valoresNulos)
        {
            //crea una instancia de un objeto tipo random
            Random verificacionRandom = new Random();

            //genera un nuevo valor aleatorio
            int numVerificacion = verificacionRandom.Next(100000, 999999);

            MessageBox.Show("El prestamo se ha realizado correctamente con la\n" +
                "clave de verificación: " + numVerificacion, 
                "Prestamo realizado correctamente");

            //imprime el valor aleatorio
            lblVerificacion.Text = "Verificación: " + Convert.ToString(numVerificacion);
        }
    //--------------------------------------------------------------------------------------------------------------------------------------------



    //----------------------------------------------------------BOTON VERIFICAR-------------------------------------------------------------------
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //llama al metodo de verifica que se cuente con numero de verificacion
            ComprobarVerificacion();

        }

    //metodo para verificar que se cuente con un numero de verificacion
        private void ComprobarVerificacion()
        {
            //pregunta si el texto del label "verificacion" ha cambiado o no
            if (lblVerificacion.Text != "Verificación: ")
            {
                //llama al metodo para calcular el bono
                CalcularBono();
            }
        }

    //metodo para llamar al metodo que realiza el calculo del bono
        private void CalcularBono()
        {
            //crea una instancia nueva de la clase prestamo
            clsPrestamo prestamo1 = new clsPrestamo();

            //imprime el valor del bono segun el tipo de usuario al mismo tiempo que manda a llamar al metodo que realiza el calculo
            lblBono.Text = "Bono: " + Convert.ToString(prestamo1.CalcularBono(cmbBoxTipo.Text, 2000));
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------



        //----------------------------------------------------------BOTON REGRESAR-------------------------------------------------------------------
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            InformacionPersonal vtnInformacion = new InformacionPersonal();
            vtnInformacion.ShowDialog();
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------



        //----------------------------------------------------------BOTON CANCELAR-------------------------------------------------------------------
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //llama al metodo que muestra el mensaje de confirmacion de salida
            MostrarMensajeSalida();
        }

        //metodo para mostrar el mensaje de confirmacion de salida de la aplicacion
        private void MostrarMensajeSalida()
        {
            //crea un nuevo objeto de tipo dialogResult con los parametros del mensaje que se quiere mostrar al usuario
            DialogResult respuestaSalida = MessageBox.Show("¿CERRAR APLICACIÓN?", "¿DESEAS SALIR DE LA APLICACIÓN?\n" +
                "Cualquier cambio no guardado se perdera.", MessageBoxButtons.YesNo);

            //pregunta si se presiono el boton "YES"
            if (respuestaSalida == DialogResult.Yes)
            {
                //cierra la aplicacion
                Application.Exit();
            }
            //pregunta si se presiono el boton "NO"
            else if (respuestaSalida == DialogResult.No)
            {
                //no hace nada
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------



        ////----------------------------------------------------------COMPROBACION DE INGRESO DE DATOS-------------------------------------------------------------------
        private void cmbBoxTipo_Enter(object sender, EventArgs e)
        {
            if (cmbBoxTipo.Text == "SELECCIONE UNA OPCIÓN")
            {
                cmbBoxTipo.Items.RemoveAt(cmbBoxTipo.SelectedIndex);
                cmbBoxTipo.SelectedIndex = 0;
            }
        }

        private void txtBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------
    }
}
