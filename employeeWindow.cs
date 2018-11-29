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
    public partial class employeeWindow : Form
    {

        private EmployeeInfo employee;
        public employeeWindow(EmployeeInfo userInfo)
        {
            employee = userInfo;
            InitializeComponent();
            label1.Text = "Welcome, " + employee.First_Name + "!";
            label3.Text = "You are an employee. Here are your links: ";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
        }

        private void updatePass_Click(object sender, EventArgs e)
        {
            updatePassword window = new updatePassword();
            window.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.youtube.com");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            companyLink1 window = new companyLink1();
            window.Show();
        }
    }
}
