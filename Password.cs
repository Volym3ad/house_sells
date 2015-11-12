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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*'; // заміняємо введені значення паролю знаком *
            textBox2.MaxLength = 7;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "admin") && (textBox2.Text == "qwerty"))
            {
                //MessageBox.Show("Логін і пароль введені правильно!");
                Form3 lis = new Form3();
                lis.Show();
            }
            else
            {
                MessageBox.Show("Дані введені неправильно! Спробуйте ще раз)");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
