using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofValidator.ofCommon.ofPlatform;
using BusinessView.ofValidator.ofCommon.ofProduct;
using FluentValidation;
namespace BusinessView.ofValidator.ofPlatform.ofProduct
{
    public class PlatformProducterValidator : ProducterValidator<PlatformProducter>
    {
        public PlatformProducterValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformProducter>.CreateWithOptions((PlatformProducter)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}