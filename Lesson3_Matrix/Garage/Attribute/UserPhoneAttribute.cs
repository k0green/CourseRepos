using System.ComponentModel.DataAnnotations;

namespace Garage.Attribute
{
    public class UserPhoneAttribute:ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            var phone = value.ToString();
            return phone.Length == 13;
        }
    }
}
