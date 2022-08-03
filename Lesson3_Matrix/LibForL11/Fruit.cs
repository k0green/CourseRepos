using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public struct Fruit
    {

        public string Name
        {
            get//add verification
            {
                if (Name != null)
                {
                    return Name;
                }
                else { return "Error"; }
            }
            set
            {
                Name = value;
            }
        }
        internal double Coast { get; set; }
        static int Id { get; set; }
        public Fruit(string name, double coast) : this()
        {
            Name = name;
            Coast = coast;
        }

        internal bool Display()
        {
            Id++;
            if (Name != null)
            {
                Console.WriteLine($"Fruit: {Name} coast: {Coast} id:{Id}");
            }
            else { Console.WriteLine($"Fruit: Undefined coast: {Coast} id:{Id}"); }
            return true;
        }
    }
}