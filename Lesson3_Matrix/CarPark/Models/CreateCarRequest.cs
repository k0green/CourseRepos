namespace CarPark.Models
{
    public class CreateCarRequest
    {
        public string Name { get; set; }

        public Guid UserId { get; set; }
    }
}
