using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofSeller
{
    [ActorContext(typeof(SellerContext))]
    public class SellerHRCenter : HRCenterDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerHRBusinessPart : HRBusinessPartDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerHREmployee : HREmployeeDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerHRRole : HRRoleDTO
    {
    }
    [ActorContext(typeof(SellerContext))]
    public class SellerEmployeeRole : EmployeeRoleDTO
    {
    }
}
