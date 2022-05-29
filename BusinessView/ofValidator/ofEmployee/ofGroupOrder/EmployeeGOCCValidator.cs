using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofGroupOrder;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployee.ofGroupOrder
{
    public class EmployeeGOCCValidator : GOCCValidator<EmployeeGOCC>
    {
        public EmployeeGOCCValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeGOCC>.CreateWithOptions((EmployeeGOCC)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}