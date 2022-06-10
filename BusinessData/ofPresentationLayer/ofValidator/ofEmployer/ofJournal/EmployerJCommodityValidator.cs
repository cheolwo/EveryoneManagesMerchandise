using BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofEmployer;
using BusinessView.ofValidator.ofCommon.ofJournal;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployer.ofJournal
{
    public class EmployerJCommodityValidator : JCommodityValidator<EmployerJCommodity>
    {
        public EmployerJCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerJCommodity>.CreateWithOptions((EmployerJCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}