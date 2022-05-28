using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofTrade.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade
{
    public class BaseEmployeeTCommodityViewModel : BaseCommodityViewModel<EmployeeTCommodity>
    {
        public BaseEmployeeTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostTCommodityViewModel : CommodityPostViewModel<EmployeeTCommodity>
    {
        public EmployeePostTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutTCommodityViewModel : CommodityPutViewModel<EmployeeTCommodity>
    {
        public EmployeePutTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteTCommodityViewModel : CommodityDeleteViewModel<EmployeeTCommodity>
    {
        public EmployeeDeleteTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsTCommodityViewModel : CommodityGetsViewModel<EmployeeTCommodity>
    {
        public EmployeeGetsTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
