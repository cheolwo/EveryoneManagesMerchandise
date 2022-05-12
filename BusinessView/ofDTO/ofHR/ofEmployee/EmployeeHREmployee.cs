using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofDTO.ofCommon.ofEmployee;

namespace BusinessView.ofDTO.ofHR.ofEmployee
{
    public class EmployeeHREmployee : EmployeeEntity
    {
        public DateTime InTime {get; set;}
        public DateTime OutTime {get; set;}
        public string? PhoneNumber {get; set;}
        [One(ViewNameofHRCenter.HRCenter)]public string? HRCenter {get; set;}
    }
}