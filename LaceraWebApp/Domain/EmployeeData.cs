using LaceraParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaceraWebApp.Domain
{
    public class EmployeeData
    {
        public List<EmployeeRecord> InvalidData { get; set; }
        public List<Employee> ValidData { get; set; }
    }
}