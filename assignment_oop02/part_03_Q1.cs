using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_oop02
{
    internal class part_03_Q1
    {

        #region Q1
        public int ID { get; set; }
        public string Name { get; set; }
        public int SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public string Gender { get; set; }

        public part_03_Q1(int iD, string name, int securityLevel, decimal salary, DateTime hireDate, string gender)
        {
            ID = iD;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Security Level: {SecurityLevel}");
            Console.WriteLine($"Salary: {Salary:C}");
            Console.WriteLine($"Hire Date: {HireDate.ToShortDateString()}");
            Console.WriteLine($"Gender: {Gender}");
        }

        #endregion

        #region Q2
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public part_03_Q1(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        } 


        #endregion
    }
}
