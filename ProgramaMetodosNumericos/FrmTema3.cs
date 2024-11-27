using System;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
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
    public partial class FrmTema3 : Form
    {
        public FrmTema3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Calcular X1, X2
            if (comboBox1.SelectedIndex == 0)
            {
                //Declaracion de variables
                double aX1 = Convert.ToDouble(txtAX1.Text);
                double aX2 = Convert.ToDouble(txtAX2.Text);
                double bX1 = Convert.ToDouble(txtBX1.Text);
                double bX2 = Convert.ToDouble(txtBX2.Text);
                double rA = Convert.ToDouble(txtAX3.Text);
                double rB = Convert.ToDouble(txtBX3.Text);
                double nocifras = Convert.ToDouble(txtCifras.Text);
                double eS = 5 * Math.Pow(10, 2 - nocifras);

                double x1 = 0, x2 = 0;
                double auxX1, auxX2;

                double eA1 = 1, eA2 = 1;
                int itt = 1;

                //Ciclo calcular x's
                for (int i = 0; i < itt; i++)
                {
                    //Guardar valores de x en auxiliares
                    auxX1 = x1;
                    auxX2 = x2;
                    //Formulas
                    x1 = (rA - (aX2 * auxX2))/ aX1;
                    x2 = (rB - (bX1 * auxX1))/ bX2;
                    //Agregar valores a la listView
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = itt.ToString();
                    listViewItem.SubItems.Add(x1.ToString());
                    listViewItem.SubItems.Add(x2.ToString());

                    if (i == 0)
                    {
                        listViewItem.SubItems.Add("-----");
                        listViewItem.SubItems.Add("-----");
                    }
                    else //Calcular Errores
                    {
                        eA1 = ((x1 - auxX1) / x1) * 100;
                        if (eA1 < 0)
                        {
                            eA1 = eA1 * -1;
                        }
                        eA2 = ((x2 - auxX2) / x2) * 100;
                        if (eA2 < 0)
                        {
                            eA2 = eA2 * -1;
                        }

                        listViewItem.SubItems.Add(eA1.ToString());
                        listViewItem.SubItems.Add(eA2.ToString());
                    }

                    lVResultados.Items.Add(listViewItem);

                    if (eA1 < eS && eA2 < eS)
                    {
                        label47.Text = x1.ToString();
                        label42.Text = x2.ToString();
                        break;
                    }
                    else
                    {
                        itt++; //Aumentar Ciclos
                    }

                }//Fin ciclo calcular x
            }//Fin X1, X2
            //Calcular X1, X2, X3
            else if (comboBox1.SelectedIndex == 1)
            {
                //Declaracion de variables
                double aX1 = Convert.ToDouble(txtAX1.Text);
                double aX2 = Convert.ToDouble(txtAX2.Text);
                double aX3 = Convert.ToDouble(txtAX3.Text);
                double rA = Convert.ToDouble(txtAX4.Text);

                double bX1 = Convert.ToDouble(txtBX1.Text);
                double bX2 = Convert.ToDouble(txtBX2.Text);
                double bX3 = Convert.ToDouble(txtBX3.Text);
                double rB = Convert.ToDouble(txtBX4.Text);

                double cX1 = Convert.ToDouble(txtCX1.Text);
                double cX2 = Convert.ToDouble(txtCX2.Text);
                double cX3 = Convert.ToDouble(txtCX3.Text);
                double rC = Convert.ToDouble(txtCX4.Text);

                double nocifras = Convert.ToDouble(txtCifras.Text);
                double eS = 5 * Math.Pow(10, 2 - nocifras);

                double x1 = 0, x2 = 0, x3 = 0;
                double auxX1, auxX2, auxX3;

                double eA1 = 1, eA2 = 1, eA3 = 1;
                int itt = 1;
                //Ciclo calcular x
                for (int i = 0; i < itt; i++)
                {
                    //Guardar valores de x en auxiliares
                    auxX1 = x1;
                    auxX2 = x2;
                    auxX3 = x3;

                    //formulas calcular x
                    x1 = (rA - (aX2 * auxX2) - (aX3 * auxX3)) / aX1;
                    x2 = (rB - (bX1 * auxX1) - (bX3 * auxX3)) / bX2;
                    x3 = (rC - (cX1 * auxX1) - (cX2 * auxX2)) / cX3;

                    //Agregar valores a listView
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = itt.ToString();
                    listViewItem.SubItems.Add(x1.ToString());
                    listViewItem.SubItems.Add(x2.ToString());
                    listViewItem.SubItems.Add(x3.ToString());

                    if (i == 0)
                    {
                        listViewItem.SubItems.Add("-----");
                        listViewItem.SubItems.Add("-----");
                        listViewItem.SubItems.Add("-----");
                    }
                    else //Calcular Errores
                    {
                        eA1 = ((x1 - auxX1) / x1) * 100;
                        if (eA1 < 0)
                        {
                            eA1 = eA1 * -1;
                        }
                        eA2 = ((x2 - auxX2) / x2) * 100;
                        if (eA2 < 0)
                        {
                            eA2 = eA2 * -1;
                        }
                        eA3 = ((x3 - auxX3) / x3) * 100;
                        if (eA3 < 0)
                        {
                            eA3 = eA3 * -1;
                        }

                        listViewItem.SubItems.Add(eA1.ToString());
                        listViewItem.SubItems.Add(eA2.ToString());
                        listViewItem.SubItems.Add(eA3.ToString());
                    }

                    lVResultados.Items.Add(listViewItem);

                    if (eA1 < eS && eA2 < eS && eA3 < eS)
                    {
                        label47.Text = x1.ToString();
                        label42.Text = x2.ToString();
                        label21.Text = x3.ToString();
                        break;
                    }
                    else
                    {
                        itt++; //Aumentar ciclo
                    }

                }//Fin ciclo calcular x
            }//Fin X1, X2, X3
            //Calcular X1, X2, X3, X4
            else if (comboBox1.SelectedIndex == 2)
            {
                //Declarar variables
                double aX1 = Convert.ToDouble(txtAX1.Text);
                double aX2 = Convert.ToDouble(txtAX2.Text);
                double aX3 = Convert.ToDouble(txtAX3.Text);
                double aX4 = Convert.ToDouble(txtAX4.Text);
                double rA = Convert.ToDouble(txtAX5.Text);

                double bX1 = Convert.ToDouble(txtBX1.Text);
                double bX2 = Convert.ToDouble(txtBX2.Text);
                double bX3 = Convert.ToDouble(txtBX3.Text);
                double bX4 = Convert.ToDouble(txtBX4.Text);
                double rB = Convert.ToDouble(txtBX5.Text);

                double cX1 = Convert.ToDouble(txtCX1.Text);
                double cX2 = Convert.ToDouble(txtCX2.Text);
                double cX3 = Convert.ToDouble(txtCX3.Text);
                double cX4 = Convert.ToDouble(txtCX4.Text);
                double rC = Convert.ToDouble(txtCX5.Text);

                double dX1 = Convert.ToDouble(txtDX1.Text);
                double dX2 = Convert.ToDouble(txtDX2.Text);
                double dX3 = Convert.ToDouble(txtDX3.Text);
                double dX4 = Convert.ToDouble(txtDX4.Text);
                double rD = Convert.ToDouble(txtDX5.Text);

                double nocifras = Convert.ToDouble(txtCifras.Text);
                double eS = 5 * Math.Pow(10, 2 - nocifras);

                double x1 = 0, x2 = 0, x3 = 0, x4 = 0;
                double auxX1, auxX2, auxX3, auxX4;

                double eA1 = 1, eA2 = 1, eA3 = 1, eA4 = 1;
                int itt = 1;
                //Ciclo calcular x
                for (int i = 0; i < itt; i++)
                {
                    //Guardar valores de x en auxiliares
                    auxX1 = x1;
                    auxX2 = x2;
                    auxX3 = x3;
                    auxX4 = x4;

                    //Formulas
                    x1 = (rA - (aX2 * auxX2) - (aX3 * auxX3) - (aX4 * auxX4)) / aX1;
                    x2 = (rB - (bX1 * auxX1) - (bX3 * auxX3) - (bX4 * auxX4)) / bX2;
                    x3 = (rC - (cX1 * auxX1) - (cX2 * auxX2) - (cX4 * auxX4)) / cX3;
                    x4 = (rD - (dX1 * auxX1) - (dX2 * auxX2) - (dX3 * auxX3)) / dX4;

                    //Agregar valores listView
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = itt.ToString();
                    listViewItem.SubItems.Add(x1.ToString());
                    listViewItem.SubItems.Add(x2.ToString());
                    listViewItem.SubItems.Add(x3.ToString());
                    listViewItem.SubItems.Add(x4.ToString());

                    if (i == 0)
                    {
                        listViewItem.SubItems.Add("-----");
                        listViewItem.SubItems.Add("-----");
                        listViewItem.SubItems.Add("-----");
                        listViewItem.SubItems.Add("-----");
                    }
                    else //Calcular Errores
                    {
                        eA1 = ((x1 - auxX1) / x1) * 100;
                        if (eA1 < 0)
                        {
                            eA1 = eA1 * -1;
                        }
                        eA2 = ((x2 - auxX2) / x2) * 100;
                        if (eA2 < 0)
                        {
                            eA2 = eA2 * -1;
                        }
                        eA3 = ((x3 - auxX3) / x3) * 100;
                        if (eA3 < 0)
                        {
                            eA3 = eA3 * -1;
                        }
                        eA4 = ((x4 - auxX4) / x4) * 100;
                        if (eA4 < 0)
                        {
                            eA4 = eA4 * -1;
                        }

                        listViewItem.SubItems.Add(eA1.ToString());
                        listViewItem.SubItems.Add(eA2.ToString());
                        listViewItem.SubItems.Add(eA3.ToString());
                        listViewItem.SubItems.Add(eA4.ToString());
                    }

                    lVResultados.Items.Add(listViewItem);

                    if (eA1 < eS && eA2 < eS && eA3 < eS && eA4 < eS)
                    {
                        label47.Text = x1.ToString();
                        label42.Text = x2.ToString();
                        label21.Text = x3.ToString();
                        label20.Text = x4.ToString();
                        break;
                    }
                    else
                    {
                        itt++; //Aumentar ciclo
                    }

                }//Fin ciclo Calcular x
            }//Fin X1, X2, X3, X4
            //Calcular X1, X2, X3, X4, X5
            else if (comboBox1.SelectedIndex == 3)
            {
                //Declarar variables
                double aX1 = Convert.ToDouble(txtAX1.Text);
                double aX2 = Convert.ToDouble(txtAX2.Text);
                double aX3 = Convert.ToDouble(txtAX3.Text);
                double aX4 = Convert.ToDouble(txtAX4.Text);
                double aX5 = Convert.ToDouble(txtAX5.Text);
                double rA = Convert.ToDouble(txtRa.Text);

                double bX1 = Convert.ToDouble(txtBX1.Text);
                double bX2 = Convert.ToDouble(txtBX2.Text);
                double bX3 = Convert.ToDouble(txtBX3.Text);
                double bX4 = Convert.ToDouble(txtBX4.Text);
                double bX5 = Convert.ToDouble(txtBX5.Text);
                double rB = Convert.ToDouble(txtRb.Text);

                double cX1 = Convert.ToDouble(txtCX1.Text);
                double cX2 = Convert.ToDouble(txtCX2.Text);
                double cX3 = Convert.ToDouble(txtCX3.Text);
                double cX4 = Convert.ToDouble(txtCX4.Text);
                double cX5 = Convert.ToDouble(txtCX5.Text);
                double rC = Convert.ToDouble(txtRc.Text);

                double dX1 = Convert.ToDouble(txtDX1.Text);
                double dX2 = Convert.ToDouble(txtDX2.Text);
                double dX3 = Convert.ToDouble(txtDX3.Text);
                double dX4 = Convert.ToDouble(txtDX4.Text);
                double dX5 = Convert.ToDouble(txtDX5.Text);
                double rD = Convert.ToDouble(txtRd.Text);

                double eX1 = Convert.ToDouble(txtEX1.Text);
                double eX2 = Convert.ToDouble(txtEX2.Text);
                double eX3 = Convert.ToDouble(txtEX3.Text);
                double eX4 = Convert.ToDouble(txtEX4.Text);
                double eX5 = Convert.ToDouble(txtEX5.Text);
                double rE = Convert.ToDouble(txtRe.Text);

                double nocifras = Convert.ToDouble(txtCifras.Text);
                double eS = 5 * Math.Pow(10, 2 - nocifras);

                double x1 = 0, x2 = 0, x3 = 0, x4 = 0, x5 = 0;
                double auxX1, auxX2, auxX3, auxX4, auxX5;

                double eA1 = 1, eA2 = 1, eA3 = 1, eA4 = 1, eA5 = 1;
                int itt = 1;
                //Ciclo calcular x
                for (int i = 0; i < itt; i++)
                {
                    //Guardar valores de x en auxiliares
                    auxX1 = x1;
                    auxX2 = x2;
                    auxX3 = x3;
                    auxX4 = x4;
                    auxX5 = x5;

                    //Formulas 
                    x1 = (rA - (aX2 * auxX2) - (aX3 * auxX3) - (aX4 * auxX4) - (aX5 * auxX5)) / aX1;
                    x2 = (rB - (bX1 * auxX1) - (bX3 * auxX3) - (bX4 * auxX4) - (bX5 * auxX5)) / bX2;
                    x3 = (rC - (cX1 * auxX1) - (cX2 * auxX2) - (cX4 * auxX4) - (cX5 * auxX5)) / cX3;
                    x4 = (rD - (dX1 * auxX1) - (dX2 * auxX2) - (dX3 * auxX3) - (dX5 * auxX5)) / dX4;
                    x5 = (rE - (eX1 * auxX1) - (eX2 * auxX2) - (eX3 * auxX3) - (eX4 * auxX4)) / eX5;
                     //Agregar valores en listView
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = itt.ToString();
                    listViewItem.SubItems.Add(x1.ToString());
                    listViewItem.SubItems.Add(x2.ToString());
                    listViewItem.SubItems.Add(x3.ToString());
                    listViewItem.SubItems.Add(x4.ToString());
                    listViewItem.SubItems.Add(x5.ToString());

                    if (i == 0)
                    {
                        listViewItem.SubItems.Add("-----");
                        listViewItem.SubItems.Add("-----");
                        listViewItem.SubItems.Add("-----");
                        listViewItem.SubItems.Add("-----");
                        listViewItem.SubItems.Add("-----");
                    }
                    else //Calcular Errores
                    {
                        eA1 = ((x1 - auxX1) / x1) * 100;
                        if (eA1 < 0)
                        {
                            eA1 = eA1 * -1;
                        }
                        eA2 = ((x2 - auxX2) / x2) * 100;
                        if (eA2 < 0)
                        {
                            eA2 = eA2 * -1;
                        }
                        eA3 = ((x3 - auxX3) / x3) * 100;
                        if (eA3 < 0)
                        {
                            eA3 = eA3 * -1;
                        }
                        eA4 = ((x4 - auxX4) / x4) * 100;
                        if (eA4 < 0)
                        {
                            eA4 = eA4 * -1;
                        }
                        eA5 = ((x5 - auxX5) / x5) * 100;
                        if (eA5 < 0)
                        {
                            eA5 = eA5 * -1;
                        }

                        listViewItem.SubItems.Add(eA1.ToString());
                        listViewItem.SubItems.Add(eA2.ToString());
                        listViewItem.SubItems.Add(eA3.ToString());
                        listViewItem.SubItems.Add(eA4.ToString());
                        listViewItem.SubItems.Add(eA5.ToString());
                    }

                    lVResultados.Items.Add(listViewItem);

                    if (eA1 < eS && eA2 < eS && eA3 < eS && eA4 < eS && eA5 < eS)
                    {
                        label47.Text = x1.ToString();
                        label42.Text = x2.ToString();
                        label21.Text = x3.ToString();
                        label20.Text = x4.ToString();
                        label19.Text = x5.ToString();
                        break;
                    }
                    else
                    {
                        itt++; //Aumentar ciclo
                    }

                }//Fin ciclo Calcular x
            }//Fin X1, X2, X3, X4, X5
        }//Fin BtnCalcular
        
        //Limpiar los datos de los textBox y label
        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            txtAX1.Text = "";
            txtAX2.Text = "";
            txtAX3.Text = "";
            txtAX4.Text = "";
            txtAX5.Text = "";

            txtBX1.Text = "";
            txtBX2.Text = "";
            txtBX3.Text = "";
            txtBX4.Text = "";
            txtBX5.Text = "";

            txtCX1.Text = "";
            txtCX2.Text = "";
            txtCX3.Text = "";
            txtCX4.Text = "";
            txtCX5.Text = "";

            txtDX1.Text = "";
            txtDX2.Text = "";
            txtDX3.Text = "";
            txtDX4.Text = "";
            txtDX5.Text = "";

            txtEX1.Text = "";
            txtEX2.Text = "";
            txtEX3.Text = "";
            txtEX4.Text = "";
            txtEX5.Text = "";

            txtRa.Text = "";
            txtRb.Text = "";
            txtRc.Text = "";
            txtRd.Text = "";
            txtRe.Text = "";
            txtCifras.Text = "";

            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
            label42.Text = "";
            label47.Text = "";
            txtAX1.Focus();

        }//Fin btnLimpiarDatos

        //Limpiar lisView
        private void btnLimpiarTabla_Click(object sender, EventArgs e)
        {
            lVResultados.Items.Clear();
        }

        //Sentencias de cambio de tamaño de Sistema de ecuaciones
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ocultar elementos
            txtAX1.Visible = false;
            txtAX2.Visible = false;
            txtAX3.Visible = false;
            txtAX4.Visible = false;
            txtAX5.Visible = false;
            txtBX1.Visible = false;
            txtBX2.Visible = false;
            txtBX3.Visible = false;
            txtBX4.Visible = false;
            txtBX5.Visible = false;
            txtCX1.Visible = false;
            txtCX2.Visible = false;
            txtCX3.Visible = false;
            txtCX4.Visible = false;
            txtCX5.Visible = false;
            txtDX1.Visible = false;
            txtDX2.Visible = false;
            txtDX3.Visible = false;
            txtDX4.Visible = false;
            txtDX5.Visible = false;
            txtEX1.Visible = false;
            txtEX2.Visible = false;
            txtEX3.Visible = false;
            txtEX4.Visible = false;
            txtEX5.Visible = false;
            txtRa.Visible = false;
            txtRb.Visible = false;
            txtRc.Visible = false;
            txtRd.Visible = false;
            txtRe.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;    
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            label37.Visible = false;
            label38.Visible = false;
            label39.Visible = false;
            label40.Visible = false;
            label41.Visible = false;
            label43.Visible = false;
            label44.Visible = false;
            label45.Visible = false;
            label46.Visible = false;
            lblVx1.Visible = false;
            lblVx2.Visible = false;
            lblVx3.Visible = false;
            lblVx4.Visible = false;
            lblVx5.Visible = false;
            lVResultados.Clear();

            //Para primer caso
            if (comboBox1.SelectedIndex == 0)
            {
                btnLimpiarDatos_Click(sender, e);
                txtAX1.Visible = true;
                txtAX2.Visible = true;
                txtBX1.Visible = true;
                txtBX2.Visible = true;
                txtAX3.Visible = true;
                txtBX3.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label6.Visible = true;
                label5.Visible = true;

                label15.Visible = true;
                label43.Visible = true;
                lblVx1.Visible = true;
                lblVx2.Visible = true;

                lVResultados.Columns.Add("Iteracion", 60);
                lVResultados.Columns.Add("X1", 60);
                lVResultados.Columns.Add("X2", 60);
                lVResultados.Columns.Add("Ea1", 60);
                lVResultados.Columns.Add("Ea2", 60);
            }
            //Para segundo caso
            else if (comboBox1.SelectedIndex == 1)
            {
                btnLimpiarDatos_Click(sender, e);
                txtAX1.Visible = true;
                txtAX2.Visible = true;
                txtAX3.Visible = true;
                txtBX1.Visible = true;
                txtBX2.Visible = true;
                txtBX3.Visible = true;
                txtCX1.Visible = true;
                txtCX2.Visible = true;
                txtCX3.Visible = true;

                txtAX4.Visible = true;
                txtBX4.Visible = true;
                txtCX4.Visible = true;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;

                label44.Visible = true;
                label45.Visible = true;
                label46.Visible = true;
                lblVx1.Visible = true;
                lblVx2.Visible = true;
                lblVx3.Visible = true;

                lVResultados.Columns.Add("Iteracion", 60);
                lVResultados.Columns.Add("X1", 60);
                lVResultados.Columns.Add("X2", 60);
                lVResultados.Columns.Add("X3", 60);
                lVResultados.Columns.Add("Ea1", 60);
                lVResultados.Columns.Add("Ea2", 60);
                lVResultados.Columns.Add("Ea3", 60);
            }
            //Para tercer caso
            else if (comboBox1.SelectedIndex == 2)
            {
                btnLimpiarDatos_Click(sender, e);
                txtAX1.Visible = true;
                txtAX2.Visible = true;
                txtAX3.Visible = true;
                txtAX4.Visible = true;
                txtBX1.Visible = true;
                txtBX2.Visible = true;
                txtBX3.Visible = true;
                txtBX4.Visible = true;
                txtCX1.Visible = true;
                txtCX2.Visible = true;
                txtCX3.Visible = true;
                txtCX4.Visible = true;
                txtDX1.Visible = true;
                txtDX2.Visible = true;
                txtDX3.Visible = true;
                txtDX4.Visible = true;

                txtAX5.Visible = true;
                txtBX5.Visible = true;
                txtCX5.Visible = true;
                txtDX5.Visible = true;


                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label24.Visible = true;
                label26.Visible = true;
                label28.Visible = true;
                label34.Visible = true;
                label38.Visible = true;
                label39.Visible = true;
                label40.Visible = true;

                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label41.Visible = true;
                lblVx1.Visible = true;
                lblVx2.Visible = true;
                lblVx3.Visible = true;
                lblVx4.Visible = true;

                lVResultados.Columns.Add("Iteracion", 60);
                lVResultados.Columns.Add("X1", 60);
                lVResultados.Columns.Add("X2", 60);
                lVResultados.Columns.Add("X3", 60);
                lVResultados.Columns.Add("X4", 60);
                lVResultados.Columns.Add("Ea1", 60);
                lVResultados.Columns.Add("Ea2", 60);
                lVResultados.Columns.Add("Ea3", 60);
                lVResultados.Columns.Add("Ea4", 60);
            }
            //Para cuarto caso
            else if (comboBox1.SelectedIndex == 3)
            {
                btnLimpiarDatos_Click(sender, e);
                txtAX1.Visible = true;
                txtAX2.Visible = true;
                txtAX3.Visible = true;
                txtAX4.Visible = true;
                txtAX5.Visible = true;
                txtBX1.Visible = true;
                txtBX2.Visible = true;
                txtBX3.Visible = true;
                txtBX4.Visible = true;
                txtBX5.Visible = true;
                txtCX1.Visible = true;
                txtCX2.Visible = true;
                txtCX3.Visible = true;
                txtCX4.Visible = true;
                txtCX5.Visible = true;
                txtDX1.Visible = true;
                txtDX2.Visible = true;
                txtDX3.Visible = true;
                txtDX4.Visible = true;
                txtDX5.Visible = true;
                txtEX1.Visible = true;
                txtEX2.Visible = true;
                txtEX3.Visible = true;
                txtEX4.Visible = true;
                txtEX5.Visible = true;

                txtRa.Visible = true;
                txtRb.Visible = true;
                txtRc.Visible = true;
                txtRd.Visible = true;
                txtRe.Visible = true;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label23.Visible = true;
                label24.Visible = true;
                label25.Visible = true;
                label26.Visible = true;
                label27.Visible = true;
                label28.Visible = true;
                label31.Visible = true;
                label32.Visible = true;
                label33.Visible = true;
                label34.Visible = true;
                label35.Visible = true;
                label36.Visible = true;
                label37.Visible = true;
                label38.Visible = true;
                label39.Visible = true;
                label40.Visible = true;

                label29.Visible = true;
                label30.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                lblVx1.Visible = true;
                lblVx2.Visible = true;
                lblVx3.Visible = true;
                lblVx4.Visible = true;
                lblVx5.Visible = true;

                lVResultados.Columns.Add("Iteracion", 60);
                lVResultados.Columns.Add("X1", 60);
                lVResultados.Columns.Add("X2", 60);
                lVResultados.Columns.Add("X3", 60);
                lVResultados.Columns.Add("X4", 60);
                lVResultados.Columns.Add("X5", 60);
                lVResultados.Columns.Add("Ea1", 60);
                lVResultados.Columns.Add("Ea2", 60);
                lVResultados.Columns.Add("Ea3", 60);
                lVResultados.Columns.Add("Ea4", 60);
                lVResultados.Columns.Add("Ea5", 60);
            }
        }

        //Rellenar datos de los sistemas con valores predeterminados
        private void btnRellenar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                txtAX1.Text = "1";
                txtAX2.Text = "1";

                txtBX1.Text = "1";
                txtBX2.Text = "-3";

                txtAX3.Text = "12";
                txtBX3.Text = "4";
                txtCifras.Text = "5";
            }
                
            else if (comboBox1.SelectedIndex == 1)
            {
                txtAX1.Text = "4";
                txtAX2.Text = "1";
                txtAX3.Text = "-2";

                txtBX1.Text = "1";
                txtBX2.Text = "3";
                txtBX3.Text = "-1";

                txtCX1.Text = "-2";
                txtCX2.Text = "-3";
                txtCX3.Text = "6";

                txtAX4.Text = "3";
                txtBX4.Text = "2";
                txtCX4.Text = "1";
                txtCifras.Text = "5";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                txtAX1.Text = "-7";
                txtAX2.Text = "1";
                txtAX3.Text = "1";
                txtAX4.Text = "-2";

                txtBX1.Text = "0";
                txtBX2.Text = "4";
                txtBX3.Text = "2";
                txtBX4.Text = "-1";

                txtCX1.Text = "3";
                txtCX2.Text = "0";
                txtCX3.Text = "-6";
                txtCX4.Text = "2";

                txtDX1.Text = "-2";
                txtDX2.Text = "-2";
                txtDX3.Text = "3";
                txtDX4.Text = "8";

                txtAX5.Text = "17";
                txtBX5.Text = "28";
                txtCX5.Text = "19";
                txtDX5.Text = "10";
                txtCifras.Text = "5";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                txtAX1.Text = "4";
                txtAX2.Text = "1";
                txtAX3.Text = "1";
                txtAX4.Text = "0";
                txtAX5.Text = "1";

                txtBX1.Text = "-1";
                txtBX2.Text = "-3";
                txtBX3.Text = "1";
                txtBX4.Text = "1";
                txtBX5.Text = "0";

                txtCX1.Text = "2";
                txtCX2.Text = "1";
                txtCX3.Text = "5";
                txtCX4.Text = "-1";
                txtCX5.Text = "-1";

                txtDX1.Text = "-1";
                txtDX2.Text = "-1";
                txtDX3.Text = "-1";
                txtDX4.Text = "4";
                txtDX5.Text = "0";

                txtEX1.Text = "0";
                txtEX2.Text = "2";
                txtEX3.Text = "-1";
                txtEX4.Text = "1";
                txtEX5.Text = "4";

                txtRa.Text = "6";
                txtRb.Text = "6";
                txtRc.Text = "6";
                txtRd.Text = "6";
                txtRe.Text = "6";
                txtCifras.Text = "5";
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
            }
        }

        private void inputConLabel1_TextoChanged(object sender, EventArgs e)
        {
            label13.Text = inputConLabel1.Texto;
        }

        private void btnCrearPdf_Click(object sender, EventArgs e)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Pdf Tema 3";
            document.Info.Author = "Victor Abundio Preza";
            document.Info.CreationDate = DateTime.Now;
            document.Info.ModificationDate = DateTime.Now;

            PdfPage page = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont font = new XFont("Tahoma", 12);

            gfx.DrawString(ToString(), font, XBrushes.Black,
                new XRect(0, 0, page.Width, page.Height),
                XStringFormats.TopLeft);

            document.Save("PdfTema3.Pdf");
            Process.Start("PdfTema3.Pdf");
        }

        private void btnCambiarFuente_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Font = fontDialog1.Font;
            }
        }
    }//Fin FrmTema3 
}//Fin namespace