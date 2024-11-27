using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaMetodosNumericos
{
    public partial class FrmTema4 : Form
    {
        public FrmTema4()
        {
            InitializeComponent();
        }

        private void btnCalcularFuncionEuler_Click(object sender, EventArgs e)
        {
            double h = Convert.ToDouble(txtHF1.Text);
            double x = Convert.ToDouble(txtX0F1.Text);
            double potenciaX = Convert.ToDouble(txtPotX.Text);
            double euler = Math.E; 

            double progresiva = (Math.Pow(euler, potenciaX * (x + h)) - Math.Pow(euler, potenciaX * x)) / h;

            double centrada = (Math.Pow(euler, potenciaX * (x + h)) - Math.Pow(euler, potenciaX * (x - h))) / (2 * h);

            double regresiva = (Math.Pow(euler, potenciaX * x) - Math.Pow(euler, potenciaX * (x - h))) / h;

            lblRProgresiva.Text = progresiva.ToString();
            lblRCentrada.Text = centrada.ToString();
            lblRRegresiva.Text = regresiva.ToString();

        }
        private void btnCalcularF2_Click(object sender, EventArgs e)
        {
            double constanteA = Convert.ToDouble(txtConstanteA.Text);
            double constanteB = Convert.ToDouble(txtConstanteB.Text);
            double constanteC = Convert.ToDouble(txtConstanteC.Text);
            double constanteD = Convert.ToDouble(txtConstanteD.Text);
            double potenciaXA = Convert.ToDouble(txtPotenciaX1.Text);
            double potenciaXB = Convert.ToDouble(txtPotenciaX2.Text);

            double x = Convert.ToDouble(txtX0F2.Text);
            double h = Convert.ToDouble(txtHF2.Text);
            double fX = (constanteA * Math.Pow(x, potenciaXA)) + (constanteB * Math.Pow(x, potenciaXB)) + (constanteC * x) + constanteD;
            double fXMasH = (constanteA * Math.Pow(x + h, potenciaXA)) + (constanteB * Math.Pow(x + h, potenciaXB)) + 
                (constanteC * (x+h)) + constanteD;
            double fXMenosH = (constanteA * Math.Pow(x - h, potenciaXA)) + (constanteB * Math.Pow(x - h, potenciaXB)) + 
                (constanteC * (x - h)) + constanteD;

            double solProgresiva = (fXMasH - fX) / h;
            double solCentrada = (fXMasH - fXMenosH) / (2 * h);
            double solRegresiva = (fX - fXMenosH) / h;

            lblRProgresivaA.Text = solProgresiva.ToString();
            lblRCentradaA.Text = solCentrada.ToString();
            lblRRegresivaA.Text = solRegresiva.ToString();
        }

        private void btnRellenarF1_Click(object sender, EventArgs e)
        {
            if (cBEjemplosF1.SelectedIndex == 0)
            {
                txtHF1.Text = "0.1";
                txtPotX.Text = "2";
                txtX0F1.Text = "1.1";
            }
            else if (cBEjemplosF1.SelectedIndex == 1)
            {
                txtHF1.Text = "0.001";
                txtPotX.Text = "1";
                txtX0F1.Text = "2";
            }
            else if (cBEjemplosF1.SelectedIndex == 2)
            {
                txtHF1.Text = "0.04";
                txtPotX.Text = "3";
                txtX0F1.Text = "5";
            }
            else if (cBEjemplosF1.SelectedIndex == 3)
            {
                txtHF1.Text = "0.0001";
                txtPotX.Text = "4";
                txtX0F1.Text = "3";
            }
            else
            {
                MessageBox.Show("Ningun indice seleccionado", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRellenarF2_Click(object sender, EventArgs e)
        {
            if (cBEjemplosF2.SelectedIndex == 0)
            {
                txtConstanteA.Text = "0";
                txtPotenciaX1.Text = "0";
                txtConstanteB.Text = "3";
                txtPotenciaX2.Text = "2";
                txtConstanteC.Text = "2";
                txtConstanteD.Text = "0";
                txtHF2.Text = "0.5";
                txtX0F2.Text = "2";

            }
            else if (cBEjemplosF2.SelectedIndex == 1)
            {
                txtConstanteA.Text = "2";
                txtPotenciaX1.Text = "3";
                txtConstanteB.Text = "-4";
                txtPotenciaX2.Text = "2";
                txtConstanteC.Text = "-5";
                txtConstanteD.Text = "4";
                txtHF2.Text = "0.001";
                txtX0F2.Text = "3";
            }
            else if (cBEjemplosF2.SelectedIndex == 2)
            {
                txtConstanteA.Text = "1";
                txtPotenciaX1.Text = "3";
                txtConstanteB.Text = "5";
                txtPotenciaX2.Text = "2";
                txtConstanteC.Text = "-4";
                txtConstanteD.Text = "2";
                txtHF2.Text = "0.001";
                txtX0F2.Text = "5";
            }
            else if (cBEjemplosF2.SelectedIndex == 3)
            {
                txtConstanteA.Text = "3";
                txtPotenciaX1.Text = "5";
                txtConstanteB.Text = "4";
                txtPotenciaX2.Text = "3";
                txtConstanteC.Text = "-6";
                txtConstanteD.Text = "-10";
                txtHF2.Text = "0.001";
                txtX0F2.Text = "4";
            }
            else
            {
                MessageBox.Show("Ningun indice seleccionado", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-Rellenar todos los datos antes de dar al boton de ejecutar \r\n" +
                "-Si algun dato no se usara rellenar con el número 0 \r\n" +
                "-Antes de rellenar datos seleccionar un ejemplo de la lista", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void colorPicker1_ColorChanged(object sender, EventArgs e)
        {
            BackColor = colorPicker1.Color;
        }

        private void inputConLabel1_TextoChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = inputConLabel1.Texto;
        }

        private void btnFuente_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Font = fontDialog1.Font;
            }
        }
    }
}
