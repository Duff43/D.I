using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        double num1 = 0;
        double num2 = 0;
        double result = 0;
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        } 
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {      
        }
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(maskedTextBox1.Text);
            num2 = Convert.ToDouble(maskedTextBox2.Text);
            result = num1 + num2;
            textBox1.Text = result.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1 = ;
            textBox1.Text = string.Empty; 
        }
    }
}
