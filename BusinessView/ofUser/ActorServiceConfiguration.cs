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
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder.ofEGOC;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofTrade;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofProduct;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofMarket;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofOrder;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofJournal;
using BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder.ofEGOC;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessLogic.ofExternal.ofSearchingService;

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
            services.AddScoped<GetUserViewModel>();
            services.AddScoped<UserActorContext>();
            services.AddScoped<EmployerActorContext>();
            services.AddScoped<ActorServiceOption>();
            services.AddScoped(typeof(EntityPageViewModel<>));
            services.AddScoped(typeof(CenterPageViewModel<>));
            services.AddScoped(typeof(CommodityPageViewModel<>));
            services.AddScoped(typeof(StatusPageViewModel<>));

            services.AddScoped(typeof(EntityPageViewModel<>));
            services.AddScoped(typeof(EntityPostViewModel<>));
            services.AddScoped(typeof(EntityPutViewModel<>));
            services.AddScoped(typeof(EntityDeleteViewModel<>));
            services.AddScoped(typeof(EntityGetsViewModel<>));

            services.AddScoped(typeof(CenterPageViewModel<>));
            services.AddScoped(typeof(CenterPostViewModel<>));
            services.AddScoped(typeof(CenterPutViewModel<>));
            services.AddScoped(typeof(CenterDeleteViewModel<>));
            services.AddScoped(typeof(CenterGetsViewModel<>));

            services.AddScoped(typeof(CommodityPageViewModel<>));
            services.AddScoped(typeof(CommodityPostViewModel<>));
            services.AddScoped(typeof(CommodityPutViewModel<>));
            services.AddScoped(typeof(CommodityDeleteViewModel<>));
            services.AddScoped(typeof(CommodityGetsViewModel<>));

            services.AddScoped(typeof(StatusPageViewModel<>));
            services.AddScoped(typeof(StatusPostViewModel<>));
            services.AddScoped(typeof(StatusPutViewModel<>));
            services.AddScoped(typeof(StatusDeleteViewModel<>));
            services.AddScoped(typeof(StatusGetsViewModel<>));

            services.AddScoped(typeof(EmployerPageViewModel<>));
            services.AddScoped(typeof(ofViewModels.ofGeneric.EmployerPostViewModel<>));
            services.AddScoped(typeof(EmployerPutViewModel<>));
            services.AddScoped(typeof(EmployerDeleteViewModel<>));
            services.AddScoped(typeof(EmployerGetsViewModel<>));

            services.AddScoped<ICenterPageRoadAddressService, KoreaSearchingAddressService>();
            services.AddScoped<ICenterPageTaxService, TaxService>();
            services.AddScoped<ICenterPageIdentityRoleService, IdentityRoleService>();

            services.AddScoped<EmployerGOCPageViewModel>();
            services.AddScoped<EmployerPostGOCViewModel>();
            services.AddScoped<EmployerPutGOCViewModel>();
            services.AddScoped<EmployerDeleteGOCViewModel>();
            services.AddScoped<EmployerGetsGOCViewModel>();

            services.AddScoped<EmployerGOCCPageViewModel>();
            services.AddScoped<EmployerPostGOCCViewModel>();
            services.AddScoped<EmployerPutGOCCViewModel>();
            services.AddScoped<EmployerDeleteGOCCViewModel>();
            services.AddScoped<EmployerGetsGOCCViewModel>();

            services.AddScoped<EmployerSGOCPageViewModel>();
            services.AddScoped<EmployerPostSGOCViewModel>();
            services.AddScoped<EmployerPutSGOCViewModel>();
            services.AddScoped<EmployerDeleteSGOCViewModel>();
            services.AddScoped<EmployerGetsSGOCViewModel>();

            services.AddScoped<EmployerMGOCPageViewModel>();
            services.AddScoped<EmployerPostMGOCViewModel>();
            services.AddScoped<EmployerPutMGOCViewModel>();
            services.AddScoped<EmployerDeleteMGOCViewModel>();
            services.AddScoped<EmployerGetsMGOCViewModel>();

            services.AddScoped<EmployerEGOCPageViewModel>();
            services.AddScoped<EmployerPostEGOCViewModel>();
            services.AddScoped<EmployerPutEGOCViewModel>();
            services.AddScoped<EmployerDeleteEGOCViewModel>();
            services.AddScoped<EmployerGetsEGOCViewModel>();

            services.AddScoped<EmployerEmployeeRolePageViewModel>();
            services.AddScoped<EmployerPostEmployeeRoleViewModel>();
            services.AddScoped<EmployerPutEmployeeRoleViewModel>();
            services.AddScoped<EmployerDeleteEmployeeRoleViewModel>();
            services.AddScoped<EmployerGetsEmployeeRoleViewModel>();

            services.AddScoped<EmployerHRBusinessPartPageViewModel>();
            services.AddScoped<EmployerPostHRBusinessPartViewModel>();
            services.AddScoped<EmployerPutHRBusinessPartViewModel>();
            services.AddScoped<EmployerDeleteHRBusinessPartViewModel>();
            services.AddScoped<EmployerGetsHRBusinessPartViewModel>();

            services.AddScoped<EmployerHRCenterPageViewModel>();
            services.AddScoped<EmployerPostHRCenterViewModel>();
            services.AddScoped<EmployerPutHRCenterViewModel>();
            services.AddScoped<EmployerDeleteHRCenterViewModel>();
            services.AddScoped<EmployerGetsHRCenterViewModel>();

            services.AddScoped<EmployerHREmployeePageViewModel>();
            services.AddScoped<EmployerPostHREmployeeViewModel>();
            services.AddScoped<EmployerPutHREmployeeViewModel>();
            services.AddScoped<EmployerDeleteHREmployeeViewModel>();
            services.AddScoped<EmployerGetsHREmployeeViewModel>();

            services.AddScoped<EmployerHRRolePageViewModel>();
            services.AddScoped<EmployerPostHRRoleViewModel>();
            services.AddScoped<EmployerPutHRRoleViewModel>();
            services.AddScoped<EmployerDeleteHRRoleViewModel>();
            services.AddScoped<EmployerGetsHRRoleViewModel>();

            services.AddScoped<EmployerJCommodityPageViewModel>();
            services.AddScoped<EmployerPostJCommodityViewModel>();
            services.AddScoped<EmployerPutJCommodityViewModel>();
            services.AddScoped<EmployerDeleteJCommodityViewModel>();
            services.AddScoped<EmployerGetsJCommodityViewModel>();

            services.AddScoped<EmployerJournalPageViewModel>();
            services.AddScoped<EmployerPostJournalViewModel>();
            services.AddScoped<EmployerPutJournalViewModel>();
            services.AddScoped<EmployerDeleteJournalViewModel>();
            services.AddScoped<EmployerGetsJournalViewModel>();

            services.AddScoped<EmployerJournalCenterPageViewModel>();
            services.AddScoped<EmployerPostJournalCenterViewModel>();
            services.AddScoped<EmployerPutJournalCenterViewModel>();
            services.AddScoped<EmployerDeleteJournalCenterViewModel>();
            services.AddScoped<EmployerGetsJournalCenterViewModel>();

            services.AddScoped<EmployerEMCommodityPageViewModel>();
            services.AddScoped<EmployerPostEMCommodityViewModel>();
            services.AddScoped<EmployerPutEMCommodityViewModel>();
            services.AddScoped<EmployerDeleteEMCommodityViewModel>();
            services.AddScoped<EmployerGetsEMCommodityViewModel>();

            services.AddScoped<EmployerMarketPageViewModel>();
            services.AddScoped<EmployerPostMarketViewModel>();
            services.AddScoped<EmployerPutMarketViewModel>();
            services.AddScoped<EmployerDeleteMarketViewModel>();
            services.AddScoped<EmployerGetsMarketViewModel>();

            services.AddScoped<EmployerMCommodityPageViewModel>();
            services.AddScoped<EmployerPostMCommodityViewModel>();
            services.AddScoped<EmployerPutMCommodityViewModel>();
            services.AddScoped<EmployerDeleteMCommodityViewModel>();
            services.AddScoped<EmployerGetsMCommodityViewModel>();

            services.AddScoped<EmployerSMCommodityPageViewModel>();
            services.AddScoped<EmployerPostSMCommodityViewModel>();
            services.AddScoped<EmployerPutSMCommodityViewModel>();
            services.AddScoped<EmployerDeleteSMCommodityViewModel>();
            services.AddScoped<EmployerGetsSMCommodityViewModel>();

            services.AddScoped<EmployerMMCommodityPageViewModel>();
            services.AddScoped<EmployerPostMMCommodityViewModel>();
            services.AddScoped<EmployerPutMMCommodityViewModel>();
            services.AddScoped<EmployerDeleteMMCommodityViewModel>();
            services.AddScoped<EmployerGetsMMCommodityViewModel>();

            services.AddScoped<EmployerPlatMarketPageViewModel>();
            services.AddScoped<EmployerPostPlatMarketViewModel>();
            services.AddScoped<EmployerPutPlatMarketViewModel>();
            services.AddScoped<EmployerDeletePlatMarketViewModel>();
            services.AddScoped<EmployerGetsPlatMarketViewModel>();

            services.AddScoped<EmployerEOCommodityPageViewModel>();
            services.AddScoped<EmployerPostEOCommodityViewModel>();
            services.AddScoped<EmployerPutEOCommodityViewModel>();
            services.AddScoped<EmployerDeleteEOCommodityViewModel>();
            services.AddScoped<EmployerGetsEOCommodityViewModel>();

            services.AddScoped<EmployerMOCommodityPageViewModel>();
            services.AddScoped<EmployerPostMOCommodityViewModel>();
            services.AddScoped<EmployerPutMOCommodityViewModel>();
            services.AddScoped<EmployerDeleteMOCommodityViewModel>();
            services.AddScoped<EmployerGetsMOCommodityViewModel>();
            
            services.AddScoped<EmployerSOCommodityPageViewModel>();
            services.AddScoped<EmployerPostSOCommodityViewModel>();
            services.AddScoped<EmployerPutSOCommodityViewModel>();
            services.AddScoped<EmployerDeleteSOCommodityViewModel>();
            services.AddScoped<EmployerGetsSOCommodityViewModel>();

            services.AddScoped<EmployerOCommodityPageViewModel>();
            services.AddScoped<EmployerPostOCommodityViewModel>();
            services.AddScoped<EmployerPutOCommodityViewModel>();
            services.AddScoped<EmployerDeleteOCommodityViewModel>();
            services.AddScoped<EmployerGetsOCommodityViewModel>();

            services.AddScoped<EmployerMGOCPageViewModel>();
            services.AddScoped<EmployerPostMGOCViewModel>();
            services.AddScoped<EmployerPutMGOCViewModel>();
            services.AddScoped<EmployerDeleteMGOCViewModel>();
            services.AddScoped<EmployerGetsMGOCViewModel>();

            services.AddScoped<EmployerEPCommodityPageViewModel>();
            services.AddScoped<EmployerPostEPCommodityViewModel>();
            services.AddScoped<EmployerPutEPCommodityViewModel>();
            services.AddScoped<EmployerDeleteEPCommodityViewModel>();
            services.AddScoped<EmployerGetsEPCommodityViewModel>();

            services.AddScoped<EmployerSPCommodityPageViewModel>();
            services.AddScoped<EmployerPostSPCommodityViewModel>();
            services.AddScoped<EmployerPutSPCommodityViewModel>();
            services.AddScoped<EmployerDeleteSPCommodityViewModel>();
            services.AddScoped<EmployerGetsSPCommodityViewModel>();

            services.AddScoped<EmployerMPCommodityPageViewModel>();
            services.AddScoped<EmployerPostMPCommodityViewModel>();
            services.AddScoped<EmployerPutMPCommodityViewModel>();
            services.AddScoped<EmployerDeleteMPCommodityViewModel>();
            services.AddScoped<EmployerGetsMPCommodityViewModel>();

            services.AddScoped<EmployerPCommodityPageViewModel>();
            services.AddScoped<EmployerPostPCommodityViewModel>();
            services.AddScoped<EmployerPutPCommodityViewModel>();
            services.AddScoped<EmployerDeletePCommodityViewModel>();
            services.AddScoped<EmployerGetsPCommodityViewModel>();

            services.AddScoped<EmployerProductCenterPageViewModel>();
            services.AddScoped<EmployerPostProductCenterViewModel>();
            services.AddScoped<EmployerPutProductCenterViewModel>();
            services.AddScoped<EmployerDeleteProductCenterViewModel>();
            services.AddScoped<EmployerGetsProductCenterViewModel>();

            services.AddScoped<EmployerProductLandPageViewModel>();
            services.AddScoped<EmployerPostProductLandViewModel>();
            services.AddScoped<EmployerPutProductLandViewModel>();
            services.AddScoped<EmployerDeleteProductLandViewModel>();
            services.AddScoped<EmployerGetsProductLandViewModel>();

            services.AddScoped<EmployerProducterPageViewModel>();
            services.AddScoped<EmployerPostProducterViewModel>();
            services.AddScoped<EmployerPutProducterViewModel>();
            services.AddScoped<EmployerDeleteProducterViewModel>();
            services.AddScoped<EmployerGetsProducterViewModel>();

            services.AddScoped<EmployerETCommodityPageViewModel>();
            services.AddScoped<EmployerPostETCommodityViewModel>();
            services.AddScoped<EmployerPutETCommodityViewModel>();
            services.AddScoped<EmployerDeleteETCommodityViewModel>();
            services.AddScoped<EmployerGetsETCommodityViewModel>();

            services.AddScoped<EmployerMTCommodityPageViewModel>();
            services.AddScoped<EmployerPostMTCommodityViewModel>();
            services.AddScoped<EmployerPutMTCommodityViewModel>();
            services.AddScoped<EmployerDeleteMTCommodityViewModel>();
            services.AddScoped<EmployerGetsMTCommodityViewModel>();

            services.AddScoped<EmployerSTCommodityPageViewModel>();
            services.AddScoped<EmployerPostSTCommodityViewModel>();
            services.AddScoped<EmployerPutSTCommodityViewModel>();
            services.AddScoped<EmployerDeleteSTCommodityViewModel>();
            services.AddScoped<EmployerGetsSTCommodityViewModel>();

            services.AddScoped<EmployerTCommodityPageViewModel>();
            services.AddScoped<EmployerPostTCommodityViewModel>();
            services.AddScoped<EmployerPutTCommodityViewModel>();
            services.AddScoped<EmployerDeleteTCommodityViewModel>();
            services.AddScoped<EmployerGetsTCommodityViewModel>();

            services.AddScoped<EmployerTradeCenterPageViewModel>();
            services.AddScoped<EmployerPostTradeCenterViewModel>();
            services.AddScoped<EmployerPutTradeCenterViewModel>();
            services.AddScoped<EmployerDeleteTradeCenterViewModel>();
            services.AddScoped<EmployerGetsTradeCenterViewModel>();

            services.AddScoped<EmployerDividedTagPageViewModel>();
            services.AddScoped<EmployerPostDividedTagViewModel>();
            services.AddScoped<EmployerPutDividedTagViewModel>();
            services.AddScoped<EmployerDeleteDividedTagViewModel>();
            services.AddScoped<EmployerGetsDividedTagViewModel>();

            services.AddScoped<EmployerDotBarcodePageViewModel>();
            services.AddScoped<EmployerPostDotBarcodeViewModel>();
            services.AddScoped<EmployerPutDotBarcodeViewModel>();
            services.AddScoped<EmployerDeleteDotBarcodeViewModel>();
            services.AddScoped<EmployerGetsDotBarcodeViewModel>();

            services.AddScoped<EmployerIncomingTagPageViewModel>();
            services.AddScoped<EmployerPostIncomingTagViewModel>();
            services.AddScoped<EmployerPutIncomingTagViewModel>();
            services.AddScoped<EmployerDeleteIncomingTagViewModel>();
            services.AddScoped<EmployerGetsIncomingTagViewModel>();

            services.AddScoped<EmployerWorkingDeskPageViewModel>();
            services.AddScoped<EmployerPostWorkingDeskViewModel>();
            services.AddScoped<EmployerPutWorkingDeskViewModel>();
            services.AddScoped<EmployerDeleteWorkingDeskViewModel>();
            services.AddScoped<EmployerGetsWorkingDeskViewModel>();

            services.AddScoped<EmployerLoadFramePageViewModel>();
            services.AddScoped<EmployerPostLoadFrameViewModel>();
            services.AddScoped<EmployerPutLoadFrameViewModel>();
            services.AddScoped<EmployerDeleteLoadFrameViewModel>();
            services.AddScoped<EmployerGetsLoadFrameViewModel>();

            services.AddScoped<EmployerWarehousePageViewModel>();
            services.AddScoped<EmployerPostWarehouseViewModel>();
            services.AddScoped<EmployerPutWarehouseViewModel>();
            services.AddScoped<EmployerDeleteWarehouseViewModel>();
            services.AddScoped<EmployerGetsWarehouseViewModel>();

            services.AddScoped<EmployerWCommodityPageViewModel>();
            services.AddScoped<EmployerPostWCommodityViewModel>();
            services.AddScoped<EmployerPutWCommodityViewModel>();
            services.AddScoped<EmployerDeleteWCommodityViewModel>();
            services.AddScoped<EmployerGetsWCommodityViewModel>();

            services.AddScoped<EmployerSWCommodityPageViewModel>();
            services.AddScoped<EmployerPostSWCommodityViewModel>();
            services.AddScoped<EmployerPutSWCommodityViewModel>();
            services.AddScoped<EmployerDeleteSWCommodityViewModel>();
            services.AddScoped<EmployerGetsSWCommodityViewModel>();

            services.AddScoped<EmployerMWCommodityPageViewModel>();
            services.AddScoped<EmployerPostMWCommodityViewModel>();
            services.AddScoped<EmployerPutMWCommodityViewModel>();
            services.AddScoped<EmployerDeleteMWCommodityViewModel>();
            services.AddScoped<EmployerGetsMWCommodityViewModel>();

            services.AddScoped<EmployerEWCommodityPageViewModel>();
            services.AddScoped<EmployerPostEWCommodityViewModel>();
            services.AddScoped<EmployerPutEWCommodityViewModel>();
            services.AddScoped<EmployerDeleteEWCommodityViewModel>();
            services.AddScoped<EmployerGetsEWCommodityViewModel>();

            return services;
        }
        public static IServiceCollection AddPlatformActorService(this IServiceCollection services)
        {
            services.AddScoped<ActorServiceOption>();
            services.AddScoped<UserActorContext>();
            services.AddScoped<EmployerActorContext>();
            services.AddScoped(typeof(EntityPageViewModel<>));
            services.AddScoped(typeof(CenterPageViewModel<>));
            services.AddScoped(typeof(CommodityPageViewModel<>));
            services.AddScoped(typeof(StatusPageViewModel<>));

            services.AddScoped(typeof(EntityPageViewModel<>));
            services.AddScoped(typeof(EntityPostViewModel<>));
            services.AddScoped(typeof(EntityPutViewModel<>));
            services.AddScoped(typeof(EntityDeleteViewModel<>));
            services.AddScoped(typeof(EntityGetsViewModel<>));

            services.AddScoped(typeof(CenterPageViewModel<>));
            services.AddScoped(typeof(CenterPostViewModel<>));
            services.AddScoped(typeof(CenterPutViewModel<>));
            services.AddScoped(typeof(CenterDeleteViewModel<>));
            services.AddScoped(typeof(CenterGetsViewModel<>));

            services.AddScoped(typeof(CommodityPageViewModel<>));
            services.AddScoped(typeof(CommodityPostViewModel<>));
            services.AddScoped(typeof(CommodityPutViewModel<>));
            services.AddScoped(typeof(CommodityDeleteViewModel<>));
            services.AddScoped(typeof(CommodityGetsViewModel<>));

            services.AddScoped(typeof(StatusPageViewModel<>));
            services.AddScoped(typeof(StatusPostViewModel<>));
            services.AddScoped(typeof(StatusPutViewModel<>));
            services.AddScoped(typeof(StatusDeleteViewModel<>));
            services.AddScoped(typeof(StatusGetsViewModel<>));

            services.AddScoped<ICenterPageRoadAddressService, KoreaSearchingAddressService>();
            services.AddScoped<ICenterPageTaxService, TaxService>();
            services.AddScoped<ICenterPageIdentityRoleService, IdentityRoleService>();

            services.AddScoped<PlatformGOCPageViewModel>();
            services.AddScoped<PlatformPostGOCViewModel>();
            services.AddScoped<PlatformPutGOCViewModel>();
            services.AddScoped<PlatformDeleteGOCViewModel>();
            services.AddScoped<PlatformGetsGOCViewModel>();

            services.AddScoped<PlatformGOCCPageViewModel>();
            services.AddScoped<PlatformPostGOCCViewModel>();
            services.AddScoped<PlatformPutGOCCViewModel>();
            services.AddScoped<PlatformDeleteGOCCViewModel>();
            services.AddScoped<PlatformGetsGOCCViewModel>();

            services.AddScoped<PlatformSGOCPageViewModel>();
            services.AddScoped<PlatformPostSGOCViewModel>();
            services.AddScoped<PlatformPutSGOCViewModel>();
            services.AddScoped<PlatformDeleteSGOCViewModel>();
            services.AddScoped<PlatformGetsSGOCViewModel>();

            services.AddScoped<PlatformMGOCPageViewModel>();
            services.AddScoped<PlatformPostMGOCViewModel>();
            services.AddScoped<PlatformPutMGOCViewModel>();
            services.AddScoped<PlatformDeleteMGOCViewModel>();
            services.AddScoped<PlatformGetsMGOCViewModel>();

            services.AddScoped<PlatformEGOCPageViewModel>();
            services.AddScoped<PlatformPostEGOCViewModel>();
            services.AddScoped<PlatformPutEGOCViewModel>();
            services.AddScoped<PlatformDeleteEGOCViewModel>();
            services.AddScoped<PlatformGetsEGOCViewModel>();

            services.AddScoped<PlatformEmployeeRolePageViewModel>();
            services.AddScoped<PlatformPostEmployeeRoleViewModel>();
            services.AddScoped<PlatformPutEmployeeRoleViewModel>();
            services.AddScoped<PlatformDeleteEmployeeRoleViewModel>();
            services.AddScoped<PlatformGetsEmployeeRoleViewModel>();

            services.AddScoped<PlatformHRBusinessPartPageViewModel>();
            services.AddScoped<PlatformPostHRBusinessPartViewModel>();
            services.AddScoped<PlatformPutHRBusinessPartViewModel>();
            services.AddScoped<PlatformDeleteHRBusinessPartViewModel>();
            services.AddScoped<PlatformGetsHRBusinessPartViewModel>();

            services.AddScoped<PlatformHRCenterPageViewModel>();
            services.AddScoped<PlatformPostHRCenterViewModel>();
            services.AddScoped<PlatformPutHRCenterViewModel>();
            services.AddScoped<PlatformDeleteHRCenterViewModel>();
            services.AddScoped<PlatformGetsHRCenterViewModel>();

            services.AddScoped<PlatformHREmployeePageViewModel>();
            services.AddScoped<PlatformPostHREmployeeViewModel>();
            services.AddScoped<PlatformPutHREmployeeViewModel>();
            services.AddScoped<PlatformDeleteHREmployeeViewModel>();
            services.AddScoped<PlatformGetsHREmployeeViewModel>();

            services.AddScoped<PlatformHRRolePageViewModel>();
            services.AddScoped<PlatformPostHRRoleViewModel>();
            services.AddScoped<PlatformPutHRRoleViewModel>();
            services.AddScoped<PlatformDeleteHRRoleViewModel>();
            services.AddScoped<PlatformGetsHRRoleViewModel>();

            services.AddScoped<PlatformJCommodityPageViewModel>();
            services.AddScoped<PlatformPostJCommodityViewModel>();
            services.AddScoped<PlatformPutJCommodityViewModel>();
            services.AddScoped<PlatformDeleteJCommodityViewModel>();
            services.AddScoped<PlatformGetsJCommodityViewModel>();

            services.AddScoped<PlatformJournalPageViewModel>();
            services.AddScoped<PlatformPostJournalViewModel>();
            services.AddScoped<PlatformPutJournalViewModel>();
            services.AddScoped<PlatformDeleteJournalViewModel>();
            services.AddScoped<PlatformGetsJournalViewModel>();

            services.AddScoped<PlatformJournalCenterPageViewModel>();
            services.AddScoped<PlatformPostJournalCenterViewModel>();
            services.AddScoped<PlatformPutJournalCenterViewModel>();
            services.AddScoped<PlatformDeleteJournalCenterViewModel>();
            services.AddScoped<PlatformGetsJournalCenterViewModel>();

            services.AddScoped<PlatformEMCommodityPageViewModel>();
            services.AddScoped<PlatformPostEMCommodityViewModel>();
            services.AddScoped<PlatformPutEMCommodityViewModel>();
            services.AddScoped<PlatformDeleteEMCommodityViewModel>();
            services.AddScoped<PlatformGetsEMCommodityViewModel>();

            services.AddScoped<PlatformMarketPageViewModel>();
            services.AddScoped<PlatformPostMarketViewModel>();
            services.AddScoped<PlatformPutMarketViewModel>();
            services.AddScoped<PlatformDeleteMarketViewModel>();
            services.AddScoped<PlatformGetsMarketViewModel>();

            services.AddScoped<PlatformMCommodityPageViewModel>();
            services.AddScoped<PlatformPostMCommodityViewModel>();
            services.AddScoped<PlatformPutMCommodityViewModel>();
            services.AddScoped<PlatformDeleteMCommodityViewModel>();
            services.AddScoped<PlatformGetsMCommodityViewModel>();

            services.AddScoped<PlatformSMCommodityPageViewModel>();
            services.AddScoped<PlatformPostSMCommodityViewModel>();
            services.AddScoped<PlatformPutSMCommodityViewModel>();
            services.AddScoped<PlatformDeleteSMCommodityViewModel>();
            services.AddScoped<PlatformGetsSMCommodityViewModel>();

            services.AddScoped<PlatformMMCommodityPageViewModel>();
            services.AddScoped<PlatformPostMMCommodityViewModel>();
            services.AddScoped<PlatformPutMMCommodityViewModel>();
            services.AddScoped<PlatformDeleteMMCommodityViewModel>();
            services.AddScoped<PlatformGetsMMCommodityViewModel>();

            services.AddScoped<PlatformPlatMarketPageViewModel>();
            services.AddScoped<PlatformPostMarketViewModel>();
            services.AddScoped<PlatformPutMarketViewModel>();
            services.AddScoped<PlatformDeleteMarketViewModel>();
            services.AddScoped<PlatformGetsMarketViewModel>();

            services.AddScoped<PlatformEOCommodityPageViewModel>();
            services.AddScoped<PlatformPostEOCommodityViewModel>();
            services.AddScoped<PlatformPutEOCommodityViewModel>();
            services.AddScoped<PlatformDeleteEOCommodityViewModel>();
            services.AddScoped<PlatformGetsEOCommodityViewModel>();

            services.AddScoped<PlatformMOCommodityPageViewModel>();
            services.AddScoped<PlatformPostMOCommodityViewModel>();
            services.AddScoped<PlatformPutMOCommodityViewModel>();
            services.AddScoped<PlatformDeleteMOCommodityViewModel>();
            services.AddScoped<PlatformGetsMOCommodityViewModel>();
            
            services.AddScoped<PlatformSOCommodityPageViewModel>();
            services.AddScoped<PlatformPostSOCommodityViewModel>();
            services.AddScoped<PlatformPutSOCommodityViewModel>();
            services.AddScoped<PlatformDeleteSOCommodityViewModel>();
            services.AddScoped<PlatformGetsSOCommodityViewModel>();

            services.AddScoped<PlatformOCommodityPageViewModel>();
            services.AddScoped<PlatformPostOCommodityViewModel>();
            services.AddScoped<PlatformPutOCommodityViewModel>();
            services.AddScoped<PlatformDeleteOCommodityViewModel>();
            services.AddScoped<PlatformGetsOCommodityViewModel>();

            services.AddScoped<PlatformMGOCPageViewModel>();
            services.AddScoped<PlatformPostMGOCViewModel>();
            services.AddScoped<PlatformPutMGOCViewModel>();
            services.AddScoped<PlatformDeleteMGOCViewModel>();
            services.AddScoped<PlatformGetsMGOCViewModel>();

            services.AddScoped<PlatformEPCommodityPageViewModel>();
            services.AddScoped<PlatformPostEPCommodityViewModel>();
            services.AddScoped<PlatformPutEPCommodityViewModel>();
            services.AddScoped<PlatformDeleteEPCommodityViewModel>();
            services.AddScoped<PlatformGetsEPCommodityViewModel>();

            services.AddScoped<PlatformSPCommodityPageViewModel>();
            services.AddScoped<PlatformPostSPCommodityViewModel>();
            services.AddScoped<PlatformPutSPCommodityViewModel>();
            services.AddScoped<PlatformDeleteSPCommodityViewModel>();
            services.AddScoped<PlatformGetsSPCommodityViewModel>();

            services.AddScoped<PlatformMPCommodityPageViewModel>();
            services.AddScoped<PlatformPostMPCommodityViewModel>();
            services.AddScoped<PlatformPutMPCommodityViewModel>();
            services.AddScoped<PlatformDeleteMPCommodityViewModel>();
            services.AddScoped<PlatformGetsMPCommodityViewModel>();

            services.AddScoped<PlatformPCommodityPageViewModel>();
            services.AddScoped<PlatformPostPCommodityViewModel>();
            services.AddScoped<PlatformPutPCommodityViewModel>();
            services.AddScoped<PlatformDeletePCommodityViewModel>();
            services.AddScoped<PlatformGetsPCommodityViewModel>();

            services.AddScoped<PlatformProductCenterPageViewModel>();
            services.AddScoped<PlatformPostProductCenterViewModel>();
            services.AddScoped<PlatformPutProductCenterViewModel>();
            services.AddScoped<PlatformDeleteProductCenterViewModel>();
            services.AddScoped<PlatformGetsProductCenterViewModel>();

            services.AddScoped<PlatformProductLandPageViewModel>();
            services.AddScoped<PlatformPostProductLandViewModel>();
            services.AddScoped<PlatformPutProductLandViewModel>();
            services.AddScoped<PlatformDeleteProductLandViewModel>();
            services.AddScoped<PlatformGetsProductLandViewModel>();

            services.AddScoped<PlatformProducterPageViewModel>();
            services.AddScoped<PlatformPostProducterViewModel>();
            services.AddScoped<PlatformPutProducterViewModel>();
            services.AddScoped<PlatformDeleteProducterViewModel>();
            services.AddScoped<PlatformGetsProducterViewModel>();

            services.AddScoped<PlatformETCommodityPageViewModel>();
            services.AddScoped<PlatformPostETCommodityViewModel>();
            services.AddScoped<PlatformPutETCommodityViewModel>();
            services.AddScoped<PlatformDeleteETCommodityViewModel>();
            services.AddScoped<PlatformGetsETCommodityViewModel>();

            services.AddScoped<PlatformMTCommodityPageViewModel>();
            services.AddScoped<PlatformPostMTCommodityViewModel>();
            services.AddScoped<PlatformPutMTCommodityViewModel>();
            services.AddScoped<PlatformDeleteMTCommodityViewModel>();
            services.AddScoped<PlatformGetsMTCommodityViewModel>();

            services.AddScoped<PlatformSTCommodityPageViewModel>();
            services.AddScoped<PlatformPostSTCommodityViewModel>();
            services.AddScoped<PlatformPutSTCommodityViewModel>();
            services.AddScoped<PlatformDeleteSTCommodityViewModel>();
            services.AddScoped<PlatformGetsSTCommodityViewModel>();

            services.AddScoped<PlatformTCommodityPageViewModel>();
            services.AddScoped<PlatformPostTCommodityViewModel>();
            services.AddScoped<PlatformPutTCommodityViewModel>();
            services.AddScoped<PlatformDeleteTCommodityViewModel>();
            services.AddScoped<PlatformGetsTCommodityViewModel>();

            services.AddScoped<PlatformTradeCenterPageViewModel>();
            services.AddScoped<PlatformPostTradeCenterViewModel>();
            services.AddScoped<PlatformPutTradeCenterViewModel>();
            services.AddScoped<PlatformDeleteTradeCenterViewModel>();
            services.AddScoped<PlatformGetsTradeCenterViewModel>();

            services.AddScoped<PlatformDividedTagPageViewModel>();
            services.AddScoped<PlatformPostDividedTagViewModel>();
            services.AddScoped<PlatformPutDividedTagViewModel>();
            services.AddScoped<PlatformDeleteDividedTagViewModel>();
            services.AddScoped<PlatformGetsDividedTagViewModel>();

            services.AddScoped<PlatformDotBarcodePageViewModel>();
            services.AddScoped<PlatformPostDotBarcodeViewModel>();
            services.AddScoped<PlatformPutDotBarcodeViewModel>();
            services.AddScoped<PlatformDeleteDotBarcodeViewModel>();
            services.AddScoped<PlatformGetsDotBarcodeViewModel>();

            services.AddScoped<PlatformIncomingTagPageViewModel>();
            services.AddScoped<PlatformPostIncomingTagViewModel>();
            services.AddScoped<PlatformPutIncomingTagViewModel>();
            services.AddScoped<PlatformDeleteIncomingTagViewModel>();
            services.AddScoped<PlatformGetsIncomingTagViewModel>();

            services.AddScoped<PlatformWorkingDeskPageViewModel>();
            services.AddScoped<PlatformPostWorkingDeskViewModel>();
            services.AddScoped<PlatformPutWorkingDeskViewModel>();
            services.AddScoped<PlatformDeleteWorkingDeskViewModel>();
            services.AddScoped<PlatformGetsWorkingDeskViewModel>();

            services.AddScoped<PlatformLoadFramePageViewModel>();
            services.AddScoped<PlatformPostLoadFrameViewModel>();
            services.AddScoped<PlatformPutLoadFrameViewModel>();
            services.AddScoped<PlatformDeleteLoadFrameViewModel>();
            services.AddScoped<PlatformGetsLoadFrameViewModel>();

            services.AddScoped<PlatformWarehousePageViewModel>();
            services.AddScoped<PlatformPostWarehouseViewModel>();
            services.AddScoped<PlatformPutWarehouseViewModel>();
            services.AddScoped<PlatformDeleteWarehouseViewModel>();
            services.AddScoped<PlatformGetsWarehouseViewModel>();

            services.AddScoped<PlatformWCommodityPageViewModel>();
            services.AddScoped<PlatformPostWCommodityViewModel>();
            services.AddScoped<PlatformPutWCommodityViewModel>();
            services.AddScoped<PlatformDeleteWCommodityViewModel>();
            services.AddScoped<PlatformGetsWCommodityViewModel>();

            services.AddScoped<PlatformSWCommodityPageViewModel>();
            services.AddScoped<PlatformPostSWCommodityViewModel>();
            services.AddScoped<PlatformPutSWCommodityViewModel>();
            services.AddScoped<PlatformDeleteSWCommodityViewModel>();
            services.AddScoped<PlatformGetsSWCommodityViewModel>();

            services.AddScoped<PlatformMWCommodityPageViewModel>();
            services.AddScoped<PlatformPostMWCommodityViewModel>();
            services.AddScoped<PlatformPutMWCommodityViewModel>();
            services.AddScoped<PlatformDeleteMWCommodityViewModel>();
            services.AddScoped<PlatformGetsMWCommodityViewModel>();

            services.AddScoped<PlatformEWCommodityPageViewModel>();
            services.AddScoped<PlatformPostEWCommodityViewModel>();
            services.AddScoped<PlatformPutEWCommodityViewModel>();
            services.AddScoped<PlatformDeleteEWCommodityViewModel>();
            services.AddScoped<PlatformGetsEWCommodityViewModel>();

            return services;
        }
        public static IServiceCollection AddEmployerLogisterService(this IServiceCollection services)
        {
            services.AddScoped<ActorContext>();
            services.AddScoped<ActorServiceOption>();
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
