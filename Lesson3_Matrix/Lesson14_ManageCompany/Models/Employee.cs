using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_ManageCompany.Models
{
    abstract class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int BaseSalary { get; set; }

        public abstract int Salary { get; set; }
        public Employee(string name, string position, int baseSalary)
        {
            Name = name;
            Position = position;
            BaseSalary = baseSalary;
        }
        public virtual string Display()
        {
            return ($"Name: {Name}, Position: {Position}, Salary{BaseSalary}");
        }
    }
}
