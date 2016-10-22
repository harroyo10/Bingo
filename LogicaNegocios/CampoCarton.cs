using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class CampoCarton
    {
        public int valor { set; get; }
        public int fila { set; get; }
        public string columna { set; get; }
        public bool boolJugado { set; get; }

        public CampoCarton() { }
        public CampoCarton(int valor, int fila, string columna)
        {
            this.valor = valor;
            this.fila = fila;
            this.columna = columna;
            this.boolJugado = false;
        }

        public override string ToString()
        {
            return "Campo[" + columna + "," + fila + "] = " + valor;
        }
    }
}
