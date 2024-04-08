using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Student : Person
    {
        public string StudentNumber;
        private string SSN;

        public Student()
        {
            StudentNumber = "U63728";

        }
        public string getSSN()
        {
            return SSN;
        }

        public void setSSN(string value)
        {
            SSN = value;
        }
    }
}


