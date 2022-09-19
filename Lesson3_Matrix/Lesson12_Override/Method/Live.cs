using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Override
{
    internal class Live
    {
        public string Name { get; set; }

        public virtual Live Fill()
        {
            Console.WriteLine("Enter Name:");
            Name = Console.ReadLine();
            return this;
        }
        public virtual string GetDisplayData()
        {
            return $"Name: {Name} ";
        }
    }
}
