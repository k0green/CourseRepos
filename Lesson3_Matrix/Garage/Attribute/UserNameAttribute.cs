using System.ComponentModel.DataAnnotations;

namespace Garage.Attribute
{
    public class UserNameAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            var userName = value.ToString();
            return userName.Split(" ").Length >= 2;
        }
    }
}
