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
        double number1, number2;
        char Operation;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNumber1.Text);
            number2 = Convert.ToDouble(txtNumber2.Text);
            Operation = Convert.ToChar(txtOperation.Text);
            if (Operation == '+')
            {
                double result = number1 + number2;
                txtResult.Text = result.ToString();
            }
            if (Operation == '-')
            {
                double result = number1 - number2;
                txtResult.Text = result.ToString();
            }
            if (Operation == '*')
            {
                double result = number1 * number2;
                txtResult.Text = result.ToString();
            }
            if (Operation == '/')
            {
                double result = number1 / number2;
                if (number2 == 0)
                {
                    MessageBox.Show("На 0 делить нельзя!");
                }
                txtResult.Text = result.ToString();
            }


        }

        
        

    }
}
