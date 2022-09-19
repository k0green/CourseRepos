using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public class Vegetable
    {
        public string Name { get; set; } = "Undifined";
        public double Coast { get; set; } = 0;
        public int Id { get; set; }
        public Vegetable(string name, double coast, int id)
        {
            Name = name;
            Coast = coast;
        }

        public bool Print()
        {
            Console.WriteLine($"Vegetable: {Name} coast: {Coast} id:{Id}");
            return true;
        }
    }
}
