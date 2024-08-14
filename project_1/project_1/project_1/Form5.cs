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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace project_1
{
    public partial class Form5 : Form
    {
        String password1;
        public Form5()
        {
            InitializeComponent();
        }

        public Form5(String password)
        {
            this.password1 = password;
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            Visible = false;
        }

        private void ticketBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string username = textBox1.Text;
            String password= textBox2.Text;
            int numOfTicekt=int.Parse(textBox3.Text);
            if (password == password1)
            {
                String query = "SELECT [numberOfTicket] FROM [dbo].[bookings] WHERE userName='" + username + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                String ticket = (String)cmd.ExecuteScalar();
                int ticket1 = int.Parse(ticket);
                String remTicket = (ticket1 - numOfTicekt).ToString();

                if (ticket1 == numOfTicekt)
                {
                    String query3 = "DELETE FROM [dbo].[bookings]  WHERE userName='" + username + "'";
                    SqlCommand cmd4 = new SqlCommand(query3, conn);
                    cmd4.ExecuteNonQuery();
     
                    MessageBox.Show("Delete Successfull");
                    Form3 f3 = new Form3();
                    f3.Show();
                    Visible=false;

                }
                else if (ticket1 > numOfTicekt)
                {

                    String query2 = "UPDATE [dbo].[bookings] SET [numberOfTicket]='" + remTicket + "'  WHERE userName='" + username + "'";
                    SqlCommand cmd2 = new SqlCommand(query2, conn);
                    cmd2.ExecuteNonQuery();
                    cmd2.Parameters.AddWithValue("@remTicket", remTicket);
                    cmd2.Parameters.AddWithValue("@username", username);
                    MessageBox.Show("Delete Successfull");
                    Form3 f3 = new Form3();
                    f3.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("You Have Only " + ticket1 + " Tickets..");
                }
            }
            else
            {
                MessageBox.Show("Invalid Password.. !");
            }
            conn.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (password1 == textBox2.Text)
            {
                String startFrom;
                String endFrom;
                String price;
                String numOfTicket;
                conn.Open();
                String username = textBox1.Text;
                String query = "SELECT * FROM [dbo].[bookings] WHERE userName='" + username + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    startFrom = reader["startFrom"].ToString();
                    endFrom = reader["endTo"].ToString();
                    price = reader["price"].ToString();
                    numOfTicket = reader["numberOfTicket"].ToString();
                    startFromLab.Text = "Start : " + startFrom;
                    endToLab.Text = "Destination : " + endFrom;
                    ticketNumLab.Text = "Number Of Ticket : " + numOfTicket;
                    priceLab.Text = "Rs. " + price;

                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Invalid Password.. !");
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            Visible = false;
        }
    }
}
