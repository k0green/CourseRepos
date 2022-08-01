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
        internal double Coast { get; set; }
        private int Id { get; set; }
        internal Vegetable(string name, double coast, int id)
        {
            Name = name;
            Coast = coast;
            Id= id;
        }

        internal string GetName()
        {
            return Name;
        }

        internal bool Print()
        {
            Console.WriteLine($"Vegetable: {Name} coast: {Coast} id:{Id}");
            return true;
        }
    }
}