using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofValidator.ofCommon.ofEmployer;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployer.ofGroupOrder
{
    public class EmployerGOCCValidator : EmployerCommodityValidator<EmployerGOCC>
    {
        public EmployerGOCCValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerGOCC>.CreateWithOptions((EmployerGOCC)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}