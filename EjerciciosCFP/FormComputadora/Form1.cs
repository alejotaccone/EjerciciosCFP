using LibreriaDeComputadoras;
namespace FormComputadora
{
    public partial class Form1 : Form
    {
        
        List<Computadora> computadoras = new List<Computadora>();
        Computadora pc1 = new Computadora(16, 240, "I9", "Windows");


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.computadoras = new List<Computadora>();
            pc1.SetPrograma("Office"); 
            computadoras.Add(pc1);
            CargarDatos();
        }

        private void CargarDatos() {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = computadoras;
            
        }

        private void VaciarDatos()
        {
            dataGridView1.DataSource = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            formAlta.ShowDialog();
            if (formAlta.DialogResult == DialogResult.OK)
            {
                computadoras.Add(formAlta.NuevaPc);
                CargarDatos();
            }
        }

    }
}
