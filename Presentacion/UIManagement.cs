using LogicaNegocios;
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
            for (int i = 0; i < HerramientasJuego.GetNombreDeModalidades().Length; i++)
            {
                cmbGameModes.Items.Add(HerramientasJuego.GetNombreDeModalidades()[i]);
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

        public Jugador[] setPlayers(DataGridView gvDetails)
        {
            Jugador[] players = new Jugador[gvDetails.RowCount];
            string nombre;
            int cantidadCartones;
            for (int i = 0; i < gvDetails.RowCount; i++)
            {
                nombre = gvDetails.Rows[i].Cells[0].Value.ToString();
                cantidadCartones = Int16.Parse(gvDetails.Rows[i].Cells[1].Value.ToString());
                players[i] = new Jugador(nombre, cantidadCartones);
            }
            return players;
        }

       
    }
}
