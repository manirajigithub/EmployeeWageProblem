using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public static class EmployeeWage
    {
        public static void CheckEmployeeAttendace()
        {
            int FullTime = 1;

            Random random = new Random();
            int empcheck = random.Next();
            if (empcheck == FullTime)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is absent");

            }
        }
    }

}


