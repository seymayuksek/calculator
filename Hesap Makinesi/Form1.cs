using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        int symbol = 0;
        double number1, number2, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void numbersAction(object sender, EventArgs e)
        {
            if (txtResult.Text=="0")
            {
                txtResult.Text = "";
            }
            txtResult.Text = txtResult.Text + ((Button)sender).Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtResult.Text);
            symbol = 1;
            txtResult.Text = "0";

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtResult.Text);
            symbol = 2;
            txtResult.Text = "0";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtResult.Text);
            symbol = 3;
            txtResult.Text = "0";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtResult.Text);
            symbol = 4;
            txtResult.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            number2 = double.Parse(txtResult.Text);
            if (symbol == 1)
            {
                result = number1 + number2;
            }
            txtResult.Text = result.ToString();

            if (symbol == 2)
            {
                result = number1 - number2;
            }
            txtResult.Text = result.ToString();
            if (symbol == 3)
            {
                result = number1 * number2;
            }
            txtResult.Text = result.ToString();
            if (symbol == 4)
            {
                result = number1 / number2;
            }
            txtResult.Text = result.ToString();
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.IndexOf(",") < 1)
            {
                txtResult.Text += ",";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "0")
            {
                if (txtResult.Text.StartsWith("-"))
                {
                    txtResult.Text = txtResult.Text.Replace("-", "");
                }
                else if (txtResult.Text.StartsWith(""))
                {
                    txtResult.Text = "-" + txtResult.Text;
                }
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
        }
    }
}
