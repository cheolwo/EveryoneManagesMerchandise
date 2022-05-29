using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofOrder;
using FluentValidation;
namespace BusinessView.ofValidator.ofCommon.ofOrder
{
    public class OCommodityValidator<TCommodity> : CommodityDTOValidator<TCommodity> where TCommodity : OCommodityDTO
    {
        public OCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TCommodity>.CreateWithOptions((TCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}