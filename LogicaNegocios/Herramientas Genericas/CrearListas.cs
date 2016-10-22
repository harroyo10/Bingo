using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class CrearListas
    {
        public static List<int> CrearListaDesordenada(int minimo, int maximo)
        {
            List<int> lista = new List<int>();

            // llenamos la lista inicial con todos los posibles valores de la lista
            for (int i = minimo; i <= maximo; i++)
            {
                lista.Add(i);
            }

            return ModificarListas.DesordenarLista(lista);
        } 

         
    }
}
