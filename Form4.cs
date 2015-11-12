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
using System.Collections.Generic;

namespace house_sells
{
    public partial class Form4 : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        DataTable table = new DataTable();


        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Flats". При необходимости она может быть перемещена или удалена.
            this.flatsTableAdapter.Fill(this.database1DataSet.Flats);

            ToolTip tool = new ToolTip();
            tool.SetToolTip(button2, "Оновити");

            conn.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Vlad\Documents\Visual Studio 2012\Projects\house_sells\house_sells\Database1.mdf;Integrated Security=True;Current Language=Russian";

            command.Connection = conn;
            command.CommandText = "SELECT * FROM Flats";


            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(table);
            dataGridView1.DataSource = table;

            text_cmb();

            //HashSet<string> hash = new HashSet<string>();
            //Dictionary<int, string> dict1 = new Dictionary<int, string>();
            //Dictionary<int, string> dict2 = new Dictionary<int, string>();
            //Dictionary<int, string> dict3 = new Dictionary<int, string>();
            //Dictionary<int, string> dict4 = new Dictionary<int, string>();
            //Dictionary<int, string> dict5 = new Dictionary<int, string>();
            //Dictionary<int, string> dict6 = new Dictionary<int, string>();


            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    dict1.Add(i, dataGridView1.Rows[i].Cells[0].Value.ToString());
            //    dict2.Add(i, dataGridView1.Rows[i].Cells[1].Value.ToString());
            //    dict3.Add(i, dataGridView1.Rows[i].Cells[2].Value.ToString());
            //    dict4.Add(i, dataGridView1.Rows[i].Cells[3].Value.ToString());
            //    dict5.Add(i, dataGridView1.Rows[i].Cells[4].Value.ToString());
            //    dict6.Add(i, dataGridView1.Rows[i].Cells[5].Value.ToString());
            //}



            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                comboBox1.Items.Add(dataGridView1.Rows[i].Cells[0].Value);
                comboBox2.Items.Add(dataGridView1.Rows[i].Cells[1].Value);
                comboBox3.Items.Add(dataGridView1.Rows[i].Cells[2].Value);
                comboBox4.Items.Add(dataGridView1.Rows[i].Cells[3].Value);
                comboBox5.Items.Add(dataGridView1.Rows[i].Cells[4].Value);
                comboBox6.Items.Add(dataGridView1.Rows[i].Cells[5].Value);
            }

            //comboBox4.Items.Add(dict1);

            //delete_repeat(comboBox1);
            //delete_repeat(comboBox2);
            //delete_repeat(comboBox3);
            //delete_repeat(comboBox4);
            //delete_repeat(comboBox5);
            //delete_repeat(comboBox6);

        }

        //private void delete_repeat(ComboBox combo)
        //{
        //    for (int i = 0, j=i+1; i < dataGridView1.Rows.Count; i++, j++)
        //    {
        //            if (combo.Items[j] == combo.Items[i])
        //            {
        //                combo.Items.RemoveAt(i);
        //            }
        //            else continue;
        //    }
        //}

        private void text_cmb()
        {
            comboBox1.Text = "Address";
            comboBox2.Text = "Size";
            comboBox3.Text = "Floor";
            comboBox4.Text = "Room_number";
            comboBox5.Text = "Build_year";
            comboBox6.Text = "Price";
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void enabled(ComboBox s1, ComboBox s2, ComboBox s3, ComboBox s4, ComboBox s5)
        {
            s1.Enabled = false;
            s2.Enabled = false;
            s3.Enabled = false;
            s4.Enabled = false;
            s5.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = string.Format("Address LIKE '%{0}%'", comboBox1.SelectedItem.ToString());
            dataGridView1.DataSource = dv;
            enabled(comboBox2, comboBox3, comboBox4, comboBox5, comboBox6);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = string.Format("Size LIKE '%{0}%'", comboBox2.SelectedItem.ToString());
            dataGridView1.DataSource = dv;
            enabled(comboBox1, comboBox3, comboBox4, comboBox5, comboBox6);        
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = string.Format("Floor LIKE '%{0}%'", comboBox3.SelectedItem.ToString());
            dataGridView1.DataSource = dv;
            enabled(comboBox1, comboBox2, comboBox4, comboBox5, comboBox6);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = string.Format("Room_number LIKE '%{0}%'", comboBox4.SelectedItem.ToString());
            dataGridView1.DataSource = dv;
            enabled(comboBox1, comboBox2, comboBox3, comboBox5, comboBox6);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = string.Format("Build_year LIKE '%{0}%'", comboBox5.SelectedItem.ToString());
            dataGridView1.DataSource = dv;
            enabled(comboBox1, comboBox2, comboBox3, comboBox4, comboBox6);
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = string.Format("Price LIKE '%{0}%'", comboBox6.SelectedItem.ToString());
            dataGridView1.DataSource = dv;
            enabled(comboBox1, comboBox2, comboBox3, comboBox4, comboBox5);
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }


        public void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    ima.Insert(i, pict);
                    if (dataGridView1.Rows[i].Cells[0].Selected == true)
                    {
                        ima[i] = new Image();
                        ima[i].Text = "Image" + (i+1);
                        ima[i].Show();
                    }
                }
        }

        public Image pict = null;
        public List<Image> ima = new List<Image>();

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;
            comboBox6.Enabled = true;

            dataGridView1.DataSource = table;
            text_cmb();
 
            //this.flatsTableAdapter.Fill(this.database1DataSet.Flats);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.flatsTableAdapter.FillBy(this.database1DataSet.Flats);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

