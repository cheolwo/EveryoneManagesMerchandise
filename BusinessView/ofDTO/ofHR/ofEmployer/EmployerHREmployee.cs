using AutoMapper;
using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData.ofHR;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofDTO.ofHR.ofEmployer
{
    [AutoMap(typeof(HREmployee))]
    public class EmployerHREmployee : EmployerEntity
    {
        public DateTime InTime {get; set;}
        public DateTime OutTime {get; set;}
        [Query][Get]public string? PhoneNumber {get; set;}
        [One(ViewNameofHRCenter.HRCenter, typeof(HRCenter))]public string? HRCenter {get; set;}
    }
}