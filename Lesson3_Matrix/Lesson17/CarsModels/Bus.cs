namespace Lesson15_CarCompany.Models
{
    [Serializable]
    internal class Bus : ICarTemplate
    {
        public string? Company { get; set; }
        public string? Model { get; set; }
        public int Id { get; set; }
        public int Year { get; set; }

    }
}