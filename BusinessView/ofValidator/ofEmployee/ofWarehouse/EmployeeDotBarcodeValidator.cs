using BusinessView.ofValidator.ofCommon.ofWarehouse;
using FluentValidation;
using BusinessView.ofDTO.ofWarehouse.ofEmployee;

namespace BusinessView.ofValidator.ofEmployee.ofWarehouse
{
    public class EmployeeDotBarcodeValidator : DotBarcodeValidator<EmployeeDotBarcode>
    {
        public EmployeeDotBarcodeValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeDotBarcode>.CreateWithOptions((EmployeeDotBarcode)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}