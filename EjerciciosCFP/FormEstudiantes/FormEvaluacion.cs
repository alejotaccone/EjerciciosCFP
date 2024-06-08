using EjercicioObj2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEstudiantes
{
    public partial class FormEvaluacion : Form
    {

        private Estudiante alumno;
        private List<Materia> materias;
        private string carrera;

        public FormEvaluacion()
        {
            InitializeComponent();
        }

        public FormEvaluacion(Estudiante alumno, List<Materia> materias, string carrera)
            :this()
        {
            this.alumno = alumno;
            this.materias = materias;
            this.carrera = carrera;
        }

        private void Load(object s, EventArgs e)
        {
            CargarLsb();
        }


        private void CargarLsb()
        {
            listBox1.Items.Add(alumno);
            listBox1.Items.Add($"Carrera: {carrera}");
            listBox1.Items.Add($"Lista de materias");
            foreach (Materia item in materias)
            {
                listBox1.Items.Add(item.Nombre);
            }
        }

        



    }
}
