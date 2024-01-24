using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R17A02_FranGV_V2
{
    public static class Comprobaciones
    {
        public static void ErroresCadena(string cadena)
        {

            // COMPROBACIONES

            if (string.IsNullOrEmpty(cadena)) throw new Exception("Cadena vacía.");
        }

        public static float ErroresNumero(string cadena)
        {

            // RECURSOS

            float num = 0;

            // COMPROBACIONES

            if (string.IsNullOrEmpty(cadena)) throw new Exception("Cadena vacía.");

            // CONVERSIÓN

            num = Convert.ToSingle(cadena);

            // SALIDA 

            return num;
        }
    }
}
