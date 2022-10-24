namespace CarPark.Models
{
    public class UpdateCarRequest
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid UserId { get; set; }
    }
}
