using BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofEmployer;
using BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofJournal;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BusinessData.ofPresentationLayer.ofValidator.ofEmployer.ofJournal
{
    public class EmployerJournalCenterValidator : JournalCenterValidator<EmployerJournalCenter>
    {
        public EmployerJournalCenterValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerJournalCenter>.CreateWithOptions((EmployerJournalCenter)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}