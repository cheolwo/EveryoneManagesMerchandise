using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofHR;
namespace BusinessView.ofDTO.ofHR.ofEmployee
{
    public class EmployeeHRRole : EmployeeEntity
    {
        [Get]public string? DetailName {get; set;}
        public string? PossibleAPIInfos {get; set;}
        [One(ViewNameofHRCenter.HRCenter)]public string? HRCenter {get; set;}
    }
}