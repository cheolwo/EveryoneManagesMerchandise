using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofProduct;
using FluentValidation;

namespace BusinessView.ofValidator.ofCommon.ofProduct
{
    public class ProductLandValidator<TEntity> : EntityDTOValidator<TEntity> where TEntity : ProductLandDTO
    {
        public ProductLandValidator()
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