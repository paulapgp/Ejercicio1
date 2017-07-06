using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Principal
    {
        public string nombreApellidos { get; set; }
        public int edad { get; set; }
        public int año { get; set; }

    }

    public class Operaciones
    {
        public string CrearMensaje(Principal obj)
        {
            string cadena = "";

            cadena = "La persona seleccionada es : " + obj.nombreApellidos + " nacida en el año " + obj.año + " y edad " + obj.edad + " años";

            return cadena;
        }
    }
}
