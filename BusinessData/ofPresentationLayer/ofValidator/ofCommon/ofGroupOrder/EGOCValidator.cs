using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder;
using FluentValidation;

namespace BusinessView.ofValidator.ofCommon.ofGroupOrder
{
    public class EGOCValidator<TEGOC> : EStatusDTOValidator<TEGOC> where TEGOC : EGOCDTO
    {
        public EGOCValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TEGOC>.CreateWithOptions((TEGOC)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}