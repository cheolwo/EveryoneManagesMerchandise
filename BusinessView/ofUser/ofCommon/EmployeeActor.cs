using BusinessView.ofCommon.ofServices.ofHR.ofEmployee;
using BusinessView.ofCommon.ofServices.ofJournal.ofEmployee;
using BusinessView.ofDTO.ofHRDTO.ofEmployee;
using BusinessView.ofDTO.ofJournalDTO.ofEmployee;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofUser
{
    public class EmployeeActor : UserActor
    {
        public EmployeeActor()
        {

        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder) 
        {
            serviceBuilder.Add(nameof(EmployeeEmployeeRole), new EmployeeEmployeeRoleService(e=>e.IsDevelopment=true));
            serviceBuilder.Add(nameof(EmployeeHRBusinessPart), new EmployeeHRBusinessPartService(e=>e.IsDevelopment=true));
            serviceBuilder.Add(nameof(EmployeeHRCenter), new EmployeeHRCenterService(e=>e.IsDevelopment=true));
            serviceBuilder.Add(nameof(EmployeeHREmployee), new EmployeeHREmployeeService(e=>e.IsDevelopment=true));
            serviceBuilder.Add(nameof(EmployeeHRRole), new EmployeeHRRoleService(e=>e.IsDevelopment=true));
            serviceBuilder.Add(nameof(EmployeeJCommodity), new EmployeeJCommodityService(e=>e.IsDevelopment=true));
            serviceBuilder.Add(nameof(EmployeeJournal), new EmployeeJournalService(e=>e.IsDevelopment=true));
            serviceBuilder.Add(nameof(EmployeeJournalCenter), new EmployeeJournalCenterService(e=>e.IsDevelopment=true));
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {

        }
    }
}
