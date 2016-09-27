using LaceraParser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaceraConsole
{
    class Program
    {

        // C:\Users\adolf\Desktop\LaceraTest.csv
        static void Main(string[] args)
        {

            List<Employee> data = new List<Employee>();
            List<EmployeeRecord> invalidRecords;
            Console.WriteLine("Please enter file path.");
            string csvFile = Console.ReadLine();
            while (csvFile != "exit" && File.Exists(csvFile))
            {

                data = CsvParser.Parse(csvFile, out invalidRecords);

                Console.WriteLine("*********** EMPLOYEE RECORDS ***********");
                Console.WriteLine(string.Format("{0,10}", "Name")
                    + string.Format("{0,20}", "Birth Date")
                    + string.Format("{0,30}", "Salary")
                    + string.Format("{0,35}", "Date Hired")
                    );
                for (int i = 0; i < data.Count; i++)
                {
                    Console.WriteLine(string.Format("{0,5}", data[i].EmployeeName.Trim('"').PadRight(20))
                        + string.Format("{0,20}", data[i].BirthDate.ToShortDateString().Trim())
                        + string.Format("{0,30:c}", data[i].Salary)
                        + string.Format("{0,35}", data[i].DateHired.ToShortDateString().Trim()));
                }

                Console.WriteLine("\n \n Invalid Employee Records \n");

                Console.WriteLine(string.Format("{0,10}", "Name")
                    + string.Format("{0,20}", "Birth Date")
                    + string.Format("{0,30}", "Salary")
                    + string.Format("{0,35}", "Date Hired")
                    );
                for (int i = 0; i < invalidRecords.Count; i++)
                {
                    Console.WriteLine(string.Format("{0,5}", invalidRecords[i].EmployeeName.Trim('"').PadRight(15))
                        + string.Format("{0,20}", invalidRecords[i].BirthDate.ToShortDateString().TrimStart())
                        + string.Format("{0,30:c}", invalidRecords[i].Salary)
                        + string.Format("{0,35}", invalidRecords[i].DateHired.ToShortDateString().TrimStart()));
                }
                Console.WriteLine(" \n Please enter another file path, or type 'exit' to exit.");
                csvFile = Console.ReadLine();

            }
        }
    }
}
