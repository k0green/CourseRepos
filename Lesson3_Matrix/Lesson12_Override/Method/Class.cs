using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Override.Новая_папка
{
    internal class Class:Division
    {
        public string _Class { get; set; }
        public override Live Fill()
        {
            base.Fill();
            Console.WriteLine("Enter Class:");
            _Class = Console.ReadLine();
            return this;
        }
        public override string GetDisplayData()
        {
            return $"{base.GetDisplayData()} Class: {_Class} ";
        }
    }
}
