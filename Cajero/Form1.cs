using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 5)
            {
                textBox1.Text += "1";
                if (textBox2.TextLength < 4)
                {
                    textBox2.Text += "";
                }
            }
            else
            {
                if (textBox2.TextLength < 4)
                {
                    textBox2.Text += "1";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 5)
            {
                textBox1.Text += "2";
                if (textBox2.TextLength < 4)
                {
                    textBox2.Text += "";
                }
            }
            else
            {
                if (textBox2.TextLength < 4)
                {
                    textBox2.Text += "2";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 5)
            {
                textBox1.Text += "3";
                if (textBox2.TextLength < 4)
                {
                    textBox2.Text += "";
                }
            }
            else
            {
                if (textBox2.TextLength < 4)
                {
                    textBox2.Text += "3";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 5)
            {
                textBox1.Text += "4";
                if (textBox2.TextLength < 4)
                {
                    textBox2.Text += "";
                }
            }
            else
            {
                if (textBox2.TextLength < 4)
                {
                    textBox2.Text += "4";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 5)
            {
                textBox1.Text += "5";
                if (textBox2.TextLength < 4)
                {
                    textBox2.Text += "";
                }
            }
            else
            {
                if (textBox2.TextLength < 4)
                {
                    textBox2.Text += "5";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 5)
            {
                textBox1.Text += "6";
                if (textBox2.TextLength < 4)
                {
                    textBox2.Text += "";
                }
            }
            else
            {
                if (textBox2.TextLength < 4)
                {
                    textBox2.Text += "6";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 5)
            {
                textBox1.Text += "7";
                if (textBox2.TextLength < 4)
                {
                    textBox2.Text += "";
                }
            }
            else
            {
                if (textBox2.TextLength < 4)
                {
                    textBox2.Text += "7";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 5)
            {
                textBox1.Text += "8";
                if (textBox2.TextLength < 4)
                {
                    textBox2.Text += "";
                }
            }
            else
            {
                if (textBox2.TextLength < 4)
                {
                    textBox2.Text += "8";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 5)
            {
                textBox1.Text += "9";
                if (textBox2.TextLength < 4)
                {
                    textBox2.Text += "";
                }
            }
            else
            {
                if (textBox2.TextLength < 4)
                {
                    textBox2.Text += "9";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 5)
            {
                textBox1.Text += "0";
                if (textBox2.TextLength < 4)
                {
                    textBox2.Text += "";
                }
            }
            else
            {
                if (textBox2.TextLength < 4)
                {
                    textBox2.Text += "0";
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string borrar = textBox1.Text.Substring(0,textBox1.Text.Length - 1);
            textBox1.Clear();
            textBox2.Clear();
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }

            if (e.KeyChar ==Convert.ToChar(Keys.Enter))
            {
                textBox2.Focus();
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "12345")
            {
                if (textBox2.Text == "1234")
                {
                    MessageBox.Show("Datos correctos");
                }
                else
                {
                    MessageBox.Show("NIP incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Cuenta incorrecta");
            }
        }
    }
}
