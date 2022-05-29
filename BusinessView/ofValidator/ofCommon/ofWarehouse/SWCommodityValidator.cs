using BusinessView.ofDTO.ofCommon;
using BusinessView.ofWarehouse;
using FluentValidation;
namespace BusinessView.ofValidator.ofCommon.ofWarehouse
{
    public class SWCommodityValidator<TSStatus> : SStatusDTOValidator<TSStatus> where TSStatus : SWCommodityDTO
    {
        public SWCommodityValidator()
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