using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofOrder;
using FluentValidation;
namespace BusinessView.ofValidator.ofCommon.ofOrder
{
    public class OrderCenterValidator<TCenter> : CenterDTOValidator<TCenter> where TCenter : OrderCenterDTO
    {
        public OrderCenterValidator()
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