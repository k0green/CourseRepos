using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_CarCompany.Models
{
    internal class Car:ICarTemplate, ICloneable, IComparable<Car>
    {
        public string Company { get; set; }
        public string Model { get; set; }
        public int Id { get; set; }
        public int Year { get; set; }

        public Car()
        {
            Company = "Toyota";
            Model = "Camry";
            Id=0;
            Year=2009;
        }

        public object Clone() => MemberwiseClone();
        public void GetInfo()
        {
            Console.WriteLine($"Car: Company: {Company} - Model: {Model} - Year: {Year} - Id: {Id}");
        }

        public int CompareTo(Car? other)
        {
            if (other is Car car) return Company.CompareTo(car.Company);
            else throw new ArgumentException("Некорректное значение параметра");
        }
    }
}
