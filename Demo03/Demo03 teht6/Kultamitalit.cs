using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03_teht6
{
    class Kultamitalit
    {

            public string Voittaja { get; set; }
            public int Vuosi { get; set; }
            public string Kisapaikka { get; set; }


            public void PrintData()
            {
                Console.WriteLine("Kultamitali voittaja : " + Voittaja);
                Console.WriteLine("Vuonna : " + Vuosi);
                Console.WriteLine("Kisapaikkana : " + Kisapaikka);

            }

        
    }
}

