using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace house_sells
{
    public partial class data_Fill : Form
    {
        public data_Fill()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void delete()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox8.Text = null;
            textBox9.Text = null;
            textBox11.Text = null;
            textBox12.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text) || String.IsNullOrWhiteSpace(textBox3.Text)
                || String.IsNullOrWhiteSpace(textBox4.Text) || String.IsNullOrWhiteSpace(textBox5.Text) || String.IsNullOrWhiteSpace(textBox6.Text)
                || String.IsNullOrWhiteSpace(textBox7.Text) || String.IsNullOrWhiteSpace(textBox8.Text) || String.IsNullOrWhiteSpace(textBox9.Text)
                || String.IsNullOrWhiteSpace(textBox11.Text) || String.IsNullOrWhiteSpace(textBox12.Text))
            {
                MessageBox.Show("Перевірте чи заповнені всі поля!");
            }
            else
            {
                SqlConnection sconnect = new SqlConnection();
                sconnect.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Vlad\Documents\Visual Studio 2012\Projects\house_sells\house_sells\Database1.mdf;Integrated Security=True;Current Language=Russian";

                try
                {
                    string sqll = "INSERT INTO Flats (Address, Size, Floor, Room_number, Build_year, Price) values ('" + textBox1.Text + "', " + textBox2.Text + ", " + textBox3.Text + ", " + textBox4.Text + ", " + textBox5.Text + ", " + textBox6.Text + ")";
                    SqlCommand exec = new SqlCommand(sqll, sconnect);
                    sconnect.Open();
                    exec.ExecuteNonQuery();

                    MessageBox.Show("Ваші дані прийнято на розгляд)");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    sconnect.Close();
                }
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

    }
}
