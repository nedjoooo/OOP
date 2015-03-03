using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GenericList
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface |
        AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = false)]
    class VersionAttribute : Attribute
    {
        public byte Major { get; set; }
        public byte Minor { get; set; }
        public VersionAttribute(byte major, byte minor)
        {
            this.Major = major;
            this.Minor = minor;
        }
    }
}
