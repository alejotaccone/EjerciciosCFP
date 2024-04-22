using System.Runtime.ConstrainedExecution;

namespace EjercicioFunciones3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se requiere la creación de una función que cumpla con los siguientes requisitos:
            //La función debe recibir tres parámetros: 'valor'(numérico), 'porcentaje'(numérico) y 'esAumento'(booleano).
            //Si el parámetro 'esAumento' es verdadero, la función debe aumentar el 'valor' original aplicando el 'porcentaje' dado.
            //Si el parámetro 'esAumento' es falso, la función debe disminuir el 'valor' original aplicando el 'porcentaje' dado.
            //El resultado obtenido después de aplicar el porcentaje al 'valor' original debe ser retornado por la función.

            Console.WriteLine(Funcion(10, 10, true));
            
            
        }

        static int Funcion(int valor, int porcentaje, bool esAumento) {
            int resultado = 0;
            int porcentaje2 = 0;
            
            porcentaje2 = valor * porcentaje / 100;       

            if (esAumento == true) {

                resultado = valor + porcentaje2;
            }
            else
            {
                resultado = valor - porcentaje2;
            }

            return resultado;
        }
    }
}
