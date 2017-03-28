using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickTackToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*keep track of moves to set Xs & Os and 
         to check when I should start looking for wins*/
        int moves = 0;

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Tomas", "Tic Tac Toe");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new_Game();
        }

        private void new_Game()
        {
            moves = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button button = (Button)c;
                    button.Enabled = true;
                    button.Text = "";
                }
            }            
            catch { }
        }
                
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; //casting sender to Button
            //Checking to make sure a square isnt full
            if (button.Enabled)
            {
                //assigning values even is x odd is o
                if ((moves % 2) == 0)
                {
                    button.Text = "X";
                    moves++;
                    button.Enabled = false;
                }
                else if ((moves % 2) != 0)
                {
                    button.Text = "O";
                    moves++;
                    button.Enabled = false;
                }
                
            }
            else
            {
                button.Text = button.Text;
            }

            /*checking for numbers of moves before 
              starting to check for a winner*/
            if (moves >= 5)
            {
                game_Over();
            }
            
        }

        private void preview_On(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                //assigning values even is x odd is o
                if ((moves % 2) == 0)
                {
                    button.Text = "X";
                    button.Enabled = true;
                }
                else if ((moves % 2) != 0)
                {
                    button.Text = "O";
                    button.Enabled = true;
                }
            }
        }
        
        private void preview_Off(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                button.Text = "";
                button.Enabled = true;
            }
        }
        
        //method to check for win or draw
        private void game_Over()
        {
            //horizontal check
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (button1.Text != ""))
            {
                MessageBox.Show(button1.Text +" Wins!", "Winner");
                new_Game();
            }
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (button4.Text != ""))
            {
                MessageBox.Show(button4.Text +" Wins!", "Winner");
                new_Game();
            }
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (button7.Text != ""))
            {
                MessageBox.Show(button7.Text +" Wins!", "Winner");
                new_Game();
            }

            //vertical check
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (button1.Text != ""))
            {
                MessageBox.Show(button1.Text +" Wins!", "Winner");
                new_Game();
            }
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (button2.Text != ""))
            {
                MessageBox.Show(button2.Text +" Wins!", "Winner");
                new_Game();
            }
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (button3.Text != ""))
            {
                MessageBox.Show(button3.Text +" Wins!", "Winner");
                new_Game();
            }

            //diagonal check
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (button1.Text != ""))
            {
                MessageBox.Show(button1.Text +" Wins!", "Winner");
                new_Game();
            }
            else if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (button3.Text != ""))
            {
                MessageBox.Show(button3.Text +" Wins!", "Winner");
                new_Game();
            }

            else if(moves == 9)
            {
                //if draw ask to see if players want to keep playing
                if (MessageBox.Show("No Winner, Play Again?", "Draw!", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new_Game();
                }
                else
                {
                    Application.Exit();
                }
                
            }
        }

        
    }
}
