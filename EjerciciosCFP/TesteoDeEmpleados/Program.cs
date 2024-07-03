using LibreriaDeEmpleados;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace TesteoDeEmpleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // el método Main():
            //Crear instancias de Gerente, Desarrollador y Analista.
            //Llamar a los métodos Trabajar(), MostrarInfo() y CalcularBonificacion() para cada instancia.
            //Utilizar el casting para llamar a los métodos específicos de las clases derivadas(Planificar(),
            //DepurarCodigo() y PrepararInforme()).


            Empleado gerente1 = new Gerente("Marcelo Galperin",1000000,"Ventas",8,7);
            Empleado desarrollador1 = new Desarrollador("Carlos Tevez", 600000, "Ventas",5,"C#","Si");
            Empleado analista1 = new Analista("Sofía González", 550000,"Ventas", 2,"SQL","Base de datos de los clientes");

            List<Empleado> empleados = new List<Empleado>();

            empleados.Add(gerente1);
            empleados.Add(desarrollador1);
            empleados.Add(analista1);

            foreach (Empleado item in empleados)
            {
                Console.WriteLine($"--------- {item.GetType().Name} ---------");

                item.Trabajar();
                item.MostrarInfo();
                Console.WriteLine($"Bonificacion: {item.CalcularBonificacion()}");
                Console.WriteLine($"Sueldo final: {item.SueldoTotal()}");

                if (item is Gerente)
                {
                    Console.WriteLine(((Gerente)item).Planificar());
                    
                }
                else if (item is Desarrollador)
                {
                    Console.WriteLine(((Desarrollador)item).DepurarCodigo());
                    
                }
                else if (item is Analista)
                {
                    Console.WriteLine(((Analista)item).PrepararInforme());
                }

            }



        }
    }
}
