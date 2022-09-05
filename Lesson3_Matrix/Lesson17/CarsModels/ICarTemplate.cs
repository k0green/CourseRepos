namespace Lesson15_CarCompany.Models
{
    [Serializable]
     abstract class ICarTemplate
    {
        public string Company { get; set; }
        public string Model { get; set; }
        public int Id { get; set; }
        public int Year { get; set; }
        static int number = 1;

        public void Fill()
        {
            Console.WriteLine("Enter Company:");
            Company = Console.ReadLine();
            Console.WriteLine("Enter Model:");
            Model = Console.ReadLine();
            Console.WriteLine("Enter Year:");
            Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Id:");
            Id = Convert.ToInt32(Console.ReadLine());
        }

        public string GetDisplayData()
        {
            number++;
            return $"Car №{number}: Company: {Company} - Model: {Model} - Year: {Year} - Id: {Id}";
        }
    }
}