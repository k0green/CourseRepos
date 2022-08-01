using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Override.Method
{
    internal class Registry
    {
        public List<Live> _lives;

        public void Add(Live live)
        {
            if (live != null)
            {
                _lives.Add(live);
            }
            else { Console.WriteLine($"Che za neponel"); }
        }
        public void PrintAll()
        {
            foreach(var l in _lives)
            {
                Console.WriteLine(l.GetDisplayData());
            }
        }
    }
}
