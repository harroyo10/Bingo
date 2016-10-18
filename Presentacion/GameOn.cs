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


        public GameOn()
        {
            InitializeComponent();
            //int[,] tableroPrueba = new int[5,5];
            //Random rnd = new Random();
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (i != 3 && j != 3)
            //        {
            //            int randomNumber = rnd.Next(1, 75);
            //            tableroPrueba[i,j] = randomNumber;
            //        } else
            //        {
            //            tableroPrueba[i,j] = 0;
            //        }
            //    }
            //}

            //int cantTableros = 5;

            //List<DataGridView> grids = new List<DataGridView>();
            //for (int r = 0; r < cantTableros; r++)
            //{
            //    DataTable dt = new DataTable();
            //    dt.Columns.Add("B");
            //    dt.Columns.Add("I");
            //    dt.Columns.Add("N");
            //    dt.Columns.Add("G");
            //    dt.Columns.Add("O");

            //   for (int i = 0; i < 5; i++)
            //    {
            //        DataRow oItem = dt.NewRow();
            //        for (int j = 0; j < 5; j++)
            //        {
            //            oItem[0] = tableroPrueba[i, j];
            //            oItem[1] = tableroPrueba[i, j];
            //            oItem[2] = tableroPrueba[i, j];
            //            oItem[3] = tableroPrueba[i, j];
            //            oItem[4] = tableroPrueba[i, j];
            //        }
            //        dt.Rows.Add(oItem);
            //        Console.WriteLine(dt);
            //        DataGridView dgv = new DataGridView();
            //        dgv.Columns.Add("B", "B");
            //        dgv.Columns.Add("I", "I");
            //        dgv.Columns.Add("N", "N");
            //        dgv.Columns.Add("G", "G");
            //        dgv.Columns.Add("O", "O");
            //        dgv.Rows.Add(dt);
            //        //dgv.Rows[0].HeaderCell.Value = "Row Text";

            //        grids.Add(dgv);
            //        Controls.Add(dgv);

            //    }

            //}

            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int x = 24;
            int y = 7;

            for (int i = 0; i < 10; i++)
            {
                DataGridView dgv = new DataGridView();
                // 
                // B
                // 
                DataGridViewTextBoxColumn LetterB = new DataGridViewTextBoxColumn();
                LetterB.HeaderText = "B";
                LetterB.Name = "LetterB";
                LetterB.ReadOnly = true;
                // 
                // B
                // 
                DataGridViewTextBoxColumn LetterI = new DataGridViewTextBoxColumn();
                LetterI.HeaderText = "I";
                LetterI.Name = "LetterI";
                LetterI.ReadOnly = true;
                // 
                // B
                // 
                DataGridViewTextBoxColumn LetterN = new DataGridViewTextBoxColumn();
                LetterN.HeaderText = "N";
                LetterN.Name = "LetterN";
                LetterN.ReadOnly = true;
                // 
                // B
                // 
                DataGridViewTextBoxColumn LetterG = new DataGridViewTextBoxColumn();
                LetterG.HeaderText = "G";
                LetterG.Name = "LetterG";
                LetterG.ReadOnly = true;
                // 
                // B
                // 
                DataGridViewTextBoxColumn LetterO = new DataGridViewTextBoxColumn();
                LetterO.HeaderText = "O";
                LetterO.Name = "LetterO";
                LetterO.ReadOnly = true;

                dgv.AllowUserToAddRows = false;
                dgv.AllowUserToDeleteRows = false;
                dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                LetterB, LetterI, LetterN, LetterG, LetterO});
                dgv.Location = new System.Drawing.Point(x, y);
                dgv.Name = "gvDetails";
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
                    B++; I++; N++; B++; O++;
                }

                dgv.Rows[0].Cells[0].Style.BackColor = Color.Red;
                dgv.Rows[1].Cells[0].Style.BackColor = Color.Red;
                dgv.Rows[2].Cells[0].Style.BackColor = Color.Red;
                dgv.Rows[3].Cells[0].Style.BackColor = Color.Red;
                dgv.Rows[4].Cells[0].Style.BackColor = Color.Red;

                dgv.Rows[0].Cells[1].Style.BackColor = Color.Red;
                dgv.Rows[0].Cells[2].Style.BackColor = Color.Red;
                dgv.Rows[2].Cells[1].Style.BackColor = Color.Red;
                dgv.Rows[4].Cells[1].Style.BackColor = Color.Red;
                dgv.Rows[4].Cells[2].Style.BackColor = Color.Red;


                pnlBoards.Controls.Add(dgv);

                y = y + 180;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 200;
            int y = 7;

            for (int i = 0; i < 10; i++)
            {
                DataGridView dgv = new DataGridView();
                // 
                // B
                // 
                DataGridViewTextBoxColumn LetterB = new DataGridViewTextBoxColumn();
                LetterB.HeaderText = "B";
                LetterB.Name = "LetterB";
                LetterB.ReadOnly = true;
                // 
                // B
                // 
                DataGridViewTextBoxColumn LetterI = new DataGridViewTextBoxColumn();
                LetterI.HeaderText = "I";
                LetterI.Name = "LetterI";
                LetterI.ReadOnly = true;
                // 
                // B
                // 
                DataGridViewTextBoxColumn LetterN = new DataGridViewTextBoxColumn();
                LetterN.HeaderText = "N";
                LetterN.Name = "LetterN";
                LetterN.ReadOnly = true;
                // 
                // B
                // 
                DataGridViewTextBoxColumn LetterG = new DataGridViewTextBoxColumn();
                LetterG.HeaderText = "G";
                LetterG.Name = "LetterG";
                LetterG.ReadOnly = true;
                // 
                // B
                // 
                DataGridViewTextBoxColumn LetterO = new DataGridViewTextBoxColumn();
                LetterO.HeaderText = "O";
                LetterO.Name = "LetterO";
                LetterO.ReadOnly = true;

                dgv.AllowUserToAddRows = false;
                dgv.AllowUserToDeleteRows = false;
                dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                LetterB, LetterI, LetterN, LetterG, LetterO});
                dgv.Location = new System.Drawing.Point(x, y);
                dgv.Name = "gvDetails";
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
                    B++; I++; N++; B++; O++;
                }
                
                pnlBoards.Controls.Add(dgv);

                y = y + 180;
            }
        }
    }
}
