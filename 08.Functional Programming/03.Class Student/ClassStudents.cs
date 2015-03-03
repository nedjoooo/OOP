using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Class_Student
{
    class ClassStudent
    {
        static void PrintCollection(IEnumerable collection)
        {
            Console.WriteLine();
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student("Sara", "Mills", 19, 510013, "02 990 000", "smills0@marketwatch.com",
                    new List<int>() { 6, 6, 4, 6, 2, 4, 2 }, 2, "Sofia"),
                new Student("Daniel", "Carter", 21, 515014, "0899000001", "dcarter1@buzzfeed.com",
                    new List<int>() { 4, 5, 2, 2, 4, 5, 3 }, 1, "Plovdiv"),
                new Student("Aaron", "Gibson", 20, 523012, "+3592 899 011", "agibson2@abv.bg",
                    new List<int>() { 5, 5, 6, 4, 4, 5, 6 }, 3, "Varna"),
                new Student("Daniel", "Alexander", 22, 543013, "0899000012", "walexander3@hexun.com",
                    new List<int>() { 3, 2, 4, 4, 5, 5, 3 }, 1, "Varna"),
                new Student("Mildred", "Hansen", 24, 568012, "0899000112", "mhansen4@skype.com",
                    new List<int>() { 4, 4, 5, 4, 6, 4, 4 }, 2, "Sofia"),
                new Student("Antonio", "Gonzalez", 21, 575014, "+359 2 899 111", "agonzalez5@zdnet.com",
                    new List<int>() { 5, 5, 4, 6, 6, 6, 5 }, 3, "Plovdiv"),
                new Student("Cheryl", "Gray", 21, 587013, "0899001212", "cgray6@yahoo.com",
                    new List<int>() { 4, 3, 5, 5, 6, 3, 6 }, 1, "Ruse"),
                new Student("Craig", "King", 19, 598013, "02 190 000", "cking7@cyberchimps.com",
                    new List<int>() { 5, 4, 5, 6, 5, 6, 6 }, 2, "Sofia"),
                new Student("Andrea", "Harper", 23, 613014, "0899011222", "aharper9@abv.bg",
                    new List<int>() { 6, 6, 6, 6, 5, 5, 6 }, 3, "Varna"),
                new Student("Margaret", "Peterson", 26, 644014, "0899211222", "mpetersonc@blogger.com",
                    new List<int>() { 5, 4, 4, 6, 6, 6, 6 }, 2, "Varna")
            };

            var specialties = new List<StudentSpeciality>() 
            { 
            new StudentSpeciality("Web Developer", 510013),
            new StudentSpeciality("QA", 543013),
            new StudentSpeciality("Web Developer", 515014),
            new StudentSpeciality("QA", 568012),
            new StudentSpeciality("Web Developer", 523012),
            new StudentSpeciality("Java Developer", 644014),
            new StudentSpeciality("Java Developer", 613014)
            };

            Console.WriteLine("Please make your choice");
            Console.WriteLine("Press problem number for test it. Problem numbers from 4 to 14");
            Console.WriteLine("Example for test problem 4 of homework press key 4");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 4:
                    StudentsByGroup(studentList);
                    break;
                case 5:
                    StudentsByFirstAndLastName(studentList);
                    break;
                case 6:
                    StudentsByAge(studentList);
                    break;
                case 7:
                    SortStudents(studentList);
                    break;
                case 8:
                    StudentsByEmailDomain(studentList);
                    break;
                case 9:
                    StudentsByPhone(studentList);
                    break;
                case 10:
                    ExcellentStudents(studentList);
                    break;
                case 11:
                    WeakStudents(studentList);
                    break;
                case 12:
                    EnrolledStudents(studentList);
                    break;
                case 13:
                    StudentsByGroups(studentList);
                    break;
                case 14:
                    StudentSpecialty(studentList, specialties);
                    break;
                default:
                    Console.WriteLine("Incorrect choice");
                    break;
            }                                              
            
        }
        private static void StudentsByGroup(List<Student> studentList)
        {
            Console.WriteLine("Problem 4. Students by Group");
            var studentsByGroup = studentList
                .Where(student => student.GroupNumber == 2)
                .OrderBy(student => student.FirstName)
                .ToList();
            PrintCollection(studentsByGroup);
            Console.WriteLine();
        }

        private static void StudentsByFirstAndLastName(List<Student> studentList)
        {
            Console.WriteLine("Problem 5. Students by First and Last Name");
            var studentsByFirstAndLastName = studentList
                .Where(student => student.LastName.CompareTo(student.FirstName) == 1)
                .ToList();
            PrintCollection(studentsByFirstAndLastName);
            Console.WriteLine();
        }

        private static void StudentsByAge(List<Student> studentList)
        {
            Console.WriteLine("Problem 6. Students by Age");
            var studentsByAge = studentList
                .Where(student => student.Age > 18 && student.Age < 24)
                .Select(student => new { student.FirstName, student.LastName, student.Age });
            PrintCollection(studentsByAge);
        }    

        private static void SortStudents(List<Student> studentList)
        {
            Console.WriteLine("Problem 7. Sort Students");
            var sortStudents = studentList
                .OrderByDescending(student => student.FirstName)
                .ThenByDescending(student => student.LastName);
            PrintCollection(sortStudents);
        }

        private static void StudentsByEmailDomain(List<Student> studentList)
        {
            Console.WriteLine("Problem 8. Filter Students by Email Domain");
            string emailPattern = "@abv.bg$";
            var studentsByEmailDomain = studentList
                .Where(student => Regex.IsMatch(student.Email, emailPattern));
            PrintCollection(studentsByEmailDomain);
        }

        private static void StudentsByPhone(List<Student> studentList)
        {
            Console.WriteLine("Problem 9. Filter Students by Phone");
            string phonePattern = "(\\+359\\s*|0)2{1}";
            var studentsByPhone = studentList
                .Where(student => Regex.IsMatch(student.Phone, phonePattern));
            PrintCollection(studentsByPhone);
        }

        private static void ExcellentStudents(List<Student> studentList)
        {
            Console.WriteLine("Problem 10. Excellent Students");
            var excellentStudents = studentList
                .Where(student => student.Marks.Contains(6))
                .Select(student => new { student.FirstName, student.LastName, student.Marks })
                .ToList();
            excellentStudents.ForEach(student =>
                Console.WriteLine("Student name: {0} {1}, Marks: {2}",
                    student.FirstName, student.LastName, string.Join(", ", student.Marks)));
        }

        private static void WeakStudents(List<Student> studentList)
        {
            Console.WriteLine("Problem 11. Weak Students");
            var weakStudents = studentList
                .Where(student => student.Marks.Where(mark => mark == 2).Count() == 2);
            PrintCollection(weakStudents);
        }

        private static void EnrolledStudents(List<Student> studentList)
        {
            Console.WriteLine("Problem 12. Students Enrolled in 2014");
            var enrolledStudents = studentList
                .Where(student => student.FacultyNumber.ToString().EndsWith("14"));
            PrintCollection(enrolledStudents);
        }

        private static void StudentsByGroups(List<Student> studentList)
        {
            Console.WriteLine("Problem 13. * Students by Groups");
            var groupedStudents = studentList.GroupBy(student => student.GroupName)
                .Select(group => new { GroupName = group.Key, studentList = group.ToList() })
                .ToList();
            groupedStudents.ForEach(student =>
                {
                    Console.WriteLine("Group Name {0}", student.GroupName);
                    PrintCollection(student.studentList);
                });
        }

        private static void StudentSpecialty(List<Student> studentList, List<StudentSpeciality> specialties)
        {
            Console.WriteLine("Problem 14. * Students Joined to Specialties");
            var studentSpeciality = studentList
                .Join(specialties,
                    student => student.FacultyNumber,
                    specility => specility.FacultyNumber,
                    (student, specility) => new
                    {
                        Name = student.FirstName + " " + student.LastName,
                        FacNum = student.FacultyNumber,
                        Specialty = specility.SpecialtyName
                    });

            PrintCollection(studentSpeciality);
        }

          

        

        
    }
}
