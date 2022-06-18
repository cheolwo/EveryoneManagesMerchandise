using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofLogister
{
    [ActorContext(typeof(LogisterContext))]
    public class LogisterHRCenter : HRCenterDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterHRBusinessPart : HRBusinessPartDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterHREmployee : HREmployeeDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterHRRole : HRRoleDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterEmployeeRole : EmployeeRoleDTO
    {
    }
}
