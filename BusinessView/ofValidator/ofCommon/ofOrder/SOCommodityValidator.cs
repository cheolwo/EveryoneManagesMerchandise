using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofOrder;
using FluentValidation;
namespace BusinessView.ofValidator.ofCommon.ofOrder
{
    public class SOCommodityValidator<TSStatus> : SStatusDTOValidator<TSStatus> where TSStatus : SOCommodityDTO
    {
        public SOCommodityValidator()
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