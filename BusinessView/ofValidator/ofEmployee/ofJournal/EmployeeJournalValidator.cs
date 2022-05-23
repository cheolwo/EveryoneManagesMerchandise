using BusinessView.ofDTO.ofJournal.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofEmployee;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployee.ofJournal
{
    public class EmployeeJournalValidator : EmployeeEntityValidator<EmployeeJournal>
    {
        public EmployeeJournalValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeJournal>.CreateWithOptions((EmployeeJournal)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}