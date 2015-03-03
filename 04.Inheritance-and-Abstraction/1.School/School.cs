using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School
{
    class School
    {
        static void Main(string[] args)
        {
            List<Student> students2 = new List<Student>()
            {
                new Student("Znaiko Vseznaikov", "The best student"),
                new Student("Znaiko Znaikov"),
                new Student("Talant Znaikov"),
                new Student("Mimi Minkova")
            };

            List<Student> students1 = new List<Student>()
            {
                new Student("Mr Been"),
                new Student("Denzel Washington"),
                new Student("Messi"),
                new Student("Misho Mishoka")
            };

            List<Discipline> disciplines2 = new List<Discipline>()
            {
                new Discipline("OOP", 24, students2, "Very important"),
                new Discipline("High Quality Code", 28, students2),
                new Discipline("JavaScript OOP", 14, students2)
            };

            List<Discipline> disciplines1 = new List<Discipline>()
            {
                new Discipline("Java Basics", 8, students1),
                new Discipline("JavaScript Basics", 28, students1),
                new Discipline("PHP Basics", 14, students1)
            };

            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher("Svetlin Nakov", disciplines2, "Good"),
                new Teacher("Moya Milost", disciplines1)
            };

            Classes anyClass = new Classes("AnyClass", teachers, "Simple");
        }
    }
}
