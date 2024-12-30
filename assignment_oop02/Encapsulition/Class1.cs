using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_oop02.Encapsulition
{
    internal struct Employee
    {
        #region Encapsulation

        #region Attributes

        public int Id;
        private string Name;
        public decimal salary;

        #endregion

        #region Constructors
        public Employee(int id, string name, decimal _salary)
        {
            Id = id;
            Name = name;
            salary = _salary;
        }
        #endregion

        #region Methods
        public override string ToString()

        {

            return $"id: {Id}\nName: {Name}\nsalary: {salary:c}";

        }
        #endregion


        #region GEt-SET

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)

        {

            Name = name.Length > 5 ? name.Substring(0, 5) : name;

        }
        #endregion

        #region Property

        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value > 5000 ? 5000 : value;
            }

        }

        public int Age { get; set; }

        //private decimal deduction;
        public decimal Deduction
        {
            get { return salary * 0.2m; }
        }



        #endregion 
        #endregion







    }
}
