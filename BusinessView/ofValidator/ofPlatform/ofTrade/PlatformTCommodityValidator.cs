using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofValidator.ofCommon.ofTrade;
using FluentValidation;
namespace BusinessView.ofValidator.ofPlatform.ofTrade
{
    public class PlatformTCommodityValidator : TCommodityValidator<PlatformTCommodity>
    {
        public PlatformTCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformTCommodity>.CreateWithOptions((PlatformTCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}