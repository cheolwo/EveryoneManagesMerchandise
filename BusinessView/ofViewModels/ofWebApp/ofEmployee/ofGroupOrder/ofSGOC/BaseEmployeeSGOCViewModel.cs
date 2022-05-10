using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder
{
    public class BaseEmployeeSGOCViewModel : BaseStatusViewModel<EmployeeSGOC>
    {
        public BaseEmployeeSGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostSGOCViewModel : StatusPostViewModel<EmployeeSGOC>
    {
        public EmployeePostSGOCViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutSGOCViewModel : StatusPutViewModel<EmployeeSGOC>
    {
        public EmployeePutSGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteSGOCViewModel : StatusDeleteViewModel<EmployeeSGOC>
    {
        public EmployeeDeleteSGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsSGOCViewModel : StatusGetsViewModel<EmployeeSGOC>
    {
        public EmployeeGetsSGOCViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
