﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Burbuja.models
{
    internal class MetBurbuja
    {
        // Metodo para ordenar el arreglo
        public void OrdenarBurbuja(int[] arreglo)
        {
            // Ciclo para recorrer el arreglo
            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int j = i + 1; j < arreglo.Length; j++)
                {
                    if (arreglo[j] < arreglo[i])
                    {
                        int tempo = arreglo[j];
                        arreglo[j] = arreglo[i];
                        arreglo[i] = tempo;
                    }
                }
            }
        }
    }
}
