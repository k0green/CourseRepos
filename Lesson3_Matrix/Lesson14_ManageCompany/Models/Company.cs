namespace Lesson14_ManageCompany.Models
{
    internal class Company
    {
        private List<Employee> _employees = new List<Employee>();

        private readonly Random _random = new Random();

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public void PrintAll()
        {
            foreach (var e in _employees)
            {
                Console.WriteLine(e.Display());
            }
        }

        public void FireSomeone()
        {
            var randomIndex = _random.Next(0, _employees.Count - 1);
            _employees.RemoveAt(randomIndex);
        }

        public void PromotionSmd()
        {
            int i = 0;
            foreach (var e in _employees)
            {
                Console.WriteLine($"{i}. {e.Display()}");
                i++;
            }
            Console.WriteLine("Enter people:");
            int num = Convert.ToInt32(Console.ReadLine());
            var man = new Manager(null, null, 0);
            var ex = new Executive(null, null, 0);
            var salem = new SalariedEmployee(null, null, 0);

            Console.WriteLine("Enter new position\n0-Executive\n1-manager\n2-SalariedEmployee:");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 0:
                    ex.Name = _employees[num].Name;
                    ex.Position = _employees[num].Position;
                    ex.BaseSalary = _employees[num].BaseSalary;
                    _employees.Add(ex);
                    _employees.RemoveAt(num);
                    break;
                case 1:
                    man.Name = _employees[num].Name;
                    man.Position = _employees[num].Position;
                    man.BaseSalary = _employees[num].BaseSalary;
                    _employees.Add(man);
                    _employees.RemoveAt(num);
                    break;
                case 2:
                    salem.Name = _employees[num].Name;
                    salem.Position = _employees[num].Position;
                    salem.BaseSalary = _employees[num].BaseSalary;
                    _employees.Add(salem);
                    _employees.RemoveAt(num);
                    break;
                default:
                    Console.WriteLine("Try again");
                    break;
            }


        }
    }
}
