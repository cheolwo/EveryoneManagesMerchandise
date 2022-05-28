using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWarehouse;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofWarehouse
{
    public class EmployerWarehousePageViewModel : WarehousePageViewModel<EmployerWarehouse> 
    {
        public readonly EmployerPostWarehouseViewModel _EmployerPostWarehouseViewModel;
        public readonly EmployerPutWarehouseViewModel _EmployerPutWarehouseViewModel;
        public readonly EmployerDeleteWarehouseViewModel _EmployerDeleteWarehouseViewModel;
        public readonly EmployerGetsWarehouseViewModel _EmployerGetsWarehouseViewModel;

        public EmployerWarehousePageViewModel(EmployerPostWarehouseViewModel EmployerPostWarehouseViewModel, 
                                        EmployerPutWarehouseViewModel EmployerPutWarehouseViewModel,
                                        EmployerDeleteWarehouseViewModel EmployerDeleteWarehouseViewModel,
                                        EmployerGetsWarehouseViewModel EmployerGetsWarehouseViewModel)
                :base(EmployerPostWarehouseViewModel, EmployerPutWarehouseViewModel, EmployerDeleteWarehouseViewModel, EmployerGetsWarehouseViewModel)
                    
        {
            _EmployerPostWarehouseViewModel = EmployerPostWarehouseViewModel;
            _EmployerPutWarehouseViewModel = EmployerPutWarehouseViewModel;
            _EmployerDeleteWarehouseViewModel = EmployerDeleteWarehouseViewModel;
            _EmployerGetsWarehouseViewModel = EmployerGetsWarehouseViewModel;
        }
    }
}