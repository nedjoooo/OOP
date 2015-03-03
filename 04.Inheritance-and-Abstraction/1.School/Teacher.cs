using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School
{
    public class Teacher : Person
    {
        List<Discipline> disciplines = new List<Discipline>();
        public List<Discipline> Disiplines
        {
            get { return this.disciplines; }
            set
            {
                try
                {
                    if (value.Count == 0)
                    {
                        throw new ArgumentNullException();
                    }
                    this.disciplines = value;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Disciplines list can not be empty!");
                }
            }
        }
        public Teacher(string name, List<Discipline> disciplines, string details = null)
            : base(name, details)
        {
            this.Disiplines = disciplines;
        }
    }
}
