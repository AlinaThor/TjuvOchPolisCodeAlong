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

        private Random random = new Random();
        public Person()
        {         
            PositionX = random.Next(1, 101);
            PositionY = random.Next(1, 26);
        }

        public void SetNewLocation()
        {
            int direction = random.Next(1, 5);
            if(direction == 1)
            {
                //upp
                PositionY = -1;
            }
            else if (direction == 2)
            {
                //höger
                PositionX += 1;
            }
            else if (direction == 3)
            {
                //ner
                PositionY += 1;
            }
            else if (direction == 4)
            {
                //vänster
                PositionX -= 1;
                
            }

            //Har karaktären kommit för högt upp?
            if(PositionY < 1)
            {
                PositionY = 25;
            }


            //Har karaktären kommit för högt upp?
            if (PositionY > 25)
            {
                PositionY = 1;
            }

            //Har karaktären kommit för långt till höger?
            if (PositionX > 100)
            {
                PositionX = 1;
            }

            //Har karaktären kommit för högt upp?
            if (PositionX < 1)
            {
                PositionX = 100;
            }
        }
    }
}
