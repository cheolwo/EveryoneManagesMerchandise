using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData.ofHR;
namespace BusinessView.ofDTO.ofHR.ofEmployer
{
    public class EmployerHRBusinessPart : EmployerEntity
    {
        public string? PartName {get; set;}
        public string? PossibleAPIInfos {get; set;}
        public string? HRCenter {get; set;}
    }
}