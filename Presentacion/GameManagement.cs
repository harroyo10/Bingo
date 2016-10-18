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
        String gameMode;

        public GameManagement(String[] playersNicknames, String[] bAmounts, String gMode)
        {
            players = playersNicknames;
            boardsAmounts = bAmounts;
            gameMode = gMode;
        }

        public String[] getPlayers()
        {
            return this.players;
        }

        public String[] getBoardsAmounts()
        {
            return this.boardsAmounts;
        }

        public String getGameMode()
        {
            return this.gameMode;
        }

    }
}
