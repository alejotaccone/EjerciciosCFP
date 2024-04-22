using LibreriaDeRobots;
using System.Drawing;

namespace EjemploRobots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot r1 = new Robot("Robotito",65,30);
            Robot r2 = new Robot("chat", 65, 40);


            int danioEmitio;
            int round = 1;
            do { 
                Console.WriteLine($"-------- Round: {round++} --------");
                
                Console.ForegroundColor = ConsoleColor.Blue;
                danioEmitio = r1.Atacar();
                Console.WriteLine($"{r1.GetNombre()} Lanzo un golpe de: {danioEmitio}");
                Console.WriteLine($"La resistencia de {r2.GetNombre()} es de: {r2.GetResistencia()}");
                r2.RecibirDanio(danioEmitio);
                Console.WriteLine($"{r2.GetNombre()} quedo con {r2.GetVida()} puntos de vida");

                Console.WriteLine(r2.GetResistencia());

                //
                Console.ResetColor();
                Console.WriteLine("CONTRA ATAQUE");

                
                Console.ForegroundColor = ConsoleColor.Red;
                danioEmitio = r2.Atacar();
                Console.WriteLine($"{r2.GetNombre()} Lanzo un golpe de: {danioEmitio}");
                Console.WriteLine($"La resistencia de {r1.GetNombre()} es de: {r1.GetResistencia()}");
                r1.RecibirDanio(danioEmitio);
                Console.WriteLine($"{r1.GetNombre()} quedo con {r1.GetVida()} puntos de vida");

                Console.WriteLine(r1.GetResistencia());


                Console.ResetColor();
            } while( (r2.GetVida() > 0 && r1.energia > 0) && (r1.GetVida() > 0 && r2.energia > 0));
            
            
            if (r1.GetVida() > r2.GetVida() )
            {
                Console.WriteLine($"El ganador es {r1.GetNombre()}!");
            }
            else
            {
                Console.WriteLine($"El ganador es {r2.GetNombre()}");
            }

            //if (r3.SetColor(Color.Blue))
            //{
            //    Console.WriteLine("Color cambiado con exito");
            //}
            //else {
            //    Console.WriteLine("No es un color permitido");
            //}
            //Console.WriteLine(r3.RobotToString());


            


        }
    }
}
