using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Student
{
    public class StudentSpeciality
    {
        private string specialtyName;
        private uint facultyNumber;

        public StudentSpeciality(string specialtyName, uint facultyNumber)
        {
            this.SpecialtyName = specialtyName;
            this.FacultyNumber = facultyNumber;
        }

        public uint FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            set
            {
                if (value.Equals(null))
                {
                    throw new ArgumentNullException("FacultyNumber", "FacultyNumber can not be null!");
                }

                this.facultyNumber = value;
            }
        }

        public string SpecialtyName
        {
            get
            {
                return this.specialtyName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("SpecialtyName", "SpecialtyName can not be null or empty!");
                }

                this.specialtyName = value;
            }
        }
    }
}
