using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofSeller.ofEmployee
{
    [ActorContext(typeof(EmployeeSellerContext))]
    public class EmployeeSellerHRCenter : SellerHRCenter
    {
    }
    [ActorContext(typeof(EmployeeSellerContext))]
    public class EmployeeSellerHRBusinessPart : SellerHRBusinessPart
    {
    }
    [ActorContext(typeof(EmployeeSellerContext))]
    public class EmployeeSellerHREmployee : SellerHREmployee
    {
    }
    [ActorContext(typeof(EmployeeSellerContext))]
    public class EmployeeSellerHRRole : SellerHRRole
    {
    }
    [ActorContext(typeof(EmployeeSellerContext))]
    public class EmployeeSellerEmployeeRole : SellerEmployeeRole
    {
    }
}
