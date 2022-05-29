using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofValidator.ofCommon.ofEmployer;
using FluentValidation;
using BusinessView.ofValidator.ofCommon.ofGroupOrder;
namespace BusinessView.ofValidator.ofEmployer.ofGroupOrder
{
    public class EmployerSGOCValidator : SGOCValidator<EmployerSGOC>
    {
        public EmployerSGOCValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerSGOC>.CreateWithOptions((EmployerSGOC)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}