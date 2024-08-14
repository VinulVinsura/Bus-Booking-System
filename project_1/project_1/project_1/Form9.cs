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
    public partial class Form9 : Form
    {
        string userName;
        public Form9()
        {
            InitializeComponent();
        }
        public Form9(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3= new Form3();
            f3.Show();
            Visible=false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Bus_System;Integrated Security=True");
            conn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM [dbo].[bookings] WHERE userName='"+ userName + "'", conn);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);
            dataGridView1.DataSource = dtb1;
            conn.Close();
        }
    }
}
