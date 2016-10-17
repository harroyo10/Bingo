using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas
{
    public class CrearArray
    {
        public static int[] CrearRandomArray(int cantidadCampos, int minimo, int maximo)
        {
            int[] arrayInicial = new int[maximo-minimo+1];
            int[] arrayFinal = new int[cantidadCampos];

            // llenamos el array inicial con todos los posibles valores de minimo a maximo
            for (int i = 0; i<=(maximo-minimo); i++)
            {
                arrayInicial[i] = i+minimo;
            }

            // desordenamos el Array
            int[] arrayDesordenado = ModificarArray.DesordenarArray(arrayInicial);

            // seleccionamos solo la cantidad de campos que ocupamos para el array
            for (int j=0; j<cantidadCampos; j++)
            {
                arrayFinal[j] = arrayDesordenado[j];
            }

            return arrayFinal;
        } 

         
    }
}
