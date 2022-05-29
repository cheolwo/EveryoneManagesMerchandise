using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofCommon.ofTrade;
using FluentValidation;
namespace BusinessView.ofValidator.ofCommon.ofTrade
{
    public class TradeCenterValidator<TCenter> : CenterDTOValidator<TCenter> where TCenter : TradeCenterDTO
    {
        public TradeCenterValidator()
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