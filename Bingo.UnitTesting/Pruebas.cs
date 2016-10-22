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
            //Creamos dos jugadores 
            List<Jugador> jugadores = new List<Jugador>()
            {
                new Jugador("Jugador 1", 1),
                new Jugador("Jugador 2", 1)
            };
            
            //Creamos un juego nuevo si y solo si hay 1 ganador
            Juego juego;
            List<int> numerosRequeridosParaCarton1;
            List<int> numerosRequeridosParaCarton2;
            do
            {
                juego = new Juego(25, jugadores, "Cuatro Esquinas");
                numerosRequeridosParaCarton1 = juego.jugadores[0].cartones[0].EncontrarNumerosRequeridosParaGanar();
                numerosRequeridosParaCarton1.Sort();
                numerosRequeridosParaCarton2 = juego.jugadores[1].cartones[0].EncontrarNumerosRequeridosParaGanar();
                numerosRequeridosParaCarton2.Sort();
            } while (string.Join(",", numerosRequeridosParaCarton1) == string.Join(",", numerosRequeridosParaCarton2));

            //Sacamos los numeros ganadores necesarios para el jugador 1
            juego.numerosJugados = numerosRequeridosParaCarton1;

            //Encontramos el ganador
            List<CartonBingo> ganadores = juego.ObtenerCartonesGanadores();
            string ganadorReal = ganadores[0].jugadorAlQuePertenece;

            //Definimos el ganador esperado
            string ganadorEsperado = "Jugador 1";

            //comparar que solo hay 1 ganador y es el mismo 
            Assert.AreEqual(ganadores.Count, 1);
            Assert.AreEqual(ganadorEsperado, ganadorReal);
        }

       [TestMethod]
        public void VariosGanadores()
        {
            //Creamos dos jugadores 
            List<Jugador> jugadores = new List<Jugador>()
            {
                new Jugador("Jugador 1", 1),
                new Jugador("Jugador 2", 1)
            };

            //Creamos un juego nuevo a carton lleno
            Juego juego = new Juego(25, jugadores, "Cartón Lleno");

            //Jugamos los numeros del bingo 1-25
            List<int> todosLosNumeros = new List<int>();
            for (int i=1; i<=25; i++)
            {
                todosLosNumeros.Add(i);
            }

            juego.numerosJugados = todosLosNumeros;

            //Encontramos los ganadores
            List<CartonBingo> ganadores = juego.ObtenerCartonesGanadores();

            //comparar que los dos cartones son ganadores
            Assert.AreEqual(ganadores.Count, 2);
        }

        [TestMethod]
        public void NingunGanador()
        {
            //Creamos dos jugadores 
            List<Jugador> jugadores = new List<Jugador>()
            {
                new Jugador("Jugador 1", 1),
                new Jugador("Jugador 2", 1)
            };

            //Creamos un juego nuevo a carton lleno
            Juego juego = new Juego(25, jugadores, "Cartón Lleno");

            //Jugamos el primer numero 
            int primerNumero = 1;
            juego.numerosJugados.Add(primerNumero);

            //Encontramos los ganadores
            List<CartonBingo> ganadores = juego.ObtenerCartonesGanadores();

            //comparar que ninguno de los dos cartones son ganadores todavia
            Assert.AreEqual(ganadores.Count, 0);
        }

        [TestMethod]
        public void NumerosHanSidoJugados()
        {
            //Creamos dos jugadores 
            List<Jugador> jugadores = new List<Jugador>()
            {
                new Jugador("Jugador 1", 1),
                new Jugador("Jugador 2", 1)
            };

            //Creamos un juego nuevo a carton lleno con 25 numeros en el Biombo
            Juego juego = new Juego(25, jugadores, "Cartón Lleno");

            //Sacamos 3 veces un numero del Biombo
            for(int i=0; i<3; i++)
            {
                juego.SacarNumeroDeBiombo();
            }

            //Definimos la cantidad de numeros jugados esperados
            int numerosJugadosEsperados = 3;

            //Definimos la cantidad de numeros jugados reales
            int numerosJugadosReales = juego.numerosJugados.Count;

            //comparar hemos jugado 3 numeros
            Assert.AreEqual(numerosJugadosEsperados, numerosJugadosReales);
        }

        [TestMethod]
        public void NumerosNoHanSidoJugados()
        {
            //Creamos dos jugadores 
            List<Jugador> jugadores = new List<Jugador>()
            {
                new Jugador("Jugador 1", 1),
                new Jugador("Jugador 2", 1)
            };

            //Creamos un juego nuevo a carton lleno con 25 numeros en el Biombo
            Juego juego = new Juego(25, jugadores, "Cartón Lleno");

            //Sacamos 3 veces un numero del Biombo
            for (int i = 0; i < 3; i++)
            {
                juego.SacarNumeroDeBiombo();
            }

            //Definimos la cantidad de numeros que no han sido jugados esperados
            int numerosNoJugadosEsperados = 22;

            //Definimos la cantidad de numeros jugados reales
            int numerosNoJugadosReales = juego.numerosEnBiombo.Count;

            //comparar hemos jugado 3 numeros
            Assert.AreEqual(numerosNoJugadosEsperados, numerosNoJugadosReales);
        }

        [TestMethod]
        public void NumeroEnColumnaRespectiva()
        {
            //Numero a ubicar en columna
            int numero = 25;

            //Escenario a 25 numeros en el Biombo 
            int totalNumeros = 25;    
            string columnaEsperada = "O";
            string columnaReal = HerramientasJuego.EncontrarAQueColumnaPertenece(numero, totalNumeros / 5);
            Assert.AreEqual(columnaEsperada, columnaReal);

            //Escenario a 100 numeros en el Biombo
            int totalNumeros2 = 100;
            string columnaEsperada2 = "I";
            string columnaReal2 = HerramientasJuego.EncontrarAQueColumnaPertenece(numero, totalNumeros2 / 5);
            Assert.AreEqual(columnaEsperada2, columnaReal2);
        }

    }
}
