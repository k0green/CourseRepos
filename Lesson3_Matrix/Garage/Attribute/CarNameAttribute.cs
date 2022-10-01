using System.ComponentModel.DataAnnotations;

namespace Garage.Attribute
{
    public class CarNameAttribute:ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            var carName = value.ToString();
            return carName.Split(" ").Length >= 2;
        }
    }
}
