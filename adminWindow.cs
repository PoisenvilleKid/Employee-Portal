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
    public partial class adminWindow : Form
    {
        private EmployeeInfo admin;
        public adminWindow(EmployeeInfo userInfo)
        {
            admin = userInfo;
            InitializeComponent();
            label1.Text = "Welcome, " + admin.First_Name + "!";
            label3.Text = "You are an admin. Here are your links: ";

        }

        private void logout_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
