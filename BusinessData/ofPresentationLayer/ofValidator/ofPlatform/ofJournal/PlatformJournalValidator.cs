using BusinessView.ofValidator.ofCommon.ofJournal;
using FluentValidation;
using BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofPlatform;
namespace BusinessView.ofValidator.ofPlatform.ofJournal
{
    public class PlatformJournalValidator : JournalValidator<PlatformJournal>
    {
        public PlatformJournalValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformJournal>.CreateWithOptions((PlatformJournal)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}