using System;
using System.Collections.Generic;

namespace Lesson23
{
    public partial class Car
    {
        public Car()
        {
            Garages = new HashSet<Garage>();
        }

        public int Id { get; set; }
        public string? Number { get; set; }
        public string? Model { get; set; }
        public int? OwnerId { get; set; }

        public virtual Driver? Owner { get; set; }
        public virtual ICollection<Garage> Garages { get; set; }


        public Car Fill()
        {
            Car car = new Car();
            Console.WriteLine("Enter car model");
            car.Model = Console.ReadLine();
            Console.WriteLine("Enter car number in format 1111-AA1");
            car.Number = Console.ReadLine();
            Console.WriteLine("Enter owner's id");
            car.OwnerId = Convert.ToInt32(Console.ReadLine());
            return car;
        }
    }
}
