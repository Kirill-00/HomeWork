using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    public partial class Form1 : Form
    {
        static public double DTPrice = 59.00;
        static public double A102Price = 65.00;
        static public double hotP = 4.00;
        static public double hamP = 5.40;
        static public double friP = 7.20;
        static public double colaP = 4.40;
        public Form1()
        {
            InitializeComponent();
            Oil.SelectedIndex = 0;
            radioButton1.Checked = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Oil.SelectedIndex == 0)
            {
                textBox1.Text = DTPrice.ToString();
            }else if(Oil.SelectedIndex == 1)
            {
                textBox1.Text = A102Price.ToString();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                textBox3.Text = "0";
                textBox3.Enabled = false;
                textBox2.Enabled = true;
                groupBox5.Text = "К оплате";
                label6.Text = "Руб";
            }else if(radioButton2.Checked)
            {
                textBox2.Text="0";
                textBox2.Enabled = false;
                textBox3.Enabled=true;
                groupBox5.Text = "К выдаче";
                label6.Text = "Л";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            if (tbx.Text != "0" && tbx.Text.Length <= 1)
            {
                if (tbx.Text == "") tbx.Text = "0";

                if (radioButton2.Checked) textBox2.Text = textBox2.Text;
            }else if (tbx.Text[0] == '0' && tbx.Text.Length > 1)
            {
                string tmp = "";
                for (int i = 1; i < tbx.Text.Length; i++)
                {
                    tmp += tbx.Text[i];
                }
                tbx.Text = tmp;
            }
            
            if(radioButton1.Checked)
            {
                double gp = Convert.ToDouble(textBox1.Text);
                double q = Convert.ToDouble(textBox2.Text);
                double gasp = gp * q;
                label7.Text = gasp.ToString();
            }else
            {
                double gp = Convert.ToDouble(textBox1.Text);
                double s = Convert.ToDouble(textBox3.Text);
                double gasp = s / gp;
                label7.Text = gasp.ToString("0.00");
            }
            if (textBox3.Text != "0")
            {
                double P = Convert.ToDouble(textBox3.Text) + Convert.ToDouble(label10.Text);
                textBox8.Text = Convert.ToString(P);
            }
            else
            {
                double P = Convert.ToDouble(label7.Text) + Convert.ToDouble(label10.Text);
                textBox8.Text = Convert.ToString(P);
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                numericUpDown1.Enabled = true;
                if (numericUpDown1.Value == 0)
                    numericUpDown1.Value = 1;
            }else
            {
                numericUpDown1.Enabled = false;
                numericUpDown1.Value = 0;
            }

            if (checkBox2.Checked)
            {
                numericUpDown2.Enabled = true;
                if (numericUpDown2.Value == 0)
                    numericUpDown2.Value = 1;
            }
            else
            {
                numericUpDown2.Enabled = false;
                numericUpDown2.Value = 0;
            }

            if (checkBox3.Checked)
            {
                numericUpDown3.Enabled = true;
                if (numericUpDown3.Value == 0)
                    numericUpDown3.Value = 1;
            }
            else
            {
                numericUpDown3.Enabled = false;
                numericUpDown3.Value = 0;
            }

            if (checkBox4.Checked)
            {
                numericUpDown4.Enabled = true;
                if (numericUpDown4.Value == 0)
                    numericUpDown4.Value = 1;
            }
            else
            {
                numericUpDown4.Enabled = false;
                numericUpDown4.Value = 0;
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
                checkBox1.Checked = false;

            if (numericUpDown2.Value == 0)
                checkBox2.Checked = false;

            if (numericUpDown3.Value == 0)
                checkBox3.Checked = false;

            if (numericUpDown4.Value == 0)
                checkBox4.Checked = false;

            double hot, ham, fri, cola;

            hot = hotP * Convert.ToDouble(numericUpDown1.Value);
            ham = hamP * Convert.ToDouble(numericUpDown2.Value);
            fri = friP * Convert.ToDouble(numericUpDown3.Value);
            cola = colaP * Convert.ToDouble(numericUpDown4.Value);

            double cafeP = hot + ham + fri + cola;
            label10.Text = Convert.ToString(cafeP);

            if (textBox3.Text != "0")
            {
                double P = Convert.ToDouble(textBox3.Text) + Convert.ToDouble(label10.Text);
                textBox8.Text = Convert.ToString(P); 
            }else
            {
                double P = Convert.ToDouble(label7.Text) + Convert.ToDouble(label10.Text);
                textBox8.Text = Convert.ToString(P);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Oil.SelectedIndex = 0;
            radioButton1.Checked = true;
            textBox2.Text = "0";
            textBox3.Text = "0";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }
    }
}
