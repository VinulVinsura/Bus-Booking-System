using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1
{
    public partial class Form3 : Form
    {
        String username;
        String password;
        public Form3()
        {
            InitializeComponent();
            
        }

        public Form3(String username, String password)
        {
            this.username = username;
            this.password = password;
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
           
            Form6 f6 = new Form6(username,password);
            f6.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(password);
            f5.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9(username);
            f9.Show();
            Visible = false;
        }
    }
}
