using BusinessView.ofCommon.ofServices.ofWarehouse;
using BusinessView.ofGeneric;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofWarehouse.ofEmployer;

namespace BusinessView.ofUser.ofEmployer
{
    public class EmployerLogister : EmployerActor, IActorViewService<EmployerWarehouse>, IActorViewService<EmployerDividedTag>
         , IActorViewService<EmployerDotBarcode>, IActorViewService<EmployerEWCommodity>, IActorViewService<EmployerIncomingTag>,
        IActorViewService<EmployerLoadFrame>, IActorViewService<EmployerMWCommodity>, IActorViewService<EmployerSWCommodity>, IActorViewService<EmployerWorkingDesk>

    {
        public EmployerLogister()
        {

        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder)
        {
            serviceBuilder.Add(nameof(EmployerWarehouse), new EmployerWarehouseService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerWCommodity), new EmployerWCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerSWCommodity), new EmployerSWCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerMWCommodity), new EmployerMWCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerEWCommodity), new EmployerEWCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerDividedTag), new EmployerDividedTagService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerDotBarcode), new EmployerDotBarcodeService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerIncomingTag), new EmployerIncomingTagService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerLoadFrame), new EmployerLoadFrameService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerWorkingDesk), new EmployerWorkingDeskService(e => e.IsDevelopment = true));
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder)
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde)
        {

        }

        public Task DeleteAsync(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerWarehouse> PostAsync(EmployerWarehouse t)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerDividedTag> PostAsync(EmployerDividedTag t)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerEWCommodity> PostAsync(EmployerEWCommodity t)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerSWCommodity> PostAsync(EmployerSWCommodity t)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerMWCommodity> PostAsync(EmployerMWCommodity t)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerWorkingDesk> PostAsync(EmployerWorkingDesk t)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerLoadFrame> PostAsync(EmployerLoadFrame t)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerDotBarcode> PostAsync(EmployerDotBarcode t)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerIncomingTag> PostAsync(EmployerIncomingTag t)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerWarehouse> PutAsync(EmployerWarehouse t)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerDividedTag> PutAsync(EmployerDividedTag t)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerEWCommodity> PutAsync(EmployerEWCommodity t)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerSWCommodity> PutAsync(EmployerSWCommodity t)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerMWCommodity> PutAsync(EmployerMWCommodity t)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerWorkingDesk> PutAsync(EmployerWorkingDesk t)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerLoadFrame> PutAsync(EmployerLoadFrame t)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerDotBarcode> PutAsync(EmployerDotBarcode t)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerIncomingTag> PutAsync(EmployerIncomingTag t)
        {
            throw new NotImplementedException();
        }


        Task<IEnumerable<EmployerWarehouse>?> IActorViewService<EmployerWarehouse>.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerDividedTag>?> IActorViewService<EmployerDividedTag>.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerEWCommodity>?> IActorViewService<EmployerEWCommodity>.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerSWCommodity>?> IActorViewService<EmployerSWCommodity>.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerMWCommodity>?> IActorViewService<EmployerMWCommodity>.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerWorkingDesk>?> IActorViewService<EmployerWorkingDesk>.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerLoadFrame>?> IActorViewService<EmployerLoadFrame>.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerDotBarcode>?> IActorViewService<EmployerDotBarcode>.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerIncomingTag>?> IActorViewService<EmployerIncomingTag>.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerWarehouse> IActorViewService<EmployerWarehouse>.GetByIdAsync(string Id)
        {
            throw new NotImplementedException();
        }

        Task<EmployerDividedTag> IActorViewService<EmployerDividedTag>.GetByIdAsync(string Id)
        {
            throw new NotImplementedException();
        }

        Task<EmployerEWCommodity> IActorViewService<EmployerEWCommodity>.GetByIdAsync(string Id)
        {
            throw new NotImplementedException();
        }

        Task<EmployerSWCommodity> IActorViewService<EmployerSWCommodity>.GetByIdAsync(string Id)
        {
            throw new NotImplementedException();
        }

        Task<EmployerMWCommodity> IActorViewService<EmployerMWCommodity>.GetByIdAsync(string Id)
        {
            throw new NotImplementedException();
        }

        Task<EmployerWorkingDesk> IActorViewService<EmployerWorkingDesk>.GetByIdAsync(string Id)
        {
            throw new NotImplementedException();
        }

        Task<EmployerLoadFrame> IActorViewService<EmployerLoadFrame>.GetByIdAsync(string Id)
        {
            throw new NotImplementedException();
        }

        Task<EmployerDotBarcode> IActorViewService<EmployerDotBarcode>.GetByIdAsync(string Id)
        {
            throw new NotImplementedException();
        }

        Task<EmployerIncomingTag> IActorViewService<EmployerIncomingTag>.GetByIdAsync(string Id)
        {
            throw new NotImplementedException();
        }
    }
}
