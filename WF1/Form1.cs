using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message1 = "Живет: у. Пушкина д. Колотушкина.";
            string message2 = "Умеет: много всего.";
            string message3 = "И вообще хороший человек.";
            MessageBox.Show(message1, "Страница 1");
            MessageBox.Show(message2, "Страница 2");
            MessageBox.Show(message3, $"Среднее количество символов: {(message3.Length+message2.Length+message1.Length)/3}");
        }
    }
}
