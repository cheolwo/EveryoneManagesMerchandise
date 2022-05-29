using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofMarket;
using FluentValidation;
namespace BusinessView.ofValidator.ofCommon.ofMarket
{
    public class MMCommodityValidator<TMStatus> : MStatusDTOValidator<TMStatus> where TMStatus : MMCommodityDTO
    {
        public MMCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TMStatus>.CreateWithOptions((TMStatus)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}