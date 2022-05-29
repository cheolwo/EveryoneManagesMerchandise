using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofOrder;
using FluentValidation;
namespace BusinessView.ofValidator.ofCommon.ofOrder
{
    public class MOCommodityValidator<TMStatus> : MStatusDTOValidator<TMStatus> where TMStatus : MOCommodityDTO
    {
        public MOCommodityValidator()
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