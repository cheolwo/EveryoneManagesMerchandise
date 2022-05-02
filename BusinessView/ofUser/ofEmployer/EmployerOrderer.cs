using BusinessView.ofCommon.ofServices.ofGroupOrder.ofEmployer;
using BusinessView.ofCommon.ofServices.ofJournal.ofEmployer;
using BusinessView.ofGroupOrder.ofEmployer;
using BusinessView.ofMarket.ofEmployer;
using BusinessView.ofOrder.ofEmployer;
using BusinessView.ofProduct.ofEmployer;
using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofWarehouse.ofEmployer;

namespace BusinessView.ofUser.ofEmployer
{
    public class EmployerOrderer: EmployerActor
    {
        public EmployerOrderer()
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

            serviceBuilder.Add(nameof(EmployerGOC), new EmployerGOCService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerGOCC), new EmployerGOCCService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerSGOC), new EmployerSGOCService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerMGOC), new EmployerMGOCService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerEGOC), new EmployerEGOCService(e => e.IsDevelopment = true));

            serviceBuilder.Add(nameof(EmployerTradeCenter), new EmployerTradeCenterService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerTCommodity), new EmployerTCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerSTCommodity), new EmployerSTCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerMTCommodity), new EmployerMTCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerETCommodity), new EmployerETCommodityService(e => e.IsDevelopment = true));

            serviceBuilder.Add(nameof(EmployerOrderCenter), new EmployerOrderCenterService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerOCommodity), new EmployerOCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerSOCommodity), new EmployerSOCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerMOCommodity), new EmployerMOCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerEOCommodity), new EmployerEOCommodityService(e => e.IsDevelopment = true));

            serviceBuilder.Add(nameof(EmployerEMCommodity), new EmployerEMCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerMarket), new EmployerMarketService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerMCommodity), new EmployerMCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerSMCommodity), new EmployerSMCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerMMCommodity), new EmployerMMCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerPlatMarket), new EmployerPlatMarketService(e => e.IsDevelopment = true));

            serviceBuilder.Add(nameof(EmployerProducter), new EmployerProducterService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerEPCommodity), new EmployerEPCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerSPCommodity), new EmployerSPCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerMPCommodity), new EmployerMPCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerProductCenter), new EmployerProductCenterService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerProductLand), new EmployerProductLandService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(EmployerPCommodity), new EmployerPCommodityService(e => e.IsDevelopment = true));
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {

        }
    }
}
