using BusinessView.ofCommon.ofServices.ofWarehouse.ofEmployee;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofWarehouse.ofEmployee;

namespace BusinessView.ofUser.ofEmployee
{
    public class EmployeeLogister : EmployeeActor
    {
        public EmployeeLogister()
        {

        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder) 
        {
            serviceBuilder.Add(nameof(EmployeeWarehouse), new EmployeeWarehouseService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeWarehouse), new EmployeeWarehouseService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeWarehouse), new EmployeeWarehouseService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeWarehouse), new EmployeeWarehouseService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeWarehouse), new EmployeeWarehouseService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeWarehouse), new EmployeeWarehouseService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeWarehouse), new EmployeeWarehouseService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeWarehouse), new EmployeeWarehouseService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeWarehouse), new EmployeeWarehouseService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeWarehouse), new EmployeeWarehouseService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeWarehouse), new EmployeeWarehouseService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeWarehouse), new EmployeeWarehouseService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeWarehouse), new EmployeeWarehouseService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeWarehouse), new EmployeeWarehouseService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeWarehouse), new EmployeeWarehouseService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeWarehouse), new EmployeeWarehouseService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeWarehouse), new EmployeeWarehouseService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployeeWarehouse), new EmployeeWarehouseService(e=>e.IsDevelopment = true));
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {

        }
    }
}
