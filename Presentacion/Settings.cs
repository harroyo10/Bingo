using LogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Settings : Form
    {

        private UIManagement UI;
        private startMenu sMenu;

        public Settings(startMenu sMenu)
        {
            InitializeComponent();
            UI = new UIManagement();
            extraComponents();
            this.sMenu = sMenu;
        }

        private void extraComponents()
        {
            CenterToScreen();
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Text = "Ajustes del juego";
            UI.setGameModes(cmbGameModes);
            cmbGameModes.SelectedIndex = 0;
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtBoardAmounts.Text == "" || txtBoardAmounts.Text == "0")
            {
                MessageBox.Show("Campos vacíos, por favor revise los campos nuevamente.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                UI.setGridViewData(txtBoardAmounts, txtUsername, gvDetails, lblAoB, lblAoP);
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (lblAoB.Text == "0" || lblAoP.Text == "0" || txtAmountOfNumbers.Text == "")
            {
                MessageBox.Show("Datos insuficientes para iniciar el juego.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((Int16.Parse(txtAmountOfNumbers.Text)) % 5 != 0 && (Int16.Parse(txtAmountOfNumbers.Text)) >= 25)
                {
                    MessageBox.Show("Ingrese un valor múltiplo de 5 para proseguir.", "Dato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int amountOfNumbers = Int16.Parse(txtAmountOfNumbers.Text);
                    Jugador[] players = UI.setPlayers(gvDetails);
                    int gameMode = cmbGameModes.SelectedIndex;
                    GameManagement GM = new GameManagement(players, gameMode, amountOfNumbers);
                    sMenu.setGameMangament(GM);
                    sMenu.getPlayButton().Enabled = true;
                    sMenu.Visible = true;
                    Hide();
                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            sMenu.Visible = true;
            Hide();
        }
    }
}
