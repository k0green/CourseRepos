using Lesson14_ManageCompany.Enums;

namespace Lesson14_ManageCompany.Constants
{
    internal static class EmployeesType
    {
        public static Dictionary<EmployeeType, string> Texts = new Dictionary<EmployeeType, string>
        {
            { EmployeeType.HourluyEmployee, "Hourly Employee" },
            { EmployeeType.SalariedEmployee, "Salaried Employee" },
            { EmployeeType.Manager, "manager" },
            { EmployeeType.Executive, "Executive" },
        };
    }
}
