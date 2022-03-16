using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Organogram
{
    public struct Employee
    {
        public int ID;
        public int ReferenceID;
        public string FirstName;
        public string LastName;
        public string Company;
        public string City;
        public string Role;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var EmployeeList = new List<Employee>();

            string[] lines = File.ReadAllLines("companies_data.csv");
            foreach (var line in lines)
            {
                var col = line.Split(',');
                var record = new Employee
                {
                    ID = int.Parse(col[0]),
                    ReferenceID = int.Parse(col[1]),
                    FirstName = col[2],
                    LastName = col[3],
                    Company = col[4],
                    City = col[5],
                    Role = col[6]
                };
                EmployeeList.Add(record);
            }

            EmployeeList.Sort(delegate (Employee x, Employee y) 
            {
                if (x.ID > y.ID)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            } );

            var lead = EmployeeList.Where(item => item.ReferenceID == 0);

            foreach (var leader in lead)
            {
                Console.WriteLine(leader.ID +", "+ leader.FirstName + " " + leader.LastName + ", " + leader.Company + ", " + leader.Role);
                TreeTools.PrintTree(EmployeeList, "\t", leader.ID);
            }
            Console.ReadKey();
        }
        
    }
}