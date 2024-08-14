using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1
{
    public partial class Form6 : Form
    {
        string place;
        int place1=0;
        String userName;
        String password;
       
 
        public Form6()
        {
            InitializeComponent();
            
        }

        public Form6(String userName, string password)
        {
            this.userName = userName;
            this.password = password;
            InitializeComponent();
            
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void logingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;
        }

        private void ticketCancelingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            Visible = false;
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            conn.Open();

            if (comboBox1.SelectedIndex == 0)
            {
                place = "Galle";
                place1 = 1;
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM [dbo].[bus] WHERE busTo='Galle'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox2.Text = reader["distance"].ToString();
                    textBox1.Text = reader["price"].ToString();

                }
                else
                {
                    MessageBox.Show("Error");
                }
                conn.Close();

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                place = "Aluthgama";
                place1 = 1;
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM [dbo].[bus] WHERE busTo='Aluthgama'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox2.Text = reader["distance"].ToString();
                    textBox1.Text = reader["price"].ToString();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                conn.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                place = "Colombo";
                place1 = 1;
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM [dbo].[bus] WHERE busTo='Colombo'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox2.Text = reader["distance"].ToString();
                    textBox1.Text = reader["price"].ToString();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                conn.Close();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                place = "Kadawatha";
                place1 = 1;
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM [dbo].[bus] WHERE busTo='Kadawatha'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox2.Text = reader["distance"].ToString();
                    textBox1.Text = reader["price"].ToString();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                conn.Close();
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            conn.Open();

            if (comboBox2.SelectedIndex == 3)
            {
                place = "Galle";
                place1 = 2;
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM [dbo].[bus] WHERE busTo='Galle'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox2.Text = reader["distance"].ToString();
                    textBox1.Text = reader["price"].ToString();

                }
                else
                {
                    MessageBox.Show("Error");
                }
                conn.Close();

            }
            else if (comboBox2.SelectedIndex == 2)
            {
                place = "Aluthgama";
                place1 = 2;
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM [dbo].[bus] WHERE busTo='Aluthgama'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox2.Text = reader["distance"].ToString();
                    textBox1.Text = reader["price"].ToString();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                conn.Close();
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                place = "Colombo";
                place1 = 2;
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM [dbo].[bus] WHERE busTo='Colombo'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox2.Text = reader["distance"].ToString();
                    textBox1.Text = reader["price"].ToString();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                conn.Close();
            }
            else if (comboBox2.SelectedIndex == 0)
            {
                place = "Kadawatha";
                place1 = 2;
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM [dbo].[bus] WHERE busTo='Kadawatha'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox2.Text = reader["distance"].ToString();
                    textBox1.Text = reader["price"].ToString();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                conn.Close();
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Nplace = place;
            int Fplace = place1;
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            conn.Open();
            if (Fplace == 1)
            {
                if (comboBox4.SelectedIndex == 1)
                {
                    SqlCommand cmd = new SqlCommand(@"SELECT [busNo] FROM [dbo].[bus] WHERE busTo='" + Nplace + "' AND  timeToMatara='7.00'", conn);
                    string bus = (String)cmd.ExecuteScalar();
                    textBox4.Text = bus;
                }
                else if (comboBox4.SelectedIndex == 0)
                {
                    SqlCommand cmd = new SqlCommand(@"SELECT [busNo] FROM [dbo].[bus] WHERE busTo='" + Nplace + "' AND  timeToMatara='4.00'", conn);
                    string bus = (String)cmd.ExecuteScalar();
                    textBox4.Text = bus;

                }
            }else if (Fplace == 2)
            {
                if (comboBox4.SelectedIndex == 0)
                {
                    SqlCommand cmd = new SqlCommand(@"SELECT [busNo] FROM [dbo].[bus] WHERE busTo='" + Nplace + "' AND  timeToMatara='7.00'", conn);
                    string bus = (String)cmd.ExecuteScalar();
                    textBox4.Text = bus;
                    
                }
                else if (comboBox4.SelectedIndex == 1)
                {
                    SqlCommand cmd = new SqlCommand(@"SELECT [busNo] FROM [dbo].[bus] WHERE busTo='" + Nplace + "' AND  timeToMatara='4.00'", conn);
                    string bus = (String)cmd.ExecuteScalar();
                    textBox4.Text = bus;
                    

                }

            }
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = int.Parse(textBox1.Text);
            int num = int.Parse(textBox3.Text);

            int value = (price * num)/2;

            Form1 form = new Form1();

            string start;
            string end;
            if (place1 == 1)
            {
                start = "Matara";
                end = place;
            }
            else
            {
                start = place;
                end = "Matara";
            }

            int t = comboBox4.SelectedIndex;
            string time;
            if (t == 0)
            {
                time = "7AM";
            }
            else
            {
                time = "4PM";
            }
       

            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");


            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[bookings]
           ([userName]
           ,[startFrom]
           ,[endTo]
           ,[distance]
           ,[numberOfTicket]
           ,[time]
           ,[busNo]
           ,[price]
           ,[password])
        VALUES
            ('" + userName + "','" + start + "','" + end + "','" + textBox2.Text + "','" + textBox3.Text + "','" + time + "','" + textBox4.Text + "','" + value + "','"+password+"')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Total Advance : RS "+value);



            Form7 f7 = new Form7();
            f7.Show();
            Visible = false;
        }
    }
}
