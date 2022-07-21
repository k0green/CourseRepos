using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Override.Новая_папка
{
    internal class Genus:Family
    {
        public string _Genus { get; set; }
        public override Live Fill()
        {
            base.Fill();
            Console.WriteLine("Enter Genus:");
            _Genus = Console.ReadLine();
            return this;
        }
        public override string GetDisplayData()
        {
            return $"{base.GetDisplayData()} Genus: {_Genus}";
        }
    }
}
