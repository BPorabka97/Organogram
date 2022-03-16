using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organogram
{
    public class TreeTools
    {
        public static void PrintTree(List<Employee> allEmployees, string formatter, int id)
        {
            var children = allEmployees.Where(g => g.ReferenceID == id).ToList();
            children.Sort(delegate (Employee x, Employee y)
            {
                if (x.ID > y.ID)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            });

            if (children.Count > 0)
            {
                int n = children.Count - 1;

                for (int i = 0; i <= n; i++)
                {
                    Console.WriteLine(formatter + "==> " + children[i].ID + ", " + children[i].FirstName + " " + children[i].LastName + ", " + children[i].Company + ", " + children[i].Role);
                    PrintTree(allEmployees, formatter + "\t", children[i].ID);
                }
            }
        }
    }
}
