Parallel.Invoke(
    () => {Parallel.ForEach<int>(new List<int>() { 6, 3, 5, 1 }, Print);},
    () => { Parallel.For(1, 5, Sqrtet); },
    () => Parallel.For(1, 5, Square)
);

void Print(int n)
{
    Console.WriteLine($"Выполняется задача {Task.CurrentId}");
    Thread.Sleep(n * 100);
    Console.WriteLine($"Mass {n}");
}
void Square(int n)
{
    Console.WriteLine($"Выполняется задача {Task.CurrentId}");
    Thread.Sleep(3000);
    Console.WriteLine($"Square {n * n}");
}
void Sqrtet(int n)
{
    Console.WriteLine($"Выполняется задача {Task.CurrentId}");
    Parallel.For(5, 9, Sqrtet);
    Thread.Sleep(3000);
    Console.WriteLine($"Sqrtet{Math.Sqrt(n)}");
}
Task task1 = new Task(() =>
{
    Console.WriteLine("Task Starts");
    Thread.Sleep(1000);
    Console.WriteLine("Task Ends");
});
task1.Start();