using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeGOCCViewModel : BaseCommodityViewModel<EmployeeGOCC>
    {
        public BaseEmployeeGOCCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostGOCCViewModel : CommodityPostViewModel<EmployeeGOCC>
    {
        public EmployeePostGOCCViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutGOCCViewModel : CommodityPutViewModel<EmployeeGOCC>
    {
        public EmployeePutGOCCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteGOCCViewModel : CommodityDeleteViewModel<EmployeeGOCC>
    {
        public EmployeeDeleteGOCCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsGOCCViewModel : CommodityGetsViewModel<EmployeeGOCC>
    {
        public EmployeeGetsGOCCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
