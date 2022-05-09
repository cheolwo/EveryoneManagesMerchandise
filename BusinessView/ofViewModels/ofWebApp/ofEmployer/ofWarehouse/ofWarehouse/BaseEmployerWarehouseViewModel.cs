using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerWarehouseViewModel : BaseCenterViewModel<EmployerWarehouse>
    {
        public BaseEmployerWarehouseViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
        }
    }
    public class EmployerPostWarehouseViewModel : CenterPostViewModel<EmployerWarehouse>
    {
        public EmployerPostWarehouseViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
    }
    public class EmployerPutWarehouseViewModel : CenterPutViewModel<EmployerWarehouse>
    {
        public EmployerPutWarehouseViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerDeleteWarehouseViewModel : CenterDeleteViewModel<EmployerWarehouse>
    {
        public EmployerDeleteWarehouseViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
    public class EmployerGetsWarehouseViewModel : CenterGetsViewModel<EmployerWarehouse>
    {
        public EmployerGetsWarehouseViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
    }
}
