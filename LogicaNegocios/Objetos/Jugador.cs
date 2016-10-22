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
        public List<CartonBingo> cartones { set; get; }

        public Jugador(string nombre, int cantidadCartones)
        {
            this.nombre = nombre;
            this.cantidadCartones = cantidadCartones;
            this.cartones = new List<CartonBingo>();
        }
    }
}
