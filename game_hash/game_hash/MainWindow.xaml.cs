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

        bool playerHash = true;
        bool gameOn = false;

        int countMove = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            if (gameOn)
            {
                SetStatus(1, btn_1);
            }
            else
            {
                MessageBox.Show("Você precisa começar uma nova partida");
            }
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            if (gameOn)
            {
                SetStatus(2, btn_2);
            }
            else
            {
                MessageBox.Show("Você precisa começar uma nova partida");
            }
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            if (gameOn)
            {
                SetStatus(3, btn_3);
            }
            else
            {
                MessageBox.Show("Você precisa começar uma nova partida");
            }
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            if (gameOn)
            {
                SetStatus(4, btn_4);
            }
            else
            {
                MessageBox.Show("Você precisa começar uma nova partida");
            }
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            if (gameOn)
            {
                SetStatus(5, btn_5);
            }
            else
            {
                MessageBox.Show("Você precisa começar uma nova partida");
            }
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            if (gameOn)
            {
                SetStatus(6, btn_6);
            }
            else
            {
                MessageBox.Show("Você precisa começar uma nova partida");
            }
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            if (gameOn)
            {
                SetStatus(7, btn_7);
            }
            else
            {
                MessageBox.Show("Você precisa começar uma nova partida");
            }
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            if (gameOn)
            {
                SetStatus(8, btn_8);
            }
            else
            {
                MessageBox.Show("Você precisa começar uma nova partida");
            }
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            if (gameOn)
            {
                SetStatus(9, btn_9);
            }
            else
            {
                MessageBox.Show("Você precisa começar uma nova partida");
            }
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
        }
        public void SetStatus(int position, Button b)
        {
            if(countMove<= 9)
            {
                if (playerHash) //HashList[position].clicked pedir ajuda do professor
                {
                    HashList.Add(new Hash() { clicked = true, playerGame = playerHash });
                    b.Content = "X";
                    playerHash = false;
                    countMove++;
                }
                else
                {
                    HashList.Add(new Hash() { clicked = true, playerGame = playerHash });
                    b.Content = "O";
                    playerHash = true;
                    countMove++;
                }
            }
            else
            {
                MessageBox.Show("Você precisa começar uma nova partida");
            }
        }
    }
}
