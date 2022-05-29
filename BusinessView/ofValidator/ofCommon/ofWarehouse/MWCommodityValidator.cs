using BusinessView.ofDTO.ofCommon;
using BusinessView.ofWarehouse;
using FluentValidation;
namespace BusinessView.ofValidator.ofCommon.ofWarehouse
{
    public class MWCommodityValidator<TMStatus> : MStatusDTOValidator<TMStatus> where TMStatus : MWCommodityDTO
    {
        public MWCommodityValidator()
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