using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace assignment_oop02
{
    internal class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public double Spead { get; set; }

        public Car(int id, string model, double spead)
        {
            Id = id;
            Model = model;
            Spead = spead;
            Console.WriteLine("ceor01");
        }

        public Car(int id, string model):this(id,model,290)
        {
            //Id = id;
            //Model = model;
            //Spead = 290;
            Console.WriteLine("ceor02");
        }

        public Car(int id):this(id,"Audi",350)
        {
            //Id = id;
            //Model = "Audi";
            //Spead = 350;
            Console.WriteLine("ceor03");
        }

        public override string ToString()
        {
            return $"id: {Id}\nmodel: {Model}\nSpead: {Spead}";
        }









    }
}
