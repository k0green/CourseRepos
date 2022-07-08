using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public struct Fruit
    {

        public string Name { get; set; }
        internal double Coast { get; set; }
        private int Id { get; set; }
        public Fruit(string name, double coast, int id):this()
        {
            Name = name;
            Coast = coast;
            Id = id;
        }

        public bool Display()
        {
            Console.WriteLine($"Fruit: {Name} coast: {Coast} id:{Id}");
            return true;
        }
    }
}