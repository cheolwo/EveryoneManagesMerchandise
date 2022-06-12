using FluentValidation;
using BusinessView.ofValidator.ofCommon.ofGroupOrder;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofPlaform;
namespace BusinessView.ofValidator.ofPlatform.ofGroupOrder
{
    public class PlatformGOCValidator : GOCValidator<PlatformGOC>
    {
        public PlatformGOCValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformGOC>.CreateWithOptions((PlatformGOC)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}