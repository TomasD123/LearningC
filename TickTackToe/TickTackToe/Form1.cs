﻿using System;
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
        int moves, xo = 0;

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
            xo = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button button = (Button)c;
                    button.Text = "";
                }
            }            
            catch { }
        }
                
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; //casting sender to Button
            //Checking to make sure a square isnt full
            if (button.Text != "X" & button.Text != "O")
            {
                if ((xo % 2) == 0)
                {
                    button.Text = "X";
                    xo++;
                }
                else if ((xo % 2) != 0)
                {
                    button.Text = "O";
                    xo++;
                }
                moves = xo;
            }
            else
            {
                button.Text = button.Text;
            }

            if(moves >= 5)
            {
                game_Over();
            }
            
        }

        
        private void game_Over()
        {
            //horizontal check
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (button1.Text != ""))
            {
                MessageBox.Show(button1.Text +" Wins!", "Awsome");
                new_Game();
            }
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (button4.Text != ""))
            {
                MessageBox.Show(button4.Text +" Wins!", "Awsome");
                new_Game();
            }
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (button7.Text != ""))
            {
                MessageBox.Show(button7.Text +" Wins!", "Awsome");
                new_Game();
            }

            //vertical check
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (button1.Text != ""))
            {
                MessageBox.Show(button1.Text +" Wins!", "Awsome");
                new_Game();
            }
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (button2.Text != ""))
            {
                MessageBox.Show(button2.Text +" Wins!", "Awsome");
                new_Game();
            }
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (button3.Text != ""))
            {
                MessageBox.Show(button3.Text +" Wins!", "Awsome");
                new_Game();
            }

            //diagnal check
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (button1.Text != ""))
            {
                MessageBox.Show(button1.Text +" Wins!", "Awsome");
                new_Game();
            }
            else if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (button3.Text != ""))
            {
                MessageBox.Show(button3.Text +" Wins!", "Awsome");
                new_Game();
            }

            else if(moves == 9)
            {
                //end_Game;
                if (MessageBox.Show("No Winner, Play Agin?", "Bummer", 
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