using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1Guia1._1ProgII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            string marca = tbMarca.Text;
            int modelo = Convert.ToInt32(upModelo.Value);
            int añoACalcular = Convert.ToInt32(upAñoCalcular.Value);
            double valorFabricacion = Convert.ToDouble(tbValorFabrica.Text);
            double tasaDepre = Convert.ToDouble(tbTasa.Text);
            int vidaUtil = Convert.ToInt32(tbVida.Text);

            ClassMoto miMoto = new ClassMoto(marca, modelo, valorFabricacion);

            double depreLineal = miMoto.CalcularDepreciacionLineal(añoACalcular,vidaUtil);
            double depreAnual = miMoto.CalcularDepreciacionAnual(añoACalcular,tasaDepre);

            fVerResultados vMostrar = new fVerResultados();
            
            vMostrar.lbResultados.Items.Add(miMoto.VerDescripcion());

            vMostrar.lbResultados.Items.Add($"Depreciación lineal: ${depreLineal,10:f2}");

            vMostrar.lbResultados.Items.Add($"Depreciación anual:  ${depreAnual,10:f2}");

            vMostrar.ShowDialog();
        }
    }
}
