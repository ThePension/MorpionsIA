using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        // Plateau de jeu
        int totalCount = 0;
        string[,] board = new string[3, 3];
        const bool DefaultAITurn = true;
        bool xTurn = true;
        int nbTours = 0;
        Dictionary<string, int> scores = new Dictionary<string, int>();
        
        public Form1()
        {
            InitializeComponent();
            scores.Add("Personne", 0);
            scores.Add("X", 10);
            scores.Add("O", -10);
            
            InitialisationPlateau(null, null);
        }
        // Remettre le plateau à 0 (vider les cases)
        public void InitialisationPlateau(object sender, EventArgs e)
        {
            if (cbComputerFirst.Checked)
            {
                xTurn = DefaultAITurn;
            }
            else
            {
                xTurn = !DefaultAITurn;
            }
            
            nbTours = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Button btn = (Button)this.panel1.Controls["btn" + i + "" + y];
                    board[i, y] = "";
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Button btn = (Button)this.panel1.Controls["btn" + i +""+ y];
                    btn.Text = "";
                }
            }
            if (xTurn)
            {
                btnCases_Click(null, null);
            }
        }
        public string CheckWinner()
        {
            string gagnant = "";

            // horizontale
            for (int i = 0; i < 3; i++)
            {
                if (board[i,0] == board[i,1] && board[i, 1] == board[i,2] && board[i, 0] != "")
                {
                    gagnant = board[i,0];
                }
            }

            // Verticale
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != "")
                {
                    gagnant = board[0,i];
                }
            }

            // Diagonales
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[1,1]!= "")
            {
                gagnant = board[0,0];
            }
            if (board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2] && board[2, 0] != "")
            {
                gagnant = board[2,0];
            }
            int openSpots = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == "")
                    {
                        openSpots++;
                    }
                }
            }
            // S'il n'y pas de gagnant et que toutes les cases sont remplies
            if (gagnant == "" && openSpots == 0)
            {
                return "Personne";
            }
            else
            {
                return gagnant;
            }
        }

        private void btnCases_Click(object sender, EventArgs e)
        {
            Button btnSelectedCase = (Button)sender;               
            if (xTurn)
            {
                string pos = MeilleurDeplacement(), coorX = pos.Substring(0, 1), coorY = pos.Substring(1, 1);
                // MessageBox.Show("X:" + coorX + "Y:" + coorY);
                Button btn = (Button)this.panel1.Controls["btn" + coorX + "" + coorY];
                btn.Text = "X";
                board[Convert.ToInt32(coorX), Convert.ToInt32(coorY)] = "X";
                nbTours++; // Augmentation du nombre de tours
                xTurn = !xTurn; // Changement de joueur
                string gagnant = CheckWinner();
                if (gagnant != "")
                {
                    if (gagnant == "Personne") MessageBox.Show("Égalité", gagnant + " n'a gagné !");
                    else MessageBox.Show("Gagnant", gagnant + " a gagné !");
                }
            }
            else
            {
                if (btnSelectedCase.Text == "")
                {
                    int x = Convert.ToInt32(btnSelectedCase.Name.Substring(3, 1));
                    int y = Convert.ToInt32(btnSelectedCase.Name.Substring(4, 1));

                    btnSelectedCase.Text = "O";
                    board[x, y] = "O";
                    nbTours++; // Augmentation du nombre de tours
                    xTurn = !xTurn; // Changement de joueur
                    // Contrôler s'il y a un gagnant
                    string gagnant = CheckWinner();
                    if (gagnant != "")
                    {
                        if (gagnant == "Personne") MessageBox.Show("Égalité", gagnant + " n'a gagné !");
                        else MessageBox.Show("Gagnant", gagnant + " a gagné !");
                    }
                    else
                    {
                        btnCases_Click(null, null);
                    }
                }
            }
        }

        public string MeilleurDeplacement()
        {
            totalCount = 0;
            int bestMoveX=0, bestMoveY=0;
            int bestScore = int.MinValue+10;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i,j] == "")
                    {
                        board[i,j] = "X";
                        int score = Minimisation(0);
                        board[i,j] = "";
                        if (score > bestScore)
                        {
                            bestScore = score;
                            
                            bestMoveX = i;
                            bestMoveY = j;
                        }
                    }
                }
            }
            lblTotalCount.Text = "Nombre de dispositions calculées : " + totalCount;
            return bestMoveX + "" + bestMoveY;
        }

        public int Maximisation(int prof)
        {
            totalCount++;
            string result = CheckWinner();
            if (result != "") return scores[result];
            int bestScore = int.MinValue+10;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == "")
                    {
                        board[i, j] = "X";
                        int score = Minimisation(prof+1);
                        board[i, j] = "";
                        if (score > bestScore)
                        {
                            bestScore = score;
                        }
                    }
                }
            }
            return bestScore;
        }
        public int Minimisation(int prof)
        {
            string result = CheckWinner();
            if (result != "") {
                    return scores[result];
            }
            int bestScore = int.MaxValue-10;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == "")
                    {
                        board[i, j] = "O";
                        int score = Maximisation(prof+1);
                        board[i, j] = "";

                        if (score < bestScore)
                        {
                            bestScore = score;
                        }
                    }
                }
            }
            return bestScore;
        }
    }
}
