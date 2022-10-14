using Garage.Attribute;
using System.ComponentModel.DataAnnotations;

namespace Garage.Models
{
    public class CreateUserRequest
    {
        [UserName(ErrorMessage = "Cars name cannot be shorter then 2 words")]
        public string Name { get; set; }

        [UserPhone(ErrorMessage = "U must enter 13 symbols")]
        public string Phone { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> result = new List<ValidationResult>();

            var c = Phone.Substring(0, Phone.Length-10);
            if (c!="+375")
                result.Add(new ValidationResult("phone must start with +375"));
            if (Name.Length < 2 || Name.Length > 20)
                result.Add(new ValidationResult("invalid name length"));
            if (string.IsNullOrWhiteSpace(Name))
                result.Add(new ValidationResult("no name specified"));
            return result;
        }
    }
}
