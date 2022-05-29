using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofValidator.ofCommon.ofTrade;
using FluentValidation;
namespace BusinessView.ofValidator.ofPlatform.ofTrade
{
    public class PlatformTradeCenterValidator : TradeCenterValidator<PlatformTradeCenter>
    {
        public PlatformTradeCenterValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformTradeCenter>.CreateWithOptions((PlatformTradeCenter)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}