namespace Ej1Guia1._1ProgII
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.upModelo = new System.Windows.Forms.NumericUpDown();
            this.upAñoCalcular = new System.Windows.Forms.NumericUpDown();
            this.tbValorFabrica = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTasa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVida = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.upModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upAñoCalcular)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(89, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(46, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo (año):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(42, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año a calcular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(5, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor de fabricación:";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(153, 12);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(100, 20);
            this.tbMarca.TabIndex = 4;
            // 
            // upModelo
            // 
            this.upModelo.Location = new System.Drawing.Point(153, 38);
            this.upModelo.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.upModelo.Minimum = new decimal(new int[] {
            1886,
            0,
            0,
            0});
            this.upModelo.Name = "upModelo";
            this.upModelo.ReadOnly = true;
            this.upModelo.Size = new System.Drawing.Size(68, 20);
            this.upModelo.TabIndex = 5;
            this.upModelo.Value = new decimal(new int[] {
            1886,
            0,
            0,
            0});
            // 
            // upAñoCalcular
            // 
            this.upAñoCalcular.Location = new System.Drawing.Point(153, 64);
            this.upAñoCalcular.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.upAñoCalcular.Minimum = new decimal(new int[] {
            1886,
            0,
            0,
            0});
            this.upAñoCalcular.Name = "upAñoCalcular";
            this.upAñoCalcular.ReadOnly = true;
            this.upAñoCalcular.Size = new System.Drawing.Size(68, 20);
            this.upAñoCalcular.TabIndex = 6;
            this.upAñoCalcular.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // tbValorFabrica
            // 
            this.tbValorFabrica.Location = new System.Drawing.Point(153, 90);
            this.tbValorFabrica.Name = "tbValorFabrica";
            this.tbValorFabrica.Size = new System.Drawing.Size(100, 20);
            this.tbValorFabrica.TabIndex = 7;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(12, 129);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(102, 49);
            this.btCalcular.TabIndex = 8;
            this.btCalcular.Text = "Calcular costo";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(151, 129);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(102, 49);
            this.btCerrar.TabIndex = 9;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(286, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tasa de depreciación:";
            // 
            // tbTasa
            // 
            this.tbTasa.Location = new System.Drawing.Point(445, 12);
            this.tbTasa.Name = "tbTasa";
            this.tbTasa.Size = new System.Drawing.Size(61, 20);
            this.tbTasa.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(330, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Vida util (años):";
            // 
            // tbVida
            // 
            this.tbVida.Location = new System.Drawing.Point(445, 41);
            this.tbVida.Name = "tbVida";
            this.tbVida.Size = new System.Drawing.Size(61, 20);
            this.tbVida.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 188);
            this.Controls.Add(this.tbVida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTasa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.tbValorFabrica);
            this.Controls.Add(this.upAñoCalcular);
            this.Controls.Add(this.upModelo);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tasación de motos";
            ((System.ComponentModel.ISupportInitialize)(this.upModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upAñoCalcular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.NumericUpDown upModelo;
        private System.Windows.Forms.NumericUpDown upAñoCalcular;
        private System.Windows.Forms.TextBox tbValorFabrica;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTasa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVida;
    }
}

