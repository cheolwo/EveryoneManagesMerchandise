using BusinessView.ofCommon.ofServices.ofJournal.ofEmployer;
using BusinessView.ofGeneric;
using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofWarehouse.ofEmployer;

namespace BusinessView.ofUser.ofEmployer
{
    public class EmployerLogister : EmployerActor, IActorViewService<EmployerWarehouse>, IActorViewService<EmployerDividedTag>
         , IActorViewService<EmployerDotBarcode>, IActorViewService<EmployerEWCommodity>, IActorViewService<EmployerIncomingTag>,
        IActorViewService<EmployerLoadFrame>, IActorViewService<EmployerMWCommodity>, IActorViewService<EmployerSWCommodity>, IActorViewService<EmployerWorkingDesk>,
        IActorViewService<EmployerWCommodity>

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

            serviceBuilder.Add(nameof(EmployerTradeCenter), new EmployerTradeCenterService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerTCommodity), new EmployerTCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerSTCommodity), new EmployerSTCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerMTCommodity), new EmployerMTCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerETCommodity), new EmployerETCommodityService(e => e.IsDevelopment = true));
        }
        
        public new Task<IEnumerable<EmployerWarehouse>?> GetsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<EmployerWarehouse?> PostAsync(EmployerWarehouse entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerDividedTag?> PostAsync(EmployerDividedTag entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerWarehouse?> PutAsync(EmployerWarehouse entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerDividedTag?> PutAsync(EmployerDividedTag entity)
        {
            throw new NotImplementedException();
        }

        protected override void OnStrorageBuilder(StorageBuilder storageBuilder)
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde)
        {

        }

        Task<EmployerWarehouse?> IActorViewService<EmployerWarehouse>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        Task<EmployerDividedTag?> IActorViewService<EmployerDividedTag>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerDividedTag>?> IActorViewService<EmployerDividedTag>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerEWCommodity>?> IActorViewService<EmployerEWCommodity>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerEWCommodity?> IActorViewService<EmployerEWCommodity>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerEWCommodity?> PostAsync(EmployerEWCommodity entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerEWCommodity?> PutAsync(EmployerEWCommodity entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerMWCommodity>?> IActorViewService<EmployerMWCommodity>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerMWCommodity?> IActorViewService<EmployerMWCommodity>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerMWCommodity?> PostAsync(EmployerMWCommodity entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerMWCommodity?> PutAsync(EmployerMWCommodity entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerSWCommodity>?> IActorViewService<EmployerSWCommodity>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerSWCommodity?> IActorViewService<EmployerSWCommodity>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerSWCommodity?> PostAsync(EmployerSWCommodity entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerSWCommodity?> PutAsync(EmployerSWCommodity entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerIncomingTag>?> IActorViewService<EmployerIncomingTag>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerIncomingTag?> IActorViewService<EmployerIncomingTag>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerIncomingTag?> PostAsync(EmployerIncomingTag entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerIncomingTag?> PutAsync(EmployerIncomingTag entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerWorkingDesk>?> IActorViewService<EmployerWorkingDesk>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerWorkingDesk?> IActorViewService<EmployerWorkingDesk>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerWorkingDesk?> PostAsync(EmployerWorkingDesk entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerWorkingDesk?> PutAsync(EmployerWorkingDesk entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerDotBarcode>?> IActorViewService<EmployerDotBarcode>.GetsAsync()
        {
            throw new NotImplementedException();
        }

       Task<EmployerDotBarcode?> IActorViewService<EmployerDotBarcode>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerDotBarcode?> PostAsync(EmployerDotBarcode entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerDotBarcode?> PutAsync(EmployerDotBarcode entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerLoadFrame>?> IActorViewService<EmployerLoadFrame>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerLoadFrame?> IActorViewService<EmployerLoadFrame>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerLoadFrame?> PostAsync(EmployerLoadFrame entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerLoadFrame?> PutAsync(EmployerLoadFrame entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerWCommodity>?> IActorViewService<EmployerWCommodity>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerWCommodity?> IActorViewService<EmployerWCommodity>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerWCommodity?> PostAsync(EmployerWCommodity entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerWCommodity?> PutAsync(EmployerWCommodity entity)
        {
            throw new NotImplementedException();
        }
    }
}
