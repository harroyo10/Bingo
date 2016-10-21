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
        startMenu mainMenu;
        Juego game;
        String modeName;
        int bingoNumber;
        List<int> numbers = new List<int>();
        UIManagement UI = new UIManagement();

        public GameOn(startMenu oldSM, GameManagement oldGM)
        {
            InitializeComponent();
            //Inicio de las clases de ayuda
            GM = oldGM;
            mainMenu = oldSM;
            //Componentes extra
            extraComponents();
            //Inicio del juego
            game = new Juego(GM.getAmountOfNumbers(), GM.getPlayers().ToList(), modeName);
            //Temp
            bingoNumber = 0;
        }

        private void extraComponents()
        {
            //Componentes atravez de la UI
            UI.populateCmbOfUsers(cmbUsers, GM.getPlayers());
            modeName = UI.setGameMode(GM.getGameMode(), pbGameMode);
            //Otros
            lblAmountOfPlaters.Text = GM.getPlayers().Length.ToString();
        }

        private void generateUserBingoBoards(int boardsAmount, int player)
        {
            int x = 24; //Ancho
            int y = 35;//Altura
            int labelX = 10;

            for (int i = 0; i < boardsAmount; i++)
            {

                DataGridView dgv = UI.makeDataGridView(x, y);

                int[,] matriz = new int[5,5];
                CartonBingo carton = GM.getPlayers()[player].cartones[i];
                foreach (KeyValuePair<string, CampoCarton[]> entry in carton.getCarton())
                {
                    CampoCarton[] CampoCarton = entry.Value;
                    for (int j = 0; j < 5; j++)
                    {
                        char column = (CampoCarton[j].columna[0]);
                        matriz[setColumnFromDictionary(column) , j] = CampoCarton[j].valor;
                    }
                }

                string[] row = new string[5];

                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        row[k] = matriz[k, j].ToString();
                    }
                    dgv.Rows.Add(row);
                }

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

        //Buttons methods

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbUsers.SelectedIndex;
            int cant = GM.getPlayers()[index].cantidadCartones;

            pnlBoards.Controls.Clear();
            generateUserBingoBoards(cant, index);
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
                    signal = UI.isRepeated(bingoNumber, numbers); ;
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

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            mainMenu.getPlayButton().Enabled = false;
            mainMenu.Visible = true;
            Hide();
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
