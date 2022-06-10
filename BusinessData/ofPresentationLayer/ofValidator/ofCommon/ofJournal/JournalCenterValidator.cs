using BusinessData.ofPresentationLayer.ofDTO.ofJournal;
using FluentValidation;

namespace BusinessView.ofValidator.ofCommon.ofJournal
{
    public class JournalCenterValidator<TCenter> : CenterDTOValidator<TCenter> where TCenter : JournalCenterDTO
    {
        public JournalCenterValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TCenter>.CreateWithOptions((TCenter)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}