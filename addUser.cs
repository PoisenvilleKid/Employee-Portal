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
    public partial class addUser : Form
    {
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;uid=root;" +
        "pwd=;database=employee");

        public addUser()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                int j = 0;
                string employeeID = EmployeeID.Text.ToString();
                int empID = Int32.Parse(employeeID);

                string firstName = First.Text.ToString();
                string lastName = Last.Text.ToString();
                string userName = textBox1.Text.ToString();
                string passWord = textBox2.Text.ToString();
                string role = Role.SelectedItem.ToString();

                String sql2 = "insert into employee";
                MySqlCommand command = new MySqlCommand(sql2, connection);
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into employee values("+empID+ ", '" +role+ "', '" + userName + "', '" + passWord + "','" + firstName+ "', '" +lastName+ "')";

                j = command.ExecuteNonQuery();

                if(j >= 1)
                {
                    MessageBox.Show("User Registered!");
                }
                else
                {
                    MessageBox.Show("Not Registered!");
                }

            }

            catch(System.Exception error)
            {
                MessageBox.Show("Error: " + error.ToString());
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
