using BusinessView.ofCommon.ofServices.ofHR.ofEmployee;
using BusinessView.ofCommon.ofServices.ofJournal.ofPlatform;
using BusinessView.ofCommon.ofServices.ofJournalCenter.ofEmployee;
using BusinessView.ofCommon.ofServices.ofJournalCenter.ofPlatform;
using BusinessView.ofDTO.ofHR.ofPlatform;
using BusinessView.ofDTO.ofJournal.ofPlatform;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofUser
{
    public class PlatformActorContext : UserActorContext
    {
        public PlatformActorContext()
        {

        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder) 
        {
            serviceBuilder.Add(nameof(PlatformEmployeeRole), new PlatformEmployeeRoleService(e=>e.IsDevelopment=true));
            serviceBuilder.Add(nameof(PlatformHRBusinessPart), new PlatformHRBusinessPartService(e=>e.IsDevelopment=true));
            serviceBuilder.Add(nameof(PlatformHRCenter), new PlatformHRCenterService(e=>e.IsDevelopment=true));
            serviceBuilder.Add(nameof(PlatformHREmployee), new PlatformHREmployeeService(e=>e.IsDevelopment=true));
            serviceBuilder.Add(nameof(PlatformHRRole), new PlatformHRRoleService(e=>e.IsDevelopment=true));
            serviceBuilder.Add(nameof(PlatformJCommodity), new PlatformJCommodityService(e=>e.IsDevelopment=true));
            serviceBuilder.Add(nameof(PlatformJournal), new PlatformJournalService(e=>e.IsDevelopment=true));
            serviceBuilder.Add(nameof(PlatformJournalCenter), new PlatformJournalCenterService(e=>e.IsDevelopment=true));
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {

        }
    }
}
