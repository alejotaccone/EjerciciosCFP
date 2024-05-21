
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
            this.misAutos = new List<Auto>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.misAutos = new List<Auto>();
            this.comboBox1.Items.AddRange(Auto.ColoresValidos().ToArray());
        }

        private void Limpiar()
        {
            this.textBoxMarca.Text = string.Empty;
            this.textBoxCombustible.Text = string.Empty;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string marca = this.textBoxMarca.Text;
            string cantCombustible = this.textBoxCombustible.Text;
            string color = this.comboBox1.Text;


            if (double.TryParse(cantCombustible, out double combValido))
            {
                Auto miAuto = new Auto(marca, combValido, color);

                misAutos.Add(miAuto);

                this.listBoxAuto.Items.AddRange(misAutos.ToArray());
                
            }


            this.Limpiar();

        }

       
    }
}
