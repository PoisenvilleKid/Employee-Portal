using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Final2
{
    public partial class masterWindow : Form
    {
        private EmployeeInfo masterAdmin;
        public masterWindow(EmployeeInfo userInfo)
        {
            masterAdmin = userInfo;
            InitializeComponent();
            label1.Text = "Welcome, " + masterAdmin.First_Name + "!";
            label3.Text = "You are a master admin. Here are your links: ";

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            addUser window = new addUser();
            window.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            updateUser window = new updateUser();
            window.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updatePassword window = new updatePassword();
            window.Show();
        }

        private void companyLink1_Click(object sender, EventArgs e)
        {
            companyLink1 window = new companyLink1();
            window.Show();
        }

        private void globalLink1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
        }

        private void globalLink2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.youtube.com");
        }

        private void adminLink1_Click(object sender, EventArgs e)
        {
            adminLink1 window = new adminLink1();
            window.Show();
        }

        private void adminLink2_Click(object sender, EventArgs e)
        {
            adminLink2 window = new adminLink2();
            window.Show();
        }

        private void masterLink1_Click(object sender, EventArgs e)
        {
            masterLink1 window = new masterLink1();
            window.Show();
        }
    }
}
