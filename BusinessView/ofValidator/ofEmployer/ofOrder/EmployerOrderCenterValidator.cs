using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofValidator.ofCommon.ofEmployer;
using BusinessView.ofValidator.ofCommon.ofOrder;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployer.ofOrder
{
    public class EmployerOrderCenterValidator : OrderCenterValidator<EmployerOrderCenter>
    {
        public EmployerOrderCenterValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerOrderCenter>.CreateWithOptions((EmployerOrderCenter)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}