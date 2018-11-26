using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Final2
{
    // Employee Info Class used to get and set info from our Database
    public class EmployeeInfo
    {
        public int Employee_ID;
        public string Role;
        public string Username;
        public string Password;
        public string First_Name;
        public string Last_Name;

        public string get_role()
        {
            return Role;
        }

    }
}
