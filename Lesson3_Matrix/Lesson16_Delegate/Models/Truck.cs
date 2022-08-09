namespace Lesson15_CarCompany.Models
{
    internal class Truck : ICarTemplate
    {
        public string? Company { get; set; }
        public string? Model { get; set; }
        public int Id { get; set; }
        public int Year { get; set; }

    }
}