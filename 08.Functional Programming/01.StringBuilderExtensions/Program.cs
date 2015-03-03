using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder();
            str.Append("Hello");
            Console.WriteLine(str.ToString());

            var output = str.Substring(1, 3);           
            Console.WriteLine(output);

            str.RemoveText("o");
            Console.WriteLine(str.ToString());

            List<string> strings = new List<string>()
            {
                "SoftUni", "Nakov", "Education"
            };

            List<int> integers = new List<int>()
            {
                1, 9, 8, 0
            };

            str.AppendAll(integers);
            Console.WriteLine(str.ToString());

            str.AppendAll(strings);
            Console.WriteLine(str.ToString());
        }
    }
}
