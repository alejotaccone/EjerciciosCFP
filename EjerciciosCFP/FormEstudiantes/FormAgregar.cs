using EjercicioObj2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEstudiantes
{
    public partial class FormAgregar : Form
    {



        private Estudiante nuevoAlumno;

        public FormAgregar()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            nuevoAlumno = new Estudiante(textBox1.Text, textBox2.Text, textBox3.Text);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public Estudiante MiAlumno
        {
            get
            {
                return nuevoAlumno;
            }
        }

    }
}
