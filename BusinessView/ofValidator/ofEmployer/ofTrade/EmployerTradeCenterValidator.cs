using BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofEmployer;
using BusinessView.ofValidator.ofCommon.ofTrade;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployer.ofTrade
{
    public class EmployerTradeCenterValidator : TradeCenterValidator<EmployerTradeCenter>
    {
        public EmployerTradeCenterValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerTradeCenter>.CreateWithOptions((EmployerTradeCenter)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}