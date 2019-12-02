using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Крестики_нолики
{
    public partial class Form1 : Form
    {
        string turn = "";
        Random rnd = new Random();
        int[] mass = new int[9];
        Button[] btn = new Button[9];
        public Form1()
        {
            InitializeComponent();
            if (rnd.Next(1, 7) <= 3)
            {
                turn = "крестики";
                label2.Text = "X";
            }
            else
            {
                turn = "нолики";
                label2.Text = "O";
            }
            btn[0] = button1;
            btn[1] = button2;
            btn[2] = button3;
            btn[3] = button4;
            btn[4] = button5;
            btn[5] = button6;
            btn[6] = button7;
            btn[7] = button8;
            btn[8] = button9;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (turn == "крестики")
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        btn[i].Text = "X";
                        label2.Text = "O";
                        turn = "нолики";
                        btn[i].Enabled = false;
                        mass[i] = 1;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        btn[i].Text = "O";
                        label2.Text = "X";
                        turn = "крестики";
                        btn[i].Enabled = false;
                        mass[i] = 2;
                        break;
                    }
                }
            }
            if (mass[0]==1 && mass[1]==1 && mass[2] == 1)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[2].BackColor = System.Drawing.Color.Red;
                for (int i =0; i<btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
            }
            if (mass[3] == 1 && mass[4] == 1 && mass[5] == 1)
            {
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
            }
            if (mass[6] == 1 && mass[7] == 1 && mass[8] == 1)
            {
                btn[6].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
            }
            if (mass[0] == 1 && mass[3] == 1 && mass[6] == 1)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
            }
            if (mass[1] == 1 && mass[4] == 1 && mass[7] == 1)
            {
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
            }
            if (mass[2] == 1 && mass[5] == 1 && mass[8] == 1)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
            }
            if (mass[0] == 1 && mass[4] == 1 && mass[8] == 1)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
            }
            if (mass[2] == 1 && mass[4] == 1 && mass[6] == 1)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
            }
            if (mass[0] == 2 && mass[1] == 2 && mass[2] == 2)//нолики
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[2].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
            }
            if (mass[3] == 2 && mass[4] == 2 && mass[5] == 2)
            {
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
            }
            if (mass[6] == 2 && mass[7] == 2 && mass[8] == 2)
            {
                btn[6].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
            }
            if (mass[0] == 2 && mass[3] == 2 && mass[6] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
            }
            if (mass[1] == 2 && mass[4] == 2 && mass[7] == 2)
            {
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
            }
            if (mass[2] == 2 && mass[5] == 2 && mass[8] == 2)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
            }
            if (mass[0] == 2 && mass[4] == 2 && mass[8] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
            }
            if (mass[2] == 2 && mass[4] == 2 && mass[6] == 2)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i< btn.Length; i++)
            {
                mass[i] = 0;
                btn[i].Text = "";
                if (rnd.Next(1,7)<=3)
                {
                    turn = "крестики";
                    label2.Text = "X";
                }
                else
                {
                    turn = "нолики";
                    label2.Text = "O";
                }
                btn[i].Enabled = true;
                btn[i].BackColor = System.Drawing.Color.White;
            }
        }
    }
}
