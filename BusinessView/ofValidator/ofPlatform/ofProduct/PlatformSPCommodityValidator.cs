using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofValidator.ofCommon.ofPlatform;
using FluentValidation;
namespace BusinessView.ofValidator.ofPlatform.ofProduct
{
    public class PlatformSPCommodityValidator : PlatformStatusValidator<PlatformSPCommodity>
    {
        public PlatformSPCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformSPCommodity>.CreateWithOptions((PlatformSPCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}