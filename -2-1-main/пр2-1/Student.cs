using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр2_1
{
    internal class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public Student(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }
    
    }
}
