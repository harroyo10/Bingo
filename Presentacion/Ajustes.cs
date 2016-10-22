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
    public partial class Ajustes : Form
    {

        private ManejoUI UI;
        private MenuPrincipal sMenu;

        public Ajustes(MenuPrincipal sMenu)
        {
            InitializeComponent();
            UI = new ManejoUI();
            ComponentesExtras();
            this.sMenu = sMenu;
        }

        private void ComponentesExtras()
        {
            CenterToScreen();
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Text = "Ajustes del juego";
            UI.EstablecerModoDeJuego(cmbGameModes);
            cmbGameModes.SelectedIndex = 0;
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtBoardAmounts.Text == "" || txtBoardAmounts.Text == "0")
            {
                MessageBox.Show("Campos vacíos, por favor revise los campos nuevamente.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                UI.EstablecerDataGridView(txtBoardAmounts, txtUsername, gvDetails, lblAoB, lblAoP);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lblAoB.Text == "0" || lblAoP.Text == "0" || txtAmountOfNumbers.Text == "")
            {
                MessageBox.Show("Datos insuficientes para iniciar el juego.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((Int16.Parse(txtAmountOfNumbers.Text)) % 5 != 0 || (Int16.Parse(txtAmountOfNumbers.Text)) < 24)
                {
                    MessageBox.Show("Ingrese un valor múltiplo de 5 y mayor a 25 para proseguir.", "Dato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int amountOfNumbers = Int16.Parse(txtAmountOfNumbers.Text);
                    Jugador[] players = UI.ListaDeJugadores(gvDetails);
                    int gameMode = cmbGameModes.SelectedIndex;
                    ManejoDelJuego GM = new ManejoDelJuego(players, gameMode, amountOfNumbers);
                    sMenu.EstablecerModoDeJuego(GM);
                    sMenu.ObtenerBotonJugar().Enabled = true;
                    sMenu.Visible = true;
                    Hide();
                }
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            sMenu.Visible = true;
            Hide();
        }

    }
}
