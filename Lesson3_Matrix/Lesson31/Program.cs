using Lesson31.Models;

Test();
GC.Collect();
Console.ReadLine();

void Test()
{
    Person mike = new Person("Mike");
    mike.Dispose();
    using (Person nik = new Person("Nik"))
    {
        Console.WriteLine($"Name: {nik.Name}");
    }

}