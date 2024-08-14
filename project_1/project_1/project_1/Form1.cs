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
using System.Data;
using System.Data.SqlClient;

namespace project_1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        
        SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
        String userRole;

        String userName;

        public String login()
        {
             
                userName=textBox1.Text;
                String query = "SELECT [userRole] FROM [dbo].[user] WHERE userName='" + textBox1.Text + "' AND password='" + textBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                String userRole = (String)cmd.ExecuteScalar();
                conn.Close();



            return userRole;


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
                userRole = login();
                if (userRole=="user")
                 {
                    MessageBox.Show("User Login Successfuly");
                    Form3 f3 = new Form3(textBox1.Text,textBox2.Text);
                    f3.Show();
                    Visible = false;
                    return;
                }
              if (userRole!=null)
                {
                    MessageBox.Show("Invalid User Entry !");
                }
            else
               {
                MessageBox.Show("Invalid UserName Or Password !");

               }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            userRole = login();

            if (userRole == "admin")
            {

                MessageBox.Show("Admin Login Successfuly");
                Form4 f4 = new Form4();
                f4.Show();
                Visible = false; 
                return;
            }
            if (userRole != null)
            {
                MessageBox.Show("Invalid User Entry !");
            }
            else
            {
                MessageBox.Show("Invalid UserName Or Password !");

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;
        }
    }
}
