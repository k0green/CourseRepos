using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Override.Method
{
    internal static class ConsoleExtensions
    {
        public static string GetStringFromConsole(string message)
        {
            Console.WriteLine($"{message}:");
            return Console.ReadLine();
        }
    }
}
