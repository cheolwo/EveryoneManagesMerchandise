using BusinessView.ofCommon.ofServices.ofJournal.ofEmployer;
using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofUser.ofEmployer
{
    public class EmployerSellerContext: EmployerActorContext
    {
        public EmployerSellerContext()
        {

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

            serviceBuilder.Add(nameof(EmployerEMCommodity), new EmployerEMCommodityService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerSMCommodity), new EmployerSMCommodityService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerMMCommodity), new EmployerMMCommodityService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerMCommodity), new EmployerMCommodityService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerPlatMarket), new EmployerPlatMarketService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerMarket), new EmployerMarketService(e=>e.IsDevelopment = true));
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {

        }
    }
}
