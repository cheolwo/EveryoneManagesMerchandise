using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofValidator.ofCommon.ofMarket;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployer.ofMarket
{
    public class EmployerMMCommodityValidator : MMCommodityValidator<EmployerMMCommodity>
    {
        public EmployerMMCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerMMCommodity>.CreateWithOptions((EmployerMMCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}