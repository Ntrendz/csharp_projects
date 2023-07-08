using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int FirstNumber { get; private set; }
        public int SecondNumber { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal first = Convert.ToDecimal(txtFirst.Text);
            decimal second = Convert.ToDecimal(txtSecond.Text);

            
                txtResult.Text = Convert.ToString(first + second);
            
        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSecond_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirst.Clear();
            txtSecond.Clear();
            txtResult.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            decimal first = Convert.ToDecimal(txtFirst.Text);
            decimal second = Convert.ToDecimal(txtSecond.Text);

            txtResult.Text = Convert.ToString(first - second);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            decimal first = Convert.ToDecimal(txtFirst.Text);
            decimal second = Convert.ToDecimal(txtSecond.Text);


            txtResult.Text = Convert.ToString(first * second);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            decimal first = Convert.ToDecimal(txtFirst.Text);
            decimal second = Convert.ToDecimal(txtSecond.Text);


            txtResult.Text = Convert.ToString(first / second);
        }
    }
}
