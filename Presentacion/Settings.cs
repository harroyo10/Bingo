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

        public Settings()
        {
            InitializeComponent();
            UI = new UIManagement();
            extraComponents();
        }

        private void extraComponents()
        {
            CenterToScreen();
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Text = "Ajustes del juego";
            UI.setGameModes(cmbGameModes);
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtBoardAmounts.Text == "")
            {
                MessageBox.Show("Campos vacíos, por favor revise los campos nuevamente.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                UI.setGridViewData(txtBoardAmounts, txtUsername, gvDetails, lblAoB, lblAoP);
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (lblAoB.Text == "0" || lblAoP.Text == "0")
            {
                MessageBox.Show("No hay datos de jugadores registrados.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String[] players = UI.setPlayers(gvDetails);
                String[] pAoB = UI.setPlayers(gvDetails); //Player Amount of Boards
                GameOn Test = new GameOn();
                Hide();
                Test.ShowDialog();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
