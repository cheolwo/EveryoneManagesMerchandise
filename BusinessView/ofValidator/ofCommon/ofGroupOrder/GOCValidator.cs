using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofGroupOrder;
using FluentValidation;

namespace BusinessView.ofValidator.ofCommon.ofGroupOrder
{
    public class GOCValidator<TGOC> : CenterDTOValidator<TGOC> where TGOC : GOCDTO
    {
        public GOCValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TGOC>.CreateWithOptions((TGOC)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}