using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class Juego
    {
        public int totalNumeros { get; set; }
        public int totalJugadores { get; set; }
        public Jugador[] jugadores { get; set; }
        public int intervalo { get; set; }

        public Juego(int totalNumeros, int totalJugadores)
        {
            Console.WriteLine("JUEGO INICIO");
            this.totalNumeros = totalNumeros;
            this.intervalo = (int)(totalNumeros / 5);
        }
    }
}
