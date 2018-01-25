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
        double first;
        double second;
        string oper = "nul";

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

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtOut.AppendText(".");
        }

        //changes sign and checks for zeros
        private void btnSign_Click(object sender, EventArgs e)
        {
            if ((System.Convert.ToString(txtOut.Text)).Contains("."))
            {
                
            }
            else
            {
                double sig = System.Convert.ToDouble(txtOut.Text);
                txtOut.Clear();
                txtOut.AppendText(System.Convert.ToString(sig * (-1)));
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            first = System.Convert.ToDouble(txtOut.Text);
            txtOut.Clear();
            oper = "add";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            first = System.Convert.ToDouble(txtOut.Text);
            txtOut.Clear();
            oper = "min";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            first = System.Convert.ToDouble(txtOut.Text);
            txtOut.Clear();
            oper = "mul";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            first = System.Convert.ToDouble(txtOut.Text);
            txtOut.Clear();
            oper = "div";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtOut.Clear();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtOut.Clear();
            oper = "nul";
            first = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (oper == "add")
            {
                second = System.Convert.ToDouble(txtOut.Text);
                txtOut.Clear();
                txtOut.AppendText(System.Convert.ToString(first + second));
            }
            if (oper == "min")
            {
                second = System.Convert.ToDouble(txtOut.Text);
                txtOut.Clear();
                txtOut.AppendText(System.Convert.ToString(first - second));
            }
            if (oper == "mul")
            {
                second = System.Convert.ToDouble(txtOut.Text);
                txtOut.Clear();
                txtOut.AppendText(System.Convert.ToString(first * second));
            }
            if (oper == "div")
            {
                second = System.Convert.ToDouble(txtOut.Text);
                txtOut.Clear();
                txtOut.AppendText(System.Convert.ToString((first / second) +(first % second)));
            }






        }
    }
}
