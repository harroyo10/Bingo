﻿using LogicaNegocios;
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
        int bingoNumber;
        List<int> numbers = new List<int>();

        public GameOn(GameManagement oldGM)
        {
            InitializeComponent();
            GM = oldGM;
            extraComponents();
            game = new Juego(GM.getAmountOfNumbers(), GM.getPlayers().ToList(), modeName);
            bingoNumber = 0;
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

        private void generateUserBingoBoards(int boardsAmount, int player)
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

                //Ajustar el tamaño de las columnas
                for (int j = 0; j < 5; j++)
                {
                    DataGridViewColumn column = dgv.Columns[j];
                    column.Width = 20;
                }

                CartonBingo carton = GM.getPlayers()[player].cartones[i];
                foreach (KeyValuePair<string, CampoCarton[]> entry in carton.getCarton())
                {
                    CampoCarton[] CC = entry.Value;
                    Console.WriteLine(CC[0].ToString());
                    String[] row = new String[] { "" };
                    //Console.WriteLine(CC[1].ToString());
                    //Console.WriteLine(CC[3].ToString());
                    //Console.WriteLine(CC[4].ToString());
                }

                //for (int p = 0; p < 5; p++)
                //{
                //    string[] row = new string[] { B.ToString(), I.ToString(), N.ToString(), G.ToString(), O.ToString() };
                //    dgv.Rows.Add(row);
                //    B++; I++; N++; G++; O++;
                //}

                //Agregar label junto con el número de carton
                Label boardIndicator = new Label();
                boardIndicator.Text = "Cartón #: " + (i + 1);
                boardIndicator.Left = 20;
                boardIndicator.Top = labelX;

                pnlBoards.Controls.Add(boardIndicator);
                pnlBoards.Controls.Add(dgv);

                y = y + 190;
                labelX = labelX + 190;
            }
        }

        private void testing400()
        {
            for (int i = 0; i<5; i++)
            {
                string[] row = new string[] { "" };
            }
        }

        private int setColumnFromDictionary(char columnLetter)
        {
            int columnNumber = 0;
            switch(columnLetter)
            {
                case 'B':
                    columnNumber = 0;
                    break;
                case 'I':
                    columnNumber = 1;
                    break;
                case 'N':
                    columnNumber = 2;
                    break;
                case 'G':
                    columnNumber = 3;
                    break;
                case 'O':
                    columnNumber = 4;
                    break;
            }
            return columnNumber;
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

            test24(index);

            pnlBoards.Controls.Clear();
            //generateUserBingoBoards(cant, index);
        }

        private void test24(int index)
        {
            int[,] matriz = new int[5, 5];
            CartonBingo carton = GM.getPlayers()[index].cartones[index];
            foreach (KeyValuePair<string, CampoCarton[]> entry in carton.getCarton())
            {
                CampoCarton[] CC = entry.Value;

                
                for (int i = 0; i < 5; i++)
                {
                    char column = (CC[i].columna[0]);
                    matriz[setColumnFromDictionary(column), i] = CC[setColumnFromDictionary(column)].valor;
                }

                //Console.WriteLine(matriz[0, 0]);
                //Console.WriteLine(matriz[0, 1]);





                //String[] row = new String[] { "" };
                Console.WriteLine(CC[0].ToString());
                Console.WriteLine(CC[1].ToString());
                Console.WriteLine(CC[2].ToString());
                Console.WriteLine(CC[3].ToString());
                Console.WriteLine(CC[4].ToString());
            }
        }

        private bool isRepeated(int bingoNumber)
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

        private String generateNumbersText()
        {
            String numbersText = "";
            for (int i = 0; i < numbers.Count; i++)
            {
                numbersText = numbersText + numbers.ToArray()[i] + ", ";
            }
            return numbersText;
        }

        private int GenerateBingoNumber()
        {
            Random rnd = new Random();
            bingoNumber = rnd.Next(1, (GM.getAmountOfNumbers() + 1));
            return bingoNumber;
        }

        //btnBingoNumber
        private void button3_Click(object sender, EventArgs e)
        {
            if (numbers.Count < GM.getAmountOfNumbers())
            {
                bool signal = false;
                while (signal == false)
                {
                    bingoNumber = GenerateBingoNumber();
                    signal = isRepeated(bingoNumber);
                    if (signal)
                    {
                        lblAmountOfNumbers.Text = (numbers.Count + 1).ToString();
                        numbers.Add(bingoNumber);
                        numbers.Sort();
                        txtBingoNumbers.Text = generateNumbersText();
                    }
                }
            } else
            {
                MessageBox.Show("No se pueden agregar más números.", "Límite de números", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
