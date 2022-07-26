using Lesson14_ManageCompany.Enums;

namespace Lesson14_ManageCompany.Constants
{
    internal class OperationsType
    {
        public static Dictionary<OperationType, string> Texts = new Dictionary<OperationType, string>
        {
            { OperationType.Add, "Add new employee" },
            { OperationType.ShowAll, "Show all employees" },
            { OperationType.Fire, "Fire someone" }
        };
    }
}
