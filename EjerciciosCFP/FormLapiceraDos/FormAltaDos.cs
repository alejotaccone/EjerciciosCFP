using LibreriaDeLapiceras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLapiceraDos
{
    public partial class FormAltaDos : Form
    {
        List<Color> colores;
        Lapicera nuevaLapicera;
        public FormAltaDos()
        {
            InitializeComponent();
        }
        private void FormAltaDos_Load(object sender, EventArgs e)
        {
            CargarColores();
        }
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            nuevaLapicera = new Lapicera((Color)lst_Colores.SelectedItem, int.Parse(txt_Precio.Text), txt_Marca.Text);
            DialogResult = DialogResult.OK;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }



        private void CargarColores()
        {
            colores = new List<Color>
            {
                Color.AliceBlue,Color.Black,Color.Blue,Color.Brown,
            };
            lst_Colores.DataSource = colores;
        }

        public Lapicera NuevaLapicera
        {
            get
            {
                return nuevaLapicera;
            }
        }
    }
}
