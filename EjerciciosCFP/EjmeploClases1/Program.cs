using LibreriaDePersonas;

namespace EjmeploClases1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona primerEmpleado = new Persona(1, "Jorge", "Newman");
            Persona segundoEmpleado = new Persona(2, "George", "Gonzalez",250000,"Gerencia");
            Persona tercerEmpleado = new Persona(3, "Fernando", "Boole");

            Console.WriteLine(primerEmpleado.InformarDatos()); 
            Console.WriteLine($"Consulto sueldo empleado 2: {segundoEmpleado.GetSueldo()}");

            primerEmpleado.SetSueldo(15);

            Console.WriteLine($"Consulto sueldo empleado 1: {primerEmpleado.GetSueldo()}");

        }
    }
}
