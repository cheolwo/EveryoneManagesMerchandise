using BusinessView.ofActorService;
using BusinessView.ofCommon.ofServices.ofGroupOrder.ofEmployee;
using BusinessView.ofCommon.ofServices.ofJournal.ofEmployee;
using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofUser.ofCommon;
using Microsoft.Extensions.Options;

namespace BusinessView.ofUser.ofEmployee
{
    public class EmployeeProducterContext : EmployeeActorContext
    {
        public EmployeeProducterContext(ActorServiceOption options)
            :base(options)
        {

        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder) 
        {
            serviceBuilder.Add(nameof(EmployeeWarehouse), new EmployeeWarehouseService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeWCommodity), new EmployeeWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeSWCommodity), new EmployeeSWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMWCommodity), new EmployeeMWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeEWCommodity), new EmployeeEWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeDividedTag), new EmployeeDividedTagService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeDotBarcode), new EmployeeDotBarcodeService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeIncomingTag), new EmployeeIncomingTagService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeLoadFrame), new EmployeeLoadFrameService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeWorkingDesk), new EmployeeWorkingDeskService(_options.WarehouseServiceOptions));

            serviceBuilder.Add(nameof(EmployeeGOC), new EmployeeGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeGOCC), new EmployeeGOCCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeSGOC), new EmployeeSGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMGOC), new EmployeeMGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeEGOC), new EmployeeEGOCService(_options.GroupOrderServiceOptions));

            serviceBuilder.Add(nameof(EmployeeTradeCenter), new EmployeeTradeCenterService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployeeTCommodity), new EmployeeTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployeeSTCommodity), new EmployeeSTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMTCommodity), new EmployeeMTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployeeETCommodity), new EmployeeETCommodityService(_options.TradeServiceOptions));

            serviceBuilder.Add(nameof(EmployeeOrderCenter), new EmployeeOrderCenterService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeOCommodity), new EmployeeOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeSOCommodity), new EmployeeSOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMOCommodity), new EmployeeMOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeEOCommodity), new EmployeeEOCommodityService(_options.OrderServiceOptions));

            serviceBuilder.Add(nameof(EmployeeEMCommodity), new EmployeeEMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMarket), new EmployeeMarketService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMCommodity), new EmployeeMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployeeSMCommodity), new EmployeeSMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMMCommodity), new EmployeeMMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployeePlatMarket), new EmployeePlatMarketService(_options.MarketServiceOptions));

            serviceBuilder.Add(nameof(EmployeeProducterContext), new EmployeeProducterService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployeeEPCommodity), new EmployeeEPCommodityService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployeeSPCommodity), new EmployeeSPCommodityService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMPCommodity), new EmployeeMPCommodityService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployeeProductCenter), new EmployeeProductCenterService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployeeProductLand), new EmployeeProductLandService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployeePCommodity), new EmployeePCommodityService(_options.ProductServiceOptions));
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {

        }
    }
}
