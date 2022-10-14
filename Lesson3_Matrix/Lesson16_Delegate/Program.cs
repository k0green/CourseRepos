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

carParkAdministration.Notify+=(msg)=>Console.WriteLine(msg);
//carParkAdministration.Notify+=(msg)=>Console.WriteLine($"Sved to logs: {msg}");
var messages = new List<string>();
carParkAdministration.Notify+=(msg)=>messages.Add(msg);

Dictionary<CarType, string> cars = new Dictionary<CarType, string>
{
    {CarType.truck, "Truck" },
    {CarType.tractor, "Tractor" },
    {CarType.car, "Car" },
    {CarType.bus, "Bus" },
};

Dictionary<OperationType, Action> operations = new Dictionary<OperationType, Action>
{
    {OperationType.Add, delegate(){
     foreach (var at in cars)
            {
                Console.WriteLine($"Press ({(int)at.Key}) to ({at.Value})");
            }
            CarType carTypes = (CarType)int.Parse(Console.ReadLine());
            switch (carTypes)
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
            }}},
    {OperationType.ShowAll, carParkAdministration.PrintAll },
    {OperationType.Remove, carParkAdministration.RemoveCar },    
    {OperationType.PrintLogs, carParkAdministration.PrintLogos },
    {OperationType.FinishWork, carParkAdministration.FinishProgWork }
};

bool i=true;
while (i)
{
    foreach (var o in operations)
    {
        Console.WriteLine($"Press ({(int)o.Key}) to ({o.Value.ToString()})");
    }
    OperationType operation = (OperationType)int.Parse(Console.ReadLine());
    if (operation == OperationType.FinishWork) i = false;
    if(operation == OperationType.PrintLogs)
    {
        foreach(var mess in messages)
        {
            Console.WriteLine($"{mess }");
        }
    }


    operations[operation]();
}
