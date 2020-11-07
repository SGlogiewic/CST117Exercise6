using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST117Exercise6
{
    public partial class Form1 : Form
    {
        static int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //establishes dice
            Dice a1 = new Dice(6);
            Dice a2 = new Dice(6);
            label1.Text = a1.rollDie().ToString();
            label2.Text = a2.rollDie().ToString();
            //sets up strings for dice
            String stringRoll1 = label1.Text;
            int roll1 = int.Parse(stringRoll1);
            String stringRoll2 = label2.Text;
            int roll2 = int.Parse(stringRoll2);
            //counts the numbers on the dice
            count++;
            //when program rolls snake eyes
            if (roll1 == 1 & roll2 == 1) 
            {
                MessageBox.Show("Rolls it took to get snake eyes: " + count);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
