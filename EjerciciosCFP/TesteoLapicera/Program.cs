using LibreriaDeLapiceras;
namespace TesteoLapicera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lapicera lapicera1 = new Lapicera(System.Drawing.Color.AliceBlue, 1000, "marca");

            int cantLetras;
            Console.WriteLine(lapicera1.ToString());
            string seguirEscribiendo = "si";
            while (seguirEscribiendo=="si")
            {
                Console.WriteLine("Ingrese la cantidad de letras");
                cantLetras = int.Parse(Console.ReadLine());

                lapicera1.Escribir(cantLetras);
                if (!lapicera1.Escribir(cantLetras))
                {
                    Console.WriteLine("La cantidad de tinta no es suficiente para escribir todas las letras");
                    break;
                }
                Console.WriteLine(lapicera1.NivelDeTinta);
                lapicera1.Recargar();
                Console.WriteLine(lapicera1.NivelDeTinta);
                Console.WriteLine("Quiere seguir escribiendo? si - no");
                seguirEscribiendo = Console.ReadLine();

            }
        }
    }
}
