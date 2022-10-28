using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Midterm_Exam
{
    public class Teachers:CollectionBase
    {
        public void add(Teacher teacher)
        {
            List.Add(teacher);
        }

        public Teacher this [int index]
        {
            get { return (Teacher)this[index]; }
            set { List[index] = value; }
        }
    }
}
