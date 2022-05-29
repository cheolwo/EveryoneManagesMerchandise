using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofCommon.ofTrade;
using FluentValidation;

namespace BusinessView.ofValidator.ofCommon.ofTrade
{
    public class ETCommodityValidator<TEStatus> : EStatusDTOValidator<TEStatus> where TEStatus : ETCommodityDTO
    {
        public ETCommodityValidator()
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