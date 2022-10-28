using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Exam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            School school = new School();

            int choice;
            char option;
            do
            {
                do
                {
                    Console.WriteLine("=================== School System management ==================");
                    Console.WriteLine("1. Add Student.");
                    Console.WriteLine("2. Add Teacher.");
                    Console.WriteLine("3. Remove Student From The Semester.");
                    Console.WriteLine("4. Add Balance To Student Profile.");
                    Console.WriteLine("5. Deduct Balance From Student Profile.");
                    Console.WriteLine("6. Change Student CohortNumber.");
                    Console.WriteLine("7. Increase The Teacher Experince");
                    Console.WriteLine("8. Increase The Teaching Hours");
                    Console.WriteLine("9. Decrease The Teaching Hours");
                    Console.WriteLine("10. Display.");
                    Console.WriteLine("11. Find Teachers With Above Five Years Experince.");
                    Console.WriteLine("12. Save student to file.");
                    Console.WriteLine("13. Exit.");
                } while ((!int.TryParse(Console.ReadLine(), out choice)) || choice < 1 || choice > 13);

                switch (choice)
                {
                    case 1:
                        school.AddStudent();
                        break;
                    case 2:
                        school.AddTeacher();
                        break;
                    case 3:
                        school.RemoveStudentFromTheSemester();
                        break;
                    case 4:
                        school.AddBalanceToStudentProfile();
                        break;
                    case 5:
                        school.DeductBalanceFromStudentProfile();
                        break;
                    case 6:
                        school.ChangeStudentCohortNumber();
                        break;
                    case 7:
                        school.IncreaseTheTeacherExperince();
                        break;
                    case 8:
                        school.IncreaseTheTeachingHours();
                        break;
                    case 9:
                        school.DecreaseTheTeachingHours();
                        break;
                    case 10:
                        school.Display();
                        break;
                    case 11:
                        school.FindTeachersWithAboveFiveYearsExperince();
                        break;
                    case 12:
                        school.saveStudentsInformationIntoFile();
                        break;
                    case 13:
                        Console.WriteLine("Thank you bye.");
                        Environment.Exit(0);
                        break;

                }
                Console.WriteLine("Do you want to continue ? (Y/N)");
                option = Convert.ToChar(Console.ReadLine());
            } while (option == 'Y' || option == 'y');
            
            

            
        }
    }
}
