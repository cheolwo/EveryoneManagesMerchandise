using BusinessView.ofDTO.ofCommon;
using BusinessView.ofWarehouse;
using FluentValidation;
namespace BusinessView.ofValidator.ofCommon.ofWarehouse
{
    public class IncomingTagValidator<TEntity> : EntityDTOValidator<TEntity> where TEntity : IncomingTagDTO
    {
        public IncomingTagValidator()
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