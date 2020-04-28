using System;
using System.Collections.Generic;
using System.Text;

namespace _12_Company
{
    class Employee
    {
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public string passportNumber { get; private set; }
        Room Room;

        public Employee(string fn, string ln, string pn, Room room)
        {
            firstName = fn;
            lastName = ln;
            passportNumber = pn;
            Room = room;
        }
 
        public virtual string FullEmployeeInfo()
        {
            return firstName + " " + lastName + ", " + "Passport Number: " + passportNumber + ";" + " " + "Room" + ":" + " " + Room.Area +'\n';
        }

        public virtual void WhoWorks()
        {
            {
                Console.WriteLine(firstName + " " + lastName + ", " + "Passport Number: " + passportNumber + "; " + " " + "Room" + ":" + " " + Room.Area + '\n');
            }
        }
    }
}
