using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofCommon.ofTrade;
using FluentValidation;
namespace BusinessView.ofValidator.ofCommon.ofTrade
{
    public class STCommodityValidator<TSStatus> : SStatusDTOValidator<TSStatus> where TSStatus : STCommodityDTO
    {
        public STCommodityValidator()
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