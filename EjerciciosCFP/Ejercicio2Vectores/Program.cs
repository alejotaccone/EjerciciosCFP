using System.Numerics;

namespace Ejercicio2Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cargar un vector de enteros de 5 elementos, sumar los valores y mostrarlo.


            int[] numeros = MostrarArray(5);

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            int valorSuma = Sumar(numeros);

            Console.WriteLine($"La suma de todos los numeros es de: { valorSuma}");

        }

        static int[] MostrarArray(int cantidad)
        {
            int[] numeros = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = PedirEntero($"Ingrese el numero {i + 1} de {cantidad}: ", "El dato es incorrecto");
            }

            return numeros;
        }


        static int PedirEntero(string mensaje, string mensajeError)
        {
            string numeroLeido;
            int numeroValido = 0;

            Console.Write(mensaje);
            numeroLeido = Console.ReadLine();

            while (!int.TryParse(numeroLeido, out numeroValido))
            {
                Console.WriteLine(mensajeError);
                Console.WriteLine(mensaje);
                numeroLeido = Console.ReadLine();
            }

            return numeroValido;
        }


        static int Sumar(int[] numeros)
        {
            int suma = 0;
            foreach (int numero in numeros)
            {
                suma += numero;
            }
            return suma;
        }
    }
}
