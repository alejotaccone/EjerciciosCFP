using EjercicioObj2;
namespace FormEstudiantes
{
    public partial class FormPrincipal : Form
    {

        private List<Estudiante> alumnos;
        private List<Materia> materias;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.alumnos = new List<Estudiante>();
            this.alumnos = Estudiante.ListaAlumnos();
            this.materias = new List<Materia>();
            this.listBoxAlumnos.DataSource = this.alumnos;
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar formAlta = new FormAgregar();
            formAlta.ShowDialog();

            if (formAlta.DialogResult == DialogResult.OK && formAlta.MiAlumno is not null)
            {
                //uso propiedad MiAlumno para agregarlo a la lista
                alumnos.Add(formAlta.MiAlumno);
                CargarListarAlumnos();


            }
        }


        private void CargarListarAlumnos()
        {
            listBoxAlumnos.DataSource = null;
            listBoxAlumnos.DataSource = alumnos;
        }

        private void CargarListarMaterias()
        {
            listBoxMaterias.DataSource = null;
            listBoxMaterias.DataSource = materias;
        }



        private void btnEvaluar_Click(object sender, EventArgs e)
        {

            Random rdn = new Random();



        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            FormAgregarMaterias formAgregarMaterias = new FormAgregarMaterias();

            formAgregarMaterias.ShowDialog();

            if (formAgregarMaterias.DialogResult == DialogResult.OK)
            {
                materias.Add(formAgregarMaterias.MiMateria);
                CargarListarMaterias();
            }
        }

        private void btnEstadoAcademico_Click(object sender, EventArgs e)
        {

            Estudiante alumno = alumnos[0];
            List<Materia> lista = materias;
            string carrera = "Tec. Programacion";

            FormEvaluacion evaluacion = new FormEvaluacion(alumno,lista,carrera);
            evaluacion.ShowDialog();
        }

        


    }
}
