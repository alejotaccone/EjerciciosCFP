using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDeLapiceras;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace FormPrincipal
{
    public partial class FormAlta : Form
    {
        Lapicera nuevaLapicera;
        public FormAlta()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            nuevaLapicera = new Lapicera(Color.FromName(txt_Color.Text), int.Parse(txt_Precio.Text), txt_Marca.Text);
            DialogResult = DialogResult.OK;
            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult  = DialogResult.Cancel;
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
