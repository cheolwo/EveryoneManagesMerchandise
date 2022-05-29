using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofValidator.ofCommon.ofEmployer;
using BusinessView.ofValidator.ofCommon.ofProduct;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployer.ofProduct
{
    public class EmployerProductCenterValidator : ProductCenterValidator<EmployerProductCenter>
    {
        public EmployerProductCenterValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerProductCenter>.CreateWithOptions((EmployerProductCenter)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}