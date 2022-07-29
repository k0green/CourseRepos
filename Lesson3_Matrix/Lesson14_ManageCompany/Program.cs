using Lesson14_ManageCompany.Models;
using Lesson14_ManageCompany.Enums;
using Lesson14_ManageCompany.Constants;

var company = new Company();

while (true)
{
    foreach (var o in OperationsType.Texts)
    {
        Console.WriteLine($"Press ({(int)o.Key}) to {o.Value}");
    }

    OperationType operation = (OperationType)int.Parse(Console.ReadLine());

    switch (operation)
    {
        case OperationType.Add:
            foreach (var et in EmployeesType.Texts)
            {
                Console.WriteLine($"Press ({(int)et.Key}) to add {et.Value}");
            }

            EmployeeType employeeType = (EmployeeType)int.Parse(Console.ReadLine());

            switch (employeeType)
            {
                case EmployeeType.HourluyEmployee:
                    company.Add(new HourlyEmployee("Jame", "Actor", 300));
                    break;
                case EmployeeType.SalariedEmployee:
                    company.Add(new SalariedEmployee("Mike", "Accictan", 280));
                    break;
                case EmployeeType.Manager:
                    company.Add(new Manager("Kal", "Deputy Director", 710));
                    break;
                case EmployeeType.Executive:
                    company.Add(new Executive("Jorge", "CEO", 2134));
                    break;
            }

            break;
        case OperationType.Fire:
            company.FireSomeone();
            break;
        case OperationType.ShowAll:
            company.PrintAll();
            break;
        case OperationType.Promotion:
            company.PromotionSmd();
            break;
    }
}