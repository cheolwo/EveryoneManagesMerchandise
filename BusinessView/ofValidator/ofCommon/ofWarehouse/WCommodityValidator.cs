using BusinessView.ofDTO.ofCommon;
using BusinessView.ofWarehouse;
using FluentValidation;

namespace BusinessView.ofValidator.ofCommon.ofWarehouse
{
    public class WCommodityValidator<TCommodity> : CommodityDTOValidator<TCommodity> where TCommodity : WCommodityDTO
    {
        public WCommodityValidator()
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