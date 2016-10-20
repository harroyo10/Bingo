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

        

        


    }

}
