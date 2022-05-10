using BusinessView.ofDTO.ofJournal.ofPlatform;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofJournal.ofJournalCenter
{
    public class PlatformJournalCenterPageViewModel : CenterPageViewModel<PlatformJournalCenter> 
    {
        public PlatformJournalCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        PlatformPostJournalCenterViewModel PlatformPostJournalCenterViewModel, 
                                        PlatformPutJournalCenterViewModel PlatformPutJournalCenterViewModel,
                                        PlatformDeleteJournalCenterViewModel PlatformDeleteJournalCenterViewModel,
                                        PlatformGetsJournalCenterViewModel PlatformGetsJournalCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, PlatformPostJournalCenterViewModel, PlatformPutJournalCenterViewModel, PlatformDeleteJournalCenterViewModel, PlatformGetsJournalCenterViewModel)
                    
        {
            
        }
    }
}