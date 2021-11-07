using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double number1,number2, Result;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNumber1.Text);
            number2 = Convert.ToDouble(txtNumber2.Text);
            Result = number1 + number2;
            txtResult1.Text = Result.ToString();

        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNumber1.Text);
            number2 = Convert.ToDouble(txtNumber2.Text);
            Result = number1 - number2;
            txtResult1.Text = Result.ToString();
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNumber1.Text);
            number2 = Convert.ToDouble(txtNumber2.Text);
            Result = number1 * number2;
            txtResult1.Text = Result.ToString();
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNumber1.Text);
            number2 = Convert.ToDouble(txtNumber2.Text);
            if (number2 == 0)
            {
                MessageBox.Show(this, "На 0 делить нельзя!");
            }
          
            Result = number1 / number2;
            txtResult1.Text = Result.ToString();
            
        }
    }
}
