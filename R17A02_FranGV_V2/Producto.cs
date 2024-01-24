using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R17A02_FranGV_V2
{
    public class Producto
    {
        // - CONSTANTES PRIVADAS CLASE -


        private const float PRECIO_MAX = 350.0f;
        private const float PRECIO_MIN = 50.0f;

        private const float IVA = 0.21f;


        // - Miembros de Clase -

        private string _nombre;

        private float _precio;

        // - Propiedades -


        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }


        public float Precio
        {
            get
            {
                return _precio;
            }

            set
            {
                if (value > PRECIO_MAX) throw new Exception($"El precio supera el rango de valores establecido ({PRECIO_MIN} - {PRECIO_MAX}).");
                if (value < PRECIO_MIN) throw new Exception($"El precio es menor al rango de valores establecido ({PRECIO_MIN} - {PRECIO_MAX}).");

                _precio = value;
            }
        }





        // - Métodos - 

        public float PrecioIVA()
        {
            // RECURSOS

            float resultado = 0;

            if (Precio > 0) resultado = Precio * (IVA + 1);

            return resultado;
        }


    }
}
