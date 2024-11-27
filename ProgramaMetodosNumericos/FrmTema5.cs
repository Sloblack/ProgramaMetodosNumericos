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
    public partial class FrmTema5 : Form
    {
        public FrmTema5()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();//Cerrar formulario
        }
        //Seleccionar numero de coordenadas a ingresar
        private void cbxTamanio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Objetos invisibles 
            txtX0.Visible = false;
            txtX1.Visible = false;
            txtX2.Visible = false;
            txtX3.Visible = false;
            txtY0.Visible = false;
            txtY1.Visible = false;
            txtY2.Visible = false;
            txtY3.Visible = false;
            txtValorCX_3.Visible = false;
            txtValorCX_2.Visible = false;
            txtValorCX_1.Visible = false;
            txtValorCInd.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            lblX_3.Visible = false;
            lblX_2.Visible = false;
            //Mostrar solo elementos necesarios
            if (cbxTamanio.SelectedIndex == 0)
            {
                btnLimpiarResultados_Click(sender, e);
                btnLimpiarValores_Click(sender, e);
                txtX0.Visible = true;
                txtX1.Visible = true;
                txtY0.Visible = true;
                txtY1.Visible = true;
                txtValorCX_3.Visible = true;
                txtValorCX_2.Visible = true;
                label1.Visible = true;
                label6.Visible = true;
            }
            else if (cbxTamanio.SelectedIndex == 1)
            {
                btnLimpiarResultados_Click(sender, e);
                btnLimpiarValores_Click(sender, e);
                txtX0.Visible = true;
                txtX1.Visible = true;
                txtX2.Visible = true;
                txtY0.Visible = true;
                txtY1.Visible = true;
                txtY2.Visible = true;
                txtValorCX_3.Visible = true;
                txtValorCX_2.Visible = true;
                txtValorCX_1.Visible = true;
                lblX_3.Visible = true;
                lblX_3.Text = "2";
                label1.Visible = true;
                label2.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
            }
            else if (cbxTamanio.SelectedIndex == 2)
            {
                btnLimpiarResultados_Click(sender, e);
                btnLimpiarValores_Click(sender, e);
                txtX0.Visible = true;
                txtX1.Visible = true;
                txtX2.Visible = true;
                txtX3.Visible = true;
                txtY0.Visible = true;
                txtY1.Visible = true;
                txtY2.Visible = true;
                txtY3.Visible = true;
                txtValorCX_3.Visible = true;
                txtValorCX_2.Visible = true;
                txtValorCX_1.Visible = true;
                txtValorCInd.Visible = true;
                lblX_3.Visible = true;
                lblX_3.Text = "3";
                lblX_2.Visible = true;
                lblX_2.Text = "2";
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
            }
        }
        //Limpiar los resultados 
        private void btnLimpiarResultados_Click(object sender, EventArgs e)
        {
            txtValorCX_3.Text = "";
            txtValorCX_2.Text = "";
            txtValorCX_1.Text = "";
            txtValorCInd.Text = "";
        }
        //Limpiar los valores
        private void btnLimpiarValores_Click(object sender, EventArgs e)
        {
            txtX0.Text = "";
            txtX1.Text = "";
            txtX2.Text = "";
            txtX3.Text = "";
            txtY0.Text = "";
            txtY1.Text = "";
            txtY2.Text = "";
            txtY3.Text = "";
        }
        //Rellenar los datos
        private void btnRellenarDatos_Click_1(object sender, EventArgs e)
        {
            if (cbxTamanio.SelectedIndex == 0)
            {
                txtX0.Text = "5";
                txtX1.Text = "-2";
                txtY0.Text = "-1";
                txtY1.Text = "1";
            }
            else if (cbxTamanio.SelectedIndex == 1)
            {
                txtX0.Text = "-6";
                txtX1.Text = "6";
                txtX2.Text = "1";
                txtY0.Text = "8";
                txtY1.Text = "-16";
                txtY2.Text = "-2";
            }
            else if (cbxTamanio.SelectedIndex == 2)
            {
                txtX0.Text = "1";
                txtX1.Text = "-3";
                txtX2.Text = "5";
                txtX3.Text = "7";
                txtY0.Text = "-2";
                txtY1.Text = "1";
                txtY2.Text = "2";
                txtY3.Text = "-3";
            }
            else
            {
                MessageBox.Show("Ningun indice seleccionado", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Cuando se ingresen solo 2 pares de coordenadas
            if (cbxTamanio.SelectedIndex == 0)
            {
                if (txtX0.Text == string.Empty || txtX1.Text == string.Empty ||
                    txtY0.Text == string.Empty || txtY1.Text == string.Empty)
                {
                    MessageBox.Show("Rellenar todos los campos", "Error",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                }
                else
                {
                    //Declaracion de coordenadas de X y Y
                    double x0 = Convert.ToDouble(txtX0.Text),
                       y0 = Convert.ToDouble(txtY0.Text),
                       x1 = Convert.ToDouble(txtX1.Text),
                       y1 = Convert.ToDouble(txtY1.Text);

                    //Calcular valores de las constantes para L0
                    //Calcular los valores de el producto de la multiplicacion de (X - Xn)
                    double valorX_1L0 = 1,
                           valorIndL0 = -x1;
                    //Calcular la multiplicacion de los productos de la funcion por Y0
                    double l0X_1 = y0 * valorX_1L0,
                           l0V_i = y0 * valorIndL0;
                    //Calcular el valor con el que se dividiran los valores de la funcion
                    double divL0 = x0 - x1;
                    //Dividir los valores de las constantes de la funcion 
                    double constanteX_1L0 = l0X_1 / divL0,
                           constanteV_iL0 = l0V_i / divL0;

                    //Calcular valores de las constantes para L1
                    //Calcular los valores de el producto de la multiplicacion de (X - Xn)
                    double valorX_1L1 = 1,
                           valorIndL1 = -x0;
                    //Calcular la multiplicacion de los productos de la funcion por Y1
                    double l1X_1 = y1 * valorX_1L1,
                           l1V_i = y1 * valorIndL1;
                    //Calcular el valor con el que se dividiran los valores de la funcion
                    double divL1 = x1 - x0;
                    //Dividir los valores de las constantes de la funcion 
                    double constanteX_1L1 = l1X_1 / divL1,
                           constanteV_iL1 = l1V_i / divL1;
                    //Sumar los resultados para obtener el total de cada constante
                    double valorConstanteX_1 = constanteX_1L0 +
                           constanteX_1L1,
                           valorConstanteInd = constanteV_iL0 +
                           constanteV_iL1;
                    //Imprimir los resultados en el formulario 
                    txtValorCX_3.Text = valorConstanteX_1.ToString();
                    txtValorCX_2.Text = valorConstanteInd.ToString();
                }
            }//Fin 2 pares de coodenadas

            //Cuando se ingresan 3 pares de coordenadas
            else if (cbxTamanio.SelectedIndex == 1)
            {
                if (txtX0.Text == string.Empty || txtX1.Text == string.Empty ||
                    txtX2.Text == string.Empty || txtY0.Text == string.Empty || 
                    txtY1.Text == string.Empty || txtY2.Text == string.Empty)
                {
                    MessageBox.Show("Rellenar todos los campos", "Error",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                }
                else
                {
                    //Declaracion de coordenadas de X y Y
                    double x0 = Convert.ToDouble(txtX0.Text),
                           y0 = Convert.ToDouble(txtY0.Text),
                           x1 = Convert.ToDouble(txtX1.Text),
                           y1 = Convert.ToDouble(txtY1.Text),
                           x2 = Convert.ToDouble(txtX2.Text),
                           y2 = Convert.ToDouble(txtY2.Text);

                    //Calcular valores de las constantes para L0
                    //Calcular los valores de el producto de la multiplicacion de (X - Xn)
                    double valorX_2L0 = 1,
                           valorX_1L0 = (-x1) + (-x2),
                           valorIndL0 = (-x1) * (-x2);
                    //Calcular la multiplicacion de los productos de la funcion por Y0
                    double l0X_2 = y0 * valorX_2L0,
                           l0X_1 = y0 * valorX_1L0,
                           l0V_i = y0 * valorIndL0;
                    //Calcular el valor con el que se dividiran los valores de la funcion
                    double divL0 = (x0 - x1) * (x0 - x2);
                    //Dividir los valores de las constantes de la funcion 
                    double constanteX_2L0 = l0X_2 / divL0,
                           constanteX_1L0 = l0X_1 / divL0,
                           constanteV_iL0 = l0V_i / divL0;

                    //Calcular valores de las constantes para L0
                    //Calcular los valores de el producto de la multiplicacion de (X - Xn)
                    double valorX_2L1 = 1,
                           valorX_1L1 = (-x0) + (-x2),
                           valorIndL1 = (-x0) * (-x2);
                    //Calcular la multiplicacion de los productos de la funcion por Y0
                    double l1X_2 = y1 * valorX_2L1,
                           l1X_1 = y1 * valorX_1L1,
                           l1V_i = y1 * valorIndL1;
                    //Calcular el valor con el que se dividiran los valores de la funcion
                    double divL1 = (x1 - x0) * (x1 - x2);
                    //Dividir los valores de las constantes de la funcion 
                    double constanteX_2L1 = l1X_2 / divL1,
                           constanteX_1L1 = l1X_1 / divL1,
                           constanteV_iL1 = l1V_i / divL1;

                    //Calcular valores de las constantes para L0
                    //Calcular los valores de el producto de la multiplicacion de (X - Xn)
                    double valorX_2L2 = 1,
                           valorX_1L2 = (-x0) + (-x1),
                           valorIndL2 = (-x0) * (-x1);
                    //Calcular la multiplicacion de los productos de la funcion por Y0
                    double l2X_2 = y2 * valorX_2L2,
                           l2X_1 = y2 * valorX_1L2,
                           l2V_i = y2 * valorIndL2;
                    //Calcular el valor con el que se dividiran los valores de la funcion
                    double divL2 = (x2 - x0) * (x2 - x1);
                    //Dividir los valores de las constantes de la funcion 
                    double constanteX_2L2 = l2X_2 / divL2,
                           constanteX_1L2 = l2X_1 / divL2,
                           constanteV_iL2 = l2V_i / divL2;
                    //Sumar los resultados 
                    double valorConstanteX_2 = constanteX_2L0 +
                           constanteX_2L1 + constanteX_2L2,
                    valorConstanteX_1 = constanteX_1L0 +
                           constanteX_1L1 + constanteX_1L2,
                    valorConstanteInd = constanteV_iL0 +
                           constanteV_iL1 + constanteV_iL2;
                    //Imprimir los resultados
                    txtValorCX_3.Text = valorConstanteX_2.ToString();
                    txtValorCX_2.Text = valorConstanteX_1.ToString();
                    txtValorCX_1.Text = valorConstanteInd.ToString();
                }
            }//Fin 3 pares de coodenadas

            //Para cuando son 4 pares de coodenadas
            else if (cbxTamanio.SelectedIndex == 2)
            {
                if (txtX0.Text == string.Empty || txtX1.Text == string.Empty ||
                    txtX2.Text == string.Empty || txtX3.Text == string.Empty ||
                    txtY0.Text == string.Empty || txtY1.Text == string.Empty ||
                    txtY2.Text == string.Empty || txtY3.Text == string.Empty)
                {
                    MessageBox.Show("Rellenar todos los campos", "Error",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                }
                else{
                    //Declaracion de coordenadas de X y Y
                    double x0 = Convert.ToDouble(txtX0.Text),
                           y0 = Convert.ToDouble(txtY0.Text),
                           x1 = Convert.ToDouble(txtX1.Text),
                           y1 = Convert.ToDouble(txtY1.Text),
                           x2 = Convert.ToDouble(txtX2.Text),
                           y2 = Convert.ToDouble(txtY2.Text),
                           x3 = Convert.ToDouble(txtX3.Text),
                           y3 = Convert.ToDouble(txtY3.Text);

                    //Calcular valores de las constantes para L0
                    //Calcular los valores de el producto de la multiplicacion de (X - Xn)
                    double valorX_3L0 = 1,
                           valorX_2L0 = (-x3) + (-x2) + (-x1),
                           valorX_1L0 = (-x1) * (-x2) + (-x1) * (-x3) + (-x2) * (-x3),
                           valorIndL0 = (-x1) * (-x2) * (-x3);
                    //Calcular la multiplicacion de los productos de la funcion por Y0
                    double l0X_3 = y0 * valorX_3L0,
                           l0X_2 = y0 * valorX_2L0,
                           l0X_1 = y0 * valorX_1L0,
                           l0V_i = y0 * valorIndL0;
                    //Calcular el valor con el que se dividiran los valores de la funcion
                    double divL0 = (x0 - x1) * (x0 - x2) * (x0 - x3);
                    //Dividir los valores de las constantes de la funcion 
                    double constanteX_3L0 = l0X_3 / divL0,
                           constanteX_2L0 = l0X_2 / divL0,
                           constanteX_1L0 = l0X_1 / divL0,
                           constanteV_iL0 = l0V_i / divL0;

                    //Calcular los valores para L1
                    double valorX_3L1 = 1,
                           valorX_2L1 = (-x3) + (-x2) + (-x0),
                           valorX_1L1 = (-x0) * (-x2) + (-x0) * (-x3) + (-x2) * (-x3),
                           valorIndL1 = (-x0) * (-x2) * (-x3);
                    //Calcular la multiplicacion de los productos de la funcion por Y1
                    double l1X_3 = y1 * valorX_3L1,
                           l1X_2 = y1 * valorX_2L1,
                           l1X_1 = y1 * valorX_1L1,
                           l1V_i = y1 * valorIndL1;
                    //Calcular el valor con el que se dividiran los valores de la funcion
                    double divL1 = (x1 - x0) * (x1 - x2) * (x1 - x3);
                    //Dividir los valores de las constantes de la funcion 
                    double constanteX_3L1 = l1X_3 / divL1,
                           constanteX_2L1 = l1X_2 / divL1,
                           constanteX_1L1 = l1X_1 / divL1,
                           constanteV_iL1 = l1V_i / divL1;
                    //Calcular los valores para L2
                    double valorX_3L2 = 1,
                           valorX_2L2 = (-x3) + (-x1) + (-x0),
                           valorX_1L2 = (-x0) * (-x1) + (-x0) * (-x3) + (-x1) * (-x3),
                           valorIndL2 = (-x0) * (-x1) * (-x3);
                    //Calcular la multiplicacion de los productos de la funcion por Y2
                    double l2X_3 = y2 * valorX_3L2,
                           l2X_2 = y2 * valorX_2L2,
                           l2X_1 = y2 * valorX_1L2,
                           l2V_i = y2 * valorIndL2;
                    //Calcular el valor con el que se dividiran los valores de la funcion
                    double divL2 = (x2 - x0) * (x2 - x1) * (x2 - x3);
                    //Dividir los valores de las constantes de la funcion 
                    double constanteX_3L2 = l2X_3 / divL2,
                           constanteX_2L2 = l2X_2 / divL2,
                           constanteX_1L2 = l2X_1 / divL2,
                           constanteV_iL2 = l2V_i / divL2;
                    //Calcular los valores para L3
                    double valorX_3L3 = 1,
                           valorX_2L3 = (-x2) + (-x1) + (-x0),
                           valorX_1L3 = (-x0) * (-x1) + (-x0) * (-x2) + (-x1) * (-x2),
                           valorIndL3 = (-x0) * (-x1) * (-x2);
                    //Calcular la multiplicacion de los productos de la funcion por Y2
                    double l3X_3 = y3 * valorX_3L3,
                           l3X_2 = y3 * valorX_2L3,
                           l3X_1 = y3 * valorX_1L3,
                           l3V_i = y3 * valorIndL3;
                    //Calcular el valor con el que se dividiran los valores de la funcion
                    double divL3 = (x3 - x0) * (x3 - x1) * (x3 - x2);
                    //Dividir los valores de las constantes de la funcion 
                    double constanteX_3L3 = l3X_3 / divL3,
                           constanteX_2L3 = l3X_2 / divL3,
                           constanteX_1L3 = l3X_1 / divL3,
                           constanteV_iL3 = l3V_i / divL3;
                    //Sumar los valores de las constantes
                    double valorConstanteX_3 = constanteX_3L0 +
                           constanteX_3L1 + constanteX_3L2 + constanteX_3L3,
                    valorConstanteX_2 = constanteX_2L0 +
                           constanteX_2L1 + constanteX_2L2 + constanteX_2L3,
                    valorConstanteX_1 = constanteX_1L0 +
                           constanteX_1L1 + constanteX_1L2 + constanteX_1L3,
                    valorConstanteInd = constanteV_iL0 +
                           constanteV_iL1 + constanteV_iL2 + constanteV_iL3;
                    //Imprimir los valores obtenidos
                    txtValorCX_3.Text = valorConstanteX_3.ToString();
                    txtValorCX_2.Text = valorConstanteX_2.ToString();
                    txtValorCX_1.Text = valorConstanteX_1.ToString();
                    txtValorCInd.Text = valorConstanteInd.ToString();
                }
            }//Fin 4 pares de coodenadas
        }//Fin btnCalcular_Click

        private void btnColorP2_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;
            }
        }

        private void btnColorFondo_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if ( result == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }

        private void panel3_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                panel3.BackColor = colorDialog1.Color;
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-Ingresar solo datos numericos\r\n" +
                "-Se pueden poner valores arbitrarios\r\n" +
                "-Para rellenar primero debe seleccionar un indice de la lista", 
                "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTipoFuente_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Font = fontDialog1.Font;
            }
        }
    }
}