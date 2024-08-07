using LibreriaDeComputadoras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormComputadora
{
    public partial class FormAlta : Form
    {
        Computadora nuevaPc;
        public FormAlta()
        {
            InitializeComponent();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            CargarProcesadores();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int memoriaRam = (int)numericUpDown1.Value;
            int capacidadDisco = (int)numericUpDown2.Value;
            string procesador = comboBox1.Text;
            string sistemaOperativo = "";

            foreach (RadioButton rd in groupBoxSistOperativo.Controls)
            {
                if (rd.Checked == true)
                {
                    sistemaOperativo = rd.Text;
                    break;
                }
            }


            


            if (memoriaRam>0 && capacidadDisco>0 && !string.IsNullOrEmpty(procesador) && !string.IsNullOrEmpty(sistemaOperativo))
            {
                nuevaPc = new Computadora(memoriaRam, capacidadDisco, procesador, sistemaOperativo);
                foreach (CheckBox ckb in groupBoxProgramas.Controls)
                {
                    if (ckb.Checked == true)
                    {
                        nuevaPc.SetPrograma(ckb.Text);
                    }
                }
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Verifique los datos ingresados","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        public Computadora NuevaPc { get => nuevaPc; }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void CargarProcesadores()
        {
            comboBox1.DataSource = Computadora.ListadoDeProcesadores();
        }
        
    }
}
