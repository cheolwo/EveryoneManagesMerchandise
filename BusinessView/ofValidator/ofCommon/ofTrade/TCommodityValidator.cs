using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofCommon.ofTrade;
using FluentValidation;
namespace BusinessView.ofValidator.ofCommon.ofTrade
{
    public class TCommodityValidator<TCommodity> : CommodityDTOValidator<TCommodity> where TCommodity : TCommodityDTO
    {
        public TCommodityValidator()
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