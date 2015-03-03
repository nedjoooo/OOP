using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Disperser
{
    public class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable
    {
        public string[] strings;

        public StringDisperser(params string[] strings)
        {
            this.strings = strings;
        }

        public override bool Equals(object obj)
        {
            return this.ToString() == ((StringDisperser)obj).ToString();
        }

        public override string ToString()
        {
            return String.Join("", this.strings);
        }

        public override int GetHashCode()
        {
            var newHashCode = 0;
            foreach (var item in this.strings)
            {
                newHashCode ^= item.GetHashCode();
            }
            return newHashCode;
        }

        public static bool operator ==(StringDisperser strDisperser1, StringDisperser strDisperser2)
        {
            return strDisperser1.Equals(strDisperser2);
        }

        public static bool operator !=(StringDisperser strDisperser1, StringDisperser strDisperser2)
        {
            return !(strDisperser1.Equals(strDisperser2));
        }

        public object Clone()
        {
            var newStringDisperser = new StringDisperser((string[])this.strings.Clone());
            return newStringDisperser;
        }

        public int CompareTo(StringDisperser other)
        {
            string thisString = "";
            foreach (var item in this.strings)
            {
                thisString += item;
            }
            string otherString = "";
            foreach (var item in other.strings)
            {
                otherString += item;
            }

            return thisString.CompareTo(otherString);
        }

        public IEnumerator GetEnumerator()
        {
            var str = this.ToString();
            foreach (var item in str)
            {
                yield return item;
            }
        }
    }
}
