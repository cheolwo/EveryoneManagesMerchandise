using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofHR;
using FluentValidation;
namespace BusinessView.ofValidator.ofCommon.ofHR
{
    public class HREmployeeValidator<TEntity> : EntityDTOValidator<TEntity> where TEntity : HREmployeeDTO
    {
        public HREmployeeValidator()
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