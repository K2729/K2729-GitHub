using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03_teht5
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Nimi : " + Name);
            Console.WriteLine("Ikä : " + Age);
            Console.WriteLine("Osoite : " + Address);

        }
        }
}
