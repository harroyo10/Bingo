using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas
{
    public class ConsultarArray
    {
        public static bool EstaElNumeroEnArray(int[] elArray, int elNumeroAConsultar)
        {
            // TO DO
            return false;
        }

        public static string ImprimirArray(int[] elArray)
        {
            return string.Join(",", elArray);
        }

        public static Boolean SonArraysIguales(int[] array1, int[] array2)
        {
            return ImprimirArray(array1) == ImprimirArray(array2);
        }
    }
}
