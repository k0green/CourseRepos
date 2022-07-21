using Lesson12_Override;
using Lesson12_Override.Enums;
using Lesson12_Override.Method;
using Lesson12_Override.Новая_папка;

var registry = new Registry();

Dictionary<Operations, string> operations = new Dictionary<Operations, string>
{
        {Operations.Add, "Add new animal" },
    {Operations.ShowAll, "Show all animal" }
};

Dictionary<AnimalTypes, string> animal = new Dictionary<AnimalTypes, string>
{
        {AnimalTypes.Domain, "Domain" },
    {AnimalTypes.Kingdom, "Kingdom" },
    {AnimalTypes.Division, "Division" },
    {AnimalTypes.Class, "Class" },
    {AnimalTypes.Order, "Order" },
    {AnimalTypes.Family, "Family" },
    {AnimalTypes.Genus, "Genus" },
    {AnimalTypes.Species, "Species" },
};

while (true)
{
    foreach (var o in operations)
    {
        Console.WriteLine($"Press ({(int)o.Key}) to ({o.Value})");
    }
    Operations operation = (Operations)int.Parse(Console.ReadLine());

    switch (operation)
    {
        case Operations.Add:
            foreach (var at in animal)
            {
                Console.WriteLine($"Press ({(int)at.Key}) to ({at.Value})");
            }
            AnimalTypes animalTypes = (AnimalTypes)int.Parse(Console.ReadLine());
            switch (animalTypes)
            {
                case AnimalTypes.Domain:
                    registry.Add(new Domain().Fill());
                    break;
                case AnimalTypes.Kingdom:
                    registry.Add(new Kingdom().Fill());
                    break;
                case AnimalTypes.Division:
                    registry.Add(new Division().Fill());
                    break;
                case AnimalTypes.Class:
                    registry.Add(new Class().Fill());
                    break;
                case AnimalTypes.Order:
                    registry.Add(new Order().Fill());
                    break;
                case AnimalTypes.Family:
                    registry.Add(new Family().Fill());
                    break;
                case AnimalTypes.Genus:
                    registry.Add(new Genus().Fill());
                    break;
                case AnimalTypes.Species:
                    registry.Add(new Species().Fill());
                    break;

            }
            break;
        case Operations.ShowAll:
            registry.PrintAll();
            break;
    }
}