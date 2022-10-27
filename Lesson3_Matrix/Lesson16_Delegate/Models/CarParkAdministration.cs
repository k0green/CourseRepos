namespace Lesson15_CarCompany.Models
{
    internal class CarParkAdministration : ICloneable
    {
        public List<ICarTemplate> _cars = new List<ICarTemplate>();
        public event NotificationHandler? Notify;

        public void Add(ICarTemplate carTemplat)
        {
            _cars.Add(carTemplat);
            Notify?.Invoke($"Car {carTemplat.Company} {carTemplat.Model} was add");
        }

        public object Clone() => MemberwiseClone();

        public void PrintAll()
        {
            Notify?.Invoke("Display all cars in park:\n\n");
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
            Notify?.Invoke("Car was remove");
        }
        public void FinishProgWork() { }
        public void PrintLogos() { }
        public delegate void NotificationHandler(string msg);
    }
}