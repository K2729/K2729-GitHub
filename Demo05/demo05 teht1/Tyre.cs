﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo05_teht1
{
    class Tyre
    { 
        public string Name { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }

        public override string ToString()
        {
            return "Name" + Name + "Type" + Type + "Size" + Size;
        }

    }
}
