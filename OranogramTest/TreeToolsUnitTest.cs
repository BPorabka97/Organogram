using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Organogram;
using System.Collections.Generic;

namespace OranogramTest
{
    [TestClass]
    public class TreeToolsUnitTest
    {
        [TestMethod]
        public void TreeToolsEmptyListTest()
        {
            TreeTools.PrintTree(new List<Employee>(), "test", 1);
        }

        [TestMethod]
        public void TreeToolsNullListTest()
        {
            TreeTools.PrintTree(null, "test", 1);
        }

        [TestMethod]
        public void TreeToolsNullFormatterTest()
        {
            TreeTools.PrintTree(new List<Employee>(), null, 1);
        }

        [TestMethod]
        public void TreeToolsFakeEmployeeTest()
        {
            var TestList = new List<Employee>()
            {
               new Employee
               {
                   ID = 279, ReferenceID = 17, FirstName = "John", LastName = "Pancake", City = "Johannesburg", Company = "Oracle", Role = "Junior .NET Developer"
               }
            };

            TreeTools.PrintTree(new List<Employee>(), "test", 279);
        }
    }
}
