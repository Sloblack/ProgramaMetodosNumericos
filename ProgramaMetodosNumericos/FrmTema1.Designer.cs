namespace ProgramaMetodosNumericos
{
    partial class FrmTema1
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
            this.txtNumeroIngresado = new System.Windows.Forms.TextBox();
            this.lblIngresaNumero = new System.Windows.Forms.Label();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.btnCalculoSerie = new System.Windows.Forms.Button();
            this.txtNumCifras = new System.Windows.Forms.TextBox();
            this.txtVariableX = new System.Windows.Forms.TextBox();
            this.lblCifras = new System.Windows.Forms.Label();
            this.lblVariableX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lVwSerieMc = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnCambiarColor = new System.Windows.Forms.Button();
            this.btnFuente = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.lblNumeroCifras = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumeroIngresado
            // 
            this.txtNumeroIngresado.Location = new System.Drawing.Point(9, 91);
            this.txtNumeroIngresado.Name = "txtNumeroIngresado";
            this.txtNumeroIngresado.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroIngresado.TabIndex = 0;
            // 
            // lblIngresaNumero
            // 
            this.lblIngresaNumero.AutoSize = true;
            this.lblIngresaNumero.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblIngresaNumero.Location = new System.Drawing.Point(9, 72);
            this.lblIngresaNumero.Name = "lblIngresaNumero";
            this.lblIngresaNumero.Size = new System.Drawing.Size(80, 13);
            this.lblIngresaNumero.TabIndex = 1;
            this.lblIngresaNumero.Text = "Ingresa número";
            // 
            // btnComprobar
            // 
            this.btnComprobar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnComprobar.Location = new System.Drawing.Point(131, 91);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(75, 23);
            this.btnComprobar.TabIndex = 2;
            this.btnComprobar.Text = "Contar Cifras";
            this.btnComprobar.UseVisualStyleBackColor = false;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // btnCalculoSerie
            // 
            this.btnCalculoSerie.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCalculoSerie.Location = new System.Drawing.Point(190, 307);
            this.btnCalculoSerie.Name = "btnCalculoSerie";
            this.btnCalculoSerie.Size = new System.Drawing.Size(87, 29);
            this.btnCalculoSerie.TabIndex = 3;
            this.btnCalculoSerie.Text = "Calcular";
            this.btnCalculoSerie.UseVisualStyleBackColor = false;
            this.btnCalculoSerie.Click += new System.EventHandler(this.btnCalculoSerie_Click);
            // 
            // txtNumCifras
            // 
            this.txtNumCifras.Location = new System.Drawing.Point(14, 263);
            this.txtNumCifras.Name = "txtNumCifras";
            this.txtNumCifras.Size = new System.Drawing.Size(39, 20);
            this.txtNumCifras.TabIndex = 4;
            // 
            // txtVariableX
            // 
            this.txtVariableX.Location = new System.Drawing.Point(12, 315);
            this.txtVariableX.Name = "txtVariableX";
            this.txtVariableX.Size = new System.Drawing.Size(41, 20);
            this.txtVariableX.TabIndex = 5;
            // 
            // lblCifras
            // 
            this.lblCifras.AutoSize = true;
            this.lblCifras.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblCifras.Location = new System.Drawing.Point(9, 247);
            this.lblCifras.Name = "lblCifras";
            this.lblCifras.Size = new System.Drawing.Size(197, 13);
            this.lblCifras.TabIndex = 7;
            this.lblCifras.Text = "Ingrese el numero de cifras significativas";
            // 
            // lblVariableX
            // 
            this.lblVariableX.AutoSize = true;
            this.lblVariableX.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblVariableX.Location = new System.Drawing.Point(9, 299);
            this.lblVariableX.Name = "lblVariableX";
            this.lblVariableX.Size = new System.Drawing.Size(94, 13);
            this.lblVariableX.TabIndex = 8;
            this.lblVariableX.Text = "Ingrese Valor de X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cifra Significativa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(9, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Serie de Maclaurin";
            // 
            // lVwSerieMc
            // 
            this.lVwSerieMc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lVwSerieMc.HideSelection = false;
            this.lVwSerieMc.Location = new System.Drawing.Point(292, 61);
            this.lVwSerieMc.Name = "lVwSerieMc";
            this.lVwSerieMc.Size = new System.Drawing.Size(375, 392);
            this.lVwSerieMc.TabIndex = 11;
            this.lVwSerieMc.UseCompatibleStateImageBehavior = false;
            this.lVwSerieMc.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Iteración";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Resultado";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Es";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ea";
            this.columnHeader4.Width = 90;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLimpiar.Location = new System.Drawing.Point(190, 345);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 29);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar Tabla";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRegresar.Location = new System.Drawing.Point(9, 431);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 13;
            this.btnRegresar.Text = "<Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCambiarColor
            // 
            this.btnCambiarColor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCambiarColor.Location = new System.Drawing.Point(113, 430);
            this.btnCambiarColor.Name = "btnCambiarColor";
            this.btnCambiarColor.Size = new System.Drawing.Size(134, 23);
            this.btnCambiarColor.TabIndex = 14;
            this.btnCambiarColor.Text = "Cambiar color de fondo";
            this.btnCambiarColor.UseVisualStyleBackColor = false;
            this.btnCambiarColor.Click += new System.EventHandler(this.btnCambiarColor_Click);
            // 
            // btnFuente
            // 
            this.btnFuente.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnFuente.Location = new System.Drawing.Point(113, 401);
            this.btnFuente.Name = "btnFuente";
            this.btnFuente.Size = new System.Drawing.Size(134, 23);
            this.btnFuente.TabIndex = 15;
            this.btnFuente.Text = "Cambiar Tipo de Fuente";
            this.btnFuente.UseVisualStyleBackColor = false;
            this.btnFuente.Click += new System.EventHandler(this.btnFuente_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAyuda.Location = new System.Drawing.Point(9, 401);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(75, 23);
            this.btnAyuda.TabIndex = 16;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // lblNumeroCifras
            // 
            this.lblNumeroCifras.AutoSize = true;
            this.lblNumeroCifras.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblNumeroCifras.Location = new System.Drawing.Point(54, 128);
            this.lblNumeroCifras.Name = "lblNumeroCifras";
            this.lblNumeroCifras.Size = new System.Drawing.Size(13, 13);
            this.lblNumeroCifras.TabIndex = 17;
            this.lblNumeroCifras.Text = "?";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label.Location = new System.Drawing.Point(9, 128);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(36, 13);
            this.label.TabIndex = 18;
            this.label.Text = "Cifras:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Location = new System.Drawing.Point(9, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Valor:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblValor.Location = new System.Drawing.Point(54, 353);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(13, 13);
            this.lblValor.TabIndex = 19;
            this.lblValor.Text = "?";
            // 
            // FrmTema1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(681, 466);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblNumeroCifras);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnFuente);
            this.Controls.Add(this.btnCambiarColor);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lVwSerieMc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVariableX);
            this.Controls.Add(this.lblCifras);
            this.Controls.Add(this.txtVariableX);
            this.Controls.Add(this.txtNumCifras);
            this.Controls.Add(this.btnCalculoSerie);
            this.Controls.Add(this.btnComprobar);
            this.Controls.Add(this.lblIngresaNumero);
            this.Controls.Add(this.txtNumeroIngresado);
            this.Name = "FrmTema1";
            this.Text = "Serie de MacLaurin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroIngresado;
        private System.Windows.Forms.Label lblIngresaNumero;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.Button btnCalculoSerie;
        private System.Windows.Forms.TextBox txtNumCifras;
        private System.Windows.Forms.TextBox txtVariableX;
        private System.Windows.Forms.Label lblCifras;
        private System.Windows.Forms.Label lblVariableX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lVwSerieMc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnCambiarColor;
        private System.Windows.Forms.Button btnFuente;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label lblNumeroCifras;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValor;
    }
}