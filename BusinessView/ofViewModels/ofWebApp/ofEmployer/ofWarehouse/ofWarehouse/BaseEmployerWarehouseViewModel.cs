using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerWarehouseViewModel : BaseCenterViewModel<EmployerWarehouse>
    {
        public BaseEmployerWarehouseViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostWarehouseViewModel : EmployerCenterPostViewModel<EmployerWarehouse>
    {
        public EmployerPostWarehouseViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutWarehouseViewModel : EmployerCenterPutViewModel<EmployerWarehouse>
    {
        public EmployerPutWarehouseViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteWarehouseViewModel : EmployerCenterDeleteViewModel<EmployerWarehouse>
    {
        public EmployerDeleteWarehouseViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsWarehouseViewModel : EmployerCenterGetsViewModel<EmployerWarehouse>
    {
        public EmployerGetsWarehouseViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
