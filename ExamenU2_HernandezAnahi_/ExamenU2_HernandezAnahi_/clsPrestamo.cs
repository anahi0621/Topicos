using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU2_HernandezAnahi_
{
    class clsPrestamo : clsProyector
    {
        //atributos de la clase prestamo
        int codigo;
        string nombre;
        double bono;

        //metodo para realizar el calculo del bono en funcion del tipo de usuario
        public double CalcularBono(string tipoUsuario, double total)
        {
            //pregunta si el tipo de usuario es alumno
            if (tipoUsuario == "ALUMNO")
            {
                //realiza el calculo del bono de 3%
                bono = total * 0.03;
            }
            //pregunta si el tipo de usuario es docente
            else if (tipoUsuario == "DOCENTE")
            {
                //realiza el calculo del bono de 15%
                bono = total * 0.15;
            }
            //pregunta si el tipo de usuario es administrativo
            else if (tipoUsuario == "ADMINISTRATIVO")
            {
                //realiza el calculo del bono de 20%
                bono = total * 0.20;
            }

            //regresa el valor del bono
            return bono;
        }
    }
}
