using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofMarket;
using FluentValidation;
namespace BusinessView.ofValidator.ofCommon.ofMarket
{
    public class SMCommodityValidator<TSStatus> : SStatusDTOValidator<TSStatus> where TSStatus : SMCommodityDTO
    {
        public SMCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TSStatus>.CreateWithOptions((TSStatus)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}