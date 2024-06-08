using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioObj2
{
    public class Evaluacion
    {

        private Estudiante alumno;
        private List<Materia> materias;
        private string carrera;



        private Evaluacion()
        {
            this.materias = new List<Materia>();
        }

        


        private Evaluacion(Estudiante alumno, string carerra)
            :this()
        {
            this.alumno = alumno;
            this.carrera = carerra;
        }


        public Materia SetMateria
        {
            set
            {
                this.materias.Add(value);
            }
           
        }

        public List<Materia> Materias
        {
            get
            {
                return this.materias;
            }
        }

        public Estudiante Alumno
        {
            get
            { return this.alumno; }
        }


    }
}
