using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace house_sells
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 win = new Form4();
            win.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Password pass = new Password();
            pass.Show();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Information info = new Information();
            info.Show();
        }
    }
}
