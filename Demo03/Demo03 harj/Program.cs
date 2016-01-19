using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03_harj
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one car instance
            Car car = new Car();
            car.Model = "Audi";
            car.Color = "Red";
            car.Engine = 5.0;
            car.FuzzyDices = false;
            car.Speed = 100;
            car.PrintData();
            car.Accelerate(50);
            car.PrintData();


            Console.ReadLine();
        }
    }
}
