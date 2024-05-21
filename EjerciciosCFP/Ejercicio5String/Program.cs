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
            


            Console.WriteLine("Ingrese su nombre y apellido seprado con un espacio: ");
            nombreCompleto = Console.ReadLine();

            string[] palabras = nombreCompleto.Split(' ');
            char[] arrayNombre = palabras[0].ToLower().ToCharArray();
            char[] arrayApellido = palabras[1].ToLower().ToCharArray();


            string nombre = arrayNombre.ToString();
            string apellido = arrayApellido.ToString();

            foreach (char letras in arrayNombre)
            {
                Console.Write(letras);
            }

            Console.Write(" ");

            foreach (char letras in arrayApellido)
            {

                Console.Write(letras);
            }

            Console.WriteLine($"nOMBRE;");
        }
    }
}
