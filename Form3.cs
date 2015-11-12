using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace house_sells
{
    public partial class Form3 : Form
    {
        Flats fl_1 = new Flats();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Flats". При необходимости она может быть перемещена или удалена.
            this.flatsTableAdapter.Fill(this.database1DataSet.Flats);

            ToolTip tool = new ToolTip();
            tool.SetToolTip(button4, "Оновити");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //fl_1.address = textBox1.Text;
            //fl_1.size = textBox2.Text;
            //fl_1.stage = textBox3.Text;
            //fl_1.num_rooms = textBox4.Text;
            //fl_1.build_year = textBox5.Text;
            //fl_1.price = textBox6.Text;

            //dataGridView1.Rows.Add(fl_1.address, fl_1.size, fl_1.stage, fl_1.num_rooms, fl_1.build_year, fl_1.price);

            SqlConnection cn = new SqlConnection(global::house_sells.Properties.Settings.Default.Database1ConnectionString);
            
            //cn.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Vlad\Documents\Visual Studio 2012\Projects\house_sells\house_sells\Database1.mdf;Integrated Security=True;Current Language=Russian";
            //DataTable table = new DataTable();
            //table.Locale = System.Globalization.CultureInfo.InvariantCulture;

            try
            {
                string sql = "INSERT INTO Flats (Address, Size, Floor, Room_number, Build_year, Price) values ('" + textBox1.Text + "', " + textBox2.Text + ", " + textBox3.Text + ", " + textBox4.Text + ", " + textBox5.Text + ", " + textBox6.Text + ")";
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();

                MessageBox.Show("Done", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            //dataGridView1.Rows.Clear();
            database1DataSet.Clear();
            button3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(index);

            //if (database1DataSet.Flats.Rows[0].ItemArray[0] == null)
            if (dataGridView1.Rows[0].Cells[0].Value == null)
                button3.Enabled = false;
        }

        //private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        //{
            /*Stream str = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {

                if ((str = openFileDialog1.OpenFile()) != null) {
                    StreamReader read = new StreamReader(str);
                    
                    string[] s;
                    int num = 0;

                    try
                    {
                        string[] str1 = read.ReadToEnd().Split('\n');
                        num = str1.Count();
                        //dataGridView1.RowCount = num;
                        //database1DataSet.Flats.Rows.Count = num;

                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            s = str1[i].Split('_');
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            //for (int j = 0; j < database1DataSet.Flats.Columns.Count; j++)
                            {
                                dataGridView1.Rows[i].Cells[j].Value = s[j];
                            }
                        }

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    finally
                    {
                        read.Close();
                    }
                }
            }*/

        //}

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Stream myStream;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter writet = new StreamWriter(myStream);

                    try
                    {
                        for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                        //for (int i = 0; i < database1DataSet.Flats.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            ///for (int j = 0; j < database1DataSet.Flats.Columns.Count - 1; j++)
                            {
                                writet.Write(dataGridView1.Rows[i].Cells[j].Value.ToString());
                                if (j != dataGridView1.ColumnCount - 1)
                                {
                                    writet.Write("_");
                                }
                                else break;
                            }
                            writet.WriteLine();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        writet.Close();
                    }
                    myStream.Close();
                }
            }*/

            flatsTableAdapter.Update(database1DataSet);
            database1DataSet.AcceptChanges();
            MessageBox.Show("Зміни збережені!");

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.flatsTableAdapter.Fill(this.database1DataSet.Flats);
        }
    }
}
