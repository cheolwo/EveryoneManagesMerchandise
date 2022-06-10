using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofProducter
{
    [ActorContext(typeof(ProducterContext))]
    public class ProducterHRCenter : HRCenterDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterHRBusinessPart : HRBusinessPartDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterHREmployee : HREmployeeDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterHRRole : HRRoleDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterEmployeeRole : EmployeeRoleDTO
    {
    }
}
