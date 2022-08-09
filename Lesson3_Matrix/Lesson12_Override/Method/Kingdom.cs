using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Override
{
    internal class Kingdom:Domain
    {
        public string _Kingdom { get; set; }
        public override Live Fill()
        {
            return base.Fill();
            Console.WriteLine("Enter Kindom:");
            _Kingdom = Console.ReadLine();
            return this;
        }
        public override string GetDisplayData()
        {
            return base.GetDisplayData();
        }
    }
}
