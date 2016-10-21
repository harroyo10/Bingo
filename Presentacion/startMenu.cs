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
    public partial class startMenu : Form
    {
        GameManagement GM;

        public startMenu()
        {
            InitializeComponent();
            extraComponents();
        }

        private void extraComponents()
        {
            CenterToScreen();
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Text = "Bienvenido al Bingo Latina";
            btnPlay.Enabled = false;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings frmSettings = new Settings(this);
            this.Visible = false;
            frmSettings.ShowDialog();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            GameOn newGame = new GameOn(this, GM);
            this.Visible = false;
            newGame.ShowDialog();
        }

        //Sets & Gets

        public void setGameMangament(GameManagement GM)
        {
            this.GM = GM;
        }

        public Button getPlayButton()
        {
            return btnPlay;
        }

    }
}
