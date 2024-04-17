namespace EjemploFunciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string nombre;
            //string apellido;
            //string direccion;

            //nombre = PedirCadena("Ingrese su nombre");
            //apellido = PedirCadena("Ingrese su apellido");
            //direccion = PedirCadena("Ingrese su direccion");
            //Console.WriteLine($"Ud es: {nombre} {apellido} y vive en: {direccion}");


            //----------------------------------------------------------------- FUNCION2

            //int unNumero = 8;
            //int otroNumero = 12;
            //int resultado;

            //resultado = Calculadora(unNumero, otroNumero, '+');

            //Console.WriteLine(resultado);

            //-----------------------------------------------------------------FUNCION 3 Y 4


            int numero = PedirEnteroConRangoV2("Ingrese un numero entre 10 y 50","NUMERO MAL",50,10);
            Console.WriteLine(numero);

            //Console.WriteLine("Ingrese un numero");
            //string numeroLeido = Console.ReadLine();


            //if (EsNumerico(numeroLeido))
            //{
            //    Console.WriteLine("Es un numero");
            //}
            //else
            //{
            //    Console.WriteLine("No e sun numero");
            //} 

        }
        //Una funcion para pedir el ingreso de una cadena y retornarla
        static string PedirCadena(string mensaje)
        {
            string lectura;
            Console.WriteLine(mensaje);
            lectura = Console.ReadLine();

            return lectura;
        }
        //Una funcion para sumar 2 numeros enteros
        static int SumarDeEnteros(int nroUno, int nroDos)
        {
            int resultado;
            resultado = nroUno + nroDos;

            return resultado;
        }
        //Una funcion calculadora
        static int Calculadora(int nroUno, int nroDos, char operador)
        {
            int resultado = 0;

            switch (operador)
            {
                case '+':
                    resultado = nroUno + nroDos;
                    break;
                case '-':
                    break;
                    resultado = nroUno - nroDos;
                case '*':
                    break;
                    resultado = nroUno * nroDos;
                case '/':
                    break;
                    resultado = nroUno / nroDos;
            }

            return resultado;
        }



        //-----------------------------------------------------------------

        //Pedir el ingreso de un numero entero entre un maximo y un minimo y retornarlo
        //static int PedirEnteroConRango(string mensaje, string mensajeError, int maximo, int minimo)
        //{
        //    string numeroLeido;
        //    int numeroValido = 0;

        //    Console.WriteLine(mensaje);
        //    numeroLeido = Console.ReadLine();


        //    while (!EsNumerico(numeroLeido) || int.Parse(numeroLeido) < maximo || int.Parse(numeroLeido) < minimo)
        //    {
        //        Console.WriteLine(mensajeError);
        //        Console.WriteLine(mensaje);
        //        numeroLeido = Console.ReadLine();
        //    }

        //    numeroValido = int.Parse(numeroLeido);


        //    return numeroValido;
        //}


        static int PedirEnteroConRangoV2(string mensaje, string mensajeError, int maximo, int minimo)
        {
            string numeroLeido;
            int numeroValido = 0;

            Console.WriteLine(mensaje);
            numeroLeido = Console.ReadLine();

            while (!int.TryParse(numeroLeido,out numeroValido) || numeroValido > maximo || numeroValido < minimo)
            {
                Console.WriteLine(mensajeError);
                Console.WriteLine(mensaje);
                numeroLeido = Console.ReadLine();
            }

            return numeroValido;
        }



        //cambiada por el tryparse de arriba
        static bool EsNumerico(string dato) {

            bool esNumerico = true;

            foreach (char digito in dato)
            {
                if (!char.IsDigit(digito))
                {
                    esNumerico = false;
                    break;
                }
            }

            return esNumerico;
        }
    }

}

