using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string opr;
        double oparand1, oparand2, result;

        private void btn_ChangeText_Click(object sender, EventArgs e)
        {
            int n1;
            if (!Int32.TryParse(txt_1.Text, out n1))
            {
                MessageBox.Show("Enter a Value in the TextBox");
                return;
            }



            oparand2 = Convert.ToDouble(txt_1.Text);
            switch (opr)
            {
                case "+":
                    result = oparand1 + oparand2;
                    txt_1.Text = Convert.ToString(result);
                    break;

                case "-":
                    result = oparand1 - oparand2;
                    txt_1.Text = Convert.ToString(result);
                    break;

                case "*":
                    result = oparand1 * oparand2;
                    txt_1.Text = Convert.ToString(result);
                    break;

                case "/":
                    if (oparand2 == 0)
                    {
                        txt_1.Text = "0.0";
                        break;
                    }
                    else
                    {
                        result = oparand1 / oparand2;
                        txt_1.Text = Convert.ToString(result);
                        break;
                    }
            }
        }

        private void txt_1_TextChanged(object sender, EventArgs e)
        {
           
        }
 
        //button 1 coding
        private void btn1_Click(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + 1;
        }

       

        // button 2 coding
        private void btn2_Click(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + 2;
        }

        // button 3 coding
        private void btn3_Click(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + 3;
        }

        // button 4 coding
        private void btn4_Click(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + 4;
        }

      
        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_1.Text = "";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            oparand1 = Convert.ToDouble(txt_1.Text);
            opr = "+";
            txt_1.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            oparand1 = Convert.ToDouble(txt_1.Text);
            opr = "*";
            txt_1.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            oparand1 = Convert.ToDouble(txt_1.Text);
            opr = "-";
            txt_1.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            oparand1 = Convert.ToDouble(txt_1.Text);
            opr = "/";
            txt_1.Clear();
        }

        // button 5 coding
        private void btn5_Click_1(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + 5;
        }

        // button 6 coding
        private void btn6_Click(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + 6;
        }

        // button 7 coding
        private void btn7_Click_1(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + 7;
        }

        // button 8 coding
        private void btn8_Click_1(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + 8;
        }

        // button 9 coding
        private void btn9_Click_1(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + 9;
        }

        // button 8 coding
        private void btn0_Click_1(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // button dot coding
        private void btnDot_Click_1(object sender, EventArgs e)
        {
            if (txt_1.Text.Contains("."))
            {
                txt_1.Text = txt_1.Text;
            }
            else
            {
                txt_1.Text = txt_1.Text + ".";
            }
        }


        // button 00 coding
        private void btn00_Click_1(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + 0 + 0;
        }

    }
}
