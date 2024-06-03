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
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;



        public string Apellido { get => apellido; set => apellido = value; }
        public string Legajo { get => legajo; set => legajo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NotaPrimerParcial { 

            get => notaPrimerParcial;

            set 
            {
                if (value >=0 && value<=10)
                {
                    notaPrimerParcial = value;
                }
                else
                {
                    notaPrimerParcial = 0;
                }

            }
        }
        public int NotaSegundoParcial 
        { 
            get => notaSegundoParcial;
            set
            {
                if (value >= 0 && value <= 10)
                {
                    notaSegundoParcial = value;
                }
                else
                {
                    notaSegundoParcial = 0;
                }

            }
        }

        public double NotaFinal 
        {
            get
            {
                return this.CalcularNotaFinal();
            }
        
        }

        public double Promedio
        {
            get
            {
                return this.CalcularPromedio();
            }

        }


        static Estudiante()
        {
            random = new Random();
        }


        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int nota)
        {   
                this.notaPrimerParcial = nota;  
        }

        public void SetNotaSegundoParcial(int nota)
        {           
                this.notaSegundoParcial = nota;           
        }

        private double CalcularPromedio()
        {      
            return ((double)notaPrimerParcial + notaSegundoParcial) /2;
        }

        public double CalcularNotaFinal()
        {
            double notaFinal;

            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            { 
                notaFinal = random.Next(6, 10);
            }
            else
            {
                notaFinal = -1;
            }
            return notaFinal;
        }


        public string EstudianteToString2()
        {

           StringBuilder texto = new StringBuilder();
            double notaFinal = CalcularNotaFinal();
            string notaFinalText;


            texto.AppendLine($"Nombre: {nombre} {apellido}");
            texto.AppendLine($"Primer parcial: {notaPrimerParcial}");
            texto.AppendLine($"Segundo Parcial: {notaSegundoParcial}");
            texto.AppendLine($"Promedio: {CalcularPromedio()}");
            if (notaFinal != -1)
            {
                texto.AppendLine($"Nota Final: {notaFinal}");
            }
            else
            {
                texto.AppendLine("Alumno desaprobado");
            }
           
            
            return texto.ToString();
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
