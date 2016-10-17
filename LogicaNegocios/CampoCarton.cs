using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class CampoCarton
    {
        int valor;
        int filar;
        int columna;
        bool boolJugado;
        bool boolAfortunado;

        public CampoCarton(int valor, int fila, int columna)
        {
            this.valor = valor;
            this.filar = fila;
            this.columna = columna;
            this.boolJugado = false;
            this.boolAfortunado = false;
        }

        public int getValor()
        {
            return this.valor;
        }

        public bool estaJugado()
        {
            return boolJugado;
        }

        public bool esAFortunado()
        {
            return boolAfortunado;
        }

    }
}
