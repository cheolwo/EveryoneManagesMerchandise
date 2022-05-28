using BusinessView.ofDTO.ofJournal.ofPlatform;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofExternal.ofSearchingService;
namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofJournal.ofJournalCenter
{
    public class PlatformJournalCenterPageViewModel : CenterPageViewModel<PlatformJournalCenter> 
    {
        public readonly PlatformPostJournalCenterViewModel _PlatformPostJournalCenterViewModel;
        public readonly PlatformPutJournalCenterViewModel _PlatformPutJournalCenterViewModel;
        public readonly PlatformDeleteJournalCenterViewModel _PlatformDeleteJournalCenterViewModel;
        public readonly PlatformGetsJournalCenterViewModel _PlatformGetsJournalCenterViewModel;
        public PlatformJournalCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        PlatformPostJournalCenterViewModel PlatformPostJournalCenterViewModel, 
                                        PlatformPutJournalCenterViewModel PlatformPutJournalCenterViewModel,
                                        PlatformDeleteJournalCenterViewModel PlatformDeleteJournalCenterViewModel,
                                        PlatformGetsJournalCenterViewModel PlatformGetsJournalCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, PlatformPostJournalCenterViewModel, PlatformPutJournalCenterViewModel, PlatformDeleteJournalCenterViewModel, PlatformGetsJournalCenterViewModel)
                    
        {
            _PlatformPostJournalCenterViewModel = PlatformPostJournalCenterViewModel;
            _PlatformPutJournalCenterViewModel = PlatformPutJournalCenterViewModel;
            _PlatformDeleteJournalCenterViewModel = PlatformDeleteJournalCenterViewModel;
            _PlatformGetsJournalCenterViewModel = PlatformGetsJournalCenterViewModel;
        }
    }
}