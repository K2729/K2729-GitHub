using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo05_teht4
{
    class Bike
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public List<Specs> Specs { get; }

        public Bike()
        {
            Specs = new List<Specs>();
        }
        public void AddSpec(Specs spec)
        {
            Specs.Add(spec);
        }
        public override string ToString()
        {
            string sBike = "Bike : " + Name + "\n\nModel : " + Model + "\n\nSpecs :\n\n";
            foreach (Specs spec in Specs)
            {
                sBike += spec.ToString() + "\n";
            }
            return sBike;
        }

     


    }
}