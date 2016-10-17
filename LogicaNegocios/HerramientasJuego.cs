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
          //  int[] array; 
            for (int i=0; i<5; i++)
            {
                //if(carton1.getCarton().Values.[i] != carton2.getCarton().Values[i])
               // {
               //     return false;
              //  }
            }
            return true;;
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

        public static CampoCarton[] GenerarColumnaBingo(string columna, int intervalo)
        {
            int[] valoresColumna = Herramientas.CrearArray.CrearRandomArray(5,
                                                                EncontrarIntervaloDeColumna(columna, intervalo)[0],
                                                                EncontrarIntervaloDeColumna(columna, intervalo)[1]);
            CampoCarton[] campos = new CampoCarton[5];
            for (int i=0; i<valoresColumna.Length; i++)
            {
                campos[i] = new CampoCarton(valoresColumna[i], i, columna);
            }
            return campos;

        }

        public static string TempImprimirColumna(CampoCarton[] columna)
        {
            var msg = "";
            foreach (var item in columna)
            {
                msg += item.ToString() + ",";
            }
            return msg;
        }



    }

}
