using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofOrderer
{
    [ActorContext(typeof(OrdererContext))]
    public class OrdererHRCenter : HRCenterDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererHRBusinessPart : HRBusinessPartDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererHREmployee : HREmployeeDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererHRRole : HRRoleDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererEmployeeRole : EmployeeRoleDTO
    {
    }
}
