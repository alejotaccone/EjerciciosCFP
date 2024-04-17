namespace Ejercicio5String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.Pedir el ingreso de nombre y apellido separado por un espacio, guardar cada dato en una variable diferente y asegurarse de que respete el formato de la primera letra en mayúscula y el resto en minúsculas, mostrar el apellido y el nombre por separado.
            //ej: juAN ROBles(primero nombre luego apelido)
            //imprimir:
            //Apellido: Robles.
            //Nombre: Juan.

            string nombreCompleto;
            string nombre;
            string apellido;

            Console.WriteLine("Ingrese su nombre y apellido seprado con un espacio: ");
            nombreCompleto = Console.ReadLine();



            for (int i = 0; i < nombreCompleto.Length; i++)
            {
                
                if (i < nombreCompleto.Length - 1)
                {
                    Console.Write(" - ");
                }
            }



        }
    }
}
