using System;

namespace _12_Company
{
  
    class Program
    {
        static void Main(string[] args)
        {


            Room[] rooms = new Room[5];
            rooms[0] = new Room(15, 30);
            rooms[1] = new Room(16, 31);
            rooms[2] = new Room(17, 32);
            rooms[3] = new Room(18, 33);
            rooms[4] = new Room(19, 34);

            Employee[] employees=new Employee[10];
            employees[0] = new Developer("fn4", "ln4", "pn4", rooms[1]);
            employees[1] = new Employee("fn2", "ln2", "pn2", rooms[0]);
            employees[2] = new Employee("fn3", "ln3", "pn3", rooms[1]);
            employees[3] = new Employee("fn4", "ln4", "pn4", rooms[1]);
            employees[4] = new Employee("FN5", "LN5", "PN5", rooms[2]);
            employees[5] = new QA("fn6", "ln6", "pn6", rooms[2], "Sertificat");
            employees[6] = new Employee("fn7", "ln7", "pn7", rooms[3]);
            employees[7] = new QA_Lead("fn8", "ln8", "pn8", rooms[3], "Certif", 10);
            employees[8] = new Employee("fn9", "ln9", "pn9", rooms[4]);
            employees[9] = new BA("fn10", "ln10", "pn10", rooms[4]);

            Company company = new Company("The Best Company Ever", employees);

            Office office = new Office("Chapaeva, 5",rooms);
            company.Office = office;
            
            Console.WriteLine(company.CompanyFullInfo());

            Console.ReadKey();
        }
    }
}
