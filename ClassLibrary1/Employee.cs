using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaceraParser
{
   public class Employee
    {
        public Employee(string employeeName)
        {
            EmployeeName = employeeName;
            EmployeeName.Trim('"');
        }

        public string EmployeeName { get; private set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateHired { get; set; }
    }
}
