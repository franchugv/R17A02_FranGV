using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R17A02_FranGV_V2
{
    public static class Interfaz
    {

        #region ENTRADA

        public static string SolicitarCadena(string text)
        {
            // RECURSOS

            string dato;

            bool esValido;



            // INICIALIZACION

            dato = "";

            esValido = true;

            // ENTRADA

            do
            {

                // RESET

                esValido = true;

                // SOLICITUD DATO

                Console.Write($"Escriba su {text}: ");
                dato = Console.ReadLine();

                try
                {
                    Comprobaciones.ErroresCadena(dato);
                }
                catch(Exception Error)
                {
                    esValido = false;
                    Console.WriteLine($"Error {Error.Message}");
                }

            }while (!esValido);

            // PROCESO


            // SALIDA

            return dato;
        }

        public static float SolicitarNumero(string text, Producto OBJ)
        {
            // RECURSOS


            bool esValido;

            string aux;



            // INICIALIZACION


            aux = "";

            esValido = true;

            // ENTRADA

            do
            {

                // RESET

                esValido = true;

                // SOLICITUD DATO

                Console.Write($"Escriba su {text}: ");
                aux = Console.ReadLine();

                try
                {
                    OBJ.Precio = Comprobaciones.ErroresNumero(aux);
                }
                catch (Exception Error)
                {
                    esValido = false;
                    Console.WriteLine($"Error {Error.Message}");
                }

            } while (!esValido);

            // PROCESO


            // SALIDA

            return OBJ.Precio;
        }

        #endregion

        public static void MostrarDatos(string name, float num, float numiva)
        {


            Console.WriteLine($"Nombre: {name}");
            Console.WriteLine($"Precio: {num}");
            Console.WriteLine($"Precio + IVA: {numiva}");

        }


    }
}
