using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
struct Fruit
    {
        public string Name { get; set; } = "Undifined";
        public double Coast { get; set; } = 0;
        public int Id { get; set; } = 0;
        public Fruit(string name, double coast, int id)
        {
            Name = name;
            Coast = coast;
        }

        public bool Display()
        {
            Console.WriteLine($"Fruit: {Name} coast: {Coast} id:{Id}");
            return true;
        }
    }
}
