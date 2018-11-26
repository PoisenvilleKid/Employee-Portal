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
        private EmployeeInfo fred2;
        public employeeWindow(EmployeeInfo Employee)
        {
            fred2 = Employee;
            InitializeComponent();
            label1.Text = "Your Role Is : " + fred2.get_role();
            
        }
    }
}
