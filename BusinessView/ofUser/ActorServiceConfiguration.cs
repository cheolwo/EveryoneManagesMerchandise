using BusinessView.ofCommon.ofServices;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofServices.ofGroupOrder;
using BusinessView.ofServices.ofHR;
using BusinessView.ofServices.ofJournal;
using BusinessView.ofServices.ofMarket;
using BusinessView.ofServices.ofOrder;
using BusinessView.ofServices.ofProduct;
using BusinessView.ofServices.ofTrade;
using BusinessView.ofUser.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder.ofGOC;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder.ofGOCC;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder.ofMGOC;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder.ofSGOC;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR.ofEmployeeRole;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR.ofHRBusinessPart;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR.ofHRCenter;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR.ofHREmployee;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR.ofHRRole;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal.ofJCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal.ofJournal;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal.ofJournalCenter;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket.ofEMCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket.ofMarket;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket.ofMCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket.ofMMCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket.ofPlatMarket;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket.ofSMCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder.ofEOCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder.ofMOCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder.ofOCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder.ofSOCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofEPCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofMPCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofPCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofProductCenter;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofProducter;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofProductLand;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofSPCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade.ofETCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade.ofMTCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade.ofSTCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade.ofTCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade.ofTradeCenter;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofDividedTag;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofDotBarcode;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofEWCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofIncomingTag;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofLoadFrame;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofMWCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofSWCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofWarehouse;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofWCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse.ofWorkingDesk;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder.ofGOC;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder.ofGOCC;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder.ofMGOC;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofGroupOrder.ofSGOC;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR.ofEmployeeRole;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR.ofHRBusinessPart;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR.ofHRCenter;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR.ofHREmployee;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofHR.ofHRRole;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofJournal.ofJCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofJournal.ofJournal;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofJournal.ofJournalCenter;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket.ofEMCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket.ofMarket;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket.ofMCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket.ofMMCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket.ofPlatMarket;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofMarket.ofSMCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder.ofEOCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder.ofMOCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder.ofOCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofOrder.ofSOCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct.ofEPCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct.ofMPCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct.ofPCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct.ofProductCenter;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct.ofProducter;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct.ofProductLand;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofProduct.ofSPCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade.ofETCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade.ofMTCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade.ofSTCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade.ofTCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofTrade.ofTradeCenter;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofDividedTag;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofDotBarcode;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofEWCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofIncomingTag;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofLoadFrame;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofMWCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofSWCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofWarehouse;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofWCommodity;
using BusinessView.ofViewModels.ofWebApp.ofEmployee.ofWarehouse.ofWorkingDesk;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder.ofGOC;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder.ofGOCC;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder.ofMGOC;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder.ofSGOC;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR.ofEmployeeRole;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR.ofHRBusinessPart;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR.ofHRCenter;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR.ofHREmployee;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR.ofHRRole;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofJournal.ofJCommodity;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofJournal.ofJournal;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofJournal.ofJournalCenter;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket.ofEMCommodity;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket.ofMarket;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket.ofMCommodity;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket.ofMMCommodity;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket.ofPlatMarket;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket.ofSMCommodity;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder.ofEOCommodity;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder.ofMOCommodity;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder.ofOCommodity;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder.ofSOCommodity;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct.ofEPCommodity;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct.ofMPCommodity;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct.ofPCommodity;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct.ofProductCenter;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct.ofProducter;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct.ofProductLand;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct.ofSPCommodity;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade.ofETCommodity;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade.ofMTCommodity;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade.ofSTCommodity;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade.ofTCommodity;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade.ofTradeCenter;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofDividedTag;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofDotBarcode;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofEWCommodity;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofIncomingTag;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofLoadFrame;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofMWCommodity;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofSWCommodity;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofWarehouse;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofWCommodity;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofWorkingDesk;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessView.ofActorService
{
    public class ActorServiceOption
    {
        public const string ActorService = "ActorService";
        public bool IsDevelopment = true;
        public DTOServiceOptions DTOServiceOptions = new();
        public GroupOrderServiceOptions GroupOrderServiceOptions = new();
        public HRServiceOptions HRServiceOptions = new();
        public JournalServiceOptions JournalServiceOptions = new();
        public MarketServiceOptions MarketServiceOptions = new();
        public OrderServiceOptions OrderServiceOptions = new();
        public TradeServiceOptions TradeServiceOptions = new();
        public WarehouseServiceOptions WarehouseServiceOptions = new();
        public ProductServiceOptions ProductServiceOptions = new();
    }
    public static class ActorServiceConfiguration
    {
        public static IServiceCollection AddEmployerActorService(this IServiceCollection services)
        {
            services.AddScoped<UserActorContext>();
            services.AddScoped<EmployerActorContext>();
            services.AddScoped(typeof(EntityPageViewModel<>));
            services.AddScoped(typeof(CenterPageViewModel<>));
            services.AddScoped(typeof(CommodityPageViewModel<>));
            services.AddScoped(typeof(StatusPageViewModel<>));

            services.AddScoped<EmployerGOCPageViewModel>();
            services.AddScoped<EmployerGOCCPageViewModel>();
            services.AddScoped<EmployerSGOCPageViewModel>();
            services.AddScoped<EmployerMGOCPageViewModel>();
            services.AddScoped<EmployerMGOCPageViewModel>();

            services.AddScoped<EmployerEmployeeRolePageViewModel>();
            services.AddScoped<EmployerHRBusinessPartPageViewModel>();
            services.AddScoped<EmployerHRCenterPageViewModel>();
            services.AddScoped<EmployerHREmployeePageViewModel>();
            services.AddScoped<EmployerHRRolePageViewModel>();

            services.AddScoped<EmployerJCommodityPageViewModel>();
            services.AddScoped<EmployerJournalPageViewModel>();
            services.AddScoped<EmployerJournalCenterPageViewModel>();

            services.AddScoped<EmployerEMCommodityPageViewModel>();
            services.AddScoped<EmployerMarketPageViewModel>();
            services.AddScoped<EmployerMCommodityPageViewModel>();
            services.AddScoped<EmployerSMCommodityPageViewModel>();
            services.AddScoped<EmployerMMCommodityPageViewModel>();
            services.AddScoped<EmployerPlatMarketPageViewModel>();

            services.AddScoped<EmployerEOCommodityPageViewModel>();
            services.AddScoped<EmployerMOCommodityPageViewModel>();
            services.AddScoped<EmployerSOCommodityPageViewModel>();
            services.AddScoped<EmployerOCommodityPageViewModel>();
            services.AddScoped<EmployerMGOCPageViewModel>();

            services.AddScoped<EmployerEPCommodityPageViewModel>();
            services.AddScoped<EmployerSPCommodityPageViewModel>();
            services.AddScoped<EmployerMPCommodityPageViewModel>();
            services.AddScoped<EmployerPCommodityPageViewModel>();
            services.AddScoped<EmployerProductCenterPageViewModel>();
            services.AddScoped<EmployerProductLandPageViewModel>();
            services.AddScoped<EmployerProducterPageViewModel>();

            services.AddScoped<EmployerETCommodityPageViewModel>();
            services.AddScoped<EmployerMTCommodityPageViewModel>();
            services.AddScoped<EmployerSTCommodityPageViewModel>();
            services.AddScoped<EmployerTCommodityPageViewModel>();
            services.AddScoped<EmployerTradeCenterPageViewModel>();

            services.AddScoped<EmployerDividedTagPageViewModel>();
            services.AddScoped<EmployerDotBarcodePageViewModel>();
            services.AddScoped<EmployerIncomingTagPageViewModel>();
            services.AddScoped<EmployerWorkingDeskPageViewModel>();
            services.AddScoped<EmployerLoadFramePageViewModel>();
            services.AddScoped<EmployerWarehousePageViewModel>();
            services.AddScoped<EmployerWCommodityPageViewModel>();
            services.AddScoped<EmployerSWCommodityPageViewModel>();
            services.AddScoped<EmployerMWCommodityPageViewModel>();
            services.AddScoped<EmployerEWCommodityPageViewModel>();

            return services;
        }
        public static IServiceCollection AddPlatformActorService(this IServiceCollection services)
        {
            services.AddScoped<UserActorContext>();
            services.AddScoped<EmployerActorContext>();
            services.AddScoped(typeof(EntityPageViewModel<>));
            services.AddScoped(typeof(CenterPageViewModel<>));
            services.AddScoped(typeof(CommodityPageViewModel<>));
            services.AddScoped(typeof(StatusPageViewModel<>));

            services.AddScoped<PlatformGOCPageViewModel>();
            services.AddScoped<PlatformGOCCPageViewModel>();
            services.AddScoped<PlatformSGOCPageViewModel>();
            services.AddScoped<PlatformMGOCPageViewModel>();
            services.AddScoped<PlatformMGOCPageViewModel>();

            services.AddScoped<PlatformEmployeeRolePageViewModel>();
            services.AddScoped<PlatformHRBusinessPartPageViewModel>();
            services.AddScoped<PlatformHRCenterPageViewModel>();
            services.AddScoped<PlatformHREmployeePageViewModel>();
            services.AddScoped<PlatformHRRolePageViewModel>();

            services.AddScoped<PlatformJCommodityPageViewModel>();
            services.AddScoped<PlatformJournalPageViewModel>();
            services.AddScoped<PlatformJournalCenterPageViewModel>();

            services.AddScoped<PlatformEMCommodityPageViewModel>();
            services.AddScoped<PlatformMarketPageViewModel>();
            services.AddScoped<PlatformMCommodityPageViewModel>();
            services.AddScoped<PlatformSMCommodityPageViewModel>();
            services.AddScoped<PlatformMMCommodityPageViewModel>();
            services.AddScoped<PlatformPlatMarketPageViewModel>();

            services.AddScoped<PlatformEOCommodityPageViewModel>();
            services.AddScoped<PlatformMOCommodityPageViewModel>();
            services.AddScoped<PlatformSOCommodityPageViewModel>();
            services.AddScoped<PlatformOCommodityPageViewModel>();
            services.AddScoped<PlatformMGOCPageViewModel>();

            services.AddScoped<PlatformEPCommodityPageViewModel>();
            services.AddScoped<PlatformSPCommodityPageViewModel>();
            services.AddScoped<PlatformMPCommodityPageViewModel>();
            services.AddScoped<PlatformPCommodityPageViewModel>();
            services.AddScoped<PlatformProductCenterPageViewModel>();
            services.AddScoped<PlatformProductLandPageViewModel>();
            services.AddScoped<PlatformProducterPageViewModel>();

            services.AddScoped<PlatformETCommodityPageViewModel>();
            services.AddScoped<PlatformMTCommodityPageViewModel>();
            services.AddScoped<PlatformSTCommodityPageViewModel>();
            services.AddScoped<PlatformTCommodityPageViewModel>();
            services.AddScoped<PlatformTradeCenterPageViewModel>();

            services.AddScoped<PlatformDividedTagPageViewModel>();
            services.AddScoped<PlatformDotBarcodePageViewModel>();
            services.AddScoped<PlatformIncomingTagPageViewModel>();
            services.AddScoped<PlatformWorkingDeskPageViewModel>();
            services.AddScoped<PlatformLoadFramePageViewModel>();
            services.AddScoped<PlatformWarehousePageViewModel>();
            services.AddScoped<PlatformWCommodityPageViewModel>();
            services.AddScoped<PlatformSWCommodityPageViewModel>();
            services.AddScoped<PlatformMWCommodityPageViewModel>();
            services.AddScoped<PlatformEWCommodityPageViewModel>();
            return services;
        }
        public static IServiceCollection AddEmployeeActorService(this IServiceCollection services)
        {
            services.AddScoped<UserActorContext>();
            services.AddScoped<EmployeeActorContext>();
            services.AddScoped(typeof(EntityPageViewModel<>));
            services.AddScoped(typeof(CenterPageViewModel<>));
            services.AddScoped(typeof(CommodityPageViewModel<>));
            services.AddScoped(typeof(StatusPageViewModel<>));

            services.AddScoped<EmployeeGOCPageViewModel>();
            services.AddScoped<EmployeeGOCCPageViewModel>();
            services.AddScoped<EmployeeSGOCPageViewModel>();
            services.AddScoped<EmployeeMGOCPageViewModel>();
            services.AddScoped<EmployeeMGOCPageViewModel>();

            services.AddScoped<EmployeeEmployeeRolePageViewModel>();
            services.AddScoped<EmployeeHRBusinessPartPageViewModel>();
            services.AddScoped<EmployeeHRCenterPageViewModel>();
            services.AddScoped<EmployeeHREmployeePageViewModel>();
            services.AddScoped<EmployeeHRRolePageViewModel>();

            services.AddScoped<EmployeeJCommodityPageViewModel>();
            services.AddScoped<EmployeeJournalPageViewModel>();
            services.AddScoped<EmployeeJournalCenterPageViewModel>();

            services.AddScoped<EmployeeEMCommodityPageViewModel>();
            services.AddScoped<EmployeeMarketPageViewModel>();
            services.AddScoped<EmployeeMCommodityPageViewModel>();
            services.AddScoped<EmployeeSMCommodityPageViewModel>();
            services.AddScoped<EmployeeMMCommodityPageViewModel>();
            services.AddScoped<EmployeePlatMarketPageViewModel>();

            services.AddScoped<EmployeeEOCommodityPageViewModel>();
            services.AddScoped<EmployeeMOCommodityPageViewModel>();
            services.AddScoped<EmployeeSOCommodityPageViewModel>();
            services.AddScoped<EmployeeOCommodityPageViewModel>();
            services.AddScoped<EmployeeMGOCPageViewModel>();

            services.AddScoped<EmployeeEPCommodityPageViewModel>();
            services.AddScoped<EmployeeSPCommodityPageViewModel>();
            services.AddScoped<EmployeeMPCommodityPageViewModel>();
            services.AddScoped<EmployeePCommodityPageViewModel>();
            services.AddScoped<EmployeeProductCenterPageViewModel>();
            services.AddScoped<EmployeeProductLandPageViewModel>();
            services.AddScoped<EmployeeProducterPageViewModel>();

            services.AddScoped<EmployeeETCommodityPageViewModel>();
            services.AddScoped<EmployeeMTCommodityPageViewModel>();
            services.AddScoped<EmployeeSTCommodityPageViewModel>();
            services.AddScoped<EmployeeTCommodityPageViewModel>();
            services.AddScoped<EmployeeTradeCenterPageViewModel>();

            services.AddScoped<EmployeeDividedTagPageViewModel>();
            services.AddScoped<EmployeeDotBarcodePageViewModel>();
            services.AddScoped<EmployeeIncomingTagPageViewModel>();
            services.AddScoped<EmployeeWorkingDeskPageViewModel>();
            services.AddScoped<EmployeeLoadFramePageViewModel>();
            services.AddScoped<EmployeeWarehousePageViewModel>();
            services.AddScoped<EmployeeWCommodityPageViewModel>();
            services.AddScoped<EmployeeSWCommodityPageViewModel>();
            services.AddScoped<EmployeeMWCommodityPageViewModel>();
            services.AddScoped<EmployeeEWCommodityPageViewModel>();
            return services;
        }
        public static IServiceCollection AddEmployerLogisterService(this IServiceCollection services)
        {
            services.AddScoped<UserActorContext>();
            services.AddScoped<EmployerLogisterContext>();
            services.AddScoped(typeof(EntityPageViewModel<>));
            services.AddScoped(typeof(CenterPageViewModel<>));
            services.AddScoped(typeof(CommodityPageViewModel<>));
            services.AddScoped(typeof(StatusPageViewModel<>));
            return services;
        }
    }
}
