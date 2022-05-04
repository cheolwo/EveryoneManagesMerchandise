using BusinessView.ofActorService;
using BusinessView.ofCommon.ofServices.ofGroupOrder.ofPlatform;
using BusinessView.ofCommon.ofServices.ofHR.ofEmployee;
using BusinessView.ofCommon.ofServices.ofJournal.ofPlatform;
using BusinessView.ofCommon.ofServices.ofJournalCenter.ofEmployee;
using BusinessView.ofCommon.ofServices.ofJournalCenter.ofPlatform;
using BusinessView.ofDTO.ofGroupOrder.ofPlatform;
using BusinessView.ofDTO.ofHR.ofPlatform;
using BusinessView.ofDTO.ofJournal.ofPlatform;
using BusinessView.ofDTO.ofMarket.ofPlatform;
using BusinessView.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofUser.ofCommon;
using Microsoft.Extensions.Options;

namespace BusinessView.ofUser
{
    public class PlatformActorContext : UserActorContext
    {
        public PlatformActorContext(ActorServiceOption options)
            :base(options)
        {

        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder) 
        {
            serviceBuilder.Add(nameof(PlatformEmployeeRole), new PlatformEmployeeRoleService(_options.HRServiceOptions));
            serviceBuilder.Add(nameof(PlatformHRBusinessPart), new PlatformHRBusinessPartService(_options.HRServiceOptions));
            serviceBuilder.Add(nameof(PlatformHRCenter), new PlatformHRCenterService(_options.HRServiceOptions));
            serviceBuilder.Add(nameof(PlatformHREmployee), new PlatformHREmployeeService(_options.HRServiceOptions));
            serviceBuilder.Add(nameof(PlatformHRRole), new PlatformHRRoleService(_options.HRServiceOptions));

            serviceBuilder.Add(nameof(PlatformJCommodity), new PlatformJCommodityService(_options.JournalServiceOptions));
            serviceBuilder.Add(nameof(PlatformJournal), new PlatformJournalService(_options.JournalServiceOptions));
            serviceBuilder.Add(nameof(PlatformJournalCenter), new PlatformJournalCenterService(_options.JournalServiceOptions));

            serviceBuilder.Add(nameof(PlatformWarehouse), new PlatformWarehouseService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(PlatformWCommodity), new PlatformWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(PlatformSWCommodity), new PlatformSWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(PlatformMWCommodity), new PlatformMWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(PlatformEWCommodity), new PlatformEWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(PlatformDividedTag), new PlatformDividedTagService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(PlatformDotBarcode), new PlatformDotBarcodeService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(PlatformIncomingTag), new PlatformIncomingTagService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(PlatformLoadFrame), new PlatformLoadFrameService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(PlatformWorkingDesk), new PlatformWorkingDeskService(_options.WarehouseServiceOptions));

            serviceBuilder.Add(nameof(PlatformTradeCenter), new PlatformTradeCenterService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(PlatformTCommodity), new PlatformTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(PlatformSTCommodity), new PlatformSTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(PlatformMTCommodity), new PlatformMTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(PlatformETCommodity), new PlatformETCommodityService(_options.TradeServiceOptions));

            serviceBuilder.Add(nameof(PlatformGOC), new PlatformGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformGOCC), new PlatformGOCCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformSGOC), new PlatformSGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformMGOC), new PlatformMGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformEGOC), new PlatformEGOCService(_options.GroupOrderServiceOptions));

            serviceBuilder.Add(nameof(PlatformOrderCenter), new PlatformOrderCenterService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformOCommodity), new PlatformOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformSOCommodity), new PlatformSOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformMOCommodity), new PlatformMOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformEOCommodity), new PlatformEOCommodityService(_options.OrderServiceOptions));

            serviceBuilder.Add(nameof(PlatformEMCommodity), new PlatformEMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(PlatformSMCommodity), new PlatformSMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(PlatformMMCommodity), new PlatformMMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(PlatformMCommodity), new PlatformMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(PlatformPlatMarket), new PlatformPlatMarketService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(PlatformMarket), new PlatformMarketService(_options.MarketServiceOptions));

            serviceBuilder.Add(nameof(PlatformProducter), new PlatformProducterService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(PlatformEPCommodity), new PlatformEPCommodityService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(PlatformSPCommodity), new PlatformSPCommodityService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(PlatformMPCommodity), new PlatformMPCommodityService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(PlatformProductCenter), new PlatformProductCenterService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(PlatformProductLand), new PlatformProductLandService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(PlatformPCommodity), new PlatformPCommodityService(_options.ProductServiceOptions));
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {

        }
    }
}
