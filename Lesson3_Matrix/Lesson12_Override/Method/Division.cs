using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Override.Новая_папка
{
    internal class Division : Live //Kingdom
    {
        public string _Division { get; set; }
        public override Live Fill()
        {
            return base.Fill();
            Console.WriteLine("Enter Division:");
            _Division = Console.ReadLine();
            return this;
        }
        public override string GetDisplayData()
        {
            return $"{base.GetDisplayData()} Division: {_Division} ";
        }
    }
}
