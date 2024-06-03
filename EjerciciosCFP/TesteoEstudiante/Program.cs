using EjercicioObj2;
using TesteoEstudiante;
namespace TesteoEstudiante
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Estudiante estudiante6 = new Estudiante("Alejo", "Taccone", "1001");

            //estudiante6.Legajo = "1007";

            Random rand = new Random(); 

            List<Estudiante> alumnos = new List<Estudiante>
            {
                new Estudiante("Alejo","Taccone","1001"),
                new Estudiante("Martin", "Palermo", "1002"),
                new Estudiante("Pichon", "Advincula", "1003"),
                new Estudiante("Leonel", "Messi", "1004"),
                new Estudiante("Roman", "Riquelme", "1005")
            };

            foreach (Estudiante a in alumnos)
            {
                a.SetNotaPrimerParcial(rand.Next(1,10));
                a.SetNotaSegundoParcial(rand.Next(1, 10));
            }


            foreach (Estudiante item in alumnos)
            {
                Console.WriteLine(item.EstudianteToString2());
            }

        
        }
    }
}
