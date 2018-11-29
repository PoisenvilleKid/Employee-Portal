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
    public partial class updatePassword : Form
    {
        MySqlConnection connection1 = new MySqlConnection("server=127.0.0.1;uid=root;" +
       "pwd=;database=employee");
        public updatePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection1.Open();
                int j = 0;
                string employeeID = textBox1.Text.ToString();
                int empID = Int32.Parse(employeeID);

                string userName = textBox2.Text.ToString();
                string oldPass = textBox3.Text.ToString();
                string newPass = textBox4.Text.ToString();

                String sql2 = "update employee";
                MySqlCommand command = new MySqlCommand(sql2, connection1);
                command.CommandType = CommandType.Text;
                command.CommandText = "update employee set Password='" + newPass + "' where Employee_ID=" + empID + " AND Username='" + userName + "' AND Password='" +oldPass+ "'";

                j = command.ExecuteNonQuery();

                if (j >= 1)
                {
                    MessageBox.Show("User Password Updated!");
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
