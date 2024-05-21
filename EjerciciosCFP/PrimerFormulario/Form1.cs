namespace PrimerFormulario
{
    public partial class Form1 : Form
    {

        string nombre;
        string apellido;
        string contrasenia;
        public Form1()
        {
            InitializeComponent();


        }
        private void btnIngresas_Click(object sender, EventArgs e)
        {
            this.nombre = txtNombre.Text;
            this.apellido = txtApellido.Text;
            this.contrasenia = txtContrasenia.Text;
            listBox1.Items.Add($"El nombre ingresado es: {this.nombre} {this.apellido}");
            listBox1.Items.Add($"Su contrasenia es: {this.contrasenia}");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = " ";
            txtApellido.Text = " ";
            txtContrasenia.Text = " ";
        }

        

       
    }
}
