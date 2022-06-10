using FluentValidation;
using BusinessView.ofValidator.ofCommon.ofGroupOrder;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofPlaform;
namespace BusinessView.ofValidator.ofPlatform.ofGroupOrder
{
    public class PlatformSGOCValidator : SGOCValidator<PlatformSGOC>
    {
        public PlatformSGOCValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformSGOC>.CreateWithOptions((PlatformSGOC)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}