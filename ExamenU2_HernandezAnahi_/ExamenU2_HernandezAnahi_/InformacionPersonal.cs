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
    public partial class InformacionPersonal : Form
    {
        //-------------------------------------------------------CARGANDO EL FORMULARIO---------------------------------------------------------------
        public InformacionPersonal()
        {
            InitializeComponent();
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------



        //------------------------------------------------------------BOTON REGRESAR-------------------------------------------------------------------
        //metodo que controla el evento de el boton regresar
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------



        //------------------------------------------------------------BOTON CANCELAR-------------------------------------------------------------------
        //metodo que controla el evento del boton cancelar
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
    }
}
