using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class Juego
    {
        public int totalNumeros { get; }
        public List<Jugador> jugadores { get; }
        public int intervalo { get; }
        public string modalidad { get; }

        public Juego(int totalNumeros, List<Jugador> jugadores, string modalidad)
        {
            Console.WriteLine("JUEGO INICIO");
            this.totalNumeros = totalNumeros;
            this.intervalo = (int)(totalNumeros / 5);
            this.modalidad = modalidad;
            this.jugadores = jugadores;
            HerramientasJuego.CrearCartonesDeJugadores(jugadores,intervalo,modalidad);
        }
    }
}
