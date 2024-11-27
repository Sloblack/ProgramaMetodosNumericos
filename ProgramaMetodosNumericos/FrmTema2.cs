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
    public partial class FrmBiseccion : Form
    {
        public FrmBiseccion()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Validar si los datos estan llenos
            if (txtConstanteA.Text != string.Empty && txtConstanteB.Text != string.Empty &&
                txtConstanteC.Text != string.Empty && txtConstanteD.Text != string.Empty &&
                txtPotenciaX1.Text != string.Empty && txtPotenciaX2.Text != string.Empty &&
                txtIntervaloA.Text != string.Empty && txtIntervaloB.Text != string.Empty &&
                txtCifra.Text != string.Empty)
            {
                //Definicion de variables
                double potenciaX1 = Convert.ToDouble(txtPotenciaX1.Text);
                double potenciaX2 = Convert.ToDouble(txtPotenciaX2.Text);
                double vA = Convert.ToDouble(txtConstanteA.Text);//Valor que acompaña a x1
                double vB = Convert.ToDouble(txtConstanteB.Text);//Valor que acompaña a x2
                double vC = Convert.ToDouble(txtConstanteC.Text);//Valor que acompaña a x3
                double vD = Convert.ToDouble(txtConstanteD.Text);//Valor independiente
                double a = Convert.ToDouble(txtIntervaloA.Text);//Primer intervalo
                double b = Convert.ToDouble(txtIntervaloB.Text);//Segundo intervalo
                double m = 0, mAnterior;
                double fA, fB, fM;
                double iteracion = 1;
                double noCifras = Convert.ToDouble(txtCifra.Text);
                double eS = 5 * Math.Pow(10, 2 - noCifras), eA = 1;//Convetir numero de cifras a la estimacion


                //Ciclo for calcular raiz 
                for (int i = 0; i < iteracion; i++)
                {
                    mAnterior = m;
                    m = (a + b) / 2;

                    //Evaluar funciones en a, b, m
                    fA = (vA * Math.Pow(a, potenciaX1)) + (vB * Math.Pow(a, potenciaX2)) + (vC * a) + vD;
                    fB = (vA * Math.Pow(b, potenciaX1)) + (vB * Math.Pow(b, potenciaX2)) + (vC * b) + vD;
                    fM = (vA * Math.Pow(m, potenciaX1)) + (vB * Math.Pow(m, potenciaX2)) + (vC * m) + vD;

                    //Agregar elementos a listview 
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = iteracion.ToString();
                    listViewItem.SubItems.Add(a.ToString());
                    listViewItem.SubItems.Add(b.ToString());
                    listViewItem.SubItems.Add(m.ToString());
                    listViewItem.SubItems.Add(fA.ToString());
                    listViewItem.SubItems.Add(fB.ToString());
                    listViewItem.SubItems.Add(fM.ToString());

                    //Marcar como nulo el primer error absoluto
                    if (i == 0)
                    {
                        listViewItem.SubItems.Add("-----");
                    }
                    else //Calcular error absoluto
                    {
                        eA = ((m - mAnterior) / m) * 100;
                        if (eA < 0) //Si eA es negativo multiplicar por -1
                        {
                            eA = eA * (-1);
                        }
                        listViewItem.SubItems.Add(eA.ToString());
                    }
                    lvwElementos.Items.Add(listViewItem);//Imprimir resultados en lisview
                    lblResultado.Text = m.ToString();


                    if (fM == 0 || eA < eS) //Definir cuando parar el programa
                    {
                        break;
                    }
                    else if (fA < 0 && fM > 0 || fA > 0 && fM < 0)
                    {
                        b = m;
                    }
                    else if (fB < 0 && fM > 0 || fB > 0 && fM < 0)
                    {
                        a = m;
                    }
                    else if ((fA < 0 && fB < 0 && fM < 0)
                        || (fA > 0 && fB > 0 && fM > 0))
                    {
                        MessageBox.Show("Solucion no dentro de los intervalos o" +
                            " la solucion no esta dentro de los numeros reales");
                        lblResultado.Text = "0";
                        break;

                    }
                    iteracion++; //Aumentar numero de ciclos 
                }//Fin calcular raiz
            }//Fin Validar datos llenos
            else
            {
                MessageBox.Show("Campos vacios", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtConstanteA.Text = "";
            txtPotenciaX1.Text = "";
            txtPotenciaX2.Text = "";
            txtConstanteB.Text = "";
            txtConstanteC.Text = "";
            txtConstanteD.Text = "";
            txtIntervaloA.Text = "";
            txtIntervaloB.Text = "";
            txtCifra.Text = "";
            lblResultado.Text = "0";
            txtConstanteA.Focus();
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            lvwElementos.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                txtConstanteA.Text = "0";
                txtPotenciaX1.Text = "0";
                txtConstanteB.Text = "4";
                txtPotenciaX2.Text = "2";
                txtConstanteC.Text = "-2";
                txtConstanteD.Text = "-2";
                txtIntervaloA.Text = ".5";
                txtIntervaloB.Text = "2";
                txtCifra.Text = "5";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                txtConstanteA.Text = "0";
                txtPotenciaX1.Text = "0";
                txtConstanteB.Text = "1";
                txtPotenciaX2.Text = "2";
                txtConstanteC.Text = "0";
                txtConstanteD.Text = "-1";
                txtIntervaloA.Text = ".5";
                txtIntervaloB.Text = "2";
                txtCifra.Text = "5";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                txtConstanteA.Text = "0";
                txtPotenciaX1.Text = "0";
                txtConstanteB.Text = "0";
                txtPotenciaX2.Text = "0";
                txtConstanteC.Text = "2";
                txtConstanteD.Text = "4";
                txtIntervaloA.Text = "-3.5";
                txtIntervaloB.Text = "-1";
                txtCifra.Text = "4";
            }

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
                label6.BackColor = colorDialog1.Color;
            }
        }

        private void btnTipoFuente_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            if ( result == DialogResult.OK)
            {
                Font = fontDialog1.Font;
            }
        }
    }
}
