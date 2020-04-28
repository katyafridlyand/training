using System;
using System.Collections.Generic;
using System.Text;

namespace _12_Company
{
    class QA : Employee
    {
        public string QASertificate { get; private set; }
        public QA(string fn, string ln, string pn, Room room, string QASertif) : base(fn, ln, pn, room)
        {
            QASertificate = QASertif;
        }

        public override string FullEmployeeInfo()
        {
            {
                return "QA works" + '\n';
            }
        }

    }
}
