using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo05_teht1
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public List<Tyre> Tyres { get; }

        public Vehicle()
        {
            Tyres = new List<Tyre>();
        }
        public void AddTyre(Tyre tyre)
        {
            Tyres.Add(tyre);
        }
        public override string ToString()
        {
            string sVehicle = "Vehicle : " + Name + "\n\nModel : " + Model + "\n\nTyres :\n\n";
            foreach(Tyre tyre in Tyres)
            {
                sVehicle += tyre.ToString() + "\n"; 
            }
            return sVehicle;
        }



    }
}
