using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder
{
    public class BaseEmployeeMOCommodityViewModel : BaseStatusViewModel<EmployeeMOCommodity>
    {
        public BaseEmployeeMOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostMOCommodityViewModel : StatusPostViewModel<EmployeeMOCommodity>
    {
        public EmployeePostMOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutMOCommodityViewModel : StatusPutViewModel<EmployeeMOCommodity>
    {
        public EmployeePutMOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteMOCommodityViewModel : StatusDeleteViewModel<EmployeeMOCommodity>
    {
        public EmployeeDeleteMOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsMOCommodityViewModel : StatusGetsViewModel<EmployeeMOCommodity>
    {
        public EmployeeGetsMOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
