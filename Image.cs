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
    public partial class Image : Form
    {
        public Image()
        {
            InitializeComponent();
        }


        private void Image_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Flats". При необходимости она может быть перемещена или удалена.
            this.flatsTableAdapter.Fill(this.database1DataSet.Flats);


            //List<Image> y = new List<Image>();
            //Image tr = new Image();
            /*for (int i = 0; i < 4; i++)
            {
                ((Form4)this.Owner).ima[i] = y[i];
            }*/

            Bitmap image = new Bitmap(@"C:\Users\Vlad\Documents\Visual Studio 2012\Projects\house_sells\house_sells\img\28011.jpg");
            Bitmap image2 = new Bitmap(@"C:\Users\Vlad\Documents\Visual Studio 2012\Projects\house_sells\house_sells\img\photo_2.jpg");

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = image2;
            


            /*for (int i = 0; i < 4; i++)
            {
                //y[i] = new Image();
                //y[i].Text = "blbabd";
                y[i].pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                y[i].pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                if (i < 2)
                    y[i].pictureBox1.Image = image;
                else y[i].pictureBox1.Image = image2;
            }*/

            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            //pictureBox1.Image = image;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::house_sells.Properties.Settings.Default.Database1ConnectionString);


            try
            {
                string sql = "INSERT INTO Flats (Address, Size, Floor, Room_number, Build_year, Price) values ('" + textBox1.Text + "', " + textBox2.Text + ", " + textBox3.Text + ", " + textBox4.Text + ", " + textBox5.Text + ", " + textBox6.Text + ")";
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();

                MessageBox.Show("Done", "Mess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.flatsTableAdapter.Fill(this.database1DataSet.Flats);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                cn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.flatsTableAdapter.Fill(this.database1DataSet.Flats);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
