using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HumanStudentandWorker
{
    public class Student : Human
    {
        int facultyNumber;
        public int FacultyNumber 
        {
            get { return this.facultyNumber; }
            set
            {
                Validation.FacultyNumber(value);
                this.facultyNumber = value;
            }
        }
        public Student(string firstName, string lastName, int facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(" Faculty Number: {0}", this.FacultyNumber);
        }
    }
}
