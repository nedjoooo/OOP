using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLINQExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> nums = new List<int>()
            {
                1, 2, 3, 4, 5, 6
            };

            Console.WriteLine(string.Join(", ", nums));

            IEnumerable<int> notNum = nums.WhereNot(num => num == 4);
            Console.WriteLine(string.Join(", ", notNum));
            Console.WriteLine();

            IEnumerable<int> repeat = nums.Repeat(2);
            Console.WriteLine(string.Join(", ", repeat));

            IEnumerable<string> strings = new List<string>()
            {
                "SoftUni", "Nakov", "Education"
            };

            IEnumerable<string> listStrings = strings.Repeat(1);
            Console.WriteLine(string.Join(", ", listStrings));

            IEnumerable<string> endsWith = new List<string>()
            {
                "Uni", "tion"
            };

            IEnumerable<string> whereEndsWith = strings.WhereEndsWith(endsWith);
            Console.WriteLine(string.Join(", ", whereEndsWith));
        }
    }
}
