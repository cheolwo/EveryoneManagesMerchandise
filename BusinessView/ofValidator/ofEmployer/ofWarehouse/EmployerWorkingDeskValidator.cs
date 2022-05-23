using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofValidator.ofCommon.ofEmployer;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployer.ofWarehouse
{
    public class EmployerWorkingDeskValidator : EmployerEntityValidator<EmployerWorkingDesk>
    {
        public EmployerWorkingDeskValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerWorkingDesk>.CreateWithOptions((EmployerWorkingDesk)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}