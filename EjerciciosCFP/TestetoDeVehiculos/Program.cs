using LibreriaDeVehiculos;
namespace TestetoDeVehiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche miCoche = new Coche("Ford", "2024", 5, 40);
            Moto miMoto = new Moto("Susuki", "2024", "Moto",500);


            Console.WriteLine(miMoto.Conducir());
            Console.WriteLine(miMoto.MostrarInfo());

            Console.WriteLine(miCoche.Conducir());
            Console.WriteLine(miCoche.MostrarInfo());
            

            
            if (miCoche.GetType() == typeof(Coche))
            {
                Console.WriteLine(((Coche)miCoche).AbrirMaletero());
            }

            if (miMoto.GetType() == typeof(Moto))
            {
                Console.WriteLine(((Moto)miMoto).HacerCaballito());
            }
        }
    }
}
