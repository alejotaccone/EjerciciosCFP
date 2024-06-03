
using LibreriaParcial;
using System.Windows.Forms;
namespace FormAuto
{
    public partial class FormAuto : Form
    {

        List<Auto> misAutos;
        public FormAuto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.misAutos = new List<Auto>();
            this.comboBox1.DataSource = Auto.ColoresValidos();
        }

        private void Limpiar()
        {
            this.textBoxMarca.Text = string.Empty;
            this.textBoxCombustible.Text = string.Empty;
            this.comboBox1.Text = string.Empty;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string marca = this.textBoxMarca.Text;
            string cantCombustible = this.textBoxCombustible.Text;
            Color color = (Color)this.comboBox1.SelectedItem;
             
            DialogResult respuesta;

            if (double.TryParse(cantCombustible, out double combValido))
            {
                Auto miAuto = new Auto(marca, combValido, color);

                respuesta = MessageBox.Show("Desea agregar este AUTO?","Agregar",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    misAutos.Add(miAuto);
                    MessageBox.Show("Auto agregado");
                }
                else
                {
                    MessageBox.Show("Auto no agregado");
                }

            }

            this.Limpiar();

        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            this.VaciarLST();
            //this.listBoxAuto.Items.AddRange(misAutos.ToArray());
            this.listBoxAuto.DataSource = misAutos.ToArray();
            
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            this.VaciarLST();
        }

        private void VaciarLST()
        {
            this.listBoxAuto.Items.Clear();
        }

        private void CargarCMB (List<Color> colores)
        {
            this.comboBox1.DataSource = colores;
        }


    }
}
