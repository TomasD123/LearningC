﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flashy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            while (Visible)
            {
                int c, i;

                for (c = 0; c < 254 && Visible; c++)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);

                    Application.DoEvents();

                    System.Threading.Thread.Sleep(10);
                }
                
                for (i = c; i > 0 && Visible; i--)
                {
                    this.BackColor = Color.FromArgb(i, 255 - i, i);

                    Application.DoEvents();

                    System.Threading.Thread.Sleep(10);
                }
            }
        }
    }
}

