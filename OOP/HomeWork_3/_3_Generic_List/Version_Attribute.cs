using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Generic_List
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = true)]
    class VersionAttribute:System.Attribute
    {
        private int majorVersion;
        private int minorVersion;

        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }

        public VersionAttribute(int major, int minor)
        {
            this.majorVersion = major;
            this.minorVersion = minor;
        }

        public override string ToString()
        {
            return this.majorVersion + "." + this.minorVersion;
        }
    }
}
