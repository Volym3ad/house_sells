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
    public partial class User_selection : Form
    {
        public User_selection()
        {
            InitializeComponent();
            ToolTip tip = new ToolTip();
            tip.SetToolTip(pictureBox3, "Співробітник компанії");
        }

        private void User_selection_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2 ();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            data_Fill fill = new data_Fill();
            fill.Text = "Заповнення даних";
            fill.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Password sw = new Password();
            sw.Show();
        }
    }
}
