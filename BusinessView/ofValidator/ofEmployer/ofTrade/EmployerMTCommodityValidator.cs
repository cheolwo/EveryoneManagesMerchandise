using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofValidator.ofCommon.ofTrade;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployer.ofTrade
{
    public class EmployerMTCommodityValidator : MTCommodityValidator<EmployerMTCommodity>
    {
        public EmployerMTCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerMTCommodity>.CreateWithOptions((EmployerMTCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}