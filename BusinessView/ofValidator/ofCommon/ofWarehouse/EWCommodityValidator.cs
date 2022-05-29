using BusinessView.ofDTO.ofCommon;
using BusinessView.ofWarehouse;
using FluentValidation;
namespace BusinessView.ofValidator.ofCommon.ofWarehouse
{
    public class EWCommodityValidator<TEStatus> : EStatusDTOValidator<TEStatus> where TEStatus : EWCommodityDTO
    {
        public EWCommodityValidator()
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