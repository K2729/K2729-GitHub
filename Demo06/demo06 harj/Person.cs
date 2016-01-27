using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo06_harj
{
    /// <summary>
    /// This class contains Person properties.
    /// </summary>
    class Person
    {
        public string Firtsname { get; set; }
        public string Lastname { get; set; }
        public string SocialSecurityNumber { get; set; }

        public override string ToString()
        {
            return Firtsname + " " + Lastname + " " + SocialSecurityNumber;
        }

    }
}
