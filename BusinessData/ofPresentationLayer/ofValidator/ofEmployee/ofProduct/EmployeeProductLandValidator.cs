using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofProduct;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployee.ofProduct
{
    public class EmployeeProductLandValidator : ProductLandValidator<EmployeeProductLand>
    {
        public EmployeeProductLandValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeProductLand>.CreateWithOptions((EmployeeProductLand)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}