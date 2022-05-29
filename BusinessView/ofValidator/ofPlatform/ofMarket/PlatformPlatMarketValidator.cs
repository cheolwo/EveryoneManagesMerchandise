using BusinessView.ofDTO.ofMarket.ofPlatform;
using BusinessView.ofValidator.ofCommon.ofPlatform;
using BusinessView.ofValidator.ofCommon.ofMarket;
using FluentValidation;
namespace BusinessView.ofValidator.ofPlatform.ofMarket
{
    public class PlatformPlatMarketValidator : PlatMarketValidator<PlatformPlatMarket>
    {
        public PlatformPlatMarketValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformPlatMarket>.CreateWithOptions((PlatformPlatMarket)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}