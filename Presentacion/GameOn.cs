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
    public partial class GameOn : Form
    {

        GameManagement GM;
        Juego game;
        String modeName;

        public GameOn(GameManagement oldGM)
        {
            InitializeComponent();
            GM = oldGM;
            extraComponents();
            modeName = "";
            game = new Juego(GM.getAmountOfNumbers(), GM.getPlayers(), modeName);
        }

        private void extraComponents()
        {
            populateCmbOfUsers();
            setGameMode(GM.getGameMode());
            lblAmountOfPlaters.Text = GM.getPlayers().Length.ToString();
        }

        private void setGameMode(int option)
        {
            switch (option)
            {
                case 0:
                    pbGameMode.Image = Presentacion.Properties.Resources.X;
                    modeName = "Cartón lleno";
                    break;
                case 1:
                    pbGameMode.Image = Presentacion.Properties.Resources._4esquinas;
                    modeName = "Cartón lleno";
                    break;
                case 2:
                    pbGameMode.Image = Presentacion.Properties.Resources.h;
                    modeName = "Cuatro esquinas";
                    break;
                case 3:
                    pbGameMode.Image = Presentacion.Properties.Resources.X;
                    modeName = "Letra H";
                    break;
                case 4:
                    pbGameMode.Image = Presentacion.Properties.Resources.O;
                    modeName = "Letra X";
                    break;
                case 5:
                    pbGameMode.Image = Presentacion.Properties.Resources.U;
                    modeName = "Letra O";
                    break;
                case 6:
                    pbGameMode.Image = Presentacion.Properties.Resources.P;
                    modeName = "Letra U";
                    break;
                case 7:
                    pbGameMode.Image = Presentacion.Properties.Resources.X;
                    modeName = "Letra P";
                    break;
                case 8:
                    pbGameMode.Image = Presentacion.Properties.Resources.E;
                    modeName = "Letra A";
                    break;
                case 9:
                    pbGameMode.Image = Presentacion.Properties.Resources.X;
                    modeName = "Letra E";
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
        }

        private void populateCmbOfUsers()
        {
            for(int i = 0; i < GM.getPlayers().Length; i++)
            {
                cmbUsers.Items.Add(GM.getPlayers()[i].nombre);
            }
        }

        //setDataGridViewTextColumn
        private DataGridViewTextBoxColumn setDGVTextColumn(int letterIndex)
        {
            String letter = "";
            if
            (letterIndex == 0) letter = "B";
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

        private void generateUserBingoBoards(int boardsAmount)
        {
            int x = 24;
            int y = 35;
            int labelX = 10;

            for (int i = 0; i < boardsAmount; i++)
            {
                DataGridView dgv = new DataGridView();

                //GridView propierties
                dgv.AllowUserToAddRows = false;
                dgv.AllowUserToResizeColumns = false;
                dgv.AllowUserToResizeRows = false;
                dgv.AllowUserToDeleteRows = false;
                dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                setDGVTextColumn(0), setDGVTextColumn(1),setDGVTextColumn(2),setDGVTextColumn(3),setDGVTextColumn(4),});
                dgv.Location = new System.Drawing.Point(x, y);
                dgv.Name = "gvUserBoard";
                dgv.ReadOnly = true;
                dgv.Size = new System.Drawing.Size(104, 135);
                dgv.TabIndex = 0;
                dgv.RowHeadersVisible = false;

                for (int h = 0; h < 5; h++)
                {
                    DataGridViewColumn column = dgv.Columns[h];
                    column.Width = 20;
                }

                int B = 1, I = 6, N = 11, G = 16, O = 21;
                for (int p = 0; p < 5; p++)
                {
                    string[] row = new string[] { B.ToString(), I.ToString(), N.ToString(), G.ToString(), O.ToString() };
                    dgv.Rows.Add(row);
                    B++; I++; N++; G++; O++;
                }

                String[,] matriz = new String[5, 5];
                matriz[0, 0] = "X";
                dgv.Rows[2].Cells[2].Value = matriz[0, 0];

                Label myLabel = new Label();
                myLabel.Text = "Cartón #: " + (i + 1);
                myLabel.Left = 20;
                myLabel.Top = labelX;

                pnlBoards.Controls.Add(myLabel);
                pnlBoards.Controls.Add(dgv);

                y = y + 190;
                labelX = labelX + 190;
            }
        }
        
        private void generateReviewBingoBoards()
        {

        }

        private void setWinnerBoards()
        {

        }

        //Buttons methods

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbUsers.SelectedIndex;
            int cant = GM.getPlayers()[index].cantidadCartones; ;

            pnlBoards.Controls.Clear();
            generateUserBingoBoards(cant);
        }


        //private void button1_Click(object sender, EventArgs e)
        //{

        //    int x = 24;
        //    int y = 7;

        //    for (int i = 0; i < 10; i++)
        //    {
        //        DataGridView dgv = new DataGridView();

        //        dgv.AllowUserToAddRows = false;
        //        dgv.AllowUserToDeleteRows = false;
        //        dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        //        dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        //        setDGVTextColumn(0), setDGVTextColumn(1),setDGVTextColumn(2),setDGVTextColumn(3),setDGVTextColumn(4),});
        //        dgv.Location = new System.Drawing.Point(x, y);
        //        dgv.Name = "gvDetails";
        //        dgv.ReadOnly = true;
        //        dgv.Size = new System.Drawing.Size(104, 135);
        //        dgv.TabIndex = 0;

        //        dgv.RowHeadersVisible = false;

        //        for (int h = 0; h < 5; h++)
        //        {
        //            DataGridViewColumn column = dgv.Columns[h];
        //            column.Width = 20;
        //        }

        //        int B = 1, I = 6, N = 11, G = 16, O = 21;
        //        for (int p = 0; p < 5; p++)
        //        {
        //            string[] row = new string[] { B.ToString(), I.ToString(), N.ToString(), G.ToString(), O.ToString() };
        //            dgv.Rows.Add(row);
        //            B++; I++; N++; B++; O++;
        //        }

        //        int[,] matriz = new int[5, 5];
        //        matriz[0, 0] = 0;
        //        dgv.Rows[2].Cells[2].Value = matriz[0, 0];


        //        dgv.Rows[0].Cells[0].Style.BackColor = Color.Red;
        //        dgv.Rows[1].Cells[0].Style.BackColor = Color.Red;
        //        dgv.Rows[2].Cells[0].Style.BackColor = Color.Red;
        //        dgv.Rows[3].Cells[0].Style.BackColor = Color.Red;
        //        dgv.Rows[4].Cells[0].Style.BackColor = Color.Red;

        //        dgv.Rows[0].Cells[1].Style.BackColor = Color.Red;
        //        dgv.Rows[0].Cells[2].Style.BackColor = Color.Red;
        //        dgv.Rows[2].Cells[1].Style.BackColor = Color.Red;
        //        dgv.Rows[4].Cells[1].Style.BackColor = Color.Red;
        //        dgv.Rows[4].Cells[2].Style.BackColor = Color.Red;


        //        pnlBoards.Controls.Add(dgv);

        //        y = y + 180;
        //    }
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    int x = 200;
        //    int y = 7;

        //    for (int i = 0; i < 10; i++)
        //    {
        //        DataGridView dgv = new DataGridView();
        //        // 
        //        // B
        //        // 
        //        DataGridViewTextBoxColumn LetterB = new DataGridViewTextBoxColumn();
        //        LetterB.HeaderText = "B";
        //        LetterB.Name = "LetterB";
        //        LetterB.ReadOnly = true;
        //        // 
        //        // B
        //        // 
        //        DataGridViewTextBoxColumn LetterI = new DataGridViewTextBoxColumn();
        //        LetterI.HeaderText = "I";
        //        LetterI.Name = "LetterI";
        //        LetterI.ReadOnly = true;
        //        // 
        //        // B
        //        // 
        //        DataGridViewTextBoxColumn LetterN = new DataGridViewTextBoxColumn();
        //        LetterN.HeaderText = "N";
        //        LetterN.Name = "LetterN";
        //        LetterN.ReadOnly = true;
        //        // 
        //        // B
        //        // 
        //        DataGridViewTextBoxColumn LetterG = new DataGridViewTextBoxColumn();
        //        LetterG.HeaderText = "G";
        //        LetterG.Name = "LetterG";
        //        LetterG.ReadOnly = true;
        //        // 
        //        // B
        //        // 
        //        DataGridViewTextBoxColumn LetterO = new DataGridViewTextBoxColumn();
        //        LetterO.HeaderText = "O";
        //        LetterO.Name = "LetterO";
        //        LetterO.ReadOnly = true;

        //        dgv.AllowUserToAddRows = false;
        //        dgv.AllowUserToDeleteRows = false;
        //        dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        //        dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        //        LetterB, LetterI, LetterN, LetterG, LetterO});
        //        dgv.Location = new System.Drawing.Point(x, y);
        //        dgv.Name = "gvDetails";
        //        dgv.ReadOnly = true;
        //        dgv.Size = new System.Drawing.Size(104, 135);
        //        dgv.TabIndex = 0;

        //        dgv.RowHeadersVisible = false;

        //        for (int h = 0; h < 5; h++)
        //        {
        //            DataGridViewColumn column = dgv.Columns[h];
        //            column.Width = 20;
        //        }

        //        int B = 1, I = 6, N = 11, G = 16, O = 21;
        //        for (int p = 0; p < 5; p++)
        //        {
        //            string[] row = new string[] { B.ToString(), I.ToString(), N.ToString(), G.ToString(), O.ToString() };
        //            dgv.Rows.Add(row);
        //            B++; I++; N++; B++; O++;
        //        }

        //        pnlBoards.Controls.Add(dgv);

        //        y = y + 180;
        //    }
        //}
    }
}
