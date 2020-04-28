using System;
using System.Collections.Generic;
using System.Text;

namespace _12_Company
{
    class Office
    {
        public string Address { get; private set; }
        public Room[]  Rooms { get; private set; }

        public Office(string address, Room[] rooms)
        {
            Address = address;
            Rooms = rooms;
        }

        public string AllRoomsArea()
        {
            int GenArea = 0;
            foreach (Room room in Rooms)
            {
                GenArea += room.Area;
            }
            return GenArea.ToString();
        }
    }

}
