using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Override.Новая_папка
{
    internal class Order:Class
    {
        public string _Order { get; set; }
        public override Live Fill()
        {
            return base.Fill();
            Console.WriteLine("Enter Order:");
            _Order = Console.ReadLine();
            return this;
        }
        public override string GetDisplayData()
        {
            return $"{base.GetDisplayData()} Order: {_Order} ";
        }
    }
}
