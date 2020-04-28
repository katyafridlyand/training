using System;
using System.Collections.Generic;
using System.Text;

namespace _12_Company
{
    class Developer : Employee
    {
        public Developer(string fn, string ln, string pn, Room room) : base (fn, ln, pn, room)
        {
        }

        public override string FullEmployeeInfo()
        {
            {
                return "Developer works" + '\n';
            }
        }

    }
}
