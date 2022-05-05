using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofCommon.ofEmployer;

namespace BusinessView.ofDTO.ofHR.ofEmployer
{
    public class EmployerHREmployee : EmployerEntity
    {
        public DateTime InTime {get; set;}
        public DateTime OutTime {get; set;}
        public string? PhoneNumber {get; set;}
        [One(ViewNameofHRCenter.HRCenter)]public string? HRCenter {get; set;}
    }
}