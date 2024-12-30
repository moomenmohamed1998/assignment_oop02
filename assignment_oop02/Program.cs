using assignment_oop02.Encapsulition;

namespace assignment_oop02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Encapsulatoin
            //Employee employee = new Employee(10, "Moamen", 4000);



            //Console.WriteLine(employee.ToString());

            //employee.Id = 100;

            //Console.WriteLine(employee.Id);


            //employee.SetName("Ahmed");

            //Console.WriteLine(employee.GetName());

            //employee.Salary = 6000;

            //Console.WriteLine(employee.Salary);
            //Console.WriteLine(employee.Deduction); 
            #endregion

            phonebook Note = new phonebook(3);
            Note.Addpersone(0, "Ahmed", 123);
            Note.Addpersone(1, "Moamen", 546);
            Note.Addpersone(2, "Marwan", 333);


            //int Number = Note.GetNumber("Moamen");
            //Console.WriteLine(Number == -1 ? "Note Found" : Number);
            //Note.SetNumber("Mona", 999);

            //Note["Moamen"] = 999;
            //Console.WriteLine(Note["Moamen"]);

            for (int i = 0; i < Note._Size; i++)
            {

                Console.WriteLine(Note[i]);
            }

            string Name = "Moamen";
            Console.WriteLine(Name[0]);



        }
    }
}
