using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentesPersonalizadosPractica
{
    public partial class InputConLabel : UserControl
    {

        private string texto;
        public string Texto
        {
            get { return texto; }
            set { texto = value;
                if (TextoChanged != null) { 
                    TextoChanged(this, EventArgs.Empty);
                }
            }
        }

        private char posicion;
        public char Posicion
        {
            get { return posicion; }
            set { posicion = value;
                if (Posicion == 'a')
                {
                    lblCampo.Location = new Point(50, 4);
                }
                else if (Posicion == 'i')
                {
                    lblCampo.Location = new Point(6, 23);
                }
                if (PosicionChanged != null)
                {
                    PosicionChanged(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler TextoChanged;
        public event EventHandler PosicionChanged;

        public InputConLabel()
        {
            InitializeComponent();
            Posicion = 'i';
        }

        private void txtTextoIngresado_TextChanged(object sender, EventArgs e)
        {
            Texto = txtTextoIngresado.Text;
        }

        private void lblCampo_Click(object sender, EventArgs e)
        {
            if (Posicion == 'i')
            {
                Posicion = 'a';
            }
            else if (Posicion == 'a')
            {
                Posicion = 'i';
            }   
        }
    }
}
