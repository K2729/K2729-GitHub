using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo05_harj
{
    abstract class DrawingObject
    {
        public string Name { get; set; }
        public abstract void Draw();

    }
}
