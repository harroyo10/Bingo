using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class Jugador
    {
        public string nombre { set; get; }
        public int cantidadCartones { set; get; }
        public CartonBingo[] cartones { set; get; }

        public Jugador()
        {
            
        }
    }
}
