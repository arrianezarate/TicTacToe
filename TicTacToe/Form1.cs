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
        String Btntictac = "X";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tictac1.Text == "")
            {
                tictac1.Text = Btntictac;
                if (Btntictac == "X")
                {
                    Btntictac = "O";
                }
                else
                {
                    Btntictac = "X";
                }
            }
        }

        private void tictac2_Click(object sender, EventArgs e)
        {
            if (tictac2.Text == "")
            {
                tictac2.Text = Btntictac;
                if (Btntictac == "X")
                {
                    Btntictac = "O";
                }
                else
                {
                    Btntictac = "X";
                }
            }
        }

        private void tictac3_Click(object sender, EventArgs e)
        {
            if (tictac3.Text == "")
            {
                tictac3.Text = Btntictac;
                if (Btntictac == "X")
                {
                    Btntictac = "O";
                }
                else
                {
                    Btntictac = "X";
                }
            }
        }
    }
}