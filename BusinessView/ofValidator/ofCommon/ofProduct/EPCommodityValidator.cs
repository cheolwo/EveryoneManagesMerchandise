using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofProduct;
using FluentValidation;
namespace BusinessView.ofValidator.ofCommon.ofProduct
{
    public class EPCommodityValidator<TEStatus> : EStatusDTOValidator<TEStatus> where TEStatus : EPCommodityDTO
    {
        public EPCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TEStatus>.CreateWithOptions((TEStatus)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}