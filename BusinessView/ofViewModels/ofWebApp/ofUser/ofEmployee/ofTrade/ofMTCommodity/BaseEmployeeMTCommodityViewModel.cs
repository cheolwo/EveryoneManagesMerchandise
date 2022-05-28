using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofTrade.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade
{
    public class BaseEmployeeMTCommodityViewModel : BaseStatusViewModel<EmployeeMTCommodity>
    {
        public BaseEmployeeMTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostMTCommodityViewModel : StatusPostViewModel<EmployeeMTCommodity>
    {
        public EmployeePostMTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutMTCommodityViewModel : StatusPutViewModel<EmployeeMTCommodity>
    {
        public EmployeePutMTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteMTCommodityViewModel : StatusDeleteViewModel<EmployeeMTCommodity>
    {
        public EmployeeDeleteMTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsMTCommodityViewModel : StatusGetsViewModel<EmployeeMTCommodity>
    {
        public EmployeeGetsMTCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
