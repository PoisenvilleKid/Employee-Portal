using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SE_Final2
{
    
    // This is the code for the Login Page. This is the catalyst for the other windows in the portal
    public partial class Form1 : Form
    {
        public EmployeeInfo userInfo = new EmployeeInfo(); // Object to hold the Employee's info when they log in
        MySqlCommand cmd;
        MySqlDataReader dataReader;

        // connecting to our Database --- As long as our local database is named employee we are good.
        MySqlConnection myConnection = new MySqlConnection("server=127.0.0.1;uid=root;" +
        "pwd=;database=employee");

        // Constructor to Build Form
        public Form1()
        {
            InitializeComponent();
            label3.Hide();
        }

        // Cancel Button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Login Button when on click executes authenticate method
        private void button2_Click(object sender, EventArgs e)
        {
            authenticate_employee();
        }

        // Method to authenticate the employee and redirect employee to the appropriate window
        public void authenticate_employee()
        {
            int i = 0;
            myConnection.Open();
            String sql = "Select (*) from employee";
            cmd = new MySqlCommand(sql, myConnection);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from employee where Username = '" + textBox1.Text + "' and Password='" + textBox2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            dataReader = cmd.ExecuteReader();


            // assigns values from Database to the EmployeeInfo Object
            while (dataReader.Read())
            {
                userInfo.Employee_ID = ((int)dataReader.GetValue(0));
                userInfo.Role = dataReader.GetValue(1).ToString();
                userInfo.Username = dataReader.GetValue(2).ToString();
                userInfo.Password = dataReader.GetValue(3).ToString();
                userInfo.First_Name = dataReader.GetValue(4).ToString();
                userInfo.Last_Name = dataReader.GetValue(5).ToString();
            }

            // If the users information provided is not found in the Database, alert user they entered the wrong information
            if (i == 0)
            {
                label3.Show();
                label3.Text = "You have entered invalid username or password";
            }

            // If the users credentials check out, redirect them to the appropriate window according to their Role
            else
            {
                string role = userInfo.Role;
                switch(role)
                {
                    case "Master Admin":
                        open_master_admin_form(); break;
                    case "Admin":
                        open_admin_form();break;
                    case "employee":
                        open_employee_form(); break;

                }

            }

            myConnection.Close();
        }

        // If the authenticated user's role is the master admin, this method redirectcs that user to the approriate window
        public void open_master_admin_form()
        {
            masterWindow window = new masterWindow(userInfo);
            window.Show();
        }

        // If the authenticated user's role is an admin, this method redirects that user to the appropriate window
        public void open_admin_form()
        {
            adminWindow window = new adminWindow(userInfo);
            window.Show();
        }

        // If the authenticated user's role is an employee, this method redirects that user to the appropriate Window
        public void open_employee_form()
        {

            employeeWindow window = new employeeWindow(userInfo);
            window.Show();
        }

        
    }
}
