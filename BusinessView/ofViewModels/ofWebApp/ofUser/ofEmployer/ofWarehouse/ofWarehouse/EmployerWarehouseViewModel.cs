using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWarehouse;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class EmployerPostWarehouseViewModel : WarehousePostViewModel<EmployerWarehouse>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPostWarehouseViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerPutWarehouseViewModel : WarehousePutViewModel<EmployerWarehouse>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerPutWarehouseViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerDeleteWarehouseViewModel : WarehouseDeleteViewModel<EmployerWarehouse>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerDeleteWarehouseViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerGetsWarehouseViewModel : WarehouseGetsViewModel<EmployerWarehouse>
    {
        private readonly EmployerActorContext _EmployerActorContext;
        public EmployerGetsWarehouseViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}
