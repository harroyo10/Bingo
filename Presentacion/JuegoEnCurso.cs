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
    public partial class JuegoEnCurso : Form
    {

        ManejoDelJuego GM; //Extraer datos de los jugadores
        MenuPrincipal mainMenu; //Menu anterior del juego
        Juego game; //Se inicia el juego
        String modeName; //Nombre del modo de juego actual
        int bingoNumber; //Número de biombo
        int cont; //Cantidad de vecer que se va sacando un número
        ManejoUI UI = new ManejoUI();
        bool gameOver = false; //Ver si el juego continua
        String boardOwner = ""; //Nombre del dueño del cartón

        public JuegoEnCurso(MenuPrincipal oldSM, ManejoDelJuego oldGM)
        {
            InitializeComponent();
            //Inicio de las clases de ayuda
            GM = oldGM;
            mainMenu = oldSM;
            //Componentes extra
            ComponentesExtra();
            //Inicio del juego
            game = new Juego(GM.ObtenerCantidadDeNumeros(), GM.ObtenerJugadores().ToList(), modeName);
            //Temp
            bingoNumber = 0;
            cont = 0;
        }

        //Componentes extra del juego
        private void ComponentesExtra()
        {
            CenterToScreen();
            MaximizeBox = false;
            MinimizeBox = false;
            //Componentes atravez de la UI
            UI.RellenarCmbJugadores(cmbUsers, GM.ObtenerJugadores());
            modeName = UI.EstablecerModoDeJuego(GM.ObtenerModoDeJuego(), pbGameMode);
            //Otros
            lblAmountOfPlaters.Text = GM.ObtenerJugadores().Length.ToString();
        }

        //Se refresca automaticamente el jugador seleccionado en el cmb
        private void RefrescarCartones()
        {
            if (cmbUsers.SelectedIndex != -1)
            {
                int index = cmbUsers.SelectedIndex;
                int cant = GM.ObtenerJugadores()[index].cantidadCartones;

                pnlBoards.Controls.Clear();
                GenerarCartonesDeBingo(cant, index);
            }
        }

        //Genera los cartones de usuario
        private void GenerarCartonesDeBingo(int boardsAmount, int player)
        {
            int x = 50; //Ancho
            int y = 40;//Altura
            int labelY = 15;

            for (int i = 0; i < boardsAmount; i++)
            {

                DataGridView dgv = UI.CrearDataGridView(x, y);

                //Listas de coordinadas para cada cartón y si salieron favorecidas
                int[,] boardCoordinates = new int[5,5];
                List<int[]> luckyPositions = new List<int[]>();

                //Se extrae el cartón de bingo de cada jugador
                CartonBingo carton = GM.ObtenerJugadores()[player].cartones[i];
                

                foreach (KeyValuePair<string, CampoCarton[]> entry in carton.getCarton())
                {
                    CampoCarton[] CampoCarton = entry.Value;
                    for (int j = 0; j < 5; j++)
                    {
                        char column = (CampoCarton[j].columna[0]);
                        boardCoordinates[UI.ConvertirCharANum(column), j] = CampoCarton[j].valor;
                        /*
                         * Se verifica si el campo fue jugado y se agregan sus posiciones a una lista para
                         * analizarla despues
                         */
                        UI.NumerosAfortunados(CampoCarton[j], column, luckyPositions);
                    }
                }

                //Crear las filas de cada cartón
                dgv = UI.CearFilasDataGridView(dgv, boardCoordinates);

                //Pintar las celdas del tablero de bingo
                dgv = UI.PintarCelda(luckyPositions, dgv);

                //Se asigna la celda seleccionada a la del centro del cartón
                dgv.CurrentCell = dgv.Rows[2].Cells[2];
                dgv.Rows[2].Cells[2].Value = "XX";
                dgv.Rows[2].Cells[2].Style.BackColor = Color.Black;
                dgv.ClearSelection();

                //Se crea una label que indica el jugador al cual pertenece
                String newOwner = carton.jugadorAlQuePertenece;
                int numeroCarton = i;
                UI.IndicadorDeLabel(boardOwner, newOwner, labelY, pnlBoards, numeroCarton, true);
                boardOwner = newOwner;

                //Se agrega al panel cada cartón
                pnlBoards.Controls.Add(dgv);

                //Se aumenta la altura de cada componente para que se creen hacia abajo
                y = y + 400;
                labelY = labelY + 400;
            }
        }

        //Genera los cartones los cuales tienen un número recien salido
        private void GenerarCartonesAfortunados(int bingoN)
        {
            pnlFortuneBoards.Controls.Clear();

            List<CartonBingo> cartonesAfortunados = game.ObtenerAfortunados(bingoN);

            int x = 50; //Ancho
            int y = 40;//Altura
            int labelY = 15;

            for (int i = 0; i < cartonesAfortunados.Count; i++)
            {
                DataGridView dgv = UI.CrearDataGridView(x, y);

                //Listas de coordinadas para cada cartón y si salieron favorecidas
                int[,] boardCoordinates = new int[5, 5];
                List<int[]> luckyPositions = new List<int[]>();

                CartonBingo carton = cartonesAfortunados[i];
                foreach (KeyValuePair<string, CampoCarton[]> entry in carton.getCarton())
                {
                    CampoCarton[] CampoCarton = entry.Value;
                    for (int j = 0; j < 5; j++)
                    {
                        char column = (CampoCarton[j].columna[0]);
                        boardCoordinates[UI.ConvertirCharANum(column), j] = CampoCarton[j].valor;
                        /*
                         * Se verifica si el campo fue jugado y se agregan sus posiciones a una lista para
                         * analizarla despues
                         */
                        UI.NumerosAfortunados(CampoCarton[j], column, luckyPositions);
                    }
                }

                //Crear las filas de cada cartón
                dgv = UI.CearFilasDataGridView(dgv, boardCoordinates);

                //Pintar las celdas del tablero de bingo
                dgv = UI.PintarCelda(luckyPositions, dgv);

                //Se asigna la celda seleccionada a la del centro del cartón
                dgv.CurrentCell = dgv.Rows[2].Cells[2];
                dgv.Rows[2].Cells[2].Value = "XX";
                dgv.Rows[2].Cells[2].Style.BackColor = Color.Black;
                dgv.ClearSelection();

                //Se crea una label que indica el jugador al cual pertenece
                String newOwner = carton.jugadorAlQuePertenece;
                int numeroCarton = i;
                UI.IndicadorDeLabel(boardOwner, newOwner, labelY, pnlFortuneBoards, numeroCarton, false);
                boardOwner = newOwner;

                //Se agrega al panel cada cartón
                pnlFortuneBoards.Controls.Add(dgv);

                //Se aumenta la altura de cada componente para que se creen hacia abajo
                y = y + 400;
                labelY = labelY + 400;
            }
        }

        private void GenerarCartonesGanadores(int bingoN)
        {
            if (gameOver)
            {
                pnlFortuneBoards.Controls.Clear();

                List<CartonBingo> cartonesAfortunados = game.ObtenerAfortunados(bingoN);

                int x = 50; //Ancho
                int y = 40;//Altura
                int labelY = 15;

                for (int i = 0; i < cartonesAfortunados.Count; i++)
                {
                    DataGridView dgv = UI.CrearDataGridView(x, y);

                    //Listas de coordinadas para cada cartón y si salieron favorecidas
                    int[,] boardCoordinates = new int[5, 5];
                    List<int[]> luckyPositions = new List<int[]>();

                    CartonBingo carton = cartonesAfortunados[i];
                    foreach (KeyValuePair<string, CampoCarton[]> entry in carton.getCarton())
                    {
                        CampoCarton[] CampoCarton = entry.Value;
                        for (int j = 0; j < 5; j++)
                        {
                            char column = (CampoCarton[j].columna[0]);
                            boardCoordinates[UI.ConvertirCharANum(column), j] = CampoCarton[j].valor;
                            /*
                             * Se verifica si el campo fue jugado y se agregan sus posiciones a una lista para
                             * analizarla despues
                             */
                            UI.NumerosAfortunados(CampoCarton[j], column, luckyPositions);
                        }
                    }

                    //Crear las filas de cada cartón
                    dgv = UI.CearFilasDataGridView(dgv, boardCoordinates);

                    //Pintar las celdas del tablero de bingo
                    dgv = UI.PintarCelda(luckyPositions, dgv);

                    //Se asigna la celda seleccionada a la del centro del cartón
                    dgv.CurrentCell = dgv.Rows[2].Cells[2];
                    dgv.Rows[2].Cells[2].Value = "XX";
                    dgv.Rows[2].Cells[2].Style.BackColor = Color.Black;
                    dgv.ClearSelection();

                    //Se crea una label que indica el jugador al cual pertenece
                    String newOwner = carton.jugadorAlQuePertenece;
                    int numeroCarton = i;
                    UI.IndicadorDeLabel(boardOwner, newOwner, labelY, pnlFortuneBoards, numeroCarton, false);
                    boardOwner = newOwner;

                    //Se agrega al panel cada cartón
                    pnlFortuneBoards.Controls.Add(dgv);

                    //Se aumenta la altura de cada componente para que se creen hacia abajo
                    y = y + 400;
                    labelY = labelY + 400;
                }
            }
        }

        //Muestra los ganadores
        private void MostrarGanadores()
        {
            String ganadores = "";
            if (game.ObtenerGanadores().Count == 1)
            {
                ganadores = "El ganador es: ";
                ganadores = ganadores + game.ObtenerGanadores()[0] + ".";
                gameOver = true;
                MostrarMensajeDeGanadores(ganadores);
            }
            else
            {
                if (game.ObtenerGanadores().Count > 1)
                {
                    ganadores = "Los ganadores son: ";
                    for (int i = 0; i < game.ObtenerGanadores().Count; i++)
                    {
                        ganadores = ganadores + game.ObtenerGanadores()[i] + ", ";
                        gameOver = true;
                    }
                    MostrarMensajeDeGanadores(ganadores);
                }
            }

        }

        private void MostrarMensajeDeGanadores(String ganadores)
        {
            MessageBox.Show(ganadores, "¡BINGO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //Metodos de los botones

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbUsers.SelectedIndex;
            int cant = GM.ObtenerJugadores()[index].cantidadCartones;

            pnlBoards.Controls.Clear();
            GenerarCartonesDeBingo(cant, index);
        }

        //btnBingoNumber
        private void button3_Click(object sender, EventArgs e)
        {
            if (cont < GM.ObtenerCantidadDeNumeros())
            {
                Console.WriteLine(bingoNumber + "|" + GM.ObtenerCantidadDeNumeros());
                if (gameOver == false)
                {
                    bingoNumber = game.SacarNumeroDeBiombo();//Saca el número del Biombo
                    UI.EstablecerListaDeNumerosParaLaLista(lbUsedNumbers, game.numerosJugados, game.intervalo);//Muestra la lista de números
                    lblNewNumber.Text = UI.EstablecerListaDeNumerosParaElLabel(bingoNumber, game.intervalo);//Muestra el número en cuestion
                    GenerarCartonesAfortunados(bingoNumber);//Genera los cartones afortunados en el tab afortunados
                    cont++;//Aumenta el número de veces que se extrajo un número
                    lblAmountOfNumbers.Text = game.numerosJugados.Count.ToString();//Muestra la cantidad de números jugados
                    RefrescarCartones();//Si hay un jugador seleccionado, lo refresca
                    MostrarGanadores();//Muestra los cartones ganadores
                } else
                {
                    MessageBox.Show("Por favor inicie un juego nuevo.", "Juego teminado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("No se pueden agregar más números.", "Límite de números", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            mainMenu.ObtenerBotonJugar().Enabled = false;
            mainMenu.Visible = true;
            Hide();
        }
    }
}
