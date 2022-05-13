using BusinessView.ofCommon.ofServices.ofGroupOrder.ofPlatform;
using BusinessView.ofCommon.ofServices.ofJournal.ofPlatform;
using BusinessView.ofGroupOrder.ofPlatform;
using BusinessView.ofMarket.ofPlatform;
using BusinessView.ofOrder.ofPlatform;
using BusinessView.ofProduct.ofPlatform;
using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofWarehouse.ofPlatform;

namespace BusinessView.ofUser.ofPlatform
{
    public class PlatformProducter : PlatformActor
    {
        public PlatformProducter()
        {

        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder) 
        {
            serviceBuilder.Add(nameof(PlatformWarehouse), new PlatformWarehouseService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformWCommodity), new PlatformWCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformSWCommodity), new PlatformSWCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformMWCommodity), new PlatformMWCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformEWCommodity), new PlatformEWCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformDividedTag), new PlatformDividedTagService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformDotBarcode), new PlatformDotBarcodeService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformIncomingTag), new PlatformIncomingTagService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformLoadFrame), new PlatformLoadFrameService(e => e.IsDevelopment = true));

            serviceBuilder.Add(nameof(PlatformGOC), new PlatformGOCService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformGOCC), new PlatformGOCCService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformSGOC), new PlatformSGOCService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformMGOC), new PlatformMGOCService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformEGOC), new PlatformEGOCService(e => e.IsDevelopment = true));

            serviceBuilder.Add(nameof(PlatformTradeCenter), new PlatformTradeCenterService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformTCommodity), new PlatformTCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformSTCommodity), new PlatformSTCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformMTCommodity), new PlatformMTCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformETCommodity), new PlatformETCommodityService(e => e.IsDevelopment = true));

            serviceBuilder.Add(nameof(PlatformOrderCenter), new PlatformOrderCenterService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformOCommodity), new PlatformOCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformSOCommodity), new PlatformSOCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformMOCommodity), new PlatformMOCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformEOCommodity), new PlatformEOCommodityService(e => e.IsDevelopment = true));

            serviceBuilder.Add(nameof(PlatformEMCommodity), new PlatformEMCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformMarket), new PlatformMarketService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformMCommodity), new PlatformMCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformSMCommodity), new PlatformSMCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformMMCommodity), new PlatformMMCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformPlatMarket), new PlatformPlatMarketService(e => e.IsDevelopment = true));

            serviceBuilder.Add(nameof(PlatformProducter), new PlatformProducterService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformEPCommodity), new PlatformEPCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformSPCommodity), new PlatformSPCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformMPCommodity), new PlatformMPCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformProductCenter), new PlatformProductCenterService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformProductLand), new PlatformProductLandService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformPCommodity), new PlatformPCommodityService(e => e.IsDevelopment = true));
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {

        }
    }
}
