using BusinessView.ofDTO.ofJournal.ofPlatform;
using BusinessView.ofValidator.ofCommon.ofPlatform;
using FluentValidation;
namespace BusinessView.ofValidator.ofPlatform.ofJournal
{
    public class PlatformJCommodityValidator : PlatformCommodityValidator<PlatformJCommodity>
    {
        public PlatformJCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformJCommodity>.CreateWithOptions((PlatformJCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}