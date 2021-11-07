using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator3
{
    public partial class Form1 : Form
    {
        double number1, number2, number3, sum, result1, result2;

        

        private void button1_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNum1.Text);
            number2 = Convert.ToDouble(txtNum2.Text);
            sum = number1 + number2;
            number3 = Convert.ToDouble(txtNum3.Text);
            result1 = sum / number3;
            txtResult1.Text = result1.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                result2 = result1 * 10 / 100;
                txtResult2.Text = result2.ToString();
            }
            else if (radioButton2.Checked == true)
            {
                result2 = result1 * 20 / 100;
                txtResult2.Text = result2.ToString();
            }
            else if (radioButton3.Checked == true)
            {
                result2 = result2 * 50 / 100;
                txtResult2.Text = result2.ToString();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

       
    }
}
