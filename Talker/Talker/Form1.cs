using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Talker
        {
            public static int BlahBlahBlah(string thingToSay, int numberOfTimes)
            {
                string finalString = "";
                for (int count = 0; count < numberOfTimes; count++)
                {
                    finalString = finalString + thingToSay + "\n";
                }
                MessageBox.Show(finalString);
                return finalString.Length;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len = Talker.BlahBlahBlah(textBox1.Text, (int)numericUpDown1.Value);
            MessageBox.Show("The message length is " + len);
        }
    }
}
