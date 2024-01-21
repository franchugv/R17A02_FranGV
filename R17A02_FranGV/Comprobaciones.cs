using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R17A02_FranGV
{
    internal class Comprobaciones
    {

        public static void ErrorCadena(string cadena)
        {

            if (string.IsNullOrEmpty(cadena)) throw new Exception("Cadena Vacía");

        }

        public static float ErrorNum(string cadena)
        {

            // RECURSOS

            float dato;

            // INICIALIZACION

            dato = 0;

            // EXCEPCIONES

            if (string.IsNullOrEmpty(cadena)) throw new Exception("Cadena Vacía");

            // CONVERSION

            dato = Convert.ToSingle(cadena);

            return dato;

        }

    }
}
