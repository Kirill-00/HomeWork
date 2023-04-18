using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF1._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (((button.Location.X - e.X) > -30 && (button.Location.X - e.X) < 30)
                || (button.Location.Y - e.Y) > -30 && (button.Location.Y - e.Y) < 30)
            {
                Random rnd = new Random();
                button.Location = new Point(rnd.Next(this.Size.Width - 100), rnd.Next(this.Size.Height - 100));
            }
        }
    }
}
