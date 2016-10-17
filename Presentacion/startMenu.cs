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

        public String[] players;
        public String[] pAoB;

        private UIManagement UI;

        public startMenu()
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
            Text = "Bienvenido al Bingo Latina";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings frmSettings = new Settings();
            Hide();
            frmSettings.ShowDialog();           
        }
        
    }
}
