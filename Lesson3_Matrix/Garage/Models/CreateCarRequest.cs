using Garage.Attribute;
using System.ComponentModel.DataAnnotations;

namespace Garage.Models
{
    public class CreateCarRequest
    {
        [CarName(ErrorMessage = "Cars name cannot be shorter then 2 words")]
        public string Name { get; set; }

        [Required]
        public int UserId { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> result = new List<ValidationResult>();

            if (UserId < 0)
                result.Add(new ValidationResult("ivalid id"));
            if (Name.Length < 2 || Name.Length > 20)
                result.Add(new ValidationResult("invalid name length"));
            if (string.IsNullOrWhiteSpace(Name))
                result.Add(new ValidationResult("no name specified"));
            return result;
        }
    }
}
