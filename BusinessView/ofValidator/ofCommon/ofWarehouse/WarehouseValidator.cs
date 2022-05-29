using BusinessView.ofDTO.ofCommon;
using BusinessView.ofWarehouse;
using FluentValidation;
namespace BusinessView.ofValidator.ofCommon.ofWarehouse
{
    public class WarehouseValidator<TCenter> : CenterDTOValidator<TCenter> where TCenter : WarehouseDTO
    {
        public WarehouseValidator()
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