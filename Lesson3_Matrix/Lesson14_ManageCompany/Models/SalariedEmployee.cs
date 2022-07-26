using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_ManageCompany.Models
{
    internal class SalariedEmployee : Employee
    {
        public SalariedEmployee(string name, string position, int baseSalary) : base(name, position, baseSalary)
        {
            Name = name;
            Position = position;
            BaseSalary = baseSalary;
        }
        

        public override int Salary { get { return BaseSalary * 2; } set => BaseSalary=value; }
        public override string Display()
        {
            return ($"Name: {Name}, Position: {Position}, Salary {Salary}");
        }
    }
}
