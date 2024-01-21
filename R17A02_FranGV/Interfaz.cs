using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R17A02_FranGV
{
    public static class Interfaz
    {


        public static string SolicitarCadena(string text)
        {
            // RECURSOS

            string dato;
            bool esValido;

            // INICIALIZACION

            dato = "";

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
                    Comprobaciones.ErrorCadena(dato);
                }
                catch (Exception Error)
                {
                    esValido = false;
                    Console.WriteLine($"Error: {Error.Message}");
                    Console.WriteLine("Pulse ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (!esValido);

            // PROCESO


            // SALIDA METODO

            return dato;
        }

        public static float SolicitarFloat(string text)
        {
            // RECURSOS

            string aux;
            float dato;
            bool esValido;

            // INICIALIZACION

            aux = "";
            dato = 0.0f;

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
                    dato = Comprobaciones.ErrorNum(aux);
                }
                catch (Exception Error)
                {
                    esValido = false;
                    Console.WriteLine($"Error: {Error.Message}");
                    Console.WriteLine("Pulse ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (!esValido);

            // PROCESO


            // SALIDA METODO

            return dato;
        }

        public static float SolicitarFloat(string text, Producto OBJ)
        {
            // RECURSOS

            string aux;
            float dato;
            bool esValido;

            // INICIALIZACION

            aux = "";
            dato = 0.0f;

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
                    OBJ.Precio = Comprobaciones.ErrorNum(aux);
                }
                catch (Exception Error)
                {
                    esValido = false;
                    Console.WriteLine($"Error: {Error.Message}");
                    Console.WriteLine("Pulse ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (!esValido);

            // PROCESO


            // SALIDA METODO

            return OBJ.Precio;
        }

         public static void MostrarDatos(string nombres, float precios)
        {
            // RECURSOS


            // INICIALIZACION 


            // ENTRADA

            // PROCESO

         

            Console.WriteLine($"Nombre producto:\t{nombres}");
            Console.WriteLine("*************************************************");
            Console.WriteLine($"Precio:\t{precios}");
           

            // SALIDA
        }    


    }
}
