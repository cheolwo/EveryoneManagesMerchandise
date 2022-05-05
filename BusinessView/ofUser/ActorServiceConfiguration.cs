using BusinessView.ofCommon.ofServices;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofServices.ofGroupOrder;
using BusinessView.ofServices.ofHR;
using BusinessView.ofServices.ofJournal;
using BusinessView.ofServices.ofMarket;
using BusinessView.ofServices.ofOrder;
using BusinessView.ofServices.ofProduct;
using BusinessView.ofServices.ofTrade;
using BusinessView.ofUser;
using BusinessView.ofUser.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofGroupOrder;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade;
using BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

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
            services.AddScoped<GetsEmployerEmployeeRoleViewModel>();
            services.AddScoped<PostEmployerEmployeeRoleViewModel>();
            services.AddScoped<PutEmployerEmployeeRoleViewModel>();
            services.AddScoped<DeleteEmployerEmployeeRoleViewModel>();
            services.AddScoped<BaseEmployerEmployeeRoleViewModel>();

            services.AddScoped<GetsEmployerHRBusinessPartViewModel>();
            services.AddScoped<PostEmployerHRBusinessPartViewModel>();
            services.AddScoped<PutEmployerHRBusinessPartViewModel>();
            services.AddScoped<DeleteEmployerHRBusinessPartViewModel>();
            services.AddScoped<BaseEmployerHRBusinessPartViewModel>();

            services.AddScoped<GetsEmployerHRCenterViewModel>();
            services.AddScoped<PostEmployerHRCenterViewModel>();
            services.AddScoped<PutEmployerHRCenterViewModel>();
            services.AddScoped<DeleteEmployerHRCenterViewModel>();
            services.AddScoped<BaseEmployerHRCenterViewModel>();

            services.AddScoped<GetsEmployerHREmployeeViewModel>();
            services.AddScoped<PostEmployerHREmployeeViewModel>();
            services.AddScoped<PutEmployerHREmployeeViewModel>();
            services.AddScoped<DeleteEmployerHREmployeeViewModel>();
            services.AddScoped<BaseEmployerHREmployeeViewModel>();

            services.AddScoped<GetsEmployerHRRoleViewModel>();
            services.AddScoped<PostEmployerHRRoleViewModel>();
            services.AddScoped<PutEmployerHRRoleViewModel>();
            services.AddScoped<DeleteEmployerHRRoleViewModel>();
            services.AddScoped<BaseEmployerHRRoleViewModel>();

            services.AddScoped<GetsEmployerJCommodityViewModel>();
            services.AddScoped<PostEmployerJCommodityViewModel>();
            services.AddScoped<PutEmployerJCommodityViewModel>();
            services.AddScoped<DeleteEmployerJCommodityViewModel>();
            services.AddScoped<BaseEmployerJCommodityViewModel>();

            services.AddScoped<GetsEmployerJournalViewModel>();
            services.AddScoped<PostEmployerJournalViewModel>();
            services.AddScoped<PutEmployerJournalViewModel>();
            services.AddScoped<DeleteEmployerJournalViewModel>();
            services.AddScoped<BaseEmployerJournalViewModel>();

            services.AddScoped<GetsEmployerJournalCenterViewModel>();
            services.AddScoped<PostEmployerJournalCenterViewModel>();
            services.AddScoped<PutEmployerJournalCenterViewModel>();
            services.AddScoped<DeleteEmployerJournalCenterViewModel>();
            services.AddScoped<BaseEmployerJournalCenterViewModel>();
            return services;
        }
        public static IServiceCollection AddEmployerLogisterService(this IServiceCollection services)
        {
            services.AddScoped<UserActorContext>();
            services.AddScoped<EmployerLogisterContext>();
            services.AddScoped<GetUserViewModel>();
            services.AddScoped<PostUserViewModel>();
            services.AddScoped<PutUserViewModel>();
            services.AddScoped<DeleteUserViewModel>();
            services.AddScoped<GetsUserViewModel>();

            services.AddScoped<GetsEmployerWarehouseViewModel>();
            services.AddScoped<PostEmployerWarehouseViewModel>();
            services.AddScoped<PutEmployerWarehouseViewModel>();
            services.AddScoped<DeleteEmployerWarehouseViewModel>();
            services.AddScoped<BaseEmployerWarehouseViewModel>();

            services.AddScoped<GetsEmployerDividedTagViewModel>();
            services.AddScoped<PostEmployerDividedTagViewModel>();
            services.AddScoped<PutEmployerDividedTagViewModel>();
            services.AddScoped<DeleteEmployerDividedTagViewModel>();
            services.AddScoped<BaseEmployerDividedTagViewModel>();

            services.AddScoped<GetsEmployerDotBarcodeViewModel>();
            services.AddScoped<PostEmployerDotBarcodeViewModel>();
            services.AddScoped<PutEmployerDotBarcodeViewModel>();
            services.AddScoped<DeleteEmployerDotBarcodeViewModel>();
            services.AddScoped<BaseEmployerDotBarcodeViewModel>();

            services.AddScoped<GetsEmployerEWCommodityViewModel>();
            services.AddScoped<PostEmployerEWCommodityViewModel>();
            services.AddScoped<PutEmployerEWCommodityViewModel>();
            services.AddScoped<DeleteEmployerEWCommodityViewModel>();
            services.AddScoped<BaseEmployerEWCommodityViewModel>();

            services.AddScoped<GetsEmployerIncomingTagViewModel>();
            services.AddScoped<PostEmployerIncomingTagViewModel>();
            services.AddScoped<PutEmployerIncomingTagViewModel>();
            services.AddScoped<DeleteEmployerIncomingTagViewModel>();
            services.AddScoped<BaseEmployerIncomingTagViewModel>();

            services.AddScoped<GetsEmployerLoadFrameViewModel>();
            services.AddScoped<PostEmployerLoadFrameViewModel>();
            services.AddScoped<PutEmployerLoadFrameViewModel>();
            services.AddScoped<DeleteEmployerLoadFrameViewModel>();
            services.AddScoped<BaseEmployerLoadFrameViewModel>();

            services.AddScoped<GetsEmployerMWCommodityViewModel>();
            services.AddScoped<PostEmployerMWCommodityViewModel>();
            services.AddScoped<PutEmployerMWCommodityViewModel>();
            services.AddScoped<DeleteEmployerMWCommodityViewModel>();
            services.AddScoped<GetsEmployerMWCommodityViewModel>();

            services.AddScoped<GetsEmployerSWCommodityViewModel>();
            services.AddScoped<PostEmployerSWCommodityViewModel>();
            services.AddScoped<PutEmployerSWCommodityViewModel>();
            services.AddScoped<DeleteEmployerSWCommodityViewModel>();
            services.AddScoped<BaseEmployerSWCommodityViewModel>();

            services.AddScoped<GetsEmployerWorkingDeskViewModel>();
            services.AddScoped<PostEmployerWorkingDeskViewModel>();
            services.AddScoped<PutEmployerWorkingDeskViewModel>();
            services.AddScoped<DeleteEmployerWorkingDeskViewModel>();
            services.AddScoped<BaseEmployerWorkingDeskViewModel>();

            services.AddScoped<GetsEmployerTradeCenterViewModel>();
            services.AddScoped<PostEmployerTradeCenterViewModel>();
            services.AddScoped<PutEmployerTradeCenterViewModel>();
            services.AddScoped<DeleteEmployerTradeCenterViewModel>();
            services.AddScoped<BaseEmployerTradeCenterViewModel>();

            services.AddScoped<GetsEmployerTCommodityViewModel>();
            services.AddScoped<PostEmployerTCommodityViewModel>();
            services.AddScoped<PutEmployerTCommodityViewModel>();
            services.AddScoped<DeleteEmployerTCommodityViewModel>();
            services.AddScoped<BaseEmployerTCommodityViewModel>();

            services.AddScoped<GetsEmployerSTCommodityViewModel>();
            services.AddScoped<PostEmployerSTCommodityViewModel>();
            services.AddScoped<PutEmployerSTCommodityViewModel>();
            services.AddScoped<DeleteEmployerSTCommodityViewModel>();
            services.AddScoped<BaseEmployerSTCommodityViewModel>();

            services.AddScoped<GetsEmployerMTCommodityViewModel>();
            services.AddScoped<PostEmployerMTCommodityViewModel>();
            services.AddScoped<PutEmployerMTCommodityViewModel>();
            services.AddScoped<DeleteEmployerMTCommodityViewModel>();
            services.AddScoped<BaseEmployerMTCommodityViewModel>();

            services.AddScoped<GetsEmployerETCommodityViewModel>();
            services.AddScoped<PostEmployerETCommodityViewModel>();
            services.AddScoped<PutEmployerETCommodityViewModel>();
            services.AddScoped<DeleteEmployerETCommodityViewModel>();
            services.AddScoped<BaseEmployerETCommodityViewModel>();

            services.AddScoped<GetsEmployerGOCViewModel>();
            services.AddScoped<PostEmployerGOCViewModel>();
            services.AddScoped<PutEmployerGOCViewModel>();
            services.AddScoped<DeleteEmployerGOCViewModel>();
            services.AddScoped<BaseEmployerGOCViewModel>();

            services.AddScoped<GetsEmployerGOCCViewModel>();
            services.AddScoped<PostEmployerGOCCViewModel>();
            services.AddScoped<PutEmployerGOCCViewModel>();
            services.AddScoped<DeleteEmployerGOCCViewModel>();
            services.AddScoped<BaseEmployerGOCCViewModel>();

            services.AddScoped<GetsEmployerSGOCViewModel>();
            services.AddScoped<PostEmployerSGOCViewModel>();
            services.AddScoped<PutEmployerSGOCViewModel>();
            services.AddScoped<DeleteEmployerSGOCViewModel>();
            services.AddScoped<BaseEmployerSGOCViewModel>();

            services.AddScoped<GetsEmployerMGOCViewModel>();
            services.AddScoped<PostEmployerMGOCViewModel>();
            services.AddScoped<PutEmployerMGOCViewModel>();
            services.AddScoped<DeleteEmployerMGOCViewModel>();
            services.AddScoped<BaseEmployerMGOCViewModel>();

            services.AddScoped<GetsEmployerEGOCViewModel>();
            services.AddScoped<PostEmployerEGOCViewModel>();
            services.AddScoped<PutEmployerEGOCViewModel>();
            services.AddScoped<DeleteEmployerEGOCViewModel>();
            services.AddScoped<BaseEmployerEGOCViewModel>();

            services.AddScoped<GetsEmployerOrderCenterViewModel>();
            services.AddScoped<PostEmployerOrderCenterViewModel>();
            services.AddScoped<PutEmployerOrderCenterViewModel>();
            services.AddScoped<DeleteEmployerOrderCenterViewModel>();
            services.AddScoped<BaseEmployerOrderCenterViewModel>();

            services.AddScoped<GetsEmployerOCommodityViewModel>();
            services.AddScoped<PostEmployerOCommodityViewModel>();
            services.AddScoped<PutEmployerOCommodityViewModel>();
            services.AddScoped<DeleteEmployerOCommodityViewModel>();
            services.AddScoped<BaseEmployerOCommodityViewModel>();

            services.AddScoped<GetsEmployerSOCommodityViewModel>();
            services.AddScoped<PostEmployerSOCommodityViewModel>();
            services.AddScoped<PutEmployerSOCommodityViewModel>();
            services.AddScoped<DeleteEmployerSOCommodityViewModel>();
            services.AddScoped<BaseEmployerSOCommodityViewModel>();

            services.AddScoped<GetsEmployerMOCommodityViewModel>();
            services.AddScoped<PostEmployerMOCommodityViewModel>();
            services.AddScoped<PutEmployerMOCommodityViewModel>();
            services.AddScoped<DeleteEmployerMOCommodityViewModel>();
            services.AddScoped<BaseEmployerMOCommodityViewModel>();

            services.AddScoped<GetsEmployerEOCommodityViewModel>();
            services.AddScoped<PostEmployerEOCommodityViewModel>();
            services.AddScoped<PutEmployerEOCommodityViewModel>();
            services.AddScoped<DeleteEmployerEOCommodityViewModel>();
            services.AddScoped<BaseEmployerEOCommodityViewModel>();
            return services;
        }
    }
}
