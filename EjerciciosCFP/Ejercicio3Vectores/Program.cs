namespace Ejercicio3Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Idem punto 2, pero calcular el promedio.

            int[] numeros = MostrarArray(5);

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            double valorPromedio = CalcularPromedio(numeros);

            Console.WriteLine($"El promedio de todos los numeros es de: {valorPromedio}");

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


        static double CalcularPromedio(int[] numeros)
        {
            int suma = 0;
            double promedio;
            foreach (int numero in numeros)
            {
                suma += numero;
            }

            promedio = (double)suma / numeros.Length;

            return promedio;
        }
    }
}
    

