using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //first stores original number after operator is chosen, oper stores opperator type
        decimal first;
        decimal second;
        decimal sign;
        string oper = "nul";
        string dotCheck;
        string dot = ".";
        

        //10 sets to input digits to calc
        private void btn0_Click(object sender, EventArgs e)
        {
            txtOut.AppendText("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtOut.AppendText("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtOut.AppendText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtOut.AppendText("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtOut.AppendText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtOut.AppendText("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtOut.AppendText("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtOut.AppendText("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtOut.AppendText("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtOut.AppendText("9");
        }

        //adds . if not one present
        private void btnDot_Click(object sender, EventArgs e)
        {
            dotCheck = System.Convert.ToString(txtOut.Text);

            if (dotCheck.Contains(dot))
            {

            }
            else
            {
                txtOut.AppendText(".");
            }
        }

        //changes sign 
        private void btnSign_Click(object sender, EventArgs e)
        {
            if (txtOut.Text != "")
            {
                sign = System.Convert.ToDecimal(txtOut.Text);
                txtOut.Clear();
                sign = (sign) * -1;
                txtOut.AppendText(System.Convert.ToString(sign));
            }
            
        }
        //sets oper to opperator for whichever of the 4 buttons is chosen 
        private void btnPlus_Click(object sender, EventArgs e)
        {
            first = System.Convert.ToDecimal(txtOut.Text);
            txtOut.Clear();
            oper = "add";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            first = System.Convert.ToDecimal(txtOut.Text);
            txtOut.Clear();
            oper = "min";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            first = System.Convert.ToDecimal(txtOut.Text);
            txtOut.Clear();
            oper = "mult";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            first = System.Convert.ToDecimal(txtOut.Text);
            txtOut.Clear();
            oper = "div";
        }

        // clears line and resets variable
        private void btnC_Click(object sender, EventArgs e)
        {
            txtOut.Clear();
            oper = "nul";
            first = 0;
        }
        // clears line
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtOut.Clear();
        }

        //enter button, checks opperator 
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (oper == "add")
            {
                second = System.Convert.ToDecimal(txtOut.Text);
                txtOut.Clear();
                txtOut.AppendText(System.Convert.ToString(first + second));
            }
            if (oper == "min")
            {
                second = System.Convert.ToDecimal(txtOut.Text);
                txtOut.Clear();
                txtOut.AppendText(System.Convert.ToString(first - second));
            }
            if (oper == "mult")
            {
                second = System.Convert.ToDecimal(txtOut.Text);
                txtOut.Clear();               
                txtOut.AppendText(System.Convert.ToString(first * second));
            }
            if (oper == "div")
            {
                second = System.Convert.ToDecimal(txtOut.Text);
                txtOut.Clear();
                //checks for divide by zero
                if (second != 0)
                {
                    txtOut.AppendText(System.Convert.ToString((first / second) + (first % second)));
                }
                else
                {
                    txtOut.AppendText("Illegal Operation, Press C");
                }
            }






        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                btn1.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                btn0.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                btn2.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                btn3.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                btn4.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                btn5.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                btn6.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                btn7.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                btn8.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                btn9.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnEqual.PerformClick();
            }
            else if (e.KeyCode == Keys.Add)
            {
                btnPlus.PerformClick();
            }

        }
    }
}
