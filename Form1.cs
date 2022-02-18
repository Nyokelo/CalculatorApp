using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        double SecondNumber;
        double result;
        string Operation;

        public Form1()

        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (txt_Display.Text == "0" && txt_Display.Text != "null")
            {
                txt_Display.Text = "8";
            }
            else
            {
                txt_Display.Text = txt_Display.Text + "8";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (txt_Display.Text == "0" && txt_Display.Text != "null")
            {
                txt_Display.Text = "3";
            }
            else
            {
                txt_Display.Text = txt_Display.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (txt_Display.Text == "0" && txt_Display.Text != "null")
            {
                txt_Display.Text = "4";
            }
            else
            {
                txt_Display.Text = txt_Display.Text + "4";
            }
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (txt_Display.Text == "0" && txt_Display.Text != "null")
            {
                txt_Display.Text = "1";
            }
            else
            {
                txt_Display.Text = txt_Display.Text + "1";
            }

        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (txt_Display.Text == "0" && txt_Display.Text != "null")
            {
                txt_Display.Text = "2";
            }
            else
            {
                txt_Display.Text = txt_Display.Text + "2";
            }

        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (txt_Display.Text == "0" && txt_Display.Text != "null")
            {
                txt_Display.Text = "5";
            }
            else
            {
                txt_Display.Text = txt_Display.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (txt_Display.Text == "0" && txt_Display.Text != "null")
            {
                txt_Display.Text = "6";
            }
            else
            {
                txt_Display.Text = txt_Display.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (txt_Display.Text == "0" && txt_Display.Text != "null")
            {
                txt_Display.Text = "7";
            }
            else
            {
                txt_Display.Text = txt_Display.Text + "7";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (txt_Display.Text == "0" && txt_Display.Text != "null")
            {
                txt_Display.Text = "9";
            }
            else
            {
                txt_Display.Text = txt_Display.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (txt_Display.Text == "0" && txt_Display.Text != "null")
            {
                txt_Display.Text = "0";
            }
            else
            {
                txt_Display.Text = txt_Display.Text + "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            
            FirstNumber = Convert.ToDouble(txt_Display.Text);
            txt_Display.Text = "0";
            Operation = "+";
            
        }

        private void sub_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txt_Display.Text);

            txt_Display.Text = "0";
            Operation = "-";
        }

        private void mult_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txt_Display.Text);

            txt_Display.Text = "0";
            Operation = "*";
        }

        private void div_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txt_Display.Text);

            txt_Display.Text = "0";
            Operation = "/";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txt_Display.Text = "0";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            txt_Display.Text = txt_Display.Text + ".";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            SecondNumber = Convert.ToDouble(txt_Display.Text);
            if (Operation == "+")
            {
                result = FirstNumber + SecondNumber;
                txt_Display.Text = Convert.ToString(result);
               
               

            }
            SecondNumber = Convert.ToDouble(txt_Display.Text);
            if (Operation == "-")
            {
                result = FirstNumber - SecondNumber;
                txt_Display.Text = Convert.ToString(result);
                
            }
            SecondNumber = Convert.ToDouble(txt_Display.Text);
            if (Operation == "*")
            {
                result = FirstNumber * SecondNumber;
                txt_Display.Text = Convert.ToString(result);
                
            }

            SecondNumber = Convert.ToDouble(txt_Display.Text);
            if (Operation == "/")
            {
               
                    
                if (SecondNumber == 0)
                {
                    txt_Display.Text = "math error!";
                }
                else
                {
                    result = FirstNumber / SecondNumber;
                    txt_Display.Text = Convert.ToString(result);
                }

            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nDel_Click(object sender, EventArgs e)
        {
            txt_Display.Text = txt_Display.Text.Remove(txt_Display.Text.Length - 1);
           
        }

        private void nLog_Click(object sender, EventArgs e)
        {
            //txt_Display.Clear();
            txt_Display.Text = Math.Log10(double.Parse(txt_Display.Text.Trim())).ToString();
        }
    }
}
