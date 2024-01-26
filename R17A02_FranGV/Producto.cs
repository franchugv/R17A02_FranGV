using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R17A02_FranGV
{
    public class Producto
    {
        // CONSTANTES PRIVADAS

        private const float PRECIO_MAX = 350.0f;    
                                                    // PRECIO MAXIM/MÍNIMO DEL PRODUCTO
        private const float PRECIO_MIN = 50.0f;


        // ************************************************************************


        private const float IVA_PRODUCTO = 21.0f;  // IVA PRODUCTO

        private const float IVA_NOESTABLECIDO = -1.0f;  // Solo en el caso de que el precio no se haya establecido 

        // MIEMBROS DE LA CLASE

        private string _nombre; // Nombre del producto

        private float _precio;  // Precio del producto

        // COSNSTRUCTORES

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Producto()
        {
            _nombre = "Desconocido";
            _precio = 0.0f;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nameP"></param>
        public Producto(string nameP)
        {
            _nombre = nameP;
            _precio = 0.0f;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="namep"></param>
        /// <param name="price"></param>
        public Producto(string namep, float price)
        {
            _nombre = namep;
            _precio = price;
        }



        // PROPIEDADES (Las propiededas siempren empiezan por mayuscula, sin parentesis)

        public string Nombre
        {
            get
            {   // LECTURA 
                return _nombre;
            }

            set
            {   // ESCRITURA
                _nombre = value;
            }
        }

        public float Precio
        {
            get
            {
                // Excepciones
                // Comprobación de valor establecido
                if (_precio == 0) throw new Exception("ERROR: Precio no estableciido");

               
                // Metodo Privado

                RedodearPrecio();

                // Lectura

                return _precio;
            }

            set
            {
                // VALIDACIÓN DE MAXIMOS Y MÍNIMOS

                if (value > PRECIO_MAX) throw new Exception($"ERROR: El precio supera el valor maximo ({PRECIO_MIN} - {PRECIO_MAX})");
                // VALIDACIÓN DE MAXIMOS Y MÍNIMOS
                if (value < PRECIO_MIN) throw new Exception($"ERROR: El precio es menor al valor maximo ({PRECIO_MIN} - {PRECIO_MAX})");


                // ESCRITURA
                _precio = value;
            }
        }

        public float PreciosIva
        {
            get
            {
                return PrecioIva();
            }
        }

        public float IVA
        {
            get
            {
                return PrecioIva();
            }
        }

        // MÉTODOS PRIVADOS

        public float PrecioIva()
        {
            // CONSTANTE
            const float IVA = 0.21f;

            // RECURSOS

            float precioIva = 0;


            // PROCESO
            try
            {
                precioIva = Precio * (1 + IVA);
            }
            catch (Exception error)
            {
                precioIva = -1;
            }

            return precioIva;


        }

        private void RedodearPrecio()   // Redonder a dos decimales
        {
            _precio = (float)Math.Round(_precio, 2);
        }

    }
}
