using LogicaNegocios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    class ManejoUI
    {

        private int numeroDeCartonUsuario = 1; //Número de carntón de un usuario

        //Metodos para los ajustes

        //Obtiene la cantidad de cartones
        private int OtenerNumeroDeCartones(DataGridView gvDetalles)
        {
            int AmountOfBoards = 0;
            for (int i = 0; i < gvDetalles.RowCount; i++)
            {
                AmountOfBoards = AmountOfBoards + Int32.Parse(gvDetalles.Rows[i].Cells[1].Value.ToString());
            }
            return AmountOfBoards;
        }

        //Carga en el combobox de settings los modos de juego
        public void EstablecerModoDeJuego(ComboBox cmbGameModes)
        {
            for (int i = 0; i < HerramientasJuego.GetNombreDeModalidades().Length; i++)
            {
                cmbGameModes.Items.Add(HerramientasJuego.GetNombreDeModalidades()[i]);
            }
            cmbGameModes.SelectedIndex = 0;
        }

        //Agrega al gridview de settings la información de cada jugador y actualiza los campos de la pantalla
        public void EstablecerDataGridView(TextBox txtBoardAmounts, TextBox txtUsername, 
            DataGridView gvDetails, Label lblAoB, Label lblAoP)
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
                lblAoB.Text = OtenerNumeroDeCartones(gvDetails).ToString();
                lblAoP.Text = gvDetails.RowCount.ToString();
            }
        }

        //Retorna la lista de jugadores
        public Jugador[] ListaDeJugadores(DataGridView gvDetails)
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

        //Agrega al combobox de GameOn los jugadores
        public void RellenarCmbJugadores(ComboBox cmbUsers, Jugador[] players)
        {
            for (int i = 0; i < players.Length; i++)
            {
                cmbUsers.Items.Add(players[i].nombre);
            }
        }

        //Cambia la imagen del picturebox dependiendo del modo de juego
        public String EstablecerModoDeJuego(int option, PictureBox pbGameMode)
        {
            String modeName = "";
            switch (option)
            {
                case 0:
                    pbGameMode.Image = Presentacion.Properties.Resources._4esquinas;
                    modeName = "Cuatro Esquinas"; 
                    break;
                case 1:
                    pbGameMode.Image = Presentacion.Properties.Resources.CartonLleno;
                    modeName = "Cartón Lleno";
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

        //Me devuelve el nombre de la columna del datagridview
        public DataGridViewTextBoxColumn ObtenerNombreColumna(int letterIndex)
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

        //Asigna los parametros básicos de cada datagridview
        public DataGridView CrearDataGridView(int x, int y)
        {
            DataGridView dgv = new DataGridView();

            //GridView propierties
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                ObtenerNombreColumna(0), ObtenerNombreColumna(1), ObtenerNombreColumna(2), ObtenerNombreColumna(3), ObtenerNombreColumna(4),});
            dgv.Location = new System.Drawing.Point(x, y);
            dgv.Name = "gvUserBoard";
            dgv.ReadOnly = true;
            dgv.Size = new System.Drawing.Size(230, 290);
            dgv.TabIndex = 0;
            dgv.RowHeadersVisible = false;

            //Ajustar el tamaño de las filas y columnas
            for (int j = 0; j < 5; j++)
            {
                dgv.Columns[j].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataGridViewColumn column = dgv.Columns[j];
                column.Width = 45;
                dgv.Columns[j].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgv.RowTemplate.Height = 53;

            return dgv;
        }

        //Lista de números que aparece en el juego que salen del biombo
        public void EstablecerListaDeNumerosParaLaLista(ListBox list, List<int> playedNumbers, int intervalo)
        {
            list.Items.Clear();
            String lbText = "En la columna de la ";
            HerramientasJuego obtenerAqueColumnaVa = new HerramientasJuego();
            for (int i = 0; i < playedNumbers.Count; i++)
            {
                String columnNumber = HerramientasJuego.EncontrarAQueColumnaPertenece(playedNumbers[i], intervalo);
                list.Items.Add(lbText + columnNumber + ", el número " + playedNumbers[i]);
            }

        }

        //Lista de números que aparece en el juego que salen del biombo
        public String EstablecerListaDeNumerosParaElLabel(int number, int intervalo)
        {
            String lbText = "En la columna de la ";
            HerramientasJuego obtenerAqueColumnaVa = new HerramientasJuego();
            String columnNumber = HerramientasJuego.EncontrarAQueColumnaPertenece(number, intervalo);
            lbText = lbText + columnNumber + ", el número " + number;
            return lbText;
        }

        //Recibe una letra y la transforma a columna
        public int ConvertirCharANum(char columnLetter)
        {
            int columnNumber = 0;
            switch (columnLetter)
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

        private String obtenerDueño(String dueñoAntiguo, String dueñoNuevo)
        {
            if (dueñoAntiguo.Equals(dueñoNuevo))
            {
                numeroDeCartonUsuario++;
                return dueñoAntiguo;
            }
            else
            {
                numeroDeCartonUsuario = 1;
                return dueñoNuevo;
            }
        }

        //Genera una label para indicar el dueño y número de cartón
        public void IndicadorDeLabel(String dueñoAntiguo, String dueñoNuevo, int y, Panel pnl, int numeroCarton, bool tab)
        {
            String dueño = "";
            if (tab)
            {
                numeroDeCartonUsuario = numeroCarton;
                dueño = obtenerDueño(dueñoAntiguo, dueñoNuevo);
            } else
            {
                dueño = obtenerDueño(dueñoAntiguo, dueñoNuevo);
            }
            Label boardIndicator = new Label();
            boardIndicator.Text = "#" + numeroDeCartonUsuario + " de: " + dueño;
            boardIndicator.Left = 20;
            boardIndicator.Top = y;

            pnl.Controls.Add(boardIndicator);
        }

        //Pintar las rows que han sido afortunadas
        public DataGridView PintarCelda(List<int[]> luckyPositions, DataGridView dgv)
        {
            if (luckyPositions.Count > 0)
            {
                for (int j = 0; j < luckyPositions.Count; j++)
                {
                    int luckyRow = luckyPositions[j][0];
                    int luckyColumn = luckyPositions[j][1];
                    dgv.Rows[luckyRow].Cells[luckyColumn].Style.BackColor = Color.Red;
                }
            }
            return dgv;
        }

        //Se crean las filas y se agregan al cartón
        public DataGridView CearFilasDataGridView(DataGridView dgv, int[,] boardCoordinates)
        {
            string[] row = new string[5];

            for (int j = 0; j < 5; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    row[k] = boardCoordinates[k, j].ToString();
                }
                dgv.Rows.Add(row);
            }
            return dgv;
        }

        //Comprobar si el número ya fue jugado
        public List<int[]> NumerosAfortunados(CampoCarton campoCarton, char column, List<int[]> luckyPositions)
        {
            if (campoCarton.boolJugado)
            {
                int[] playedCoordinates = new int[2];
                playedCoordinates[1] = ConvertirCharANum(column);
                playedCoordinates[0] = campoCarton.fila;
                luckyPositions.Add(playedCoordinates);
            }
            return luckyPositions;
        }
    }
}
