using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_teht5
{
    class Radio
    {

        private readonly int maxVolume;

        private int volume;
   
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value >= 0 && <= 10 ) volume = value;
                else Console.WriteLine("Wrong volume setting - set again!");
            }
        }

        private readonly float maxChannel;

        private float channel;

        public float Channel
        {
            get
            {
                return channel;
            }
            set
            {
                if (value >= 2000.0 && <= 26000.0) channel = value;
                else Console.WriteLine("Wrong channel setting - set again!");
            }
        }





    }
}