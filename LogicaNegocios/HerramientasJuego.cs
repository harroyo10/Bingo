using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class HerramientasJuego
    {

        static string[] NombresDeColumnas = new string[] { "B", "I", "N", "G", "O" };

        static Dictionary<string, ModalidadJuego> Modalidades = new Dictionary<string, ModalidadJuego>()
        {
            { "Cuatro Esquinas", new ModalidadJuego(new Dictionary<string, int[]>()
                {
                    { "B", new int[] { 1,0,0,0,1 } },
                    { "I", new int[] { 0,0,0,0,0 } },
                    { "N", new int[] { 0,0,0,0,0 } },
                    { "G", new int[] { 0,0,0,0,0 } },
                    { "O", new int[] { 1,0,0,0,1 } }
                })
            },
             { "Cartón Lleno", new ModalidadJuego(new Dictionary<string, int[]>()
                {
                    { "B", new int[] { 1,1,1,1,1 } },
                    { "I", new int[] { 1,1,1,1,1 } },
                    { "N", new int[] { 1,1,1,1,1 } },
                    { "G", new int[] { 1,1,1,1,1 } },
                    { "O", new int[] { 1,1,1,1,1 } }
                })
            }
        };
           
        public static bool sonCartonesIguales(CartonBingo carton1, CartonBingo carton2)
        {
            return carton1.ImprimirValoresCarton() == carton2.ImprimirValoresCarton();
        }

        public static string[] GetNombresDeColumnas()
        {
            return NombresDeColumnas;
        }

        public static string EncontrarAQueColumnaPertenece(int numero, int intervalo)
        {
            return NombresDeColumnas[(int)Math.Floor((double)((numero - 1) / intervalo))];
        }

        public static int[] EncontrarIntervaloDeColumna(string columna, int intervalo)
        {
            int indice = Array.IndexOf(NombresDeColumnas, columna);
            int minimo = intervalo * indice + 1;
            int maximo = intervalo * indice + intervalo;
            return new int[] { minimo, maximo };
        }

        
        public static string[] GetNombreDeModalidades()
        {
            return Modalidades.Keys.ToArray();
        }

        public static ModalidadJuego GetModalidad(string nombre)
        {
            return Modalidades[nombre];
        }
        
        public static void CrearCartonesDeJugadores(List<Jugador> jugadores, int intervalo, string modalidad)
        {
            foreach (Jugador jugador in jugadores)
            {
                for(int i=0; i<jugador.cantidadCartones; i++)
                {
                    jugador.cartones.Add(new CartonBingo(intervalo, modalidad));
                }
            }
        }

    }

}
