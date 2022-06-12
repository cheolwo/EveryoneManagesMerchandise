using BusinessView.ofValidator.ofCommon.ofMarket;
using FluentValidation;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofPlatform;
namespace BusinessView.ofValidator.ofPlatform.ofMarket
{
    public class PlatformMarketValidator : MarketValidator<PlatformMarket>
    {
        public PlatformMarketValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformMarket>.CreateWithOptions((PlatformMarket)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}