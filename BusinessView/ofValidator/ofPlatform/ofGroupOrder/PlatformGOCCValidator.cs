using BusinessView.ofDTO.ofGroupOrder.ofPlatform;
using BusinessView.ofValidator.ofCommon.ofPlatform;
using FluentValidation;
using BusinessView.ofValidator.ofCommon.ofGroupOrder;
namespace BusinessView.ofValidator.ofPlatform.ofGroupOrder
{
    public class PlatformGOCCValidator : GOCCValidator<PlatformGOCC>
    {
        public PlatformGOCCValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformGOCC>.CreateWithOptions((PlatformGOCC)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}