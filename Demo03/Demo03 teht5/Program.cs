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

            Student student = new Student();

            students[0] = new Student();
            students[0].Name = "Kalle";
            students[0].Age = 20;
            students[0].Address = "Kallenkuja 6";

            students[1] = new Student();
            students[1].Name = "Mikko";
            students[1].Age = 25;
            students[1].Address = "Mikkolantie 22";

            students[2] = new Student();
            students[2].Name = "Liisa";
            students[2].Age = 30;
            students[2].Address = "Liisanmutka 445";

            students[3] = new Student();
            students[3].Name = "Mauri";
            students[3].Age = 31;
            students[3].Address = "Maurintie 34";

            students[4] = new Student();
            students[4].Name = "Terttu";
            students[4].Age = 56;
            students[4].Address = "Tertunkuja 99";

            int i = 0;

            for (i = 0; i < 5; i++)
            {
                students[i].PrintData();
            }
            

            Console.ReadLine();

        }
    }
}
