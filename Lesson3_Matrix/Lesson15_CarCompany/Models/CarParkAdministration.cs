namespace Lesson15_CarCompany.Models
{
    internal class CarParkAdministration : ICloneable
    {
        public List<ICarTemplate> _cars = new List<ICarTemplate>();

        public void Add(ICarTemplate carTemplat)
        {
            _cars.Add(carTemplat);
        }

        public object Clone() => MemberwiseClone();

        public void PrintAll()
        {
            foreach (var l in _cars)
            {
                Console.WriteLine($"{l.GetType().Name}::  {l.GetDisplayData()}");
            }
        }
        public void RemoveCar()
        {
            int i = 0;
            foreach (var l in _cars)
            {
                Console.WriteLine($"{i}. {l.GetDisplayData()}");
                i++;
            }
            Console.WriteLine("enter num of car to remove");
            int num = Convert.ToInt32(Console.ReadLine());
            _cars.RemoveAt(num);
        }
    }
}
