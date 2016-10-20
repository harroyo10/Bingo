using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class Jugador
    {
        public string nombre { get; }
        public int cantidadCartones { get; }
        public List<CartonBingo> cartones { get; }

        public Jugador(string nombre, int cantidadCartones)
        {
            this.nombre = nombre;
            this.cantidadCartones = cantidadCartones;
        }
    }
}
