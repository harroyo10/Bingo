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
        public List<int> numerosJugados { get; }
        public List<int> numerosEnBiombo;

        public Juego(int totalNumeros, List<Jugador> jugadores, string modalidad)
        {
            Console.WriteLine("JUEGO INICIO");
            this.totalNumeros = totalNumeros;
            this.intervalo = (int)(totalNumeros / 5);
            this.modalidad = modalidad;
            this.jugadores = jugadores;
            HerramientasJuego.CrearCartonesDeJugadores(jugadores,intervalo,modalidad);
            this.numerosJugados = new List<int>();
            this.numerosEnBiombo = HerramientasJuego.GenerarNumerosEnBiombo(totalNumeros);

        }

        public Juego(int totalNumeros, string modalidad) {
            //Con el fin de llamarlo al unitTesting
            this.totalNumeros = totalNumeros;
            this.modalidad = modalidad;
        }

        public int SacarNumeroDeBiombo()
        {
            int numero = numerosEnBiombo[0];

            // Saco el numero del Biombo
            numerosEnBiombo.RemoveAt(0);

            // Se agrega el numero a la lista de los jugados
            numerosJugados.Add(numero);

            // Se ordena la lista de los numeros Jugados
            numerosJugados.Sort();

            return numero;
        }

        public List<CartonBingo> ObtenerAfortunados(int numero)
        {
            List<CartonBingo> cartonesAfortunados = new List<CartonBingo>();
            foreach (Jugador jugador in jugadores)
            {
                foreach(CartonBingo carton in jugador.cartones)
                {
                    if (carton.esAfortunado(numero))
                    {
                        cartonesAfortunados.Add(carton);
                    }
                }
            }
            return cartonesAfortunados;
        }
    
    }
}
