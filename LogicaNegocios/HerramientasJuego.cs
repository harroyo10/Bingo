using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public static class HerramientasJuego
    {
        public static bool sonCartonesIguales(CartonBingo carton1, CartonBingo carton2)
        {
          //  int[] array; 
            for (int i=0; i<5; i++)
            {
              //  if(carton1.getCarton().Values.[i] != carton2.getCarton().Values[i])
               // {
               //     return false;
              //  }
            }
            return true;;
        }

        public static string encontrarColumna(int numero, int totalNumeros)
        {
            Dictionary<string, int[]> carton = new CartonBingo(totalNumeros).getCarton();
            List<string> listaDeKeys = new List<string>(carton.Keys);
            return listaDeKeys[(int)Math.Floor((double)((numero - 1) / (totalNumeros/5)))];
        }

    }

}
