using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData.ofHR;
namespace BusinessView.ofDTO.ofHR.ofEmployer
{
    public class EmployerHRCenter : EmployerCenter
    {
        public string? JournalCenterId {get; set;}
        [Get]public string? BusinessNumber { get; set; }
        [Detail][Many]public string? HREmployees {get; set;}
        [Detail][Many]public string? EmployeeRoles {get; set;}
        [Detail][Many]public string? HRRoles {get; set;}
    }
}