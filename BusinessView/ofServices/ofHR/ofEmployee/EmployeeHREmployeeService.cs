using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofServices.ofHR;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofHR.ofEmployee
{
    public class EmployeeHREmployeeService : HRService
    {
        public EmployeeHREmployeeService(HRServiceOptions options)
            : base(options)
        {

        }

    }
}
