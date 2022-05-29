using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofValidator.ofCommon.ofTrade;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployer.ofTrade
{
    public class EmployerTCommodityValidator : TCommodityValidator<EmployerTCommodity>
    {
        public EmployerTCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerTCommodity>.CreateWithOptions((EmployerTCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}