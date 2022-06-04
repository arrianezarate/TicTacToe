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
                if (tictac1.Text  == tictac2.Text)
                {
                    if (tictac2.Text == tictac3.Text)
                    {
                        MessageBox.Show("Congrats! You win " + tictac1.Text);
                        tictac1.Text = "";
                        tictac2.Text = "";
                        tictac3.Text = "";
                        tictac4.Text = "";
                        tictac5.Text = "";
                        tictac6.Text = "";
                        tictac7.Text = "";
                        tictac8.Text = "";
                        tictac9.Text = "";
                    }               
                }
                else if (tictac1.Text == tictac4.Text)
                {
                    if (tictac1.Text == tictac7.Text)
                    {
                        MessageBox.Show("Congrats! You win " + tictac1.Text);
                        tictac1.Text = "";
                        tictac2.Text = "";
                        tictac3.Text = "";
                        tictac4.Text = "";
                        tictac5.Text = "";
                        tictac6.Text = "";
                        tictac7.Text = "";
                        tictac8.Text = "";
                        tictac9.Text = "";
                    }
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
                if (tictac2.Text == tictac3.Text)
                {
                    if (tictac3.Text == tictac1.Text)
                    {
                        MessageBox.Show("Congrats! You win " + tictac2.Text);
                        tictac1.Text = "";
                        tictac2.Text = "";
                        tictac3.Text = "";
                        tictac4.Text = "";
                        tictac5.Text = "";
                        tictac6.Text = "";
                        tictac7.Text = "";
                        tictac8.Text = "";
                        tictac9.Text = "";
                    }
                }
                else if (tictac2.Text == tictac5.Text)
                {
                    if (tictac5.Text == tictac8.Text)
                    {
                        MessageBox.Show("Congrats! You win " + tictac2.Text);
                        tictac1.Text = "";
                        tictac2.Text = "";
                        tictac3.Text = "";
                        tictac4.Text = "";
                        tictac5.Text = "";
                        tictac6.Text = "";
                        tictac7.Text = "";
                        tictac8.Text = "";
                        tictac9.Text = "";
                    }
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
                if (tictac3.Text == tictac2.Text)
                {
                    if (tictac2.Text == tictac1.Text)
                    {
                        MessageBox.Show("Congrats! You win " + tictac3.Text);
                        tictac1.Text = "";
                        tictac2.Text = "";
                        tictac3.Text = "";
                        tictac4.Text = "";
                        tictac5.Text = "";
                        tictac6.Text = "";
                        tictac7.Text = "";
                        tictac8.Text = "";
                        tictac9.Text = "";
                    }
                }
                else if (tictac3.Text == tictac6.Text)
                {
                    if (tictac6.Text == tictac9.Text)
                    {
                        MessageBox.Show("Congrats! You win " + tictac3.Text);
                        tictac1.Text = "";
                        tictac2.Text = "";
                        tictac3.Text = "";
                        tictac4.Text = "";
                        tictac5.Text = "";
                        tictac6.Text = "";
                        tictac7.Text = "";
                        tictac8.Text = "";
                        tictac9.Text = "";
                    }
                }
            }
        }

        private void tictac4_Click(object sender, EventArgs e)
        {
            if (tictac4.Text == "")
            {
                tictac4.Text = Btntictac;
                if (Btntictac == "X")
                {
                    Btntictac = "O";
                }
                else
                {
                    Btntictac = "X";
                }
                if (tictac4.Text == tictac5.Text)
                {
                    if (tictac5.Text == tictac6.Text)
                    {
                        MessageBox.Show("Congrats! You win " + tictac4.Text);
                        tictac1.Text = "";
                        tictac2.Text = "";
                        tictac3.Text = "";
                        tictac4.Text = "";
                        tictac5.Text = "";
                        tictac6.Text = "";
                        tictac7.Text = "";
                        tictac8.Text = "";
                        tictac9.Text = "";
                    }
                }
                else if (tictac4.Text == tictac7.Text)
                {
                    if (tictac7.Text == tictac1.Text)
                    {
                        MessageBox.Show("Congrats! You win " + tictac4.Text);
                        tictac1.Text = "";
                        tictac2.Text = "";
                        tictac3.Text = "";
                        tictac4.Text = "";
                        tictac5.Text = "";
                        tictac6.Text = "";
                        tictac7.Text = "";
                        tictac8.Text = "";
                        tictac9.Text = "";
                    }
                }
            }
        }

        private void tictac5_Click(object sender, EventArgs e)
        {
            if (tictac5.Text == "")
            {
                tictac5.Text = Btntictac;
                if (Btntictac == "X")
                {
                    Btntictac = "O";
                }
                else
                {
                    Btntictac = "X";
                }
                if (tictac5.Text == tictac6.Text)
                {
                    if (tictac6.Text == tictac4.Text)
                    {
                        MessageBox.Show("Congrats! You win " + tictac5.Text);
                        tictac1.Text = "";
                        tictac2.Text = "";
                        tictac3.Text = "";
                        tictac4.Text = "";
                        tictac5.Text = "";
                        tictac6.Text = "";
                        tictac7.Text = "";
                        tictac8.Text = "";
                        tictac9.Text = "";
                    }
                }
                else if (tictac5.Text == tictac8.Text)
                {
                    if (tictac8.Text == tictac2.Text)
                    {
                        MessageBox.Show("Congrats! You win " + tictac5.Text);
                        tictac1.Text = "";
                        tictac2.Text = "";
                        tictac3.Text = "";
                        tictac4.Text = "";
                        tictac5.Text = "";
                        tictac6.Text = "";
                        tictac7.Text = "";
                        tictac8.Text = "";
                        tictac9.Text = "";
                    }
                }
            }
        }

        private void tictac6_Click(object sender, EventArgs e)
        {
            if (tictac6.Text == "")
            {
                tictac6.Text = Btntictac;
                if (Btntictac == "X")
                {
                    Btntictac = "O";
                }
                else
                {
                    Btntictac = "X";
                }
                if (tictac6.Text == tictac5.Text)
                {
                    if (tictac5.Text == tictac4.Text)
                    {
                        MessageBox.Show("Congrats! You win " + tictac6.Text);
                        tictac1.Text = "";
                        tictac2.Text = "";
                        tictac3.Text = "";
                        tictac4.Text = "";
                        tictac5.Text = "";
                        tictac6.Text = "";
                        tictac7.Text = "";
                        tictac8.Text = "";
                        tictac9.Text = "";
                    }
                }
                else if (tictac6.Text == tictac9.Text)
                {
                    if (tictac9.Text == tictac3.Text)
                    {
                        MessageBox.Show("Congrats! You win " + tictac6.Text);
                        tictac1.Text = "";
                        tictac2.Text = "";
                        tictac3.Text = "";
                        tictac4.Text = "";
                        tictac5.Text = "";
                        tictac6.Text = "";
                        tictac7.Text = "";
                        tictac8.Text = "";
                        tictac9.Text = "";
                    }
                }
            }
        }

        private void tictac7_Click(object sender, EventArgs e)
        {
            if (tictac7.Text == "")
            {
                tictac7.Text = Btntictac;
                if (Btntictac == "X")
                {
                    Btntictac = "O";
                }
                else
                {
                    Btntictac = "X";
                }
                if (tictac7.Text == tictac8.Text)
                {
                    if (tictac8.Text == tictac9.Text)
                    {
                        MessageBox.Show("Congrats! You win " + tictac7.Text);
                        tictac1.Text = "";
                        tictac2.Text = "";
                        tictac3.Text = "";
                        tictac4.Text = "";
                        tictac5.Text = "";
                        tictac6.Text = "";
                        tictac7.Text = "";
                        tictac8.Text = "";
                        tictac9.Text = "";
                    }
                }
                else if (tictac7.Text == tictac1.Text)
                {
                    if (tictac1.Text == tictac4.Text)
                    {
                        MessageBox.Show("Congrats! You win " + tictac7.Text);
                        tictac1.Text = "";
                        tictac2.Text = "";
                        tictac3.Text = "";
                        tictac4.Text = "";
                        tictac5.Text = "";
                        tictac6.Text = "";
                        tictac7.Text = "";
                        tictac8.Text = "";
                        tictac9.Text = "";
                    }
                }
            }
        }

        private void tictac8_Click(object sender, EventArgs e)
        {
            if (tictac8.Text == "")
            {
                tictac8.Text = Btntictac;
                if (Btntictac == "X")
                {
                    Btntictac = "O";
                }
                else
                {
                    Btntictac = "X";
                }
                if (tictac8.Text == tictac9.Text)
                {
                    if (tictac9.Text == tictac7.Text)
                    {
                        MessageBox.Show("Congrats! You win " + tictac8.Text);
                        tictac1.Text = "";
                        tictac2.Text = "";
                        tictac3.Text = "";
                        tictac4.Text = "";
                        tictac5.Text = "";
                        tictac6.Text = "";
                        tictac7.Text = "";
                        tictac8.Text = "";
                        tictac9.Text = "";
                    }
                }
                else if (tictac8.Text == tictac2.Text)
                {
                    if (tictac2.Text == tictac5.Text)
                    {
                        MessageBox.Show("Congrats! You win " + tictac8.Text);
                        tictac1.Text = "";
                        tictac2.Text = "";
                        tictac3.Text = "";
                        tictac4.Text = "";
                        tictac5.Text = "";
                        tictac6.Text = "";
                        tictac7.Text = "";
                        tictac8.Text = "";
                        tictac9.Text = "";
                    }
                }
            }
        }

        private void tictac9_Click(object sender, EventArgs e)
        {
            if (tictac9.Text == "")
            {
                tictac9.Text = Btntictac;
                if (Btntictac == "X")
                {
                    Btntictac = "O";
                }
                else
                {
                    Btntictac = "X";
                }
                if (tictac9.Text == tictac8.Text)
                {
                    if (tictac8.Text == tictac7.Text)
                    {
                        MessageBox.Show("Congrats! You win " + tictac9.Text);
                        tictac1.Text = "";
                        tictac2.Text = "";
                        tictac3.Text = "";
                        tictac4.Text = "";
                        tictac5.Text = "";
                        tictac6.Text = "";
                        tictac7.Text = "";
                        tictac8.Text = "";
                        tictac9.Text = "";
                    }
                }
                else if (tictac9.Text == tictac3.Text)
                {
                    if (tictac3.Text == tictac6.Text)
                    {
                        MessageBox.Show("Congrats! You win " + tictac9.Text);
                        tictac1.Text = "";
                        tictac2.Text = "";
                        tictac3.Text = "";
                        tictac4.Text = "";
                        tictac5.Text = "";
                        tictac6.Text = "";
                        tictac7.Text = "";
                        tictac8.Text = "";
                        tictac9.Text = "";
                    }
                }
            }
        }
    }
}