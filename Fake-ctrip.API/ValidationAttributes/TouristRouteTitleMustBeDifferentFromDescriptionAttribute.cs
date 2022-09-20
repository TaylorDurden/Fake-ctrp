using Fake_ctrip.API.Dtos;
using System.ComponentModel.DataAnnotations;

namespace Fake_ctrip.API.ValidationAttributes
{
    public class TouristRouteTitleMustBeDifferentFromDescriptionAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var touristRouteDto = (CreateTouristRouteComand)validationContext.ObjectInstance;
            if (touristRouteDto.Title == touristRouteDto.Description)
            {
                return new ValidationResult(
                    "Title should not be the same with description.",
                    new[] { "CreateTouristRouteComand " });
            }
            return ValidationResult.Success;
        }
    }
}
