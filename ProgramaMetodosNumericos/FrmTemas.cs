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
    public partial class FrmTemas : Form
    {
        Thread hilo;
        public FrmTemas()
        {
            InitializeComponent();
            hilo = new Thread(cambiaColor);
            
        }

        private void btnTema1_Click(object sender, EventArgs e)
        {
            FrmTema1 frmTema1 = new FrmTema1();
            frmTema1.Show();           
        }

        private void btnTema3_Click(object sender, EventArgs e)
        {
            FrmTema3 frmTema3 = new FrmTema3();
            frmTema3.Show();
        }

        private void btnTema2_Click(object sender, EventArgs e)
        {
            FrmBiseccion frmBiseccion = new FrmBiseccion();
            frmBiseccion.Show();
        }

        private void btnTema4_Click(object sender, EventArgs e)
        {
            FrmTema4 frmTema4 = new FrmTema4();
            frmTema4.Show();    
        }

        private void btnTema5_Click(object sender, EventArgs e)
        {
            FrmTema5 frmTema5 = new FrmTema5();
            frmTema5.Show();
        }

        private void btnTema6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon", "No disponible", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void FrmTemas_Load(object sender, EventArgs e)
        {
            hilo.Start();
        }

        private void cambiaColor()
        {
            Random random = new Random();
            int colorRed;
            int colorGreen;
            int colorBlue;
            int colorRojo = random.Next(1, 255);
            int colorVerde = random.Next(1, 255);
            int colorAzul = random.Next(1, 255);

            for (;;)
            {
                colorRed = random.Next(0, 15);
                colorGreen = random.Next(0, 15);
                colorBlue = random.Next(0, 15);
                if (colorRed % 2 == 1)
                {
                    colorRed = colorRed * -1;
                }
                if (colorGreen % 2 == 1)
                {
                    colorGreen = colorGreen * -1;
                }
                if (colorBlue % 2 == 1)
                {
                    colorBlue = colorBlue * -1;
                }

                if (colorRojo + colorRed > 255)
                {
                    colorRojo -= colorRed;
                }
                else if (colorRojo + colorRed < 1)
                {
                    colorRojo -= colorRed;
                }
                else
                {
                    colorRojo += colorRed;
                }

                if (colorGreen + colorVerde > 255)
                {
                    colorVerde -= colorGreen;
                }
                else if (colorVerde + colorGreen < 1)
                {
                    colorVerde -= colorGreen;
                }
                else
                {
                    colorVerde += colorGreen;
                }

                if (colorBlue + colorAzul > 255)
                {
                    colorAzul -= colorBlue;
                }
                else if (colorAzul + colorBlue < 1)
                {
                    colorAzul -= colorBlue;
                }
                else
                {
                    colorAzul += colorBlue;
                }

                BackColor = Color.FromArgb(colorRojo, colorVerde, colorAzul);
                Thread.Sleep(10);
            }
        }

        private void FrmTemas_Click(object sender, EventArgs e)
        {
            if (hilo.IsAlive)
            {
                hilo.Abort();
            }
            else
            {
                hilo = new Thread(cambiaColor);
                hilo.Start();
            }
        }

        private void FrmTemas_Deactivate(object sender, EventArgs e)
        {
            hilo.Abort();
        }
    }
}