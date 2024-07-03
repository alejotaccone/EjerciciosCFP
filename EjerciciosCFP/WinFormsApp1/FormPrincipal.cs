using Ingresantes;
namespace WinFormsApp1
{
    public partial class FormPrincipal : Form
    {
        List<Ingresante> Ingresantes;

        public FormPrincipal()
        {
            InitializeComponent();
            Ingresantes = new Lista<Ingresante>;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();

            formAlta.ShowDialog();
        }
    }
}
