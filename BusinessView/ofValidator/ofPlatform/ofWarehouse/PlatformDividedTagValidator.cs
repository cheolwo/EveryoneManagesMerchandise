using BusinessView.ofValidator.ofCommon.ofWarehouse;
using FluentValidation;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofPlatform;

namespace BusinessView.ofValidator.ofPlatform.ofWarehouse
{
    public class PlatformDividedTagValidator : DividedTagValidator<PlatformDividedTag>
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