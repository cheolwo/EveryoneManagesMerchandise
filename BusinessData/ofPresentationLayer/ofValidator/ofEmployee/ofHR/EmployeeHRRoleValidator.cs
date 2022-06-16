using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployee;
using BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofHR;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BusinessData.ofPresentationLayer.ofValidator.ofEmployee.ofHR
{
    public class EmployeeHRRoleValidator : HRRoleValidator<EmployeeHRRole>
    {
        public EmployeeHRRoleValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeHRRole>.CreateWithOptions((EmployeeHRRole)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}