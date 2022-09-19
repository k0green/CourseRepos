namespace Lesson23
{
    public class Operations
    {
        public void PrintAll()
        {

            var context = new autoparkContext();
            context.Cars
                      .Select(x => $"{x.Id} {x.Model} {x.Number} {x.OwnerId}")
                      .ToList()
                      .ForEach(x => Console.WriteLine(x));

        }

        public void Add()
        {
            var context = new autoparkContext();
            Car car = new Car();
            car=car.Fill();
            context.Cars.Add(car);
            context.SaveChanges();
        }

        public async void Edit()
        {
            PrintAll();
            var context = new autoparkContext();
            Console.WriteLine("Enter car id to edit");
            int id = Convert.ToInt32(Console.ReadLine());
            Car car = context.Cars.FirstOrDefault(x => x.Id == id);
            context.Cars.Remove(car);
            car=car.Fill();
            context.Cars.Update(car);
            await context.SaveChangesAsync();

        }

        public async void Delete()
        {
            PrintAll();
            var context = new autoparkContext();
            Console.WriteLine("Enter car id to delete");
            int id = Convert.ToInt32(Console.ReadLine());
            Car car = context.Cars.FirstOrDefault(x => x.Id == id);
            context.Cars.Remove(car);
            await context.SaveChangesAsync();
        }

        private void Fill()
        {
            Car car1 = new Car();
            Console.WriteLine("Enter car model");
            car1.Model = Console.ReadLine();
            Console.WriteLine("Enter car number in format 1111-AA1");
            car1.Number = Console.ReadLine();
            Console.WriteLine("Enter owner's id");
            car1.OwnerId = Convert.ToInt32(Console.ReadLine());
        }

    }
}
