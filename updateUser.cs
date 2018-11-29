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
    public partial class updateUser : Form
    {
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;uid=root;" +
        "pwd=;database=employee");
        public updateUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Close();
                    connection.Open();
                }

                int j = 0;
                string employeeID = uID.Text.ToString();
                int empID = Int32.Parse(employeeID);

                string firstName = uFirst.Text.ToString();
                string lastName = uLast.Text.ToString();

                string role = comboBox1.SelectedItem.ToString();

                String sql2 = "update employee";
                MySqlCommand command = new MySqlCommand(sql2, connection);
                command.CommandType = CommandType.Text;
                command.CommandText = "update employee set Role='" + role + "' where Employee_ID=" + empID + " AND First_Name='" + firstName + "' AND Last_Name='" + lastName + "'";

                j = command.ExecuteNonQuery();

                if (j >= 1)
                {
                    MessageBox.Show("User Role Updated!");

                }
                else
                {
                    MessageBox.Show("User not in database!");
                }
            }

            catch (System.Exception error)
            {
                MessageBox.Show("Error: " + error.ToString());
            }
            finally
            {
                connection.Close(); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
