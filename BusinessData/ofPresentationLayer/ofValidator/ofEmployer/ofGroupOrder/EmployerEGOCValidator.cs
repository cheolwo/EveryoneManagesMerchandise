using FluentValidation;
using BusinessView.ofValidator.ofCommon.ofGroupOrder;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployer;

namespace BusinessView.ofValidator.ofEmployer.ofGroupOrder
{
    public class EmployerEGOCValidator : EGOCValidator<EmployerEGOC>
    {
        public EmployerEGOCValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerEGOC>.CreateWithOptions((EmployerEGOC)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}