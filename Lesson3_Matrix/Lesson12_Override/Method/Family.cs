using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Override.Новая_папка
{
    internal class Family:Order
    {
        public string _Family { get; set; }
        public override Live Fill()
        {
            return base.Fill();
            Console.WriteLine("Enter Family:");
            _Family = Console.ReadLine();
            return this;
        }
        public override string GetDisplayData()
        {
            return $"{base.GetDisplayData()} Family: {_Family} ";
        }
    }
}
