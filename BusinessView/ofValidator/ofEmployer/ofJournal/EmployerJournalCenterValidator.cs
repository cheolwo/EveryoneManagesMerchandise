using BusinessView.ofDTO.ofJournal.ofEmployer;
using BusinessView.ofValidator.ofCommon.ofEmployer;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployer.ofJournal
{
    public class EmployerJournalCenterValidator : EmployerCenterValidator<EmployerJournalCenter>
    {
        public EmployerJournalCenterValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerJournalCenter>.CreateWithOptions((EmployerJournalCenter)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}