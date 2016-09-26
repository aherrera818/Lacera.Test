using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaceraParser
{
   public class EmployeeRecord: Employee
    {
        public EmployeeRecord(string employeeName):base(employeeName)
        {
              
        }
        public bool IsBirthDateValid { get; set; }
        public bool IsSalaryValid { get; set; }
        public bool IsDateHiredValid { get; set; }
    }
}
