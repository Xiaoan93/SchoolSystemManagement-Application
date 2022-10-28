using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Exam
{
    public abstract class Person
    {
        string firstName;
        string lastName;
        int departmentCode;

        public Person(string firstName, string lastName, int departmentCode)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.departmentCode = departmentCode;
        }

        public virtual string toString()
        {
            return "The first name is: " + this.firstName + ", last name is: " + this.lastName + ", department code is: " + this.departmentCode;
        }
    }
}
