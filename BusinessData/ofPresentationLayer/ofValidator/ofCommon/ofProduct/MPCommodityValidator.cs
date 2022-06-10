using BusinessData.ofPresentationLayer.ofDTO.ofProduct;
using FluentValidation;

namespace BusinessView.ofValidator.ofCommon.ofProduct
{
    public class MPCommodityValidator<TMStatus> : MStatusDTOValidator<TMStatus> where TMStatus : MPCommodityDTO
    {
        public MPCommodityValidator()
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