using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_ManageCompany.Models
{
    internal class Company
    {
        private List<Employee> _employees = new List<Employee>();

        private readonly Random _random = new Random();

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public void PrintAll()
        {
            foreach (var e in _employees)
            {
                Console.WriteLine(e.Display());
            }
        }

        public void FireSomeone()
        {
            var randomIndex = _random.Next(0, _employees.Count - 1);
            _employees.RemoveAt(randomIndex);
        }
    }
}
