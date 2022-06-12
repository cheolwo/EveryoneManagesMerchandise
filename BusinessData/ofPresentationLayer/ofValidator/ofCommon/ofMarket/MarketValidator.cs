using BusinessData.ofPresentationLayer.ofDTO.ofMarket;
using FluentValidation;
namespace BusinessView.ofValidator.ofCommon.ofMarket
{
    public class MarketValidator<TCenter> : CenterDTOValidator<TCenter> where TCenter : MarketDTO
    {
        public MarketValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TCenter>.CreateWithOptions((TCenter)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}