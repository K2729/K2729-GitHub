using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo05_teht4
{
    class Specs
    {
        public string Speed { get; set; }
        public string Acce { get; set; }
        public string Engine { get; set; }

        public override string ToString()
        {
            return "Top speed :" + Speed + "Acceleration :" + Acce + "Engine :" + Engine;
        }

    }
}