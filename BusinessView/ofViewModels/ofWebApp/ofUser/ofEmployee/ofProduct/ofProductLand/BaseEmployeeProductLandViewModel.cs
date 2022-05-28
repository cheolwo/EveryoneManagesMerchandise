using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct
{
    public class BaseEmployeeProductLandViewModel : BaseEntityViewModel<EmployeeProductLand>
    {
        public BaseEmployeeProductLandViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
        }
    }
    public class EmployeePostProductLandViewModel : EntityPostViewModel<EmployeeProductLand>
    {
        public EmployeePostProductLandViewModel(EmployeeActorContext EmployeeActorContext)
            : base(EmployeeActorContext)
        {

        }
    }
    public class EmployeePutProductLandViewModel : EntityPutViewModel<EmployeeProductLand>
    {
        public EmployeePutProductLandViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeDeleteProductLandViewModel : EntityDeleteViewModel<EmployeeProductLand>
    {
        public EmployeeDeleteProductLandViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
    public class EmployeeGetsProductLandViewModel : EntityGetsViewModel<EmployeeProductLand>
    {
        public EmployeeGetsProductLandViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {

        }
    }
}
