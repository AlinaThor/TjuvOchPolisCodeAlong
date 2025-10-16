using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAloneTjuvOchPolis
{
    internal class Person
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public Person()
        {
            Random random = new Random();
            PositionX = random.Next(1, 101);
            PositionY = random.Next(1, 26);
        }
    }
}
