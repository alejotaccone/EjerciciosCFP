using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioObj2
{
    public class Materia
    {
        private string nombre;
        //private int duracion;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Materia()
        {
            random = new Random();
        }


        public Materia(string nombre)
        {
            this.nombre = nombre;
            //this.duracion = duracion;
        }

        private int CalcularNotaFinal()
        {
            int nota = 0;
            if (notaPrimerParcial > 3 && notaSegundoParcial > 3)
            {
                nota = random.Next(6, 10);
            }

            return nota;
        }

        private double CalcularPromedio()
        {
            return ((double)notaPrimerParcial + notaPrimerParcial) / 2;
        }

        public override string? ToString()
        {
            return $"{nombre}";
        }

        public string Nombre { get => nombre; }
        //public int Duracion { get => duracion; }
        public int NotaPrimerParcial { get => notaPrimerParcial; set => notaPrimerParcial = value; }
        public int NotaSegundoParcial { get => notaSegundoParcial; set => notaSegundoParcial = value; }
        public int NotaFinal
        {
            get
            {
                return CalcularNotaFinal();
            }
            
        }
        public double Promedio
        {
            get
            {
                return CalcularPromedio();
            }

        }




    }


}
