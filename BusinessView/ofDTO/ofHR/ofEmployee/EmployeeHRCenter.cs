using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployee;

namespace BusinessView.ofDTO.ofHR.ofEmployee
{
    public class EmployeeHRCenter : EmployeeCenter
    {
        public string? JournalCenterId {get; set;}
        [Get]public string? BusinessNumber { get; set; }
        [Detail][Many]public string? HREmployees {get; set;}
        [Detail][Many]public string? EmployeeRoles {get; set;}
        [Detail][Many]public string? HRRoles {get; set;}
    }
}