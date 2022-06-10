using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofValidator.ofCommon.ofProduct;
using FluentValidation;
namespace BusinessView.ofValidator.ofPlatform.ofProduct
{
    public class PlatformProductLandValidator : ProductLandValidator<PlatformProductLand>
    {
        public PlatformProductLandValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformProductLand>.CreateWithOptions((PlatformProductLand)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}