using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas
{
    public  class ModificarArray
    {
        static Random numeroRandom = new Random();
        public static int[] DesordenarArray(int[] elArray)
        {
            int[] arrayDesordenado = elArray.OrderBy(x => numeroRandom.Next()).ToArray();
            return arrayDesordenado;
        }
    }
}
