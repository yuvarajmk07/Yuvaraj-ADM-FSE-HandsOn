using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((new Regex("^[0-9]*$")).IsMatch(textBox1.Text)&& (new Regex("^[0-9]*$")).IsMatch(textBox2.Text))
            {
                if (radioButton1.Checked)
                {
                    int a = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                    MessageBox.Show(String.Format("Result : {0}", a.ToString()));
                }
                else if (radioButton2.Checked)
                {
                    int a = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
                    MessageBox.Show(String.Format("Result : {0}", a.ToString()));
                }
                else if (radioButton3.Checked)
                {
                    int a = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
                    MessageBox.Show(String.Format("Result : {0}", a.ToString()));
                }
                else if (radioButton4.Checked)
                {
                    double a = double.Parse(textBox1.Text) / int.Parse(textBox2.Text);
                    MessageBox.Show(String.Format("Result : {0}", Math.Round(a,2).ToString()));
                }
            }
            else
            {
                MessageBox.Show("Please enter valid input for operands");
            }
        }
    }
}
