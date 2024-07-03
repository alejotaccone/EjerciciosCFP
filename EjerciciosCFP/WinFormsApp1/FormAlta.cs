using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaIngresante;

namespace WinFormsApp1
{
    public partial class FormAlta : Form
    {
        Ingresante ingresante;
        public FormAlta()
        {
            InitializeComponent();
        }

        private void Alta_Load(object sender, EventArgs e)
        {
            lstPais.DataSource = new List<string>()
            {
                "Argentina","Colombia","Uruguay","Ecuador","Chile","Cuba"
            };
        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;
            int edad = (int)numEdad.Value;
            string genero = string.Empty;
            string pais = lstPais.SelectedItems.ToString();
            List<string> cursos = new List<string>();


            foreach (RadioButton rd in gpbGenero.Controls)
            {
                if (rd.Checked == true)
                {
                    genero = rd.Text;
                    break;
                }
            }

            foreach (CheckBox ck in gpbCursos.Controls)
            {
                if (ck.Checked == true)
                {
                    cursos.Add(ck.Text);
                }
            }

            Ingresante = new Ingresante(nombre, apellido, edad, genero, pais);

            DialogResult = DialogResult.OK;

        }

        public Ingresante Ingresante { get => ingresante; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        
    }
}
