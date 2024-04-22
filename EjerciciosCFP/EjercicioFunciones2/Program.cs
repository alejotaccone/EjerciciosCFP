namespace EjercicioFunciones2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una función que determine si el número recibido por parámetro es primo o no.


            Console.WriteLine("Ingrese un numero");
            int valor = int.Parse(Console.ReadLine());

            Console.WriteLine(NroPrimo(valor));

        }

        static string NroPrimo(int nro) {

            int cantidadDiv = 0;
            int div = 1;
            string resultado = string.Empty;

            while (div <= nro) {
                if (nro % div == 0)
                {
                    cantidadDiv++;
                }

                if (cantidadDiv <= 2)
                {
                    resultado = "El numero es primo";
                }
                else
                {
                    resultado = "El numero no es primo";
                }


                div++;
            }

            return resultado; 
        }


    }
}
