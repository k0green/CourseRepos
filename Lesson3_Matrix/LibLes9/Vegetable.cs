using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public class Vegetable
    {

        private string Name { get; set; }
        public double Coast { get; set; }
        private int Id { get; set; }
        public Vegetable(string name, double coast, int id)
        {
            Name = name;
            Coast = coast;
            Id= id;
        }

        public string GetName()
        {
            return Name;
        }

        public bool Print()
        {
            Console.WriteLine($"Vegetable: {Name} coast: {Coast} id:{Id}");
            return true;
        }
    }
}