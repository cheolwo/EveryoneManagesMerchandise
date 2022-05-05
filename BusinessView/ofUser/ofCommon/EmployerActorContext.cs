using BusinessView.ofActorService;
using BusinessView.ofCommon.ofServices.ofGroupOrder.ofEmployer;
using BusinessView.ofCommon.ofServices.ofHR.ofEmployee;
using BusinessView.ofCommon.ofServices.ofJournal.ofEmployer;
using BusinessView.ofCommon.ofServices.ofJournalCenter.ofEmployee;
using BusinessView.ofCommon.ofServices.ofJournalCenter.ofEmployer;
using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofDTO.ofJournal.ofEmployer;
using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofUser.ofCommon;
using Microsoft.Extensions.Options;

namespace BusinessView.ofCommon.ofUser
{
    public class EmployerActorContext : UserActorContext
    {
        public EmployerActorContext(ActorServiceOption options)
            :base(options)
        {

        }


        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder)
        {
            serviceBuilder.Add(nameof(EmployerEmployeeRole), new EmployerEmployeeRoleService(_options.HRServiceOptions));
            serviceBuilder.Add(nameof(EmployerHRBusinessPart), new EmployerHRBusinessPartService(_options.HRServiceOptions));
            serviceBuilder.Add(nameof(EmployerHRCenter), new EmployerHRCenterService(_options.HRServiceOptions));
            serviceBuilder.Add(nameof(EmployerHREmployee), new EmployerHREmployeeService(_options.HRServiceOptions));
            serviceBuilder.Add(nameof(EmployerHRRole), new EmployerHRRoleService(_options.HRServiceOptions));

            serviceBuilder.Add(nameof(EmployerJCommodity), new EmployerJCommodityService(_options.JournalServiceOptions));
            serviceBuilder.Add(nameof(EmployerJournal), new EmployerJournalService(_options.JournalServiceOptions));
            serviceBuilder.Add(nameof(EmployerJournalCenter), new EmployerJournalCenterService(_options.JournalServiceOptions));

            serviceBuilder.Add(nameof(EmployerWarehouse), new EmployerWarehouseService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerWCommodity), new EmployerWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerSWCommodity), new EmployerSWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerMWCommodity), new EmployerMWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerEWCommodity), new EmployerEWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerDividedTag), new EmployerDividedTagService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerDotBarcode), new EmployerDotBarcodeService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerIncomingTag), new EmployerIncomingTagService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerLoadFrame), new EmployerLoadFrameService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerWorkingDesk), new EmployerWorkingDeskService(_options.WarehouseServiceOptions));

            serviceBuilder.Add(nameof(EmployerTradeCenter), new EmployerTradeCenterService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployerTCommodity), new EmployerTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployerSTCommodity), new EmployerSTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployerMTCommodity), new EmployerMTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployerETCommodity), new EmployerETCommodityService(_options.TradeServiceOptions));

            serviceBuilder.Add(nameof(EmployerGOC), new EmployerGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(EmployerGOCC), new EmployerGOCCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(EmployerSGOC), new EmployerSGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(EmployerMGOC), new EmployerMGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(EmployerEGOC), new EmployerEGOCService(_options.GroupOrderServiceOptions));

            serviceBuilder.Add(nameof(EmployerOrderCenter), new EmployerOrderCenterService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(EmployerOCommodity), new EmployerOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(EmployerSOCommodity), new EmployerSOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(EmployerMOCommodity), new EmployerMOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(EmployerEOCommodity), new EmployerEOCommodityService(_options.OrderServiceOptions));

            serviceBuilder.Add(nameof(EmployerEMCommodity), new EmployerEMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployerSMCommodity), new EmployerSMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployerMMCommodity), new EmployerMMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployerMCommodity), new EmployerMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployerPlatMarket), new EmployerPlatMarketService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployerMarket), new EmployerMarketService(_options.MarketServiceOptions));

            serviceBuilder.Add(nameof(EmployerProducter), new EmployerProducterService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployerEPCommodity), new EmployerEPCommodityService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployerSPCommodity), new EmployerSPCommodityService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployerMPCommodity), new EmployerMPCommodityService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployerProductCenter), new EmployerProductCenterService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployerProductLand), new EmployerProductLandService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployerPCommodity), new EmployerPCommodityService(_options.ProductServiceOptions));
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder)
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde)
        {

        }
    }
}
