using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofValidator.ofCommon.ofPlatform;
using FluentValidation;
namespace BusinessView.ofValidator.ofPlatform.ofWarehouse
{
    public class PlatformDividedTagValidator : PlatformEntityValidator<PlatformDividedTag>
    {
        public PlatformDividedTagValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformDividedTag>.CreateWithOptions((PlatformDividedTag)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}