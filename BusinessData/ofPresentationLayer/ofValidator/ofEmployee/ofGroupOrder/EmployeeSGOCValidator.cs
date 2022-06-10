using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofGroupOrder;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployee.ofGroupOrder
{
    public class EmployeeSGOCValidator : SGOCValidator<EmployeeSGOC>
    {
        public EmployeeSGOCValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeSGOC>.CreateWithOptions((EmployeeSGOC)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}