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

        private const float IVA_PRODUCTO = 21.0f;  // IVA PRODUCTO

        private const float IVA_NOESTABLECIDO = -1.0f;

        // MIEMBROS DE LA CLASE

        private string _nombre; // Nombre del producto

        private float _precio;  // Precio del producto



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
                if (_precio <= 0) throw new Exception("valor no establecido");

                // Metodo Privado
                
                PrecioIva();

                // Lectura

                return _precio;
            }

            set
            {
                // VALIDACIÓN DE MAXIMOS Y MÍNIMOS

                // ESCRITURA
                _precio = value;
            }
        }
        // MÉTODOS PRIVADOS

        private void PrecioIva()
        {

            // RECURSOS

            float IVA;
       

                IVA = (_precio * IVA_PRODUCTO) / (100);

                _precio = IVA + _precio;            
            

            if(_precio <= 0) _precio = _precio * IVA_NOESTABLECIDO / (100 + IVA_NOESTABLECIDO);    // precio no establecido
        }

    }
}
