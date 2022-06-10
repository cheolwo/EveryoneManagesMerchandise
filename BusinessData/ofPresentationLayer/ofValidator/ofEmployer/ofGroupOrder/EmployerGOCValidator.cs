using BusinessView.ofValidator.ofCommon.ofGroupOrder;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployer;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployer.ofGroupOrder
{
    public class EmployerGOCValidator : GOCValidator<EmployerGOC>
    {
        public EmployerGOCValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerGOC>.CreateWithOptions((EmployerGOC)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}