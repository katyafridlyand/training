using System;
using System.Collections.Generic;
using System.Text;

namespace _12_Company
{
    class BA : Employee
    {
        public BA(string fn, string ln, string pn, Room room) : base(fn, ln, pn, room)
        {
        }

        public override string FullEmployeeInfo()
        {
            {
                return "BA works" + '\n';
            }
        }

    }
}
