using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofSeller.ofEmployer
{
    [ActorContext(typeof(EmployerSellerContext))]
    public class EmployerSellerHRCenter : SellerHRCenter
    {
    }
    [ActorContext(typeof(EmployerSellerContext))]
    public class EmployerSellerHRBusinessPart : SellerHRBusinessPart
    {
    }
    [ActorContext(typeof(EmployerSellerContext))]
    public class EmployerSellerHREmployee : SellerHREmployee
    {
    }
    [ActorContext(typeof(EmployerSellerContext))]
    public class EmployerSellerHRRole : SellerHRRole
    {
    }
    [ActorContext(typeof(EmployerSellerContext))]
    public class EmployerSellerEmployerRole : SellerEmployeeRole
    {
    }
}
