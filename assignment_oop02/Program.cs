using assignment_oop02.Encapsulition;

namespace assignment_oop02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee(10, "Moamen", 4000);



            Console.WriteLine(employee.ToString());

            //employee.Id = 100;

            //Console.WriteLine(employee.Id);


            //employee.SetName("Ahmed");

            //Console.WriteLine(employee.GetName());

            employee.Salary = 6000;

            Console.WriteLine(employee.Salary);
            Console.WriteLine(employee.Deduction);

        }
    }
}
