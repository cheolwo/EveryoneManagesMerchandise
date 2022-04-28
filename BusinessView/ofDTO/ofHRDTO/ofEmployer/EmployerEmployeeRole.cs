using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofCommon.ofEmployer;

namespace BusinessView.ofDTO.ofHRDTO
{
    public class EmployerEmployeeRole : EmployerEntity
    {
        public string HRRole {get; set;}
        public string HRBusinessPart {get; set;}
        public string HREmployee {get; set;}
        public string PossibleAPIInfos {get; set;}
        [One(ViewNameofHRCenter.HRCenter)]public string HRCenter {get; set;}
    }
}