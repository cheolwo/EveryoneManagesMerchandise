﻿using BusinessView.ofActorService;
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
using BusinessView.ofValidator.ofEmployer.ofGroupOrder;
using BusinessView.ofValidator.ofEmployer.ofHR;
using BusinessView.ofValidator.ofEmployer.ofJournal;
using BusinessView.ofValidator.ofEmployer.ofMarket;
using BusinessView.ofValidator.ofEmployer.ofOrder;
using BusinessView.ofValidator.ofEmployer.ofProduct;
using BusinessView.ofValidator.ofEmployer.ofTrade;
using BusinessView.ofValidator.ofEmployer.ofWarehouse;

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
            ValidatorBuilder.Add(nameof(EmployerEmployeeRole), new EmployerEmployeeRoleValidator());
            ValidatorBuilder.Add(nameof(EmployerHRBusinessPart), new EmployerHRBusinessPartValidator());
            ValidatorBuilder.Add(nameof(EmployerHRCenter), new EmployerHRCenterValidator());
            ValidatorBuilder.Add(nameof(EmployerHREmployee), new EmployerHREmployeeValidator());
            ValidatorBuilder.Add(nameof(EmployerHRRole), new EmployerHRRoleValidator());

            ValidatorBuilder.Add(nameof(EmployerJCommodity), new EmployerJCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerJournal), new EmployerJournalValidator());
            ValidatorBuilder.Add(nameof(EmployerJournalCenter), new EmployerJournalCenterValidator());

            ValidatorBuilder.Add(nameof(EmployerWarehouse), new EmployerWarehouseValidator());
            ValidatorBuilder.Add(nameof(EmployerWCommodity), new EmployerWCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerSWCommodity), new EmployerSWCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerMWCommodity), new EmployerMWCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerEWCommodity), new EmployerEWCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerDividedTag), new EmployerDividedTagValidator());
            ValidatorBuilder.Add(nameof(EmployerDotBarcode), new EmployerDotBarcodeValidator());
            ValidatorBuilder.Add(nameof(EmployerIncomingTag), new EmployerIncomingTagValidator());
            ValidatorBuilder.Add(nameof(EmployerLoadFrame), new EmployerLoadFrameValidator());
            ValidatorBuilder.Add(nameof(EmployerWorkingDesk), new EmployerWorkingDeskValidator());

            ValidatorBuilder.Add(nameof(EmployerTradeCenter), new EmployerTradeCenterValidator());
            ValidatorBuilder.Add(nameof(EmployerTCommodity), new EmployerTCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerSTCommodity), new EmployerSTCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerMTCommodity), new EmployerMTCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerETCommodity), new EmployerETCommodityValidator());

            ValidatorBuilder.Add(nameof(EmployerGOC), new EmployerGOCValidator());
            ValidatorBuilder.Add(nameof(EmployerGOCC), new EmployerGOCCValidator());
            ValidatorBuilder.Add(nameof(EmployerSGOC), new EmployerSGOCValidator());
            ValidatorBuilder.Add(nameof(EmployerMGOC), new EmployerMGOCValidator());
            ValidatorBuilder.Add(nameof(EmployerEGOC), new EmployerEGOCValidator());

            ValidatorBuilder.Add(nameof(EmployerOrderCenter), new EmployerOrderCenterValidator());
            ValidatorBuilder.Add(nameof(EmployerOCommodity), new EmployerOCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerSOCommodity), new EmployerSOCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerMOCommodity), new EmployerMOCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerEOCommodity), new EmployerEOCommodityValidator());

            ValidatorBuilder.Add(nameof(EmployerEMCommodity), new EmployerEMCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerSMCommodity), new EmployerSMCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerMMCommodity), new EmployerMMCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerMCommodity), new EmployerMCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerPlatMarket), new EmployerPlatMarketValidator());
            ValidatorBuilder.Add(nameof(EmployerMarket), new EmployerMarketValidator());

            ValidatorBuilder.Add(nameof(EmployerProducter), new EmployerProducterValidator());
            ValidatorBuilder.Add(nameof(EmployerEPCommodity), new EmployerEPCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerSPCommodity), new EmployerSPCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerMPCommodity), new EmployerMPCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerProductCenter), new EmployerProductCenterValidator());
            ValidatorBuilder.Add(nameof(EmployerProductLand), new EmployerProductLandValidator());
            ValidatorBuilder.Add(nameof(EmployerPCommodity), new EmployerPCommodityValidator());
        }
    }
}
