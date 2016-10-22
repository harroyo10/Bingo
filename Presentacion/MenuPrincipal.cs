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
    public partial class MenuPrincipal : Form
    {
        ManejoDelJuego GM;

        public MenuPrincipal()
        {
            InitializeComponent();
            ComponentesExtra();
        }

        private void ComponentesExtra()
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
            Ajustes pantallaAjustes = new Ajustes(this);
            this.Visible = false;
            pantallaAjustes.ShowDialog();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            GameOn juegoNuevo = new GameOn(this, GM);
            this.Visible = false;
            juegoNuevo.ShowDialog();
        }

        //Sets & Gets

        public void EstablecerModoDeJuego(ManejoDelJuego GM)
        {
            this.GM = GM;
        }

        public Button ObtenerBotonJugar()
        {
            return btnPlay;
        }

    }
}
