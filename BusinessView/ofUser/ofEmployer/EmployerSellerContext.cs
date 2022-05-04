using BusinessView.ofActorService;
using BusinessView.ofCommon.ofServices.ofJournal.ofEmployer;
using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofUser.ofCommon;
using Microsoft.Extensions.Options;

namespace BusinessView.ofUser.ofEmployer
{
    public class EmployerSellerContext: EmployerActorContext
    {
        public EmployerSellerContext(ActorServiceOption options)
            :base(options)
        {

        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder) 
        {
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

            serviceBuilder.Add(nameof(EmployerEMCommodity), new EmployerEMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployerSMCommodity), new EmployerSMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployerMMCommodity), new EmployerMMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployerMCommodity), new EmployerMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployerPlatMarket), new EmployerPlatMarketService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployerMarket), new EmployerMarketService(_options.MarketServiceOptions));
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {

        }
    }
}
