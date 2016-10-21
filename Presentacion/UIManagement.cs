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

        //Metodos para los ajustes

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

        //Metodos el acomodo de datos en la interfaz

        public void populateCmbOfUsers(ComboBox cmbUsers, Jugador[] players)
        {
            for (int i = 0; i < players.Length; i++)
            {
                cmbUsers.Items.Add(players[i].nombre);
            }
        }

        public String setGameMode(int option, PictureBox pbGameMode)
        {
            String modeName = "";
            switch (option)
            {
                case 0:
                    pbGameMode.Image = Presentacion.Properties.Resources.X;
                    modeName = "Cartón Lleno";
                    break;
                case 1:
                    pbGameMode.Image = Presentacion.Properties.Resources._4esquinas;
                    modeName = "Cuatro esquinas";
                    break;
                case 2:
                    pbGameMode.Image = Presentacion.Properties.Resources.h;
                    modeName = "Letra H";
                    break;
                case 3:
                    pbGameMode.Image = Presentacion.Properties.Resources.X;
                    modeName = "Letra X";
                    break;
                case 4:
                    pbGameMode.Image = Presentacion.Properties.Resources.O;
                    modeName = "Letra O";
                    break;
                case 5:
                    pbGameMode.Image = Presentacion.Properties.Resources.U;
                    modeName = "Letra U";
                    break;
                case 6:
                    pbGameMode.Image = Presentacion.Properties.Resources.P;
                    modeName = "Letra P";
                    break;
                case 7:
                    pbGameMode.Image = Presentacion.Properties.Resources.X;
                    modeName = "Letra A";
                    break;
                case 8:
                    pbGameMode.Image = Presentacion.Properties.Resources.E;
                    modeName = "Letra E";
                    break;
                case 9:
                    pbGameMode.Image = Presentacion.Properties.Resources.X;
                    modeName = "Letra W";
                    break;
                case 10:
                    pbGameMode.Image = Presentacion.Properties.Resources.R;
                    modeName = "Letra R";
                    break;
                case 11:
                    pbGameMode.Image = Presentacion.Properties.Resources.custom;
                    modeName = "Custom";
                    break;
            }
            return modeName;
        }

        //setDataGridViewTextColumn
        public DataGridViewTextBoxColumn setDGVTextColumn(int letterIndex)
        {
            String letter = "";
            if (letterIndex == 0) letter = "B";
            else
            if (letterIndex == 1) letter = "I";
            else
            if (letterIndex == 2) letter = "N";
            else
            if (letterIndex == 3) letter = "G";
            else
            if (letterIndex == 4) letter = "O";

            DataGridViewTextBoxColumn columnHeader = new DataGridViewTextBoxColumn();
            columnHeader.HeaderText = letter;
            columnHeader.Name = "Letter" + letter;
            columnHeader.ReadOnly = true;
            return columnHeader;
        }

        public DataGridView makeDataGridView(int x, int y)
        {
            DataGridView dgv = new DataGridView();

            //GridView propierties
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                setDGVTextColumn(0), setDGVTextColumn(1), setDGVTextColumn(2), setDGVTextColumn(3), setDGVTextColumn(4),});
            dgv.Location = new System.Drawing.Point(x, y);
            dgv.Name = "gvUserBoard";
            dgv.ReadOnly = true;
            dgv.Size = new System.Drawing.Size(104, 135);
            dgv.TabIndex = 0;
            dgv.RowHeadersVisible = false;

            //Ajustar el tamaño de las columnas
            for (int j = 0; j < 5; j++)
            {
                DataGridViewColumn column = dgv.Columns[j];
                column.Width = 20;
            }

            return dgv;
        }




        public bool isRepeated(int bingoNumber, List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (bingoNumber == numbers.ToArray()[i])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
