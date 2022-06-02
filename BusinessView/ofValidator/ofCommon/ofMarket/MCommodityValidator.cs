using BusinessData.ofPresentationLayer.ofDTO.ofMarket;
using FluentValidation;
namespace BusinessView.ofValidator.ofCommon.ofMarket
{
    public class MCommodityValidator<TCommodity> : CommodityDTOValidator<TCommodity> where TCommodity : MCommodityDTO
    {
        public MCommodityValidator()
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