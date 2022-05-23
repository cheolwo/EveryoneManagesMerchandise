using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofValidator.ofCommon.ofEmployer;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployer.ofGroupOrder
{
    public class EmployerGOCValidator : EmployerCenterValidator<EmployerGOC>
    {
        public EmployerGOCValidator()
        {
            RuleFor(x => x.WarehouseId)
                .NotEmpty()
                .Length(1,100);
        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerGOC>.CreateWithOptions((EmployerGOC)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}