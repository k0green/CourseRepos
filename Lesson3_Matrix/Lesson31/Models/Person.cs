namespace Lesson31.Models
{
    public class Person : IDisposable
    {
        public string Name { get; set; }

        public Person(string name) => Name = name;
        ~Person()
        {
            Console.WriteLine($"{Name} was deleted");
        }

        public void Dispose()
        {
            Console.WriteLine($"{Name} was disposed");
        }
    }
}
