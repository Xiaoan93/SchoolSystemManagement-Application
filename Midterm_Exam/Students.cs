using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Midterm_Exam
{
    public class Students:CollectionBase
    {
        public void add(Student student)
        {
            List.Add(student);
        }

        public Student this [int index]
        {
            get { return(Student)List[index]; }
            set { List[index] = value; }
        }
    }
}
