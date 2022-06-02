using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofDividedTag;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployee;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse
{
    public class EmployeePostDividedTagViewModel : DividedTagPostViewModel<EmployeeDividedTag>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostDividedTagViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutDividedTagViewModel : DividedTagPutViewModel<EmployeeDividedTag>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutDividedTagViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteDividedTagViewModel : DividedTagDeleteViewModel<EmployeeDividedTag>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteDividedTagViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsDividedTagViewModel : DividedTagGetsViewModel<EmployeeDividedTag>
    {
        private readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsDividedTagViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
