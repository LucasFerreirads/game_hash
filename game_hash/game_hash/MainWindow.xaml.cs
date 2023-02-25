using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace game_hash
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ArrayList HashList = new ArrayList();
        Hash hash = new Hash();

        bool playerHash = true;       //verdadeiro identifica que o jogador é o "x" e falso é o jogador "o"
        bool gameOn = false;

        bool player1Win = false;
        bool player2Win = false;

        int[] ids = new int[9];
        bool[] playersGame = new bool[9];

        int countMove = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            SetStatus(1, btn_1);
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            SetStatus(2, btn_2);
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            SetStatus(3, btn_3);
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            SetStatus(4, btn_4);
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            SetStatus(5, btn_5);
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            SetStatus(6, btn_6);
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            SetStatus(7, btn_7);
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            SetStatus(8, btn_8);
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            SetStatus(9, btn_9);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gameOn = true;
            HashList.Clear();
            countMove = 1;
            btn_1.Content = null; 
            btn_2.Content = null; 
            btn_3.Content = null; 
            btn_4.Content = null; 
            btn_5.Content = null; 
            btn_6.Content = null;
            btn_7.Content = null;
            btn_8.Content = null;
            btn_9.Content = null;
            player1Win = false;
            player2Win = false;
            
            Array.Clear(ids);
            Array.Clear(playersGame);
        }
        public void SetStatus(int position, Button b)
        {
            if(gameOn && player1Win == false && player2Win == false)
            {
                Hash h1 = new Hash();
                foreach (Hash h in HashList)
                {
                    if (h.id == position)
                    {
                        h1.clicked = h.clicked;
                        h1.playerGame = h.playerGame;
                    }
                }
                if (countMove <= 9 && h1.clicked == false)
                {
                    if (playerHash) 
                    {
                        ids[position - 1] = position;
                        playersGame[position - 1] = playerHash;
                        b.Content = "X";
                        toWin(position, playerHash);
                        HashList.Add(new Hash() { id = position, clicked = true, playerGame = playerHash });
                        playerHash = false;
                        countMove++;
                    }
                    else
                    {
                        ids[position - 1] = position;
                        playersGame[position - 1] = playerHash;
                        b.Content = "O";
                        toWin(position, playerHash);
                        HashList.Add(new Hash() { id = position, clicked = true, playerGame = playerHash });
                        playerHash = true;
                        countMove++;
                    }
                }
                else if (h1.clicked)
                {
                    MessageBox.Show("Você selecione uma casa já selecionada");
                }
                else
                {
                    MessageBox.Show("Você precisa começar uma nova partida");
                }
            }
            else
            {
                MessageBox.Show("Você precisa começar uma nova partida");
            }
        }

        public void toWin(int position, bool playerHash)
        {
            if (ids[0] == 1 && playersGame[0] == playerHash &&
                ids[1] == 2 && playersGame[1] == playerHash &&
                ids[2] == 3 && playersGame[2] == playerHash)
            {
                if (playerHash)
                {
                    player1Win = true;
                    MessageBox.Show("PLayer 1 ganhou");
                }
                else
                {
                    player2Win = true;
                    MessageBox.Show("Player 2 ganhou");
                }
            }
            else if (ids[3] == 4 && playersGame[3] == playerHash &&
                     ids[4] == 5 && playersGame[4] == playerHash &&
                     ids[5] == 6 && playersGame[5] == playerHash)
            {

                if (playerHash)
                {
                    player1Win = true;
                    MessageBox.Show("PLayer 1 ganhou");
                }
                else
                {
                    player2Win = true;
                    MessageBox.Show("Player 2 ganhou");
                }
            }
            else if (ids[6] == 7 && playersGame[6] == playerHash &&
                     ids[7] == 8 && playersGame[7] == playerHash &&
                     ids[8] == 9 && playersGame[8] == playerHash)
            {

                if (playerHash)
                {
                    player1Win = true;
                    MessageBox.Show("PLayer 1 ganhou");
                }
                else
                {
                    player2Win = true;
                    MessageBox.Show("Player 2 ganhou");
                }
            }
            else if (ids[0] == 1 && playersGame[0] == playerHash &&
                     ids[3] == 4 && playersGame[3] == playerHash &&
                     ids[6] == 7 && playersGame[6] == playerHash)
            {

                if (playerHash)
                {
                    player1Win = true;
                    MessageBox.Show("PLayer 1 ganhou");
                }
                else
                {
                    player2Win = true;
                    MessageBox.Show("Player 2 ganhou");
                }
            }

            else if (ids[1] == 2 && playersGame[1] == playerHash &&
                     ids[4] == 5 && playersGame[4] == playerHash &&
                     ids[7] == 8 && playersGame[7] == playerHash)
            {

                if (playerHash)
                {
                    player1Win = true;
                    MessageBox.Show("PLayer 1 ganhou");
                }
                else
                {
                    player2Win = true;
                    MessageBox.Show("Player 2 ganhou");
                }
            }
            else if (ids[2] == 3 && playersGame[2] == playerHash &&
                     ids[5] == 6 && playersGame[5] == playerHash &&
                     ids[8] == 9 && playersGame[8] == playerHash)
            {

                if (playerHash)
                {
                    player1Win = true;
                    MessageBox.Show("PLayer 1 ganhou");
                }
                else
                {
                    player2Win = true;
                    MessageBox.Show("Player 2 ganhou");
                }
            }
            else if (ids[0] == 1 && playersGame[0] == playerHash &&
                     ids[4] == 5 && playersGame[4] == playerHash &&
                     ids[8] == 9 && playersGame[8] == playerHash)
            {

                if (playerHash)
                {
                    player1Win = true;
                    MessageBox.Show("PLayer 1 ganhou");
                }
                else
                {
                    player2Win = true;
                    MessageBox.Show("Player 2 ganhou");
                }
            }

            else if (ids[6] == 7 && playersGame[6] == playerHash &&
                     ids[4] == 5 && playersGame[4] == playerHash &&
                     ids[2] == 3 && playersGame[2] == playerHash)
            {

                if (playerHash)
                {
                    player1Win = true;
                    MessageBox.Show("PLayer 1 ganhou");
                }
                else
                {
                    player2Win = true;
                    MessageBox.Show("Player 2 ganhou");
                }
            }
            else if (ids[0] == 1 && ids[1] == 2 && ids[2] == 3 &&
                     ids[3] == 4 && ids[4] == 5 && ids[5] == 6 &&
                     ids[6] == 7 && ids[7] == 8 && ids[8] == 9 )
                MessageBox.Show("O jogo deu zebra");
        }
    }
}
