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

namespace project_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }

        

        private void button1_Click(object sender, EventArgs e){

            if (texPassword.Text == textRePassword.Text)
            {


                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");


                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[user]
           ([userName]
           ,[phoneNum]
           ,[email]
           ,[nic]
           ,[userRole]
           ,[password])
        VALUES
            ('" + textName.Text + "','" + textNumber.Text + "','" + textEmail.Text + "','" + textNIC.Text + "','"+"user"+"','" + texPassword.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("User Register Successfuly");
                Form1 f1= new Form1();
                f1.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Passwords are not matched. Re-enter the Passwords.");
            }
        }
    }
}
