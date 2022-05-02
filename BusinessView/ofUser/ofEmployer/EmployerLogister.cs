using BusinessView.ofCommon.ofServices.ofJournal.ofEmployer;
using BusinessView.ofGeneric;
using BusinessView.ofGroupOrder.ofEmployer;
using BusinessView.ofOrder.ofEmployer;
using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofWarehouse.ofEmployer;

namespace BusinessView.ofUser.ofEmployer
{
    public class EmployerLogister : EmployerActor, IActorViewService<EmployerWarehouse>, IActorViewService<EmployerDividedTag>
         , IActorViewService<EmployerDotBarcode>, IActorViewService<EmployerEWCommodity>, IActorViewService<EmployerIncomingTag>,
        IActorViewService<EmployerLoadFrame>, IActorViewService<EmployerMWCommodity>, IActorViewService<EmployerSWCommodity>, IActorViewService<EmployerWorkingDesk>,
        IActorViewService<EmployerWCommodity>,
         IActorViewService<EmployerTradeCenter>,
         IActorViewService<EmployerTCommodity>,
         IActorViewService<EmployerSTCommodity>,
         IActorViewService<EmployerMTCommodity>,
         IActorViewService<EmployerETCommodity>,
         IActorViewService<EmployerOCommodity>,
        IActorViewService<EmployerSOCommodity>,
        IActorViewService<EmployerMOCommodity>,
        IActorViewService<EmployerEOCommodity>,
        IActorViewService<EmployerOrderCenter>,
        IActorViewService<EmployerGOC>,
        IActorViewService<EmployerGOCC>,
        IActorViewService<EmployerSGOC>,
        IActorViewService<EmployerMGOC>,
        IActorViewService<EmployerEGOC>
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

        Task<IEnumerable<EmployerTradeCenter>?> IActorViewService<EmployerTradeCenter>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerTradeCenter?> IActorViewService<EmployerTradeCenter>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerTradeCenter?> PostAsync(EmployerTradeCenter entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerTradeCenter?> PutAsync(EmployerTradeCenter entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerTCommodity>?> IActorViewService<EmployerTCommodity>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerTCommodity?> IActorViewService<EmployerTCommodity>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerTCommodity?> PostAsync(EmployerTCommodity entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerTCommodity?> PutAsync(EmployerTCommodity entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerSTCommodity>?> IActorViewService<EmployerSTCommodity>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerSTCommodity?> IActorViewService<EmployerSTCommodity>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerSTCommodity?> PostAsync(EmployerSTCommodity entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerSTCommodity?> PutAsync(EmployerSTCommodity entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerMTCommodity>?> IActorViewService<EmployerMTCommodity>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerMTCommodity?> IActorViewService<EmployerMTCommodity>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerMTCommodity?> PostAsync(EmployerMTCommodity entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerMTCommodity?> PutAsync(EmployerMTCommodity entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerETCommodity>?> IActorViewService<EmployerETCommodity>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerETCommodity?> IActorViewService<EmployerETCommodity>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerETCommodity?> PostAsync(EmployerETCommodity entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerETCommodity?> PutAsync(EmployerETCommodity entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerOCommodity>?> IActorViewService<EmployerOCommodity>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerOCommodity?> IActorViewService<EmployerOCommodity>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerOCommodity?> PostAsync(EmployerOCommodity entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerOCommodity?> PutAsync(EmployerOCommodity entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerSOCommodity>?> IActorViewService<EmployerSOCommodity>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerSOCommodity?> IActorViewService<EmployerSOCommodity>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerSOCommodity?> PostAsync(EmployerSOCommodity entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerSOCommodity?> PutAsync(EmployerSOCommodity entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerMOCommodity>?> IActorViewService<EmployerMOCommodity>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerMOCommodity?> IActorViewService<EmployerMOCommodity>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerMOCommodity?> PostAsync(EmployerMOCommodity entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerMOCommodity?> PutAsync(EmployerMOCommodity entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerEOCommodity>?> IActorViewService<EmployerEOCommodity>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerEOCommodity?> IActorViewService<EmployerEOCommodity>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerEOCommodity?> PostAsync(EmployerEOCommodity entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerEOCommodity?> PutAsync(EmployerEOCommodity entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerOrderCenter>?> IActorViewService<EmployerOrderCenter>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerOrderCenter?> IActorViewService<EmployerOrderCenter>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerOrderCenter?> PostAsync(EmployerOrderCenter entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerOrderCenter?> PutAsync(EmployerOrderCenter entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerGOC>?> IActorViewService<EmployerGOC>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerGOC?> IActorViewService<EmployerGOC>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerGOC?> PostAsync(EmployerGOC entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerGOC?> PutAsync(EmployerGOC entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerGOCC>?> IActorViewService<EmployerGOCC>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerGOCC?> IActorViewService<EmployerGOCC>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerGOCC?> PostAsync(EmployerGOCC entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerGOCC?> PutAsync(EmployerGOCC entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerSGOC>?> IActorViewService<EmployerSGOC>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerSGOC?> IActorViewService<EmployerSGOC>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerSGOC?> PostAsync(EmployerSGOC entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerSGOC?> PutAsync(EmployerSGOC entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerMGOC>?> IActorViewService<EmployerMGOC>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerMGOC?> IActorViewService<EmployerMGOC>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerMGOC?> PostAsync(EmployerMGOC entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerMGOC?> PutAsync(EmployerMGOC entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerEGOC>?> IActorViewService<EmployerEGOC>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerEGOC?> IActorViewService<EmployerEGOC>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerEGOC?> PostAsync(EmployerEGOC entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerEGOC?> PutAsync(EmployerEGOC entity)
        {
            throw new NotImplementedException();
        }
    }
}
