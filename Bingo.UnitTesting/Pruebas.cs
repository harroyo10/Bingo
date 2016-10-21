using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaNegocios;
using System.Collections.Generic;

namespace Bingo.UnitTesting
{
    [TestClass]
    public class Pruebas
    {
        
        [TestMethod]
        public void UnGanador()
        {
            
            List<int> numerosRequeridosParaGanar = new List<int>();
            int Intervalo = 0;
            string Modalidad = "";
            bool Resultado = true;

            CartonBingo ReferenciaDinamica = new CartonBingo(Intervalo,Modalidad);
            bool ResultadoReal = ReferenciaDinamica.esGanador(numerosRequeridosParaGanar);
            Assert.AreEqual(Resultado, ResultadoReal);
           


        }

        [TestMethod]
        public void VariosGanadores()
        {
            /*List<int> numerosRequeridosParaGanar = new List<int>();
            int Intervalo = 0;
            string Modalidad = "";
            bool Resultado = true;

            CartonBingo ReferenciaDinamica = new CartonBingo(Intervalo,Modalidad);
            bool ResultadoReal = ReferenciaDinamica.esGanador(numerosRequeridosParaGanar);
            Assert.AreEqual(Resultado, ResultadoReal);
           */
        }

        [TestMethod]
        public void NingunGanador()
        {
            
            List<int> numerosRequeridosParaGanar = new List<int>();
            int Intervalo = 0;
            string Modalidad = "";
            bool Resultado = false;

            CartonBingo ReferenciaDinamica = new CartonBingo(Intervalo, Modalidad);
            bool ResultadoReal = ReferenciaDinamica.esGanador(numerosRequeridosParaGanar);
            Assert.AreEqual(Resultado, ResultadoReal);
            
        }
        [TestMethod]
        public void ElNumeroYaSalio()
        {

            int totalNumeros = 0;
            int ElNumero = 0;
            string modalidad = "";

            Juego ReferenciaDinamica = new Juego(totalNumeros, modalidad);

            if (ReferenciaDinamica.numerosJugados.Contains(ElNumero))
                return;
            
            /*
             int ElNumero = 0;
             int Intervalo = 0;
             string Modalidad = "";
             bool Resultado = true;

             CartonBingo ReferenciaDinamica = new CartonBingo(Intervalo,Modalidad);
             bool ResultadoReal = ReferenciaDinamica.esAfortunado(ElNumero);
             Assert.AreEqual(Resultado, ResultadoReal);
          */

        }
        [TestMethod]
        public void ElNumeroNoHaSalido()
        {
            
            int totalNumeros = 0;
            int ElNumero = 0;
            string modalidad = "";

            Juego ReferenciaDinamica = new Juego(totalNumeros,modalidad);
       
            if (ReferenciaDinamica.numerosJugados.Contains(ElNumero))
            {

            }
            else {
                return;
            }

           
        }

        [TestMethod]
        public void NumeroEnOtraColumna()
        {
            
            int Numero1 = 0;
            int Numero2 = 0;
            int Intervalo1 = 1;
            int Intervalo2 = 2;

            if (Numero1 == Numero2)
            {
               string Columna1 = HerramientasJuego.EncontrarAQueColumnaPertenece(Numero1, Intervalo1);
               string Columna2 =HerramientasJuego.EncontrarAQueColumnaPertenece(Numero2, Intervalo2);
                if (Columna1.Equals(Columna2)) {
                }
                return;
            }
       

          }

    }
}
