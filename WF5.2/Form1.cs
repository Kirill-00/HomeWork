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
    public partial class Form1 : Form
    {
        Good good;
        double sum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = $"Цена: {good.Price} руб";
        }
        private void Add_Click(object sender, EventArgs e)
        {
            good = new Good();
            Form2 openForm = new Form2(good, true);
            if (openForm.ShowDialog() == DialogResult.OK)
            {
                comboBox1.Items.Add(good.Name);
                sum +=good.Price;
                label2.Text = $"Общая стоимость товаров {sum} руб";
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали товар");
                return;
            }
            Form2 editForm = new Form2(good, false);
            int i = comboBox1.SelectedIndex;
            editForm.ShowDialog();
            comboBox1.Items.RemoveAt(i);
            comboBox1.Items.Insert(i, good.Name);
            comboBox1.SelectedIndex = i;
        }
    }
}
