using LibreriaDePersonas;
using System.Collections.Generic;

namespace EjmeploClases1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona primerEmpleado = new Persona(1, "Jorge", "Newman", 200000, "Gerencia");
            Persona segundoEmpleado = new Persona(2, "George", "Gonzalez",250000,"Gerencia");
            Persona tercerEmpleado = new Persona(3, "Fernando", "Boole", 150000, "Gerencia");

            //Console.WriteLine(primerEmpleado.InformarDatos()); 
            //Console.WriteLine($"Consulto sueldo empleado 2: {segundoEmpleado.GetSueldo()}");

            //primerEmpleado.SetSueldo(15);

            //Console.WriteLine($"Consulto sueldo empleado 1: {primerEmpleado.GetSueldo()}");

            List <Persona> ListaDePersonas = new List<Persona>();

            ListaDePersonas.Add( primerEmpleado);
            ListaDePersonas.Add(segundoEmpleado);
            ListaDePersonas.Add(tercerEmpleado);

            foreach (Persona item in ListaDePersonas)
            {
                Console.Write(item.InformarDatos);
            }

            Console.Write("Lista Desornedada");

            ListaDePersonas.Sort(CompararPersonasPorSueldo);

            Console.Write("Lista Ornedada");

            foreach (Persona item in ListaDePersonas)
            {
                Console.Write(item.InformarDatos);
            }

        }

        public static int CompararPersonasPorSueldo(Persona p1, Persona p2)
        {
            int result = 0;

            if (p1.GetSueldo() < p2.GetSueldo())
            {
                result = -1;
            }
            else
            {
                result = 1;
            }

            return result;
        }

    }
}
