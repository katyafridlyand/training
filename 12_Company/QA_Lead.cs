using System;
using System.Collections.Generic;
using System.Text;

namespace _12_Company
{
    class QA_Lead : QA
    {

        public int ExperienceYears { get; private set; }

        public QA_Lead(string fn, string ln, string pn, Room room, string QASertif, int experienceYears) : base(fn, ln, pn, room, QASertif)
        {
            ExperienceYears = experienceYears;
        }

        public override string FullEmployeeInfo()
        {
            {
                return "QA_Lead is SUPER!!!" + '\n';
            }
        }


    }
}
