using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CompanyHierarchy.Company_Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            // create several Sales lists
            List<Sale> foodSales = new List<Sale>()
            {
                new Sale("Cheese", new DateTime(2015, 1, 25), 12.35m),
                new Sale("Chicken", new DateTime(2015, 1, 27), 8.29m),
                new Sale("Milk", new DateTime(2015, 1, 28), 2.07m)
            };
            List<Sale> alkoholSales = new List<Sale>()
            {
                new Sale("Wiskey", new DateTime(2010, 6, 25), 36.49m),
                new Sale("Beer", new DateTime(2015, 1, 14), 1.79m),
                new Sale("Vodka", new DateTime(2014, 3, 19), 12.99m)
            };

            //create several projects lists
            List<Project> webProjects = new List<Project>()
            {
                new Project("JavaScript project", new DateTime(2014, 9, 12), "Base web project", ProjectState.Closed),
                new Project("HTML&CSS project", new DateTime(2014, 10, 1), "Second web project", ProjectState.Open),
                new Project("PHP project", new DateTime(2014, 10, 23), "Base web project", ProjectState.Open)
            };

            var programmingProjects = new List<Project>()
            {
                new Project("CSharp project", new DateTime(2014, 8, 5), "Programming project", ProjectState.Open),
                new Project("Java project", new DateTime(2014, 8, 31), "Second Programming project", ProjectState.Open)
            };

            SalesEmployee mobileSalesEmployee = new SalesEmployee(466, "Ivan", "Vankov", 3200, Department.Sales, foodSales);
            SalesEmployee computerSalesEmployee = new SalesEmployee(513, "Gergi", "Gerginov", 3400, Department.Production, alkoholSales);

            // create several developer employees
            List<Developer> webDevelopers = new List<Developer>()
            {
                new Developer(212, "Pencho", "Minkov", 3400m, Department.Production, programmingProjects),
                new Developer(310, "Stoyka", "Penkova", 3200m, Department.Marketing, webProjects)
            };
            List<Developer> mobileDevelopers = new List<Developer>()
            {
                new Developer(472, "Svtelin", "Ivankov", 5400m, Department.Accounting, programmingProjects),
                new Developer(310, "Mariya", "Stoyanova", 3900m, Department.Sales, webProjects)
            };

            var foodAndAlkoholEmployees = new List<Employee>()
            {
                new SalesEmployee(335, "Stiliyan", "Stoyanov", 3950m, Department.Production, foodSales),
                new SalesEmployee(345, "Dimitar", "Nonkov", 2500m, Department.Marketing, alkoholSales)
            };
            var noFoodEmployees = new List<Employee>()
            {
                new SalesEmployee(235, "Iliyan", "Ignatov", 3450m, Department.Accounting, foodSales),
                new SalesEmployee(145, "Ivayla", "Dimitrova", 2900m, Department.Sales, alkoholSales)
            };
            Employee programmingManager = new Manager(173, "Velichko", "Kalajdzhijski", 4600m, Department.Production, noFoodEmployees);

            List<Employee> programmingManagers = new List<Employee>()
            {
                new Manager(173, "Velichko", "Kalajdzhijski", 4600m, Department.Production,noFoodEmployees),
                new Manager(195, "Gery", "Yordanova", 4150m, Department.Sales,noFoodEmployees)
            };
            List<Employee> accountingManagers = new List<Employee>()
            {
                new Manager(175, "Yordan", "Velichkov", 3200m, Department.Accounting,foodAndAlkoholEmployees),
                new Manager(192, "Mihaela", "Todorova", 2150m, Department.Accounting,foodAndAlkoholEmployees)
            };

            var managers = new List<Person>();
            managers.AddRange(programmingManagers);
            managers.AddRange(accountingManagers);

            Console.WriteLine("Managers");
            foreach (var manager in managers)
            {
                Console.WriteLine(manager);
            }
        }
    }
}
