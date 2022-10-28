using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Exam
{
    public class Student:Person
    {
        private string firstName;
        private string lastName;
        private int departmentCode;
        public string studentID;
        public string cohortNumber;
        public double balance;
        public string semesterID;

        public Student(string firstName, string lastName, int departmentCode, string studentID, string cohortNumber, double balance, string semesterID) : base(firstName, lastName, departmentCode)
        {   
            this.firstName = firstName;
            this.lastName = lastName;
            this.departmentCode = departmentCode;
            this.studentID = studentID;
            this.cohortNumber = cohortNumber;
            this.balance = balance;
            this.semesterID = semesterID;

        }

        public override string toString()
        {
            return "Student Information: " + base.toString() + ", student ID is: " + this.studentID + ", cohort number is: " + this.cohortNumber + ", balance is: " + this.balance + ", semester ID is: " + this.semesterID;
        }

        public string StudentID
        {
            get{ return studentID; }
            set{ studentID = value; }
        }

        public string CohortNumber
        {
            get { return cohortNumber; }
            set { cohortNumber = value; }
        }

        public double Balance
        {
            get{ return balance; }
            set{ balance = value; }
        }

        public string SemesterID
        {
            get{ return semesterID; }
            set{ semesterID = value; }
        }

        public string GetID()
        {
            return studentID;
        }

        public string GetCohortNumber()
        {
            return cohortNumber;
        }

        public double GetBalance()
        {
            return balance;
        }

        public double AddBalance(double balanceAdd)
        {
            return balance += balanceAdd;         
        }

        public double deductBalance(double balanceDeduct)
        {
            return balance -= balanceDeduct;
        }

        public string GetSemesterID()
        {
            return semesterID;
        }










    }
}
