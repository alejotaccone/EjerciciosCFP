using LibreriaDeLapiceras;
namespace FormPrincipal
{
    public partial class Form1 : Form
    {
        List<Lapicera> lapiceras;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lapiceras = new List<Lapicera>();

        }

        private void CargarDGV()
        {
            dgv.DataSource = null;
            dgv.DataSource = lapiceras;
        }

        private void VaciarDGV()
        {
            dgv.DataSource = null;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            formAlta.ShowDialog();
            if (formAlta.DialogResult == DialogResult.OK && formAlta.NuevaLapicera is not null)
            {
                lapiceras.Add(formAlta.NuevaLapicera);
                CargarDGV();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VaciarDGV();
        }
    }
}
