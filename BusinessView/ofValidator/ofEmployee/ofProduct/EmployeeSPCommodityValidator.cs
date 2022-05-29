using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofProduct;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployee.ofProduct
{
    public class EmployeeSPCommodityValidator : SPCommodityValidator<EmployeeSPCommodity>
    {
        public EmployeeSPCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeSPCommodity>.CreateWithOptions((EmployeeSPCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}