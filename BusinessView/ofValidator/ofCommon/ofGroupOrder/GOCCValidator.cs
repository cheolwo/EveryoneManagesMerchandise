using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofGroupOrder;
using FluentValidation;

namespace BusinessView.ofValidator.ofCommon.ofGroupOrder
{
    public class GOCCValidator<TGOCC> : CommodityDTOValidator<TGOCC> where TGOCC : GOCCDTO
    {
        public GOCCValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TGOCC>.CreateWithOptions((TGOCC)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}