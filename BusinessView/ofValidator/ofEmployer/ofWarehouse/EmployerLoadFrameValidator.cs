using BusinessView.ofValidator.ofCommon.ofWarehouse;
using FluentValidation;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployer;

namespace BusinessView.ofValidator.ofEmployer.ofWarehouse
{
    public class EmployerLoadFrameValidator : LoadFrameValidator<EmployerLoadFrame>
    {
        public EmployerLoadFrameValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerLoadFrame>.CreateWithOptions((EmployerLoadFrame)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}