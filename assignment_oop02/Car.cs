using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_oop02
{
    internal class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public double Spead { get; set; }

        public override string ToString()
        {
            return $"id: {Id}\nmodel: {Model}\nSpead: {Spead}";
        }









    }
}
