using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExtensions
{
    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder inputString, int startIndex, int length)
        {
            string input = inputString.ToString();
            if (startIndex < 0 || startIndex > input.Length - 1)
            {
                throw new IndexOutOfRangeException("Start index must be a range 0 - length a submitted string!");
            }
            if (length < 0 || length > input.Length - startIndex)
            {
                throw new IndexOutOfRangeException("Start index must be a range start index position - length a submitted string!");
            }
            StringBuilder output = new StringBuilder();
            
            output.Append(input.Substring(startIndex, length));
            return output;
        }

        public static StringBuilder RemoveText(this StringBuilder stringBuilder, string text)
        {
            stringBuilder.Replace(text, "");
            return stringBuilder;
        }

        public static StringBuilder AppendAll<T>(this StringBuilder stringBuilder, IEnumerable<T> items)
        {
            stringBuilder.Append(" ");
            foreach (var item in items)
            {
                stringBuilder.Append(item.ToString());
                stringBuilder.Append(" ");
            }
            return stringBuilder;
        }
    }
}
