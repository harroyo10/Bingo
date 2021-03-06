﻿using LogicaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class ManejoDelJuego
    {

        Jugador[] players;
        int gameMode;
        int amountOfNumbers;

        public ManejoDelJuego(Jugador[] players, int gMode, int amountOfNumbers)
        {
            this.players = players;
            gameMode = gMode;
            this.amountOfNumbers = amountOfNumbers;
        }

        //Sets & Gets
        public Jugador[] ObtenerJugadores()
        {
            return this.players;
        }
     
        public int ObtenerModoDeJuego()
        {
            return this.gameMode;
        }

        public int ObtenerCantidadDeNumeros()
        {
            return this.amountOfNumbers;
        }

    }
}
