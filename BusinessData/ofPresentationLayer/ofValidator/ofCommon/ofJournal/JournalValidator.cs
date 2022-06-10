using BusinessData.ofPresentationLayer.ofDTO.ofJournal;
using FluentValidation;

namespace BusinessView.ofValidator.ofCommon.ofJournal
{
    public class JournalValidator<TEntity> : EntityDTOValidator<TEntity> where TEntity : JournalDTO
    {
        public JournalValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TEntity>.CreateWithOptions((TEntity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}