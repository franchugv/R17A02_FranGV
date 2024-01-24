namespace R17A02_FranGV_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // RECURSOS
            Producto Objeto;


            // INICIALIZACION

            Objeto = new Producto();


            // ENTRADA

            Objeto.Nombre = Interfaz.SolicitarCadena("nombre");

            Objeto.Precio = Interfaz.SolicitarNumero("precio", Objeto);


            // PROCESO


            // SALIDA

            Interfaz.MostrarDatos(Objeto.Nombre, Objeto.Precio, Objeto.PrecioIVA());


        }
    }
}