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
             { "Cartón Lleno", new ModalidadJuego(new Dictionary<string, int[]>()
                {
                    { "B", new int[] { 1,1,1,1,1 } },
                    { "I", new int[] { 1,1,1,1,1 } },
                    { "N", new int[] { 1,1,1,1,1 } },
                    { "G", new int[] { 1,1,1,1,1 } },
                    { "O", new int[] { 1,1,1,1,1 } }
                })
            },
            { "Cuatro Esquinas", new ModalidadJuego(new Dictionary<string, int[]>()
                {
                    { "B", new int[] { 1,0,0,0,1 } },
                    { "I", new int[] { 0,0,0,0,0 } },
                    { "N", new int[] { 0,0,0,0,0 } },
                    { "G", new int[] { 0,0,0,0,0 } },
                    { "O", new int[] { 1,0,0,0,1 } }
                })
            },
            { "Letra H", new ModalidadJuego(new Dictionary<string, int[]>()
                {
                    { "B", new int[] { 1,1,1,1,1 } },
                    { "I", new int[] { 0,0,1,0,0 } },
                    { "N", new int[] { 0,0,1,0,0 } },
                    { "G", new int[] { 0,0,1,0,0 } },
                    { "O", new int[] { 1,1,1,1,1 } }
                })
            },
            { "Letra X", new ModalidadJuego(new Dictionary<string, int[]>()
                {
                    { "B", new int[] { 1,0,0,0,1 } },
                    { "I", new int[] { 0,1,0,1,0 } },
                    { "N", new int[] { 0,0,1,0,0 } },
                    { "G", new int[] { 0,1,0,1,0 } },
                    { "O", new int[] { 1,0,0,0,1 } }
                })
            },
            { "Letra O", new ModalidadJuego(new Dictionary<string, int[]>()
                {
                    { "B", new int[] { 1,1,1,1,1 } },
                    { "I", new int[] { 1,0,0,0,1 } },
                    { "N", new int[] { 1,0,0,0,1 } },
                    { "G", new int[] { 1,0,0,0,1 } },
                    { "O", new int[] { 1,1,1,1,1 } }
                })
            },
            { "Letra U", new ModalidadJuego(new Dictionary<string, int[]>()
                {
                    { "B", new int[] { 1,1,1,1,1 } },
                    { "I", new int[] { 0,0,0,0,1 } },
                    { "N", new int[] { 0,0,0,0,1 } },
                    { "G", new int[] { 0,0,0,0,1 } },
                    { "O", new int[] { 1,1,1,1,1 } }
                })
            },
            { "Letra P", new ModalidadJuego(new Dictionary<string, int[]>()
                {
                    { "B", new int[] { 1,1,1,1,1 } },
                    { "I", new int[] { 1,0,1,0,0 } },
                    { "N", new int[] { 1,0,1,0,0 } },
                    { "G", new int[] { 1,1,1,0,0 } },
                    { "O", new int[] { 0,0,0,0,0 } }
                })
            },
            { "Letra A", new ModalidadJuego(new Dictionary<string, int[]>()
                {
                    { "B", new int[] { 1,1,1,1,1 } },
                    { "I", new int[] { 1,0,1,0,0 } },
                    { "N", new int[] { 1,0,1,0,0 } },
                    { "G", new int[] { 1,0,1,0,0 } },
                    { "O", new int[] { 1,1,1,1,1 } }
                })
            },
            { "Letra E", new ModalidadJuego(new Dictionary<string, int[]>()
                {
                    { "B", new int[] { 1,1,1,1,1 } },
                    { "I", new int[] { 1,0,1,0,1 } },
                    { "N", new int[] { 1,0,1,0,1 } },
                    { "G", new int[] { 1,0,1,0,1 } },
                    { "O", new int[] { 1,0,1,0,1 } }
                })
            },
            { "Letra W", new ModalidadJuego(new Dictionary<string, int[]>()
                {
                    { "B", new int[] { 1,1,1,1,1 } },
                    { "I", new int[] { 0,0,0,0,1 } },
                    { "N", new int[] { 0,0,1,1,1 } },
                    { "G", new int[] { 0,0,0,0,1 } },
                    { "O", new int[] { 1,1,1,1,1 } }
                })
            },
            { "Letra R", new ModalidadJuego(new Dictionary<string, int[]>()
                {
                    { "B", new int[] { 1,1,1,1,1 } },
                    { "I", new int[] { 1,0,1,0,0 } },
                    { "N", new int[] { 1,0,1,1,0 } },
                    { "G", new int[] { 1,1,1,0,1 } },
                    { "O", new int[] { 0,0,0,0,0 } }
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

        public static int ObtenerCampoDeColumna(int numero, CampoCarton[] columna)
        {
            for (int i=0; i<columna.Length; i++)
            {    
                if (columna[i].valor == numero)
                {
                    return i;
                }
            }
            return -1;
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
                    CartonBingo carton;
                    do {
                        carton = new CartonBingo(intervalo, modalidad, jugador.nombre);
                    } while (EsElCartonRepetido(carton, jugadores)); 
                    jugador.cartones.Add(carton);
                }
            }
        }

        private static bool EsElCartonRepetido(CartonBingo carton, List<Jugador> jugadores)
        {
           for(int i=0; i<jugadores.Count; i++)
            {
                try
                {
                    foreach (CartonBingo cartonAComparar in jugadores[i].cartones)
                    {
                        if (sonCartonesIguales(carton, cartonAComparar))
                            return true;
                    }
                }
                catch
                {

                }
                
            }
            return false;
        }

        public static List<int> GenerarNumerosEnBiombo(int totalNumeros)
        {
            return Herramientas.CrearListas.CrearListaDesordenada(1, totalNumeros);
        } 

    }

}
