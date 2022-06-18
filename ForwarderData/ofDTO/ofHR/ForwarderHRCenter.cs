using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofForwarder
{
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderHRCenter : HRCenterDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderHRBusinessPart : HRBusinessPartDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderHREmployee : HREmployeeDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderHRRole : HRRoleDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderEmployeeRole : EmployeeRoleDTO
    {
    }
}
