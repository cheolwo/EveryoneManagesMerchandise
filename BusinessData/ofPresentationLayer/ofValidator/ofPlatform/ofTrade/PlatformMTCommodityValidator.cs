using BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofPlatform;
using BusinessView.ofValidator.ofCommon.ofTrade;
using FluentValidation;
namespace BusinessView.ofValidator.ofPlatform.ofTrade
{
    public class PlatformMTCommodityValidator : MTCommodityValidator<PlatformMTCommodity>
    {
        public PlatformMTCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformMTCommodity>.CreateWithOptions((PlatformMTCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}