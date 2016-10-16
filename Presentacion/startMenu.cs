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
        public startMenu(bool validSettings)
        {
            InitializeComponent();
            extraComponents();
            validateSettings(validSettings);
        }

        private void extraComponents ()
        {
            CenterToScreen();
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Text = "Bienvenido al Bingo Latina";
        }

        private void validateSettings (bool validSettings)
        {
            if (validSettings == false)
            {
                btnStart.Enabled = false;
            } else
            {
                btnStart.Enabled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings frmSettings = new Settings();
            frmSettings.Show();
            
        }
        
    }
}
