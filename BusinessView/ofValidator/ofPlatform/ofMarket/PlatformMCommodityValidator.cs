using BusinessView.ofValidator.ofCommon.ofMarket;
using FluentValidation;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofPlatform;
namespace BusinessView.ofValidator.ofPlatform.ofMarket
{
    public class PlatformMCommodityValidator : MCommodityValidator<PlatformMCommodity>
    {
        public PlatformMCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformMCommodity>.CreateWithOptions((PlatformMCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}