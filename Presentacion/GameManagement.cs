using LogicaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class GameManagement
    {

        Jugador[] players;
        int gameMode;
        int amountOfNumbers;

        public GameManagement(Jugador[] players, int gMode, int amountOfNumbers)
        {
            this.players = players;
            gameMode = gMode;
            this.amountOfNumbers = amountOfNumbers;
        }

        //Sets & Gets
        public Jugador[] getPlayers()
        {
            return this.players;
        }
     
        public int getGameMode()
        {
            return this.gameMode;
        }

    }
}
