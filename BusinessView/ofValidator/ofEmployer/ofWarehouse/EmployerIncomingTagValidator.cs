using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofValidator.ofCommon.ofEmployer;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployer.ofWarehouse
{
    public class EmployerIncomingTagValidator : EmployerEntityValidator<EmployerIncomingTag>
    {
        public EmployerIncomingTagValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerIncomingTag>.CreateWithOptions((EmployerIncomingTag)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}