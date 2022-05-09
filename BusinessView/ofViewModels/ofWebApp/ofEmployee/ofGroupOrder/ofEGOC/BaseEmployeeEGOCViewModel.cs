using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeEGOCViewModel : BaseStatusViewModel<EmployeeEGOC>
    {
        public BaseEmployeeEGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostEGOCViewModel : StatusPostViewModel<EmployeeEGOC>
    {
        public EmployeePostEGOCViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutEGOCViewModel : StatusPutViewModel<EmployeeEGOC>
    {
        public EmployeePutEGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteEGOCViewModel : StatusDeleteViewModel<EmployeeEGOC>
    {
        public EmployeeDeleteEGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsEGOCViewModel : StatusGetsViewModel<EmployeeEGOC>
    {
        public EmployeeGetsEGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
