using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herramientas;
using ParametrosGlobales;

namespace LogicaNegocios
{
    public class CartonBingo
    {
        Dictionary<string,int[]> carton;
        int intervalo;
        public CartonBingo (int totalNumeros)
        {
            this.intervalo = totalNumeros / 5;
            int i = 0;
            this.carton = new Dictionary<string, int[]>()
            {
                { "B", CrearArray.CrearRandomArray(5, intervalo * i + 1, intervalo*(i++)+intervalo) },
                { "I", CrearArray.CrearRandomArray(5, intervalo * i + 1, intervalo*(i++)+intervalo) },
                { "N", CrearArray.CrearRandomArray(5, intervalo * i + 1, intervalo*(i++)+intervalo) },
                { "G", CrearArray.CrearRandomArray(5, intervalo * i + 1, intervalo*(i++)+intervalo) },
                { "O", CrearArray.CrearRandomArray(5, intervalo * i + 1, intervalo*(i++)+intervalo) },
            };
        }

        override public string ToString()
        {
            var msg = "";
            foreach(var item in this.carton.Values)
            {
                msg += ConsultarArray.imprimirArray(item)+",";
            }
            return msg;
        }

        public string imprimirColumna(string fila)
        {
            int[] valorColumna;
            if (this.carton.TryGetValue(fila, out valorColumna)) ;
            return ConsultarArray.imprimirArray(valorColumna);
        }

       public Dictionary<string, int[]> getCarton()
        {
            return this.carton;
        }


    }
}
