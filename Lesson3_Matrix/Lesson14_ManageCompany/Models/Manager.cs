using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_ManageCompany.Models
{
    internal class Manager:Employee
    {
        public Manager(string name, string position, int baseSalary) : base(name, position, baseSalary)
        {
            Name = name;
            Position = position;
            BaseSalary = baseSalary;
        }


        public override int Salary { get { return BaseSalary * 3; } set => BaseSalary = value; }
        public override string Display()
        {
            return ($"I'm a Manager. Name: {Name}, Position: {Position}, Salary {Salary}");
        }
        public static implicit operator Manager(HourlyEmployee he)
        {
            return new Manager(he.Name, he.Position, he.BaseSalary);
        }
        public static implicit operator Manager(SalariedEmployee se)
        {
            return new Manager(se.Name, se.Position, se.BaseSalary);
        }
    }
}
