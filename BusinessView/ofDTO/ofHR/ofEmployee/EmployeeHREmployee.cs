using AutoMapper;
using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofHR;
namespace BusinessView.ofDTO.ofHR.ofEmployee
{
    [AutoMap(typeof(HREmployee))]
    public class EmployeeHREmployee : EmployeeEntity
    {
        public DateTime InTime {get; set;}
        public DateTime OutTime {get; set;}
        public string? PhoneNumber {get; set;}
        [One(ViewNameofHRCenter.HRCenter, typeof(HRCenter))]public string? HRCenter {get; set;}
    }
}