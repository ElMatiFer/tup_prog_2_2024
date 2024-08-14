using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1Guia1._1ProgII
{
    internal class ClassMoto
    {
        #region Propiedades
        public string Marca
        {
            get; private set;
        }
        public int Modelo
        {
            get; private set;
        }

        public double ValorFabricacion
        {
            get; private set;
        }
        #endregion
        
        #region Constructor y Metodos
        public ClassMoto(string marca, int modelo, double valorFabricacion)
        {   
            this.Marca = marca;
            this.Modelo = modelo;
            this.ValorFabricacion = valorFabricacion;
        }

        public double CalcularDepreciacionLineal(int añoACalcular, int vidaUtil)
        {
            return ValorFabricacion - (ValorFabricacion * (añoACalcular - Modelo) / vidaUtil);
        }

        public double CalcularDepreciacionAnual(int añoACalcular)
        {
            return ValorFabricacion * (Math.Pow(1 - 0.1, añoACalcular - Modelo));
        }

        public string VerDescripcion()
        {
            return $"| Marca:{Marca} | Modelo:{Modelo} | Valor Fabriación:$ {ValorFabricacion,10:f2} |";
        }
        #endregion
    }
}
