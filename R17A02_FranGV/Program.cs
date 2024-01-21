namespace R17A02_FranGV
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // CONSTANTES


            // RECURSOS

            Producto Compra;

            // INICIALIZACION

            Compra = new Producto();

            // ENTRADA

            Compra.Nombre = Interfaz.SolicitarCadena("nombre");

            Compra.Precio = Interfaz.SolicitarFloat("precio", Compra);

            // PROCESO


            // SALIDA

            Interfaz.MostrarDatos(Compra.Nombre, Compra.Precio);
        }
    }
}