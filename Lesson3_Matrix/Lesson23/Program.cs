using Lesson23;

var operat = new Operations();

Dictionary<OperationType, string> operations = new Dictionary<OperationType, string>
{
    {OperationType.PrintAll, "Show all car" },
    {OperationType.Add, "Add new car" },
    {OperationType.Editing, "Edit car" },
    {OperationType.Delete, "Delete car" }

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
            operat.Add();
            break;
        case OperationType.PrintAll:
            operat.PrintAll();
            break;
        case OperationType.Editing:
                operat.Edit();
            break;
        case OperationType.Delete:
            operat.Delete();
            break;
    }
}