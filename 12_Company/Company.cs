using System;
using System.Collections.Generic;
using System.Text;

namespace _12_Company
{
    class Company
    {
        public Employee[] CompanyEmployees { get; private set; }
        public string CompanyName { get; private set; }
        public Office Office { get; set; }
        public Room RoomArea { get; set; }

        public Company(string companyName, Employee[] employee)
        {
            CompanyName = companyName;
            CompanyEmployees = employee;
        }

        public string CompanyFullInfo()
        {
            string companyFullInfo = "Company:" + CompanyName + '\n' + '\n';

            foreach (Employee employee in CompanyEmployees)
            {
                companyFullInfo += employee.FullEmployeeInfo();
            }

            companyFullInfo += '\n';

            companyFullInfo += "Office:" + Office.Address + ";" + " " + "Area:" + " " + Office.AllRoomsArea() + '\n' + '\n';
            
            foreach (Room room in Office.Rooms)
            {
                companyFullInfo += room.RoomsInfo();
            }

            return companyFullInfo;
            
            
        }
    }

    
}
