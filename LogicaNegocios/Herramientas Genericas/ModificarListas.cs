using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class ModificarListas
    {
        static Random numeroRandom = new Random();
        public static List<int> DesordenarLista(List<int> lista)
        {
            lista = lista.OrderBy(x => numeroRandom.Next()).ToList();
            return lista;
        }
    }
}
