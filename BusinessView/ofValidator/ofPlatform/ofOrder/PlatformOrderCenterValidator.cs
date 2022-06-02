using BusinessView.ofValidator.ofCommon.ofOrder;
using FluentValidation;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofPlatform;
namespace BusinessView.ofValidator.ofPlatform.ofOrder
{
    public class PlatformOrderCenterValidator : OrderCenterValidator<PlatformOrderCenter>
    {
        public PlatformOrderCenterValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformOrderCenter>.CreateWithOptions((PlatformOrderCenter)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}