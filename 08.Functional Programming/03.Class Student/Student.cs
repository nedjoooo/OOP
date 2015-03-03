using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Student
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public uint Age { get; set; }
        public uint FacultyNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public IList<int> Marks { get; set; }
        public uint GroupNumber { get; set; }
        public string GroupName { get; set; }

        public Student(string firstName, string lastName, uint age, uint facultyNumber, string phone,
            string email, IList<int> marks, uint groupNumber, string groupName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.GroupName = groupName;
        }
        public override string ToString()
        {
            string marks = String.Join(", ", this.Marks);
            string result =
                String.Format("Student: {0} {1},\nAge: {2} \nFaculty number: {3}, \nPhone: {4}, \nEmail: {5},\nMarks: ({6}), \nGroup number: {7}\nGroup name: {8}\n",
                this.FirstName, this.LastName, this.Age, this.FacultyNumber, this.Phone, this.Email,
                marks, this.GroupNumber, this.GroupName);

            return result;
        }
    }
}
