namespace Ej2Guia1._1ProgII
{
    partial class FInforme
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
            this.gbInformeDelViaje = new System.Windows.Forms.GroupBox();
            this.lbResultados = new System.Windows.Forms.ListBox();
            this.btCerrar = new System.Windows.Forms.Button();
            this.gbInformeDelViaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInformeDelViaje
            // 
            this.gbInformeDelViaje.Controls.Add(this.btCerrar);
            this.gbInformeDelViaje.Controls.Add(this.lbResultados);
            this.gbInformeDelViaje.Location = new System.Drawing.Point(4, 7);
            this.gbInformeDelViaje.Name = "gbInformeDelViaje";
            this.gbInformeDelViaje.Size = new System.Drawing.Size(358, 259);
            this.gbInformeDelViaje.TabIndex = 0;
            this.gbInformeDelViaje.TabStop = false;
            this.gbInformeDelViaje.Text = "Informe del viaje";
            // 
            // lbResultados
            // 
            this.lbResultados.FormattingEnabled = true;
            this.lbResultados.Location = new System.Drawing.Point(6, 19);
            this.lbResultados.Name = "lbResultados";
            this.lbResultados.Size = new System.Drawing.Size(346, 199);
            this.lbResultados.TabIndex = 0;
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(142, 224);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 23);
            this.btCerrar.TabIndex = 1;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            // 
            // FInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 271);
            this.Controls.Add(this.gbInformeDelViaje);
            this.Name = "FInforme";
            this.Text = "Informe";
            this.gbInformeDelViaje.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInformeDelViaje;
        private System.Windows.Forms.Button btCerrar;
        public System.Windows.Forms.ListBox lbResultados;
    }
}