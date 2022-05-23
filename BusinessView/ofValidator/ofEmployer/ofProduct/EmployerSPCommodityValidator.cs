using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofValidator.ofCommon.ofEmployer;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployer.ofProduct
{
    public class EmployerSPCommodityValidator : EmployerStatusValidator<EmployerSPCommodity>
    {
        public EmployerSPCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerSPCommodity>.CreateWithOptions((EmployerSPCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}