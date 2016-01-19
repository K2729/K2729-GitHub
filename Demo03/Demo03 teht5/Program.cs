using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03_teht5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student();

            Student student = new Student();
            student.Name = "Kalle";
            student.Age = 20;
            student.Address = "Kallenkuja 6";

            students[1] = new Student();
            student.Name = "Mikko";
            student.Age = 25;
            student.Address = "Mikkolantie 22";

            students[2] = new Student();
            student.Name = "Liisa";
            student.Age = 30;
            student.Address = "Liisanmutka 445";

            students[3] = new Student();
            student.Name = "Mauri";
            student.Age = 31;
            student.Address = "Maurintie 34";

            students[4] = new Student();
            student.Name = "Terttu";
            student.Age = 56;
            student.Address = "Tertunkuja 99";

            student.PrintData();


            Console.ReadLine();

        }
    }
}
