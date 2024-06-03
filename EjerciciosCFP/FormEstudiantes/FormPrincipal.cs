using EjercicioObj2;
namespace FormEstudiantes
{
    public partial class FormPrincipal : Form
    {

        private List<Estudiante> alumnos;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.alumnos = new List<Estudiante>();
            this.alumnos = Estudiante.ListaAlumnos();
            this.listBoxAlumnos.DataSource = this.alumnos;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            CargarDataGridAlumnos();

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


        private void CargarListarAlumnos ()
        {
            listBoxAlumnos.DataSource = null;
            listBoxAlumnos.DataSource = alumnos;
        }

        private void CargarDataGridAlumnos()
        {
            dataGridViewInfo.DataSource = null;
            dataGridViewInfo.DataSource = alumnos;
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {

            Random rdn = new Random();

            foreach (Estudiante item in alumnos)
            {
                item.NotaPrimerParcial = rdn.Next(1, 10);
                item.NotaSegundoParcial = rdn.Next(1, 10);
            }

        }
    }
}
