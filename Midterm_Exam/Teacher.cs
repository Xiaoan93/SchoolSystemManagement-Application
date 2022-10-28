using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Exam
{
    public class Teacher:Person
    {
        private string firstName;
        private string lastName;
        private int departmentCode;
        public string teacherID;
        public int yearsOfExperience;
        public double teachingHours;

        public Teacher(string firstName, string lastName, int departmentCode, string teacherID, int yearsOfExperience, double teachingHours): base(firstName, lastName, departmentCode)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.departmentCode = departmentCode;
            this.teacherID = teacherID;
            this.yearsOfExperience = yearsOfExperience;
            this.teachingHours = teachingHours;
        }

        public override string toString()
        {
            return "Teacher information: " + base.toString() + ", teacherID is: " + this.teacherID + ", yearsOfExperience is: " + this.yearsOfExperience + ", teachingHours is: " + this.teachingHours;
        }

        public string TeacherID
        {
            get{ return teacherID; }
            set{ teacherID = value; }
        }

        public int YearsOfExperience
        {
            get{ return yearsOfExperience; }
            set{ yearsOfExperience = value; }
        }

        public double TachingHours
        {
            get{ return teachingHours; }
            set{ teachingHours = value; }
        }

        public string GetID()
        {
            return teacherID;
        }

        public int GetYearsOfExperience()
        {
            return yearsOfExperience;
        }

        public int AddYearsOfExperience(int month)
        {
            return month /= 12;
             

        }

        public double GetHours()
        {
            return teachingHours;
        }

        public double AddHours(int hour)
        {
            return teachingHours += hour;
        }

        public double DecreaseHours(int hour)
        {
            return teachingHours -= hour;
        }






    }
}
