using LibreriaDeRobots;
using System.Drawing;

namespace EjemploRobots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot r1 = new Robot("Robotito",50,30);
            Robot r2 = new Robot("chat",20,40);
            Robot r3 = new Robot("Bestia",30,30);
            Robot r4 = new Robot("Robotito2",10,15);
            Robot r5 = new Robot("RoboCOP",150,130);

            Console.WriteLine(r1.RobotToString());
            Console.WriteLine(r2.RobotToString());
            
            Console.WriteLine(r4.RobotToString());
            Console.WriteLine(r5.RobotToString());

            //if (r3.SetColor(Color.Blue))
            //{
            //    Console.WriteLine("Color cambiado con exito");
            //}
            //else {
            //    Console.WriteLine("No es un color permitido");
            //}
            //Console.WriteLine(r3.RobotToString());

            r3.RecibirDanio(r1.Atacar());

            Console.WriteLine(r3.GetVida());

        }
    }
}
