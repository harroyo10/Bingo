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
        public Settings()
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
            Text = "Ajustes del juego";
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            string[] row = new string[] { txtUsername.Text, txtBoardAmounts.Text };
            gvDetails.Rows.Add(row);
        }
    }
}
