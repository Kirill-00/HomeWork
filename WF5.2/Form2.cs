using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF5._2
{
    public partial class Form2 : Form
    {
        Good good; bool addnew;
        public Form2(Good good, bool addnew)
        {
            InitializeComponent();
            this.addnew = addnew;
            this.good = good;
            if (addnew == false)
            {
                Text = "Редактирование товара";
                textBox1.Text = good.Name;
                textBox2.Text = good.Description;
                textBox3.Text = good.Price.ToString();
            }
            else
            {
                Text = "Добавление товара";
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void OK_Click(object sender, EventArgs e)
        {
            if (Controls.OfType<TextBox>().Any(textBox => textBox.Text == ""))
            {
                MessageBox.Show("Заполните все поля!");
            }
            if (good == null)
            {
                good = new Good();
            }
            good.Name = textBox1.Text;
            good.Description = textBox2.Text;
            try
            {
                good.Price = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Цена указана неверно");
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
