using BusinessView.ofCommon.ofServices.ofJournal.ofPlatform;
using BusinessView.ofDTO.ofMarket.ofPlatform;
using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofUser.ofPlatform
{
    public class PlatformSeller : PlatformActor
    {
        public PlatformSeller()
        {

        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder) 
        {
            serviceBuilder.Add(nameof(PlatformWarehouse), new PlatformWarehouseService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformWCommodity), new PlatformWCommodityService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformSWCommodity), new PlatformSWCommodityService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformMWCommodity), new PlatformMWCommodityService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformEWCommodity), new PlatformEWCommodityService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformDividedTag), new PlatformDividedTagService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformDotBarcode), new PlatformDotBarcodeService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformIncomingTag), new PlatformIncomingTagService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformLoadFrame), new PlatformLoadFrameService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformWorkingDesk), new PlatformWorkingDeskService(e=>e.IsDevelopment = true));

            serviceBuilder.Add(nameof(PlatformEMCommodity), new PlatformEMCommodityService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformSMCommodity), new PlatformSMCommodityService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformMMCommodity), new PlatformMMCommodityService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformMCommodity), new PlatformMCommodityService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformPlatMarket), new PlatformPlatMarketService(e=>e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformMarket), new PlatformMarketService(e=>e.IsDevelopment = true));
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {

        }
    }
}
