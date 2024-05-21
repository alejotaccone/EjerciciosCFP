using LibreriaDeCohetes;
using System.Diagnostics;
using System.Reflection;


namespace TesteoDeCohetes
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            CoheteEspacial coheteEspacial1 = new CoheteEspacial("Falcon Heavy", 70, 550, 27, "SpaceX", 48000);
            CoheteEspacial coheteEspacial2 = new CoheteEspacial("Saturn V", 111, 2970, 5, "NASA", 11000);
            CoheteEspacial coheteEspacial3 = new CoheteEspacial("Apollo-Soyuz", 68, 440, 5, "NASA y Agencia Espacial Soviética", 7800);
            CoheteEspacial coheteEspacial4 = new CoheteEspacial("Vostok", 28, 287, 1, "Agencia Espacial Soviética", 28000);

            List<CoheteEspacial> listaDeCohetes = new List<CoheteEspacial>();
            listaDeCohetes.Add(coheteEspacial1);
            listaDeCohetes.Add(coheteEspacial2);
            listaDeCohetes.Add(coheteEspacial3);
            listaDeCohetes.Add(coheteEspacial4);

            //foreach (CoheteEspacial item in listaDeCohetes)
            //{
            //    Console.WriteLine(item.MostrarDatos());
            //}

            Console.WriteLine("Bienvenido a Mision de Control");

            // SELECCION DE COHETE

            Console.WriteLine("Elige un cohete para el viaje: ");
            for (int i = 0; i < listaDeCohetes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {listaDeCohetes[i].GetNombre()}");
            }

            int seleccion;
            do
            {
                Console.Write("Selecciona el número del cohete: ");
            } while (!int.TryParse(Console.ReadLine(), out seleccion) || seleccion < 1 || seleccion > listaDeCohetes.Count);

           
            CoheteEspacial coheteSeleccionado = listaDeCohetes[seleccion - 1];

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Has seleccionado el cohete: {coheteSeleccionado.GetNombre()}");
            Console.ForegroundColor = ConsoleColor.White;

            // SELECCION DE PLANETA


            List<string> ListaDeDestinos = new List<string>
            {
                "luna",
                "Mercurio",
                "Venus",
                "Luna",
                "Marte",
                "Júpiter",
                "Saturno",
                "Urano",
                "Neptuno",
                "Plutón",
            };
    

            double distancia =0;
            

            Console.WriteLine("Elige un destino para el viaje: ");
            for (int i = 0; i < ListaDeDestinos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ListaDeDestinos[i]}");
            }

            int seleccionDestino;
            do
            {
                Console.Write("Selecciona el número del destino: ");
            } while (!int.TryParse(Console.ReadLine(), out seleccionDestino) || seleccionDestino < 1 || seleccionDestino > ListaDeDestinos.Count);


            string destino = ListaDeDestinos[seleccionDestino - 1];

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Has seleccionado: {destino}");
            Console.ForegroundColor = ConsoleColor.White;


            switch (destino)
            {
                case "luna":
                    distancia = 384400;
                    break;
                case "mercurio":
                    distancia = 57910000;
                    break;
                case "venus":
                    distancia = 108200000;
                    break;
                case "marte":
                    distancia = 227940000;
                    break;
                case "jupiter":
                    distancia = 778330000;
                    break;
                case "saturno":
                    distancia = 1424600000;
                    break;
                case "urano":
                    distancia = 2873550000;
                    break;
                case "neptuno":
                    distancia = 4497100000;
                    break;
                case "pluton":
                    distancia = 5913520000;
                    break;
            }



            Console.WriteLine($"La distancia a reccorer es de: {distancia}");
            Console.WriteLine($"Tiempo total del recorrido: {coheteSeleccionado.CalcularTiempoDeViaje(distancia)} dias");


        }
    }
}
