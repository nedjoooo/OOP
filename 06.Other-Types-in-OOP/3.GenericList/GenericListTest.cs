using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GenericList
{
    class GenericListTest
    {
        static void Main(string[] args)
        {
            Type type = typeof(GenericList<>);
            object[] versionAttributes = type.GetCustomAttributes(typeof(VersionAttribute), true);
            foreach (VersionAttribute versionAttribute in versionAttributes)
            {
                Console.WriteLine(String.Format("Version {0}.{1}", versionAttribute.Major, versionAttribute.Minor));
            }


            GenericList<int> genericList = new GenericList<int>();
            genericList.Add(1);
            genericList.Add(2);
            genericList.Add(3);
            genericList.Add(4);
            genericList.Add(5);
            genericList.Add(6);
            genericList.Add(7);
            genericList.Add(8);
            genericList.Add(9);
            genericList.Add(10);
            genericList.Add(11);
            genericList.Add(12);
            genericList.Add(13);
            genericList.Add(14);
            genericList.Add(15);
            genericList.Add(16);

            // Printing list.
            Console.WriteLine("Printing list!");
            Console.WriteLine(genericList.ToString());
            Console.WriteLine();

            // Added value in list.
            genericList.Add(17);
            Console.WriteLine("Printing list after adding value!");             
            Console.WriteLine(genericList.ToString());      
            Console.WriteLine();

            // Get value in list.
            Console.WriteLine("Accessing value: " + genericList.Access(5));
            Console.WriteLine();

            // Remove value in list.
            genericList.Remove(3);
            Console.WriteLine("Printing list after removing!");
            Console.WriteLine(genericList.ToString());
            Console.WriteLine();

            // Insert value in list.
            genericList.Insert(3, 4);
            Console.WriteLine("Printing list after insert value!");
            Console.WriteLine(genericList.ToString());
            Console.WriteLine();

            //  Find index by given value.
            Console.WriteLine(String.Format("Index by value {0} is {1}", 5, genericList.FindIndexByValue(5)));
            Console.WriteLine();

            // Check would value contains in list.
            if(genericList.Contains(19))
            {
                Console.WriteLine("Generic List contains 19");
            }
            else
            {
                Console.WriteLine("Generic List not contains 19");
            }
            Console.WriteLine();

            // Find greatest element.
            Console.WriteLine(String.Format("Greatest element is {0}", genericList.Max()));
            Console.WriteLine();

            // Find least element.
            Console.WriteLine(String.Format("Least element is {0}", genericList.Min()));
            Console.WriteLine();

            // Clear list.
            Console.WriteLine("Clear list!");
            genericList.Clear();
            Console.WriteLine(genericList.ToString());
        }
    }
}
