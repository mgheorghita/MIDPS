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
        
        public Form1()
        {
            InitializeComponent();
            this.textBox.AutoSize = false;
            this.textBox.Size = new System.Drawing.Size(266, 90);

        }
        bool checkIfOperation = false;
        string op = "";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // operations.Text += textBox.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&  (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void zero_btn_Click(object sender, EventArgs e)
        {
            checkIfOperation = false;
            textBox.Text += "0";
           // operations.Text += "0";
        }

        private void one_btn_Click(object sender, EventArgs e)
        {
            checkIfOperation = false;
            textBox.Text += "1";
            //   operations.Text += "1";
        }

        private void two_btn_Click(object sender, EventArgs e)
        {
            checkIfOperation = false;
            textBox.Text += "2";
          //  operations.Text += "2";
        }

        private void three_btn_Click(object sender, EventArgs e)
        {
            checkIfOperation = false;
            textBox.Text += "3";
            operationField.Text += "3";
        }

        private void four_btn_Click(object sender, EventArgs e)
        {
            checkIfOperation = false;
            textBox.Text += "4";
           // operations.Text += "4";
        }

        private void five_btn_Click(object sender, EventArgs e)
        {
            checkIfOperation = false;
            textBox.Text += "5";
            //operations.Text += "5";
        }

        private void six_btn_Click(object sender, EventArgs e)
        {
            checkIfOperation = false;
            textBox.Text += "6";
           // operations.Text += "6";
        }

        private void seven_btn_Click(object sender, EventArgs e)
        {
            checkIfOperation = false;
            textBox.Text += "7";
          //  operations.Text += "7";
        }

        private void eight_btn_Click(object sender, EventArgs e)
        {
            checkIfOperation = false;
            textBox.Text += "8";
            //operations.Text += "8";
        }

        private void nine_btn_Click(object sender, EventArgs e)
        {
            checkIfOperation = false;
            textBox.Text += "9";
          //  operations.Text += "9";
        }

        private void negate_btn_Click(object sender, EventArgs e)
        {
            checkIfOperation = false;
            string changed;
            if (textBox.Text.Contains('-'))
            {
                changed = textBox.Text.Replace("-", "");
            }
            else
            {
                changed = "-" + textBox.Text;
              
            }
            operationField.Text = operationField.Text.Replace(textBox.Text, changed);
            textBox.Text = changed;
        }
        double result;
      
        double result2;
        private void equal_btn_Click(object sender, EventArgs e)
        {
            checkIfOperation = false;
            operationField.Clear();
            if (op == "+")
            {
                result2 = result + double.Parse(textBox.Text);
                textBox.Text = result2.ToString();
                result = 0;
            }else
                if (op == "-")
            {
                result2 = result - double.Parse(textBox.Text);
                textBox.Text = result2.ToString();
                result = 0;
            }
            else
                if (op == "*")
            {
                result2 = result * double.Parse(textBox.Text);
                textBox.Text = result2.ToString();
                result = 0;
            }
            else
                if (op == "/")
            {
                result2 = result / double.Parse(textBox.Text);
                textBox.Text = result2.ToString();
                result = 0;
            }
           
            
        }
        private void plus_btn_Click(object sender, EventArgs e)
        {


            if (checkIfOperation == false)
            {
                operationField.Text += textBox.Text + "+";
                result += double.Parse(textBox.Text);
                textBox.Clear();
                
            }
            else
            {
               operationField.Text = operationField.Text.Substring(0, operationField.Text.Length - 1);
               operationField.Text += textBox.Text + "+";
            }
            op = "+";
            checkIfOperation = true;
        }
        private void minus_btn_Click(object sender, EventArgs e)
        {

            if (checkIfOperation == false)
            {

                operationField.Text += textBox.Text + "-";
                result += double.Parse(textBox.Text);
                textBox.Clear();
             
            }
            else
            {
                operationField.Text = operationField.Text.Substring(0, operationField.Text.Length - 1);
                operationField.Text += textBox.Text + "-";
            }

            op = "-";
            checkIfOperation = true;
        }

        private void multiply_btn_Click(object sender, EventArgs e)
        {

            if (checkIfOperation == false)
            {

                operationField.Text += textBox.Text + "*";
                result += double.Parse(textBox.Text);
                textBox.Clear();

            }
            else
            {
                operationField.Text = operationField.Text.Substring(0, operationField.Text.Length - 1);
                operationField.Text += textBox.Text + "*";
            }

            op = "*";

            checkIfOperation = true;
        }

        private void divide_btn_Click(object sender, EventArgs e)
        {


            if (checkIfOperation == false)
            {
                operationField.Text += textBox.Text + "/";
                result += double.Parse(textBox.Text);
                textBox.Clear();

            }
            else
            {
                operationField.Text = operationField.Text.Substring(0, operationField.Text.Length - 1);
                operationField.Text += textBox.Text + "/";
            }

            op = "/";
            checkIfOperation = true;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            checkIfOperation = false;
            operationField.Clear();
            textBox.Clear();
            result = 0;
        }

        private void dot_btn_Click(object sender, EventArgs e)
        {
            checkIfOperation = false;
            //operations.Text += ".";
            textBox.Text += ".";
        }
    }
}
