using LibreriaDeFunciones;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace EjemploFunciones2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //  Ingresar números en un vector, pueden ser positivos o negativos.Mostrar los negativos de forma creciente y los positivos de forma decreciente.
            //Ejemplo:
            //  Vector ingresado: { 5, 1, -9, -1, 9, 3, -2, 2}
            //  Vector ordenado: { -9, -2, -1, 9, 5, 3, 2, 1}

            int[] misNumeros = MisFunciones.MostrarArrayEnteros(8);

            misNumeros = MisFunciones.OrdenarPorCriterio(misNumeros,true);
            misNumeros = MisFunciones.OrdenarPorCriterio(misNumeros, false);

            MisFunciones.MostrarMayorOMenor("Positivos en forma decreciente", misNumeros, false);
            MisFunciones.MostrarMayorOMenor("Negativos en forma creciente", misNumeros, true);
        }
    }
}
