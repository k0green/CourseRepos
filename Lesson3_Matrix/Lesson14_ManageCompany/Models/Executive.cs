using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_ManageCompany.Models
{
    internal class Executive:Employee
    {

        public Executive(string name, string position, int baseSalary) : base(name, position, baseSalary)
        {
            Name = name;
            Position = position;
            BaseSalary = baseSalary;
        }


        public override int Salary { get { return BaseSalary * 4; } set => BaseSalary = value; }
        public override string Display()
        {
            return ($"I'm Executive. Name: {Name}, Position: {Position}, Salary {Salary}");
        }

        public static explicit operator Executive(Manager m)
        {
            return new Executive(m.Name, m.Position, m.BaseSalary);
        }

        public static implicit operator Executive(HourlyEmployee he)
        {
            return new Executive(he.Name, he.Position, he.BaseSalary);
        }
        public static implicit operator Executive(SalariedEmployee se)
        {
            return new Executive(se.Name, se.Position, se.BaseSalary);
        }
    }
}
