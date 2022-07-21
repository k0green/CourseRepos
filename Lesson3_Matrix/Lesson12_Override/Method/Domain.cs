using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Override
{
    internal class Domain : Live
    {
        public string _Domain { get; set; }

        public override Live Fill()
        {
            base.Fill();
            Console.WriteLine("Enter Domain:");
            _Domain = Console.ReadLine();
            return this;
        }

        public override string GetDisplayData()
        {
            return $"{base.GetDisplayData()} Domain: {_Domain} ";
        }

    }
}
