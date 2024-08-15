using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ej3Guia1._1ProgII.Models
{
    internal class Peaje
    {
        public int PromCantVehiculosDelMes
        {
            get; 
            set;
        }
        public int contador = 0;
        int[] Cantidades = new int[31];

        public void RegistrarResumenDelDia(int dia, int cantidadVehiculos)
        {
            Cantidades[dia-1] = cantidadVehiculos;
            contador++;
        }
        public int MayorMovimiento()
        {
            int aux=0;
            for (int i = 0; i < contador-1; i++) 
            {
                for (int j = i + 1; j < contador; j++)
                {
                    if (Cantidades[i] < Cantidades[j])
                    {
                        aux = j;
                        j = i;  
                        i = aux;
                    }
                }
            }
            return aux;
        }
    }
}
