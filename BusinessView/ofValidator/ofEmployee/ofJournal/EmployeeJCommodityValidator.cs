using BusinessView.ofDTO.ofJournal.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofJournal;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployee.ofJournal
{
    public class EmployeeJCommodityValidator : JCommodityValidator<EmployeeJCommodity>
    {
        public EmployeeJCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeJCommodity>.CreateWithOptions((EmployeeJCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}