using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofGroupOrder;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployee.ofGroupOrder
{
    public class EmployeeMGOCValidator : MGOCValidator<EmployeeMGOC>
    {
        public EmployeeMGOCValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeMGOC>.CreateWithOptions((EmployeeMGOC)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}