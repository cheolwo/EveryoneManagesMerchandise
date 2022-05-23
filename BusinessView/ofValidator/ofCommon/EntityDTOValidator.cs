using BusinessView.ofDTO.ofCommon;
using FluentValidation;

namespace BusinessView.ofValidator.ofCommon
{
    public class EntityDTOValidator<TEntity> : AbstractValidator<TEntity> where TEntity : EntityDTO
    {
        public EntityDTOValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .Length(1,100);
        }
        public virtual Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TEntity>.CreateWithOptions((TEntity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}