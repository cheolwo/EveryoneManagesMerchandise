using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeMGOCViewModel : BaseStatusViewModel<EmployeeMGOC>
    {
        public BaseEmployeeMGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostMGOCViewModel : StatusPostViewModel<EmployeeMGOC>
    {
        public EmployeePostMGOCViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutMGOCViewModel : StatusPutViewModel<EmployeeMGOC>
    {
        public EmployeePutMGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteMGOCViewModel : StatusDeleteViewModel<EmployeeMGOC>
    {
        public EmployeeDeleteMGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsMGOCViewModel : StatusGetsViewModel<EmployeeMGOC>
    {
        public EmployeeGetsMGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
