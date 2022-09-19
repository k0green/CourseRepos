using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Override.Новая_папка
{
    internal class Species:Genus
    {
        public string _Species { get; set; }
        public override Live Fill()
        {
            return base.Fill();
            Console.WriteLine("Enter Species:");
            _Species = Console.ReadLine();
            return this;
        }
        public override string GetDisplayData()
        {
            return $"{base.GetDisplayData()} Species: {_Species} ";
        }
    }
}
