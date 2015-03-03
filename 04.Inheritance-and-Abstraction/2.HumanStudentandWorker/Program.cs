using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HumanStudentandWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Ivan", "Petrov", 5120),
                new Student("Gencho", "Penchev", 5321),
                new Student("Stoyan", "Ganev", 1122),
                new Student("Emil", "Zhelev", 3423),
                new Student("Mariya", "Petrova", 510),
                new Student("Penka", "Dimitrova", 120),
                new Student("Tom", "Maimun", 130),
                new Student("Julya", "Roberts", 1120),
                new Student("Tom", "Cruse", 1210),
                new Student("Hristo", "Stoichkov", 2120)
            };

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Maistor", "Trichko", 520.20M, 8),
                new Worker("Moje", "Vsichko", 614.50M, 10),
                new Worker("Gosho", "Minchev", 420.00M, 6),
                new Worker("Bai", "Ivan", 820.90M, 11),
                new Worker("Cristiano", "Ronaldo", 1920.90M, 6),
                new Worker("Denzel", "Washington", 1820.90M, 12),
                new Worker("Jenya", "Kalkandjieva", 1820.90M, 9),
                new Worker("Tvetelina", "Stoyanova", 1220.00M, 8),
                new Worker("Liam", "Nilsen", 1410.67M, 10),
                new Worker("Georgi", "Ivanov", 2000.00M, 12)
            };

            students.Sort((x, y) => x.FacultyNumber.CompareTo(y.FacultyNumber));
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine();

            workers.Sort((x, y) => -1 * x.MoneyPerHour().CompareTo(y.MoneyPerHour()));
            foreach (var worker in workers)
            {
                Console.WriteLine(worker.ToString());
            }
            Console.WriteLine();

            var mergedList = new List<Human>();
            mergedList.AddRange(students);
            mergedList.AddRange(workers);

            var sortMergedList = mergedList.OrderBy(p => p.FirstName).ThenBy(p => p.LastName);

            foreach (var human in mergedList)
            {
                Console.WriteLine(human.ToString());
            }

            Console.WriteLine();

            foreach (var human in sortMergedList)
            {
                Console.WriteLine(human.ToString());
            }
        }
    }
}
