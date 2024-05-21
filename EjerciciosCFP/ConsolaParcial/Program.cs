using LibreriaParcial;
namespace ConsolaParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            Auto auto1 = new Auto("Ford", 65, "Blanco");
            int cont = 0;
            int cantKm;

            Console.WriteLine(auto1.AutoToString());

            Console.WriteLine("Ingrese la cantidad de km a recorrer: ");
            cantKm = int.Parse(Console.ReadLine());


            while (auto1.Avanzar(cantKm))
            {
                cont++;
            }



            Console.WriteLine($"El auto realizo {cont} vueltas");
            
        }
    }
}
