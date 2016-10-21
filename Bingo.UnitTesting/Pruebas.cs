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
            //Crear un carton con numeros del 1 al 25 asi siempre saldra un numero
            int[,] Carton1 = new int[5, 5] { { 1,2,3,4,5 },
                                           { 6,7,8,9,10}, 
                                           {11,12,13,14,15},
                                           {16,17,18,19,20 },
                                           {21,22,23,24,25} }; 

            List<Jugador> Jugadores = new List<Jugador>();
            int NumeroGanador = 1;
            int Intervalo = 1;
            string Modalidad = "Carton Lleno";
            bool Resultado = true;

            Juego ReferenciaDinamica = new Juego(Intervalo,Jugadores,Modalidad);
            ReferenciaDinamica.ObtenerAfortunados(NumeroGanador);


            /*
            List<int> numerosRequeridosParaGanar = new List<int>();
            CartonBingo ReferenciaDinamica = new CartonBingo(Intervalo,Modalidad);
            bool ResultadoReal = ReferenciaDinamica.esGanador(numerosRequeridosParaGanar);
            Assert.AreEqual(Resultado, ResultadoReal);
           */
            

        }

        [TestMethod]
        public void VariosGanadores()
        {
            int[,] Carton1 = new int[5, 5] { { 1,2,3,4,5 },
                                           { 6,7,8,9,10},
                                           {11,12,13,14,15},
                                           {16,17,18,19,20 },
                                           {21,22,23,24,25} };

            int[,] Carton2 = new int[5, 5] { { 1,2,3,4,5 },
                                           { 6,7,8,9,10},
                                           {11,12,13,14,15},
                                           {16,17,18,19,20 },
                                           {21,22,23,24,25} };
            //Crear 2 cartones con numeros del 1 al 25 asi siempre saldra en varios cartones
            List<Jugador> Jugadores = new List<Jugador>();
            int NumeroGanador = 1;
            int Intervalo = 2;
            string Modalidad = "Carton Lleno";
            bool Resultado = true;
            
            Juego ReferenciaDinamica = new Juego(Intervalo, Jugadores,Modalidad);
            ReferenciaDinamica.ObtenerAfortunados(NumeroGanador);
           
            /*
           CartonBingo ReferenciaDinamica = new CartonBingo(Intervalo,Modalidad);
           bool ResultadoReal = ReferenciaDinamica.esGanador(numerosRequeridosParaGanar);
           Assert.AreEqual(Resultado, ResultadoReal);
          */
        }

        [TestMethod]
        public void NingunGanador()
        {
            int[,] Carton3 = new int[5, 5] { { 1,2,3,4,5 },
                                           { 6,7,8,9,10},
                                           {11,12,13,14,15},
                                           {16,17,18,19,20 },
                                           {21,22,23,24,25} };

            //Crear un carton con numero del 1 al 25 y q salga el numero 26 asi nadie sale ganador
            List<Jugador> Jugadores = new List<Jugador>();
            int NumeroGanador = 26;
            int Intervalo = 3;
            string Modalidad = "Carton Lleno";
            bool Resultado = false;

            Juego ReferenciaDinamica = new Juego(Intervalo,Jugadores,Modalidad);
            ReferenciaDinamica.ObtenerAfortunados(NumeroGanador);

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
            List<Jugador> Jugadores = new List<Jugador>();
            int totalNumeros = 30;
            int ElNumero = 5;
            string Modalidad = "Carton Lleno";

            Juego ReferenciaDinamica = new Juego(totalNumeros,Jugadores, Modalidad);

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
            List<Jugador> Jugadores = new List<Jugador>();
            int totalNumeros = 30;
            int ElNumero = 4;
            string Modalidad = "Carton Lleno";

            Juego ReferenciaDinamica = new Juego(totalNumeros,Jugadores,Modalidad);
       
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
            
            int Numero1 = 3;
            int Numero2 = 3;
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
