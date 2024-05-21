using LibreriaDeProductos;

namespace PruebaDeProductos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto producto1 = new Producto("CocaCola 2.5l", 2500, "Gaseosa", 2 );
            Producto producto2 = new Producto("Chocolate Cofler Block 1 kilo", 15000,"Golosina",1);
            Producto producto3 = new Producto("Guaymayen", 500,"Golosina",38 );
            Producto producto4 = new Producto("Sprite 2.5l", 2500,"Gaseosa",2);
            Producto producto5 = new Producto("Choco Arroz", 650, "Golosina", 30);


            List<Producto> ListaDeProducto = new List<Producto>();

            ListaDeProducto.Add(producto1);
            ListaDeProducto.Add(producto2);
            ListaDeProducto.Add(producto3);
            ListaDeProducto.Add(producto4);
            ListaDeProducto.Add(producto5);

            foreach (Producto item in ListaDeProducto)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
