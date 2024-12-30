using assignment_oop02.Encapsulition;
using static assignment_oop02.Assignment;

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

            #region PhoneBook

            phonebook Note = new phonebook(3);
            Note.Addpersone(0, "Ahmed", 123);
            Note.Addpersone(1, "Moamen", 546);
            Note.Addpersone(2, "Marwan", 333);


            //int Number = Note.GetNumber("Moamen");
            //Console.WriteLine(Number == -1 ? "Note Found" : Number);
            //Note.SetNumber("Mona", 999);

            //Note["Moamen"] = 999;
            //Console.WriteLine(Note["Moamen"]);

            //for (int i = 0; i < Note._Size; i++)
            //{

            //    Console.WriteLine(Note[i]);
            //}

            //string Name = "Moamen";
            //Console.WriteLine(Name[0]) 
            #endregion;

            #region Car

            //Car c01 = new(10);

            //Console.WriteLine(c01);


            #endregion

            #region Assibnment_oop_02

            #region part 2

            #region 1-Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person[] people = new Person[3];

            //people[0] = new Person("Moamen", 125);
            //people[1] = new Person("Ali", 130);
            //people[2] = new Person("Mohamed", 122);

            //foreach (Person person in people)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //}


            #endregion

            #region 2-Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            //    Person[] people = new Person[3];

            //    for (int i = 0; i < people.Length; i++)
            //    {
            //        Console.WriteLine($"Enter deta for person {i + 1}:");
            //        Console.Write("Name: ");
            //        string name = Console.ReadLine();

            //        Console.Write("Age: ");
            //        int age = int.Parse(Console.ReadLine());

            //        people[i] = new Person(name, age);
            //    }

            //    Person old = people[0];
            //    for (int i = 1; i < people.Length; i++)
            //    {
            //        if (people[i].Age > old.Age)
            //        {
            //            old = people[i];
            //        }
            //    }

            //    Console.WriteLine($"\nThe olde person is {old.Name} age  {old.Age}.");
            //}
            #endregion


            #endregion



            #region Part 3
            #region 1-Employee is identified by an ID, Name, security level, salary, hire date and Gender.
            //Console.WriteLine("Enter Employee Details:");
            //Console.Write("ID: ");
            //int id = int.Parse(Console.ReadLine());

            //Console.Write("Name: ");
            //string name = Console.ReadLine();

            //Console.Write("Security Level: ");
            //int securityLevel = int.Parse(Console.ReadLine());

            //Console.Write("Salary: ");
            //decimal salary = decimal.Parse(Console.ReadLine());

            //Console.Write("Hire Date (yyyy-mm-dd): ");
            //DateTime hireDate = DateTime.Parse(Console.ReadLine());

            //Console.Write("Gender: ");
            //string gender = Console.ReadLine();


            #endregion

            #region 2-Develop a Class to represent the Hiring Date Data:consisting of fields to hold the day, month and Years.

            Console.WriteLine("Enter Hiring Date:");

            Console.Write("Day: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Month: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());


            

            #endregion
            #endregion
            #endregion




        }
    }
}

