using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using LaceraParser;
using System.Collections.ObjectModel;
using Microsoft.VisualBasic;
using System.IO;

namespace LaceraParser
{
    public static class CsvParser
    {
        
        public static  List<Employee> Parse(string file, out List<EmployeeRecord> invalidRecords) {

            List<Employee> employeeCollection = null;
            invalidRecords = null;
            
            using (
                TextFieldParser parser = new TextFieldParser(file))
            { 
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                parser.TrimWhiteSpace = true;
                bool isFirstLine = true;
                DateTime birthDate;
                Decimal salary;
                DateTime dateHired;

                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();

                    if (isFirstLine || fields == null)
                    {
                        isFirstLine = false;

                        continue;
                    }

                    EmployeeRecord thisEmp = new EmployeeRecord(fields[0]);

                    if (DateTime.TryParse(fields[1], out birthDate)) {
                        thisEmp.BirthDate = birthDate;
                        thisEmp.IsBirthDateValid = true;
                    }

                    if (Decimal.TryParse(fields[2], out salary)) {
                        
                        thisEmp.Salary = salary;
                        if(thisEmp.Salary <= 0.00M)
                        {
                            thisEmp.IsSalaryValid = false;
                        }
                        else { thisEmp.IsSalaryValid = true; }
                       
                    } 

                    if(DateTime.TryParse(fields[3], out dateHired))
                    {
                        thisEmp.DateHired = dateHired;
                        thisEmp.IsDateHiredValid = true;
                    }
              

                    if (!thisEmp.IsBirthDateValid || !thisEmp.IsSalaryValid || !thisEmp.IsDateHiredValid)
                    {
                        if (invalidRecords == null)
                        {
                            invalidRecords = new List<EmployeeRecord>();
                        }
                        invalidRecords.Add(thisEmp);
                    }
                    else
                    {
                        if (employeeCollection == null)
                        {
                            employeeCollection = new List<Employee>();
                        }
                        employeeCollection.Add(thisEmp);
                    }
                }

            }
            return employeeCollection;
        }
    }

}
