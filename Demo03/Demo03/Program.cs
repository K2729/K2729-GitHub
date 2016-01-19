using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Name = "Talbot";
            vehicle.Speed = 270;
            vehicle.Tyres = 4;
            vehicle.PrintData();
            vehicle.ToString();
            Console.WriteLine(vehicle.ToString());

            

        }
    }
}
