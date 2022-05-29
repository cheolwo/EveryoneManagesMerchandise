using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofHR;
using FluentValidation;
namespace BusinessView.ofValidator.ofCommon.ofHR
{
    public class HRCenterValidator<TCenter> : CenterDTOValidator<TCenter> where TCenter : HRCenterDTO
    {
        public HRCenterValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TCenter>.CreateWithOptions((TCenter)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}