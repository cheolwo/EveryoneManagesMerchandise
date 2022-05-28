using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofLoadFrame;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class EmployeePostLoadFrameViewModel : LoadFramePostViewModel<EmployeeLoadFrame>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostLoadFrameViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutLoadFrameViewModel : LoadFramePutViewModel<EmployeeLoadFrame>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutLoadFrameViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteLoadFrameViewModel : LoadFrameDeleteViewModel<EmployeeLoadFrame>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteLoadFrameViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsLoadFrameViewModel : LoadFrameGetsViewModel<EmployeeLoadFrame>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsLoadFrameViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
