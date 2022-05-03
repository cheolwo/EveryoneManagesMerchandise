using BusinessView.ofCommon.ofServices.ofJournal.ofEmployer;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofUser.ofEmployer
{
    public class EmployerForwarder : EmployerActor
    {
        public EmployerForwarder()
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
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {

        }
    }
}
