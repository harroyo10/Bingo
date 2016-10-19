using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class GameManagement
    {

        String[] players;
        String[] boardsAmounts;
        int gameMode;
        int amountOfNumbers;

        public GameManagement(String[] playersNicknames, String[] bAmounts, int gMode, int amountOfNumbers)
        {
            players = playersNicknames;
            boardsAmounts = bAmounts;
            gameMode = gMode;
            this.amountOfNumbers = amountOfNumbers;
        }

        //Sets & Gets
        public String[] getPlayers()
        {
            return this.players;
        }

        public String[] getBoardsAmounts()
        {
            return this.boardsAmounts;
        }

        public int getGameMode()
        {
            return this.gameMode;
        }

    }
}
