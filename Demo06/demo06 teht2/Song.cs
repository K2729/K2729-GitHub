using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo06_teht2
{
    class Song
    {

        public string Name { get; set; }
        public string Time { get; set; }
        

        public override string ToString()
        {
            return Name + " " + Time + " ";
        }



    }
}
