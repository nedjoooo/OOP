using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School
{
    public class Discipline
    {
        private string name;
        private int numberOfLectures;
        private List<Student> students = new List<Student>();
        private string details;

        public string Name 
        {
            get { return this.name; }
            set
            {
                try
                {
                    if(string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException();
                    }
                    this.name = value;
                }
                catch(ArgumentNullException)
                {
                    Console.WriteLine("Discipline name is can not be empty!");
                }
            }
        }
        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The number of lecture must be integer number greater than zero.");
                }

                this.numberOfLectures = value;
            }
        }

        public Discipline(string name, int numberOfLectures, List<Student> students = null, string details = null)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.students = students;
            this.Details = details;
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (String.Empty == value)
                {
                    throw new ArgumentNullException("Details can not be empty string!");
                }
                this.details = value;
            }
        }
    }
}
