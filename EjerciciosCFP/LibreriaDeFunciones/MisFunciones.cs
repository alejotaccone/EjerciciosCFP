namespace LibreriaDeFunciones
{
    public  static class MisFunciones
    {

        public static int PedirEntero(string mensaje, string mensajeError)
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

        public static string PedirCadena(string mensaje)
        {
            string lectura;
            Console.WriteLine(mensaje);
            lectura = Console.ReadLine();

            return lectura;
        }

         public static int[] MostrarArrayEnteros(int cantidad)
        {
            int[] numeros = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = PedirEntero($"Ingrese el numero {i + 1} de {cantidad}: ", "El dato es incorrecto");
            }

            return numeros;
        }

        
        public static bool EsNumerico(string dato)
        {

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

        public static int Calculadora(int nroUno, int nroDos, char operador)
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

        //Ordenar un array de enteros de menor a mayor o de mayor a menor
        public static int[] OrdenarPorCriterio(int[] datos,bool ordenarMenor)
        {
            int aux;
            for (int i = 0; i < datos.Length; i++)
            {
                for (int j = i+1 ; j < datos.Length; j++)
                {

                    if ((ordenarMenor == true && (datos[i] > datos[j])) || (ordenarMenor == false && datos[i] < datos[j]))
                    {
                        
                            aux = datos[i];
                            datos[i] = datos[j];
                            datos[j] = aux;
                        
                    }
                  
                }
            }
            return datos ;
        }      

        //Mostrar los nros positivos o negativos de un array de enteros
        public static int[] MostrarMayorOMenor(string mensaje, int[] vector,bool mostrarPositivo)
        {

            Console.WriteLine(mensaje);
            foreach (int numero in vector)
            {
                if ((mostrarPositivo == true && numero > 0) || (mostrarPositivo == false && numero < 0) )
                {                  
                        Console.WriteLine(numero);                   
                }
            }
            return vector ;
        }
    }
}
