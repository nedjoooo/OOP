using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School
{
    public class Student : Person
    {
        public static int classNumber = 0;
        private int studentClassNumber;

        public int StudentClassNumber
        {
            get { return this.studentClassNumber; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Student Class Number can not be less than or equal zero!");
                }
                this.studentClassNumber = value;
            }
        }

        public Student(string name, string details = null) : base(name, details)
        {
            this.studentClassNumber = ++Student.classNumber;
        }

    }
}
