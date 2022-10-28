using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Midterm_Exam
{
    public class School
    {
        public School() { }

        Students myStudents = new Students();
        Teachers myTeachers = new Teachers();   

        public bool studentVerifier(string studentID)
        {
            bool flag = false;
            foreach(Student student in myStudents)
            {
                if(student.GetID() == studentID)
                {
                    flag = true;
                }
            }

            return flag;
        }

        public void AddStudent()
        {
            Console.WriteLine("Please enter your student ID:");
            string studentID = Console.ReadLine();
            if(studentID.Length != 6)
            {
                Console.WriteLine("Error! ID should be 6 digits.");
            }
            else
            {   if(studentVerifier(studentID) == true)
                {
                    Console.WriteLine("Error! This stduent ID already exist!");
                }
                else
                {
                    Console.WriteLine("Please enter student first name: ");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("Please enter student last name: ");
                    string lastname = Console.ReadLine();
                    if (firstname.Length + lastname.Length > 35)
                    {
                        Console.WriteLine("Error! Name length should not exceed 35 characters. ");
                    }
                    else
                    {
                        Console.WriteLine("Please enter departmentCode:");
                        int departmentCode = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter cohortNumber: ");
                        string cohortNumber = Console.ReadLine();
                        Console.WriteLine("Please enter balance: ");
                        double balance = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter semester ID: ");
                        string semesterID = Console.ReadLine();

                        Student student = new Student(firstname, lastname, departmentCode, studentID, cohortNumber, balance, semesterID);

                        myStudents.add(student);
                        Console.WriteLine("Success! you have added your student!");
                    }
                }
                
            }
        }

        public bool TeacherVerifier(string teacherID)
        {
            bool flag = false;
            foreach(Teacher teacher in myTeachers)
            {
                if(teacher.GetID() == teacherID)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public void AddTeacher()
        {
            Console.WriteLine("Please enter your teacher ID:");
            string teacherID = Console.ReadLine();
            if(teacherID.Length != 6)
            {
                Console.WriteLine("Error! ID should be 6 digits.");
            }
            else
            {
                if (TeacherVerifier(teacherID) == true)
                {
                    Console.WriteLine("Error! This ID already exist!");
                }
                else
                {
                    Console.WriteLine("Please enter your first name:");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("Please enter your last name:");
                    string lastname = Console.ReadLine();
                    if(firstname.Length + lastname.Length > 35)
                    {
                        Console.WriteLine("Error! Name should not exceed 35 characters");
                    }
                    else
                    {
                        Console.WriteLine("Please enter your departmentCode:");
                        int departmentCode = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter your years of experince: ");
                        int yearOfExperience = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter your teaching hours:");
                        double teachingHours = Convert.ToDouble(Console.ReadLine());

                        Teacher teacher = new Teacher(firstname, lastname, departmentCode, teacherID, yearOfExperience, teachingHours);
                        myTeachers.add(teacher);
                        Console.WriteLine("Success! You have added your teacher.");
                    }
                   

                }
                
            }
        }

        public bool semesterIDverifier(string semesterID)
        {
            bool flag = false;
            foreach(Student student in myStudents)
            {
                if(student.GetSemesterID() == semesterID)
                {
                    flag = true;
                }
            }
            return flag;
        }
       
        public void RemoveStudentFromTheSemester()
        {
            Console.WriteLine("Please enter your student ID");
            string studentID = Console.ReadLine();
            if (studentVerifier(studentID) != true)
            {
                Console.WriteLine("Error! This stduent ID does not exist!");
            }
            else
            {
                Console.WriteLine("Please enter your semester ID:");
                string semesterID = Console.ReadLine();
                if(semesterIDverifier(semesterID) != true)
                {
                    Console.WriteLine("Error! This semester ID does not exist!");
                }
                else
                {
                    for (int i = 0; i < myStudents.Count; i++)
                    {
                        if (myStudents[i].StudentID == studentID)
                        {
                            myStudents.RemoveAt(i);
                            Console.WriteLine("This student have been remove from this semester.");
                        }
                    }
                }
                
                
            }
        }

        public void AddBalanceToStudentProfile()
        {
            Console.WriteLine("Please enter your studentID:");
            string studentID = Console.ReadLine();
            if(studentVerifier(studentID) != true)
            {
                Console.WriteLine("Error! This stduent ID does not exist!");

            }
            else
            {   
                foreach(Student student in myStudents)
                {
                    if(student.GetID() == studentID)
                    {
                        Console.WriteLine("pleae enter how much balance you want to add:");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        student.AddBalance(amount);
                        Console.WriteLine("Success! This balance has been added it!");

                    }
                }
                
                
            }
        }

        public void DeductBalanceFromStudentProfile()
        {
            Console.WriteLine("Please enter your studentID:");
            string studentID = Console.ReadLine();
            if (studentVerifier(studentID) != true)
            {
                Console.WriteLine("Error! This stduent ID does not exist!");

            }
            else
            {
                foreach(Student student in myStudents)
                {
                    if (student.GetID() == studentID)
                    {
                        Console.WriteLine("Please enter how much you want to deduct:");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        if(student.balance < amount)
                        {
                            Console.WriteLine("Error! There is no enough amount to deduct!");
                        }
                        else
                        {
                            student.deductBalance(amount);
                            Console.WriteLine("Success! The amount has been deducted!");
                        }

                    }
                    
                }
            }
        }

        public void ChangeStudentCohortNumber()
        {
            Console.WriteLine("Please enter your student ID");
            string studentID = Console.ReadLine();
            if(studentVerifier(studentID) != true)
            {
                Console.WriteLine("Error! StudentID not exist!");
            }
            else
            {
                foreach(Student student in myStudents)
                {
                    if(student.GetID() == studentID)
                    {
                        Console.WriteLine("Please enter your new cohortNumber:");
                        string cohortNumber = Console.ReadLine();
                        student.CohortNumber = cohortNumber;
                        Console.WriteLine("Success! CohortNumber has been changed!");
                    }
                }
            }
        }

        public void IncreaseTheTeacherExperince()
        {
            Console.WriteLine("Please enter teacher ID:");
            string teacherID = Console.ReadLine();
            if(TeacherVerifier(teacherID) != true)
            {
                Console.WriteLine("Error! This ID does not exist!");
            }
            else
            {
                foreach(Teacher teacher in myTeachers)
                {
                    if(teacher.GetID() == teacherID)
                    {
                        Console.WriteLine("Please enter how many months experinces you have: ");
                        int month = Convert.ToInt32(Console.ReadLine());
                        teacher.AddYearsOfExperience(month);
                        Console.WriteLine("Success! your experince has been added it!");
                    }
                }
            }
        }

        public void IncreaseTheTeachingHours()
        {
            Console.WriteLine("Please enter your teacherID:");
            string teacherID = Console.ReadLine();
            if(TeacherVerifier(teacherID) != true)
            {
                Console.WriteLine("Error! This ID does not exist.");
            }
            else
            {
                foreach(Teacher teacher in myTeachers)
                {
                    if(teacher.GetID() == teacherID)
                    {
                        Console.WriteLine("Please enter how many hours you want to add:");
                        int hour = Convert.ToInt32(Console.ReadLine());
                        teacher.AddHours(hour);
                        Console.WriteLine("Success! Your hours have been added it!");
                    }
                }
            }
        }

        public void DecreaseTheTeachingHours()
        {
            Console.WriteLine("Please enter your teacherID:");
            string teacherID = Console.ReadLine();
            if (TeacherVerifier(teacherID) != true)
            {
                Console.WriteLine("Error! This ID does not exist.");
            }
            else
            {
                foreach (Teacher teacher in myTeachers)
                {
                    if (teacher.GetID() == teacherID)
                    {
                        Console.WriteLine("Please enter how many hours you want to deduct:");
                        int hour = Convert.ToInt32(Console.ReadLine());
                        if(teacher.teachingHours < hour)
                        {
                            Console.WriteLine("Error! There is no enough hours to deduct.");
                        }
                        else
                        {
                            teacher.DecreaseHours(hour);
                            Console.WriteLine("Success! Your hours have been deducted it!");
                        }
                        
                    }
                }
            }
        }

        public void Display()
        {   
            if(myStudents.Count != 0)
            {
                foreach (Student student in myStudents)
                {
                    Console.WriteLine(student.toString());

                }
            }
            else
            {
                Console.WriteLine("Sorry, no found student information");
            }
            
            if(myTeachers.Count != 0)
            {
                foreach (Teacher teacher in myTeachers)
                {
                    Console.WriteLine(teacher.toString());
                }
            }
            else
            {
                Console.WriteLine("Sorry, no found teacher information");
            }
            
        }



        public void FindTeachersWithAboveFiveYearsExperince()
        {
            int count = 0;
            if (myTeachers.Count != 0)
            {
                foreach (Teacher teacher in myTeachers)
                {

                    if (teacher.GetYearsOfExperience() > 5)
                    {
                        Console.WriteLine(teacher.toString());
                       
                    }
                    else
                    {   
                        if (teacher.GetYearsOfExperience() < 5)
                        {
                            count++;
                            if (count == myTeachers.Count)
                            {
                                Console.WriteLine("Sorry no found.");
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Sorry, no found.");
            }
            

        }

        public string saveStudentsInformationIntoFile()
        {
            string msg = "";
            if(myStudents.Count != 0)
            {
                foreach(Student student in myStudents)
                {
                    using (StreamWriter sw = new StreamWriter(@"C:\Users\laoxi\Documents\LaSalle College\3rd Semester\MULTI-TIER APPLI_C#\Midterm_Exam\student.txt"))
                    {
                        foreach (Student student1 in myStudents)
                        {
                            sw.WriteLine(student1.toString());
                            Console.WriteLine("Success! your file has been added it.");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No student information found.");
            }
            
            return msg;
            

        }

    }
}
