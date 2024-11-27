using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaMetodosNumericos
{
    public partial class FrmTema1 : Form
    {
        public FrmTema1()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            int n = 0;
            int pos = 0;
            if (txtNumeroIngresado.Text != string.Empty && esNumero(txtNumeroIngresado.Text))
            {
                for (int i = 0; i < txtNumeroIngresado.TextLength; i++)
                {
                    pos = pos + 1;
                    if (txtNumeroIngresado.Text[i] != '0' && txtNumeroIngresado.Text[i] != '.')
                    {
                        break;
                    }
                }
                for (int j = pos - 1; j < txtNumeroIngresado.TextLength; j++)
                {
                    if (txtNumeroIngresado.Text[j] != '.')
                    {
                        n++;
                    }
                }
                lblNumeroCifras.Text = n.ToString();
                MessageBox.Show("Cifras:" + n);
            }
            else
            {
                MessageBox.Show("No ingreso un valor valido", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool esNumero(string texto)
        {
            bool numerico = double.TryParse(texto, out double n);
            return numerico;
        }

        private void btnCalculoSerie_Click(object sender, EventArgs e)
        {
            if (txtNumCifras.Text != string.Empty || txtVariableX.Text != string.Empty)
            {
                double x = Convert.ToDouble(txtVariableX.Text);
                double noCifras = Convert.ToDouble(txtNumCifras.Text);
                double eS = 5 * Math.Pow(10, 2 - noCifras);
                double valorReal = Math.Pow(Math.E, x);
                double eT, eA = 1;
                int iteracion = 1;
                double resultado, sumatoria = 0, valorAnterior;

                for (int i = 0; i < iteracion; i++)
                {
                    valorAnterior = sumatoria;
                    resultado = Math.Pow(x, i) / Factorial(i);
                    sumatoria += resultado;
                    eT = (sumatoria - valorReal) / sumatoria * 100;

                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = iteracion.ToString();
                    listViewItem.SubItems.Add(sumatoria.ToString());
                    listViewItem.SubItems.Add(eT.ToString());

                    if (i == 0)
                    {
                        listViewItem.SubItems.Add("-----");
                    }
                    else
                    {
                        eA = (sumatoria - valorAnterior) / sumatoria * 100;
                        listViewItem.SubItems.Add(eA.ToString());
                    }

                    lVwSerieMc.Items.Add(listViewItem);

                    if (eA < eS)
                    {
                        lblValor.Text = sumatoria.ToString();
                        break;
                    }
                    else
                    {
                        iteracion++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Metodo calcular factorial
        private static double Factorial(int n)
        {
            double fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }//Fin Factorial

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lVwSerieMc.Items.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }

        private void btnFuente_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Font = fontDialog1.Font;
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-El método de contar cifras solo acepta valores numericos \r\n" +
                "-La serie de MacLaurin calcula el valor de euler elevado a una potencia\r\n" +
                "-En el valor de X ingresar la potencia a elevar de euler\r\n" +
                "-Las cifras significativas nos da las cifras validas del numero",
                "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}