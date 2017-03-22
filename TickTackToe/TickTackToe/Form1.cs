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
        
        private void label1_DoubleClick(object sender, EventArgs e)
        {
            label1.Visible = false;
            
        }



        /*keep track of moves to set Xs & Os and 
         to check when I should start looking for wins*/
        int moves, xo = 0;      

        private void button_Click(object sender, EventArgs e)
        {
            var button = (Button) sender; //casting sender to Button
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
        }

    }
}
