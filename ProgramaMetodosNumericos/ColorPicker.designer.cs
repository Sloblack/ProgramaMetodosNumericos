namespace ComponentesPersonalizadosPractica
{
    partial class ColorPicker
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorRojo = new System.Windows.Forms.Label();
            this.colorCyan = new System.Windows.Forms.Label();
            this.colorRey = new System.Windows.Forms.Label();
            this.colorNaranja = new System.Windows.Forms.Label();
            this.colorPurpura = new System.Windows.Forms.Label();
            this.colorVerde = new System.Windows.Forms.Label();
            this.colorRosa = new System.Windows.Forms.Label();
            this.colorAmarillo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // colorRojo
            // 
            this.colorRojo.BackColor = System.Drawing.Color.Red;
            this.colorRojo.Location = new System.Drawing.Point(2, 28);
            this.colorRojo.Name = "colorRojo";
            this.colorRojo.Size = new System.Drawing.Size(30, 30);
            this.colorRojo.TabIndex = 0;
            this.colorRojo.Click += new System.EventHandler(this.colorRojo_Click);
            // 
            // colorCyan
            // 
            this.colorCyan.BackColor = System.Drawing.Color.Cyan;
            this.colorCyan.Location = new System.Drawing.Point(2, 79);
            this.colorCyan.Name = "colorCyan";
            this.colorCyan.Size = new System.Drawing.Size(30, 30);
            this.colorCyan.TabIndex = 1;
            this.colorCyan.Click += new System.EventHandler(this.colorCyan_Click);
            // 
            // colorRey
            // 
            this.colorRey.BackColor = System.Drawing.Color.Blue;
            this.colorRey.Location = new System.Drawing.Point(50, 79);
            this.colorRey.Name = "colorRey";
            this.colorRey.Size = new System.Drawing.Size(30, 30);
            this.colorRey.TabIndex = 3;
            this.colorRey.Click += new System.EventHandler(this.colorRey_Click);
            // 
            // colorNaranja
            // 
            this.colorNaranja.BackColor = System.Drawing.Color.DarkOrange;
            this.colorNaranja.Location = new System.Drawing.Point(50, 28);
            this.colorNaranja.Name = "colorNaranja";
            this.colorNaranja.Size = new System.Drawing.Size(30, 30);
            this.colorNaranja.TabIndex = 2;
            this.colorNaranja.Click += new System.EventHandler(this.colorNaranja_Click);
            // 
            // colorPurpura
            // 
            this.colorPurpura.BackColor = System.Drawing.Color.Purple;
            this.colorPurpura.Location = new System.Drawing.Point(143, 79);
            this.colorPurpura.Name = "colorPurpura";
            this.colorPurpura.Size = new System.Drawing.Size(30, 30);
            this.colorPurpura.TabIndex = 7;
            this.colorPurpura.Click += new System.EventHandler(this.colorPurpura_Click);
            // 
            // colorVerde
            // 
            this.colorVerde.BackColor = System.Drawing.Color.Green;
            this.colorVerde.Location = new System.Drawing.Point(143, 28);
            this.colorVerde.Name = "colorVerde";
            this.colorVerde.Size = new System.Drawing.Size(30, 30);
            this.colorVerde.TabIndex = 6;
            this.colorVerde.Click += new System.EventHandler(this.colorVerde_Click);
            // 
            // colorRosa
            // 
            this.colorRosa.BackColor = System.Drawing.Color.HotPink;
            this.colorRosa.Location = new System.Drawing.Point(95, 79);
            this.colorRosa.Name = "colorRosa";
            this.colorRosa.Size = new System.Drawing.Size(30, 30);
            this.colorRosa.TabIndex = 5;
            this.colorRosa.Click += new System.EventHandler(this.colorRosa_Click);
            // 
            // colorAmarillo
            // 
            this.colorAmarillo.BackColor = System.Drawing.Color.Yellow;
            this.colorAmarillo.Location = new System.Drawing.Point(95, 28);
            this.colorAmarillo.Name = "colorAmarillo";
            this.colorAmarillo.Size = new System.Drawing.Size(30, 30);
            this.colorAmarillo.TabIndex = 4;
            this.colorAmarillo.Click += new System.EventHandler(this.colorAmarillo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Seleccione un color:";
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.colorPurpura);
            this.Controls.Add(this.colorVerde);
            this.Controls.Add(this.colorRosa);
            this.Controls.Add(this.colorAmarillo);
            this.Controls.Add(this.colorRey);
            this.Controls.Add(this.colorNaranja);
            this.Controls.Add(this.colorCyan);
            this.Controls.Add(this.colorRojo);
            this.Name = "ColorPicker";
            this.Size = new System.Drawing.Size(175, 116);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label colorRojo;
        private System.Windows.Forms.Label colorCyan;
        private System.Windows.Forms.Label colorRey;
        private System.Windows.Forms.Label colorNaranja;
        private System.Windows.Forms.Label colorPurpura;
        private System.Windows.Forms.Label colorVerde;
        private System.Windows.Forms.Label colorRosa;
        private System.Windows.Forms.Label colorAmarillo;
        private System.Windows.Forms.Label label8;
    }
}
