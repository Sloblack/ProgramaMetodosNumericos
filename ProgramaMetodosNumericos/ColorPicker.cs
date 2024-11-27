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
    public partial class ColorPicker : UserControl
    {

        private Color _color;

        public Color Color
        {
            get { return _color; }
            set { _color = value;
                if (ColorChanged != null)
                {
                    ColorChanged(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler ColorChanged;
        public ColorPicker()
        {
            InitializeComponent();
        }

        private void colorRojo_Click(object sender, EventArgs e)
        {
            Color = colorRojo.BackColor;
            DeseleccionarColor();
            colorRojo.BorderStyle = BorderStyle.Fixed3D;
        }

        private void colorCyan_Click(object sender, EventArgs e)
        {
            Color = colorCyan.BackColor;
            DeseleccionarColor();
            colorCyan.BorderStyle = BorderStyle.Fixed3D;
        }

        private void colorNaranja_Click(object sender, EventArgs e)
        {
            Color = colorNaranja.BackColor;
            DeseleccionarColor();
            colorNaranja.BorderStyle = BorderStyle.Fixed3D;
        }

        private void colorRey_Click(object sender, EventArgs e)
        {
            Color = colorRey.BackColor;
            DeseleccionarColor();
            colorRey.BorderStyle = BorderStyle.Fixed3D;
        }

        private void colorAmarillo_Click(object sender, EventArgs e)
        {
            Color = colorAmarillo.BackColor;
            DeseleccionarColor();
            colorAmarillo.BorderStyle = BorderStyle.Fixed3D;
        }

        private void colorRosa_Click(object sender, EventArgs e)
        {
            Color = colorRosa.BackColor;
            DeseleccionarColor();
            colorRosa.BorderStyle = BorderStyle.Fixed3D;
        }

        private void colorVerde_Click(object sender, EventArgs e)
        {
            Color = colorVerde.BackColor;
            DeseleccionarColor();
            colorVerde.BorderStyle = BorderStyle.Fixed3D;
        }

        private void colorPurpura_Click(object sender, EventArgs e)
        {
            Color = colorPurpura.BackColor;
            DeseleccionarColor();
            colorPurpura.BorderStyle = BorderStyle.Fixed3D;
        }

        private void DeseleccionarColor()
        {
            colorRojo.BorderStyle = BorderStyle.None;
            colorCyan.BorderStyle = BorderStyle.None;
            colorNaranja.BorderStyle = BorderStyle.None;
            colorRey.BorderStyle = BorderStyle.None;
            colorAmarillo.BorderStyle = BorderStyle.None;
            colorRosa.BorderStyle = BorderStyle.None;
            colorVerde.BorderStyle = BorderStyle.None;
            colorPurpura.BorderStyle = BorderStyle.None;
        }
    }
}
