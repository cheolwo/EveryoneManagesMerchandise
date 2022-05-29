using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofEmployee;
using FluentValidation;
using BusinessView.ofValidator.ofCommon.ofGroupOrder;
namespace BusinessView.ofValidator.ofEmployee.ofGroupOrder
{
    public class EmployeeEGOCValidator : EGOCValidator<EmployeeEGOC>
    {
        public EmployeeEGOCValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeEGOC>.CreateWithOptions((EmployeeEGOC)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}