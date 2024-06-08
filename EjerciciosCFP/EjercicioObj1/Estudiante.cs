using System.Drawing;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;

namespace EjercicioObj2
{

    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre; 
        

        public string Apellido { get => apellido; set => apellido = value; }
        public string Legajo { get => legajo; set => legajo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        


        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public static List<Estudiante> ListaAlumnos()
        {
            return new List<Estudiante>()
            {           
                new Estudiante("Alejo","Taccone","1001"),
                new Estudiante("Martin", "Palermo", "1002"),
                new Estudiante("Pichon", "Advincula", "1003"),
                new Estudiante("Leonel", "Messi", "1004"),
                new Estudiante("Roman", "Riquelme", "1005")
            };
        }

        public override string ToString()
        {
            return $"{apellido}, {nombre}";
        }












    }






    //public string EstudianteToString()
    //    {
            
    //        double notaFinal = CalcularNotaFinal();
    //        string notaFinalText;

    //        if (notaFinal != -1)
    //        {
    //            notaFinalText =  notaFinal.ToString();
    //        }
    //        else
    //        {
    //            notaFinalText = "Alumno desaprobado";
    //        }

    //        return $"Nombre: {nombre} | Apellido: {apellido} | Legajo: {legajo} | Primer parcial: {notaPrimerParcial} | Segundo Parcial: {notaSegundoParcial} | Promedio: {CalcularPromedio()} | Nota Final: {notaFinalText} ";
    //    }

    
}
