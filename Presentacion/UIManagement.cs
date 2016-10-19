using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    class UIManagement
    {

        private int getAmountofBoards(DataGridView gvDetails)
        {
            int AmountOfBoards = 0;
            for (int i = 0; i < gvDetails.RowCount; i++)
            {
                AmountOfBoards = AmountOfBoards + Int32.Parse(gvDetails.Rows[i].Cells[1].Value.ToString());
            }
            return AmountOfBoards;
        }

        public void setGameModes(ComboBox cmbGameModes)
        {
            cmbGameModes.Items.Add("Seleccione uno");
            string[] gameModes = new string[] { "H", "D" };
            for (int i = 0; i <= gameModes.Length - 1; i++)
            {
                cmbGameModes.Items.Add(gameModes[i]);
            }
            cmbGameModes.SelectedIndex = 0;
        }

        public void setGridViewData(TextBox txtBoardAmounts, TextBox txtUsername, DataGridView gvDetails, Label lblAoB, Label lblAoP)
        {
            Int16 num;
            bool isNum = Int16.TryParse(txtBoardAmounts.Text.Trim(), out num);
            if (!isNum)
            {
                MessageBox.Show("El valor ingresado no corresponde a un número valido, por favor revise el campo nuevamente.",
                    "Campo invalido ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] row = new string[] { txtUsername.Text, txtBoardAmounts.Text };
                gvDetails.Rows.Add(row);
                lblAoB.Text = getAmountofBoards(gvDetails).ToString();
                lblAoP.Text = gvDetails.RowCount.ToString();
            }
        }

        public String[] setPlayers(DataGridView gvDetails)
        {
            String[] players = new String[gvDetails.RowCount];
            for (int i = 0; i < players.Length; i++)
            {
                players[i] = gvDetails.Rows[i].Cells[0].Value.ToString();
            }
            return players;
        }

        public String[] setPlayersAmountOfBoards(DataGridView gvDetails)
        {
            String[] pAoB = new String[gvDetails.RowCount];
            for (int i = 0; i < pAoB.Length; i++)
            {
                pAoB[i] = gvDetails.Rows[i].Cells[1].Value.ToString();
            }
            return pAoB;
        }
    }
}
