using BusinessView.ofCommon.ofServices.ofWarehouse;
using BusinessView.ofGeneric;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofWarehouse.ofEmployer;

namespace BusinessView.ofUser.ofEmployer
{
    public class EmployerLogister: EmployerActor, IActorViewService<EmployerWarehouse>
    {
        public EmployerLogister()
        {

        }

        public Task<EmployerWarehouse> Post(EmployerWarehouse t)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerWarehouse> Update(string Id, EmployerWarehouse t)
        {
            throw new NotImplementedException();
        }

        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder) 
        {
            serviceBuilder.Add(nameof(EmployerWarehouse), new EmployerWarehouseService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerWCommodity), new EmployerWCommodityService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerSWCommodity), new EmployerSWCommodityService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerMWCommodity), new EmployerMWCommodityService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerEWCommodity), new EmployerEWCommodityService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerDividedTag), new EmployerDividedTagService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerDotBarcode), new EmployerDotBarcodeService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerIncomingTag), new EmployerIncomingTagService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerLoadFrame), new EmployerLoadFrameService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerWorkingDesk), new EmployerWorkingDeskService(e=>e.IsDevelopment = true));
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {

        }

        Task<IEnumerable<EmployerWarehouse>?> IActorViewService<EmployerWarehouse>.Get()
        {
            throw new NotImplementedException();
        }

        Task<EmployerWarehouse> IActorViewService<EmployerWarehouse>.GetById(string Id)
        {
            throw new NotImplementedException();
        }
    }
}
