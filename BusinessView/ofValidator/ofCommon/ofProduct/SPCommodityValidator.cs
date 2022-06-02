using BusinessData.ofPresentationLayer.ofDTO.ofProduct;
using FluentValidation;
namespace BusinessView.ofValidator.ofCommon.ofProduct
{
    public class SPCommodityValidator<TSStatus> : SStatusDTOValidator<TSStatus> where TSStatus : SPCommodityDTO
    {
        public SPCommodityValidator()
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