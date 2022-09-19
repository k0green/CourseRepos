using Lesson23;

var context = new autoparkContext();
context.Cars
    .Select(x => $"{x.Number} {x.Model} {x.Id} {(x.Owner == null ? "[empty]" : x.Owner.Surname)} {(x.Owner == null ? "[empty]" : x.Owner.Name)}")
    .ToList()
    .ForEach(x => Console.WriteLine(x));

Car toyota = new Car();
toyota.Number = "1122-TT7";
toyota.Model = "Toyota Camry";
toyota.OwnerId = 1;

Car Chevrolet = new Car();
Chevrolet.Number = "0000-OO7";
Chevrolet.Model = "Chevrolet Corvett";
Chevrolet.OwnerId = 5;

Car car = context.Cars.FirstOrDefault();

context.Cars.Add(toyota);
context.SaveChanges();
Console.WriteLine("--------------------------------------------------------");
context.Cars
    .Select(x => $"{x.Number} {x.Id} {(x.Owner == null ? "[empty]" : x.Owner.Surname)} {(x.Owner == null ? "[empty]" : x.Owner.Name)}")
    .ToList()
    .ForEach(x => Console.WriteLine(x));

car.Number = Chevrolet.Number;
car.Model = Chevrolet.Model;
context.SaveChanges();
Console.WriteLine("--------------------------------------------------------");
context.Cars
    .Select(x => $"{x.Number} {x.Id} {(x.Owner == null ? "[empty]" : x.Owner.Surname)} {(x.Owner == null ? "[empty]" : x.Owner.Name)}")
    .ToList()
    .ForEach(x => Console.WriteLine(x));