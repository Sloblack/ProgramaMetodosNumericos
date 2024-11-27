namespace ProgramaMetodosNumericos
{
    partial class FrmBiseccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtConstanteA = new System.Windows.Forms.TextBox();
            this.txtConstanteB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPotenciaX1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConstanteC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lvwElementos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtIntervaloA = new System.Windows.Forms.TextBox();
            this.txtIntervaloB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCifra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPotenciaX2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtConstanteD = new System.Windows.Forms.TextBox();
            this.btnLimpiarLista = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCambiarColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnTipoFuente = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCalcular.Location = new System.Drawing.Point(574, 68);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(118, 27);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtConstanteA
            // 
            this.txtConstanteA.Location = new System.Drawing.Point(63, 69);
            this.txtConstanteA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtConstanteA.Name = "txtConstanteA";
            this.txtConstanteA.Size = new System.Drawing.Size(20, 21);
            this.txtConstanteA.TabIndex = 1;
            // 
            // txtConstanteB
            // 
            this.txtConstanteB.Location = new System.Drawing.Point(152, 70);
            this.txtConstanteB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtConstanteB.Name = "txtConstanteB";
            this.txtConstanteB.Size = new System.Drawing.Size(25, 21);
            this.txtConstanteB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(91, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(126, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "+";
            // 
            // txtPotenciaX1
            // 
            this.txtPotenciaX1.Location = new System.Drawing.Point(111, 46);
            this.txtPotenciaX1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPotenciaX1.Name = "txtPotenciaX1";
            this.txtPotenciaX1.Size = new System.Drawing.Size(23, 21);
            this.txtPotenciaX1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(182, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            // 
            // txtConstanteC
            // 
            this.txtConstanteC.Location = new System.Drawing.Point(238, 70);
            this.txtConstanteC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtConstanteC.Name = "txtConstanteC";
            this.txtConstanteC.Size = new System.Drawing.Size(24, 21);
            this.txtConstanteC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(205, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "+";
            // 
            // lvwElementos
            // 
            this.lvwElementos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvwElementos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvwElementos.HideSelection = false;
            this.lvwElementos.Location = new System.Drawing.Point(60, 137);
            this.lvwElementos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwElementos.Name = "lvwElementos";
            this.lvwElementos.Size = new System.Drawing.Size(766, 340);
            this.lvwElementos.TabIndex = 9;
            this.lvwElementos.UseCompatibleStateImageBehavior = false;
            this.lvwElementos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Iteración";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "a";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "b";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "m";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "F(a)";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "F(b)";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "F(m)";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ea";
            this.columnHeader8.Width = 80;
            // 
            // txtIntervaloA
            // 
            this.txtIntervaloA.Location = new System.Drawing.Point(417, 71);
            this.txtIntervaloA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIntervaloA.Name = "txtIntervaloA";
            this.txtIntervaloA.Size = new System.Drawing.Size(31, 21);
            this.txtIntervaloA.TabIndex = 11;
            // 
            // txtIntervaloB
            // 
            this.txtIntervaloB.Location = new System.Drawing.Point(467, 71);
            this.txtIntervaloB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIntervaloB.Name = "txtIntervaloB";
            this.txtIntervaloB.Size = new System.Drawing.Size(31, 21);
            this.txtIntervaloB.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(450, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = ",";
            // 
            // txtCifra
            // 
            this.txtCifra.Location = new System.Drawing.Point(523, 72);
            this.txtCifra.Name = "txtCifra";
            this.txtCifra.Size = new System.Drawing.Size(38, 21);
            this.txtCifra.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label7.Location = new System.Drawing.Point(520, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cifras";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label8.Location = new System.Drawing.Point(427, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "a";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label9.Location = new System.Drawing.Point(477, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.Location = new System.Drawing.Point(414, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Intervalos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label10.Location = new System.Drawing.Point(243, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Método de bisección";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLimpiar.Location = new System.Drawing.Point(699, 68);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(126, 27);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblResultado.Location = new System.Drawing.Point(698, 98);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(16, 17);
            this.lblResultado.TabIndex = 20;
            this.lblResultado.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label12.Location = new System.Drawing.Point(585, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Valor de la raiz:";
            // 
            // txtPotenciaX2
            // 
            this.txtPotenciaX2.Location = new System.Drawing.Point(206, 46);
            this.txtPotenciaX2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPotenciaX2.Name = "txtPotenciaX2";
            this.txtPotenciaX2.Size = new System.Drawing.Size(23, 21);
            this.txtPotenciaX2.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(293, 67);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "+";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label13.Location = new System.Drawing.Point(270, 68);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 25);
            this.label13.TabIndex = 24;
            this.label13.Text = "X";
            // 
            // txtConstanteD
            // 
            this.txtConstanteD.Location = new System.Drawing.Point(325, 71);
            this.txtConstanteD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtConstanteD.Name = "txtConstanteD";
            this.txtConstanteD.Size = new System.Drawing.Size(25, 21);
            this.txtConstanteD.TabIndex = 23;
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLimpiarLista.Location = new System.Drawing.Point(60, 104);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(126, 27);
            this.btnLimpiarLista.TabIndex = 26;
            this.btnLimpiarLista.Text = "Limpiar Lista";
            this.btnLimpiarLista.UseVisualStyleBackColor = false;
            this.btnLimpiarLista.Click += new System.EventHandler(this.btnLimpiarLista_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ejemplo 1",
            "Ejemplo 2",
            "Ejemplo 3"});
            this.comboBox1.Location = new System.Drawing.Point(192, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnRegresar.Location = new System.Drawing.Point(8, 483);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 29;
            this.btnRegresar.Text = "<Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCambiarColor
            // 
            this.btnCambiarColor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCambiarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCambiarColor.Location = new System.Drawing.Point(111, 483);
            this.btnCambiarColor.Name = "btnCambiarColor";
            this.btnCambiarColor.Size = new System.Drawing.Size(134, 23);
            this.btnCambiarColor.TabIndex = 30;
            this.btnCambiarColor.Text = "Cambiar color de fondo";
            this.btnCambiarColor.UseVisualStyleBackColor = false;
            this.btnCambiarColor.Click += new System.EventHandler(this.btnCambiarColor_Click);
            // 
            // btnTipoFuente
            // 
            this.btnTipoFuente.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTipoFuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnTipoFuente.Location = new System.Drawing.Point(273, 483);
            this.btnTipoFuente.Name = "btnTipoFuente";
            this.btnTipoFuente.Size = new System.Drawing.Size(134, 23);
            this.btnTipoFuente.TabIndex = 31;
            this.btnTipoFuente.Text = "Cambiar Tipo de Fuente";
            this.btnTipoFuente.UseVisualStyleBackColor = false;
            this.btnTipoFuente.Click += new System.EventHandler(this.btnTipoFuente_Click);
            // 
            // FrmBiseccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(881, 510);
            this.Controls.Add(this.btnTipoFuente);
            this.Controls.Add(this.btnCambiarColor);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnLimpiarLista);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtConstanteD);
            this.Controls.Add(this.txtPotenciaX2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCifra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIntervaloB);
            this.Controls.Add(this.txtIntervaloA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvwElementos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConstanteC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPotenciaX1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConstanteB);
            this.Controls.Add(this.txtConstanteA);
            this.Controls.Add(this.btnCalcular);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmBiseccion";
            this.Text = "Método de Bisección";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtConstanteA;
        private System.Windows.Forms.TextBox txtConstanteB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPotenciaX1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConstanteC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvwElementos;
        private System.Windows.Forms.TextBox txtIntervaloA;
        private System.Windows.Forms.TextBox txtIntervaloB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCifra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPotenciaX2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtConstanteD;
        private System.Windows.Forms.Button btnLimpiarLista;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCambiarColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnTipoFuente;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}