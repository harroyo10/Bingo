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
            /*
            List<int> numerosRequeridosParaGanar = new List<int>();
            int Intervalo = 0;
            string Modalidad = "";
            bool Resultado = true;

            CartonBingo ReferenciaDinamica = new CartonBingo(Intervalo,Modalidad);
            bool ResultadoReal = ReferenciaDinamica.esGanador(numerosRequeridosParaGanar);
            Assert.AreEqual(Resultado, ResultadoReal);
           */


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
            /*
            List<int> numerosRequeridosParaGanar = new List<int>();
            int Intervalo = 0;
            string Modalidad = "";
            bool Resultado = false;

            CartonBingo ReferenciaDinamica = new CartonBingo(Intervalo, Modalidad);
            bool ResultadoReal = ReferenciaDinamica.esGanador(numerosRequeridosParaGanar);
            Assert.AreEqual(Resultado, ResultadoReal);
            */
        }
        [TestMethod]
        public void ElNumeroYaSalio()
        {
            /*
            List < int > ElNumero = new List<int>();
            int Intervalo = 0;
            string Modalidad = "";
            bool Resultado = true;

            CartonBingo ReferenciaDinamica = new CartonBingo(Intervalo,Modalidad);
            bool ResultadoReal = ReferenciaDinamica.getNumerosAfortunados(ElNumero);
            Assert.AreEqual(Resultado, ResultadoReal);
         */
            
        }
        [TestMethod]
        public void ElNumeroNoHaSalido()
        {
           /*
            int ElNumero = 0;
            int Intervalo = 0;
            string Modalidad = "";
            bool Resultado = false;

            CartonBingo ReferenciaDinamica = new CartonBingo(Intervalo, Modalidad);
            bool ResultadoReal = ReferenciaDinamica.getNumerosAfortunados(ElNumero);
            Assert.AreEqual(Resultado, ResultadoReal);
            */
        }

        [TestMethod]
        public void NumeroEnOtraColumna()
        {
           /*
            int Numero1=1;
            int Intervalo1 =2;
            int Numero2 = 1;
            int Intervalo2 = 4;
            string ResultadoUno = HerramientasJuego.EncontrarAQueColumnaPertenece(Numero1, Intervalo1);
            string ResultadoDos = HerramientasJuego.EncontrarAQueColumnaPertenece(Numero2, Intervalo2);

            if (Numero1 == Numero2 && Intervalo1 != Intervalo2) {


            }
            */
        }

    }
}
