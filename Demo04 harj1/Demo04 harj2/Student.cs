using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_harj2
{
    class Student : Person
    {
        public string Id { get; set; }

        public Student()
        {

        }
        public Student(string firstName, string lastName, string id) 
            :base(firstName, lastName)
        {
            Id = id;
        }
        public void StudentMethod()
        {
            Console.WriteLine("Teacher does something...");
        }
        public override string ToString()
        {
            return base.ToString() + " " + Id;
        }
    }
}
