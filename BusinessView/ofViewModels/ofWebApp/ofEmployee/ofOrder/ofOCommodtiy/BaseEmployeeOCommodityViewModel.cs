using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder
{
    public class BaseEmployeeOCommodityViewModel : BaseCommodityViewModel<EmployeeOCommodity>
    {
        public BaseEmployeeOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostOCommodityViewModel : CommodityPostViewModel<EmployeeOCommodity>
    {
        public EmployeePostOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutOCommodityViewModel : CommodityPutViewModel<EmployeeOCommodity>
    {
        public EmployeePutOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteOCommodityViewModel : CommodityDeleteViewModel<EmployeeOCommodity>
    {
        public EmployeeDeleteOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsOCommodityViewModel : CommodityGetsViewModel<EmployeeOCommodity>
    {
        public EmployeeGetsOCommodityViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
