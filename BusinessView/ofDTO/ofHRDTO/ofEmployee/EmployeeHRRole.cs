using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofCommon.ofEmployee;

namespace BusinessView.ofDTO.ofHRDTO.ofEmployee
{
    public class EmployeeHRRole : EmployeeEntity
    {
        [Get]public string DetailName {get; set;}
        public string PossibleAPIInfos {get; set;}
        [One(ViewNameofHRCenter.HRCenter)]public string HRCenter {get; set;}
    }
}