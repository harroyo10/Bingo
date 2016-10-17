using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas
{
    public class ConsultarArray
    {
        public static bool estaElNumeroEnArray(int[] elArray, int elNumeroAConsultar)
        {
            // TO DO
            return false;
        }

        public static string imprimirArray(int[] elArray)
        {
            return string.Join(",", elArray);
        }

        public static Boolean sonArraysIguales(int[] array1, int[] array2)
        {
            return array1.SequenceEqual(array2);
        }
    }
}
