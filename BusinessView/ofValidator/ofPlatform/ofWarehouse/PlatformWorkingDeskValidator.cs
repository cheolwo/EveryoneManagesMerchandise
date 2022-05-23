using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofValidator.ofCommon.ofPlatform;
using FluentValidation;

namespace BusinessView.ofValidator.ofPlatform.ofWarehouse
{
    public class PlatformWorkingDeskValidator : PlatformEntityValidator<PlatformWorkingDesk>
    {
        public PlatformWorkingDeskValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformWorkingDesk>.CreateWithOptions((PlatformWorkingDesk)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}