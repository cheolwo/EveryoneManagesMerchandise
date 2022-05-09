using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeGOCViewModel : BaseCenterViewModel<EmployeeGOC>
    {
        public BaseEmployeeGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostGOCViewModel : CenterPostViewModel<EmployeeGOC>
    {
        public EmployeePostGOCViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutGOCViewModel : CenterPutViewModel<EmployeeGOC>
    {
        public EmployeePutGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteGOCViewModel : CenterDeleteViewModel<EmployeeGOC>
    {
        public EmployeeDeleteGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsGOCViewModel : CenterGetsViewModel<EmployeeGOC>
    {
        public EmployeeGetsGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
