using System;
using System.Collections.Generic;
using System.Text;

namespace _12_Company
{
    class Room
    {
        public int Length { get; private set; }
        public int Weight { get; private set; }

        public int Area
        {
            get
            {
                return Length * Weight;
            }
        }

        public Room(int length, int weight)
        {
            Length = length;
            Weight = weight;
        }

        public string RoomsInfo()
        {
            return "Room:" + Length*Weight + '\n';
        }

    }
}
