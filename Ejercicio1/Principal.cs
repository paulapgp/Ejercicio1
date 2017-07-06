using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Principal
    {
        public string nombreApellidos { get; set; } = "Paula Garcia Pasalodos";
        public int edad { get; set; } = 23;
        public int año { get; set; } = 1994;

    }

    public class Operaciones: Principal
    {
        public string CrearMensaje(Principal obj)
        {
            string cadena = "";

            cadena = "La persona seleccionada es : " + obj.nombreApellidos + " nacida en el año " + obj.año + " y edad " + obj.edad + " años";

            return cadena;
        }
    }
}
