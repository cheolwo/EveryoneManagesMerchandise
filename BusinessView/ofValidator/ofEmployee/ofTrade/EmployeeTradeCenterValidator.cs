using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofEmployee;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployee.ofTrade
{
    public class EmployeeTradeCenterValidator : EmployeeCenterValidator<EmployeeTradeCenter>
    {
        public EmployeeTradeCenterValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeTradeCenter>.CreateWithOptions((EmployeeTradeCenter)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}