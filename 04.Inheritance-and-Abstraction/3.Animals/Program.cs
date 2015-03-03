using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Sharo", 6, Gender.Male);
            Console.WriteLine(dog.ToString());

            Kitten kit = new Kitten("Pise", 1);
            Console.WriteLine(kit.ToString());
            Console.WriteLine();

            Animal[] animals = new Animal[]
            {
                new Dog("Bendji", 3, Gender.Male),
                new Tomcat("Tom", 8),
                new Frog("Jaburana", 2, Gender.Female),
                new Dog("Ulichna Prevazhodna", 7, Gender.Female),
                new Dog("Lassy", 12, Gender.Female),
                new Kitten("Pisence", 1),
                new Kitten("Malko kote", 2),
                new Tomcat("Kotak", 7)
            };

            var animalAgeAverage = from animal in animals
                                   group animal by new { GroupName = animal.GetType().Name } into gr
                                   select new
                                   {
                                       GroupName = gr.Key.GroupName,
                                       AverageAge = gr.Average(animal => animal.Age)
                                   };
            foreach (var animal in animalAgeAverage)
            {
                Console.WriteLine(String.Format("Group: {0}; Age Average: {1:0.00}", animal.GroupName, animal.AverageAge));
            }
        }
    }
}
