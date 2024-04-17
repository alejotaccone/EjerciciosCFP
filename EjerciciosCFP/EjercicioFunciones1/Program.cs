using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjercicioFunciones1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una función que evalúe si una palabra es corta o larga. Se considera larga si tiene más de 8 caracteres.

            PalabraCortaOLarga("Ingrese una palabra");

            

        }
        static string PalabraCortaOLarga(string mensaje)
        {
            string palabraEvaluada;
            string palabra;
            Console.WriteLine(mensaje);
            palabra = Console.ReadLine();

            if (palabra.Length > 8) 
            {
                palabraEvaluada = "La palabra es larga";
            }
            else
            {
                palabraEvaluada = "La palabra es corta";
            }
            Console.Write(palabraEvaluada);

            return palabra;
        }
    }
}
