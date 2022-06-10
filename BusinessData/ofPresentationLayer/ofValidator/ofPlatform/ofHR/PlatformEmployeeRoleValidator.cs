using BusinessView.ofValidator.ofCommon.ofHR;
using FluentValidation;
using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofPlatform;

namespace BusinessView.ofValidator.ofPlatform.ofHR
{
    public class PlatformEmployeeRoleValidator : EmployeeRoleValidator<PlatformEmployeeRole>
    {
        public PlatformEmployeeRoleValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformEmployeeRole>.CreateWithOptions((PlatformEmployeeRole)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}