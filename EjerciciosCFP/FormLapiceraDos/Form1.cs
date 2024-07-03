using LibreriaDeLapiceras;
namespace FormLapiceraDos
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

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            FormAltaDos formAlta = new FormAltaDos();
            formAlta.ShowDialog();
            if (formAlta.DialogResult == DialogResult.OK && formAlta.NuevaLapicera is not null)
            {
                lapiceras.Add(formAlta.NuevaLapicera);
                CargarLSTBOX();
            }
        }

        private void CargarLSTBOX()
        {
            lst_Mostrar.DataSource = null;
            lst_Mostrar.DataSource = lapiceras;
        }

        private void btn_Escribir_Click(object sender, EventArgs e)
        {
           Lapicera lapicera = lst_Mostrar.SelectedItem as Lapicera;
            lapicera.Escribir(5);
            CargarLSTBOX();
        }
    }
}
