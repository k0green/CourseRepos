using Lesson15_CarCompany.Enums;
using Lesson15_CarCompany.Models;

Car car1 = new Car();
var car2 = (Car)car1.Clone();
car1.GetInfo();
car2.GetInfo();

var t = new Car();
t.Company = "t";
var b = new Car();
b.Company = "b";
var s = new Car();
s.Company = "s";

Car[] cas = { t, b, s };
Array.Sort(cas);

foreach (Car car in cas)
{
    Console.WriteLine($"{car.Company}");
}

var carParkAdministration = new CarParkAdministration();

Dictionary<OperationType, string> operations = new Dictionary<OperationType, string>
{
        {OperationType.Add, "Add new car" },
    {OperationType.ShowAll, "Show all car" },
    {OperationType.Remove, "Remove car" }
};

Dictionary<CarType, string> cars = new Dictionary<CarType, string>
{
    {CarType.truck, "Truck" },
    {CarType.tractor, "Tractor" },
    {CarType.car, "Car" },
    {CarType.bus, "Bus" },
};

while (true)
{
    foreach (var o in operations)
    {
        Console.WriteLine($"Press ({(int)o.Key}) to ({o.Value})");
    }
    OperationType operation = (OperationType)int.Parse(Console.ReadLine());

    switch (operation)
    {
        case OperationType.Add:
            foreach (var at in cars)
            {
                Console.WriteLine($"Press ({(int)at.Key}) to ({at.Value})");
            }
            CarType animalTypes = (CarType)int.Parse(Console.ReadLine());
            switch (animalTypes)
            {
                case CarType.car:
                    ICarTemplate car = new Car();
                    car.Fill();
                    carParkAdministration.Add(car);
                    break;
                case CarType.truck:
                    ICarTemplate truck = new Truck();
                    truck.Fill();
                    carParkAdministration.Add(truck);
                    break;
                case CarType.bus:
                    ICarTemplate bus = new Bus();
                    bus.Fill();
                    carParkAdministration.Add(bus);
                    break;
                case CarType.tractor:
                    ICarTemplate tractor = new Tractor();
                    tractor.Fill();
                    carParkAdministration.Add(tractor);
                    break;
            }
            break;
        case OperationType.ShowAll:
            carParkAdministration.PrintAll();
            break;
        case OperationType.Remove:
            carParkAdministration.RemoveCar();
            break;
    }

}