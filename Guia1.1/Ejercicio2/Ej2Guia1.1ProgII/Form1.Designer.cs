namespace Ej2Guia1._1ProgII
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
            this.btIniciarViaje = new System.Windows.Forms.Button();
            this.btIngresarParada = new System.Windows.Forms.Button();
            this.gbFinalizarParada = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHoraFinalizacion = new System.Windows.Forms.TextBox();
            this.tbMinFinalizacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btFinalizarViaje = new System.Windows.Forms.Button();
            this.gbFinalizarParada.SuspendLayout();
            this.SuspendLayout();
            // 
            // btIniciarViaje
            // 
            this.btIniciarViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btIniciarViaje.Location = new System.Drawing.Point(12, 12);
            this.btIniciarViaje.Name = "btIniciarViaje";
            this.btIniciarViaje.Size = new System.Drawing.Size(300, 23);
            this.btIniciarViaje.TabIndex = 0;
            this.btIniciarViaje.Text = "Iniciar viaje";
            this.btIniciarViaje.UseVisualStyleBackColor = true;
            // 
            // btIngresarParada
            // 
            this.btIngresarParada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btIngresarParada.Location = new System.Drawing.Point(12, 41);
            this.btIngresarParada.Name = "btIngresarParada";
            this.btIngresarParada.Size = new System.Drawing.Size(300, 23);
            this.btIngresarParada.TabIndex = 1;
            this.btIngresarParada.Text = "Iniciar parada";
            this.btIngresarParada.UseVisualStyleBackColor = true;
            // 
            // gbFinalizarParada
            // 
            this.gbFinalizarParada.Controls.Add(this.btFinalizarViaje);
            this.gbFinalizarParada.Controls.Add(this.label2);
            this.gbFinalizarParada.Controls.Add(this.tbMinFinalizacion);
            this.gbFinalizarParada.Controls.Add(this.tbHoraFinalizacion);
            this.gbFinalizarParada.Controls.Add(this.label1);
            this.gbFinalizarParada.Location = new System.Drawing.Point(12, 70);
            this.gbFinalizarParada.Name = "gbFinalizarParada";
            this.gbFinalizarParada.Size = new System.Drawing.Size(300, 80);
            this.gbFinalizarParada.TabIndex = 2;
            this.gbFinalizarParada.TabStop = false;
            this.gbFinalizarParada.Text = "Finalizar Parada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora de Finalizacion [HH:MM]";
            // 
            // tbHoraFinalizacion
            // 
            this.tbHoraFinalizacion.Location = new System.Drawing.Point(201, 15);
            this.tbHoraFinalizacion.Name = "tbHoraFinalizacion";
            this.tbHoraFinalizacion.Size = new System.Drawing.Size(33, 20);
            this.tbHoraFinalizacion.TabIndex = 1;
            // 
            // tbMinFinalizacion
            // 
            this.tbMinFinalizacion.Location = new System.Drawing.Point(256, 15);
            this.tbMinFinalizacion.Name = "tbMinFinalizacion";
            this.tbMinFinalizacion.Size = new System.Drawing.Size(33, 20);
            this.tbMinFinalizacion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(240, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = ":";
            // 
            // btFinalizarViaje
            // 
            this.btFinalizarViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btFinalizarViaje.Location = new System.Drawing.Point(9, 48);
            this.btFinalizarViaje.Name = "btFinalizarViaje";
            this.btFinalizarViaje.Size = new System.Drawing.Size(280, 23);
            this.btFinalizarViaje.TabIndex = 3;
            this.btFinalizarViaje.Text = "Finalizar Viaje";
            this.btFinalizarViaje.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 154);
            this.Controls.Add(this.gbFinalizarParada);
            this.Controls.Add(this.btIngresarParada);
            this.Controls.Add(this.btIniciarViaje);
            this.Name = "Form1";
            this.Text = "Empresa de viajes";
            this.gbFinalizarParada.ResumeLayout(false);
            this.gbFinalizarParada.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btIniciarViaje;
        private System.Windows.Forms.Button btIngresarParada;
        private System.Windows.Forms.GroupBox gbFinalizarParada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMinFinalizacion;
        private System.Windows.Forms.TextBox tbHoraFinalizacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btFinalizarViaje;
    }
}

