using BusinessView.ofCommon.ofServices.ofHR.ofEmployee;
using BusinessView.ofCommon.ofServices.ofJournal.ofEmployer;
using BusinessView.ofCommon.ofServices.ofJournalCenter.ofEmployee;
using BusinessView.ofCommon.ofServices.ofJournalCenter.ofEmployer;
using BusinessView.ofDTO.ofHRDTO;
using BusinessView.ofDTO.ofHRDTO.ofEmployer;
using BusinessView.ofDTO.ofJournalDTO.ofEmployer;
using BusinessView.ofGeneric;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofUser
{
    public class EmployerActor : UserActor,
         IActorViewService<EmployerEmployeeRole>,
         IActorViewService<EmployerHRBusinessPart>,
         IActorViewService<EmployerHRCenter>,
         IActorViewService<EmployerHREmployee>,
         IActorViewService<EmployerHRRole>,
         IActorViewService<EmployerJCommodity>,
         IActorViewService<EmployerJournal>,
         IActorViewService<EmployerJournalCenter>
    {
        public EmployerActor()
        {

        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder) 
        {
            serviceBuilder.Add(nameof(EmployerEmployeeRole), new EmployerEmployeeRoleService(e=>e.IsDevelopment=true));
            serviceBuilder.Add(nameof(EmployerHRBusinessPart), new EmployerHRBusinessPartService(e=>e.IsDevelopment=true));
            serviceBuilder.Add(nameof(EmployerHRCenter), new EmployerHRCenterService(e=>e.IsDevelopment=true));
            serviceBuilder.Add(nameof(EmployerHREmployee), new EmployerHREmployeeService(e=>e.IsDevelopment=true));
            serviceBuilder.Add(nameof(EmployerHRRole), new EmployerHRRoleService(e=>e.IsDevelopment=true));
            serviceBuilder.Add(nameof(EmployerJCommodity), new EmployerJCommodityService(e=>e.IsDevelopment=true));
            serviceBuilder.Add(nameof(EmployerJournal), new EmployerJournalService(e=>e.IsDevelopment=true));
            serviceBuilder.Add(nameof(EmployerJournalCenter), new EmployerJournalCenterService(e=>e.IsDevelopment=true));
        }   
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {

        }

        public Task<EmployerHRBusinessPart?> PostAsync(EmployerHRBusinessPart entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerHRCenter?> PostAsync(EmployerHRCenter entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerHREmployee?> PostAsync(EmployerHREmployee entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerHRRole?> PostAsync(EmployerHRRole entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerJCommodity?> PostAsync(EmployerJCommodity entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerJournal?> PostAsync(EmployerJournal entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerJournalCenter?> PostAsync(EmployerJournalCenter entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerHRBusinessPart?> PutAsync(EmployerHRBusinessPart entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerHRCenter?> PutAsync(EmployerHRCenter entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerHREmployee?> PutAsync(EmployerHREmployee entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerHRRole?> PutAsync(EmployerHRRole entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerJCommodity?> PutAsync(EmployerJCommodity entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerJournal?> PutAsync(EmployerJournal entity)
        {
            throw new NotImplementedException();
        }

        public Task<EmployerJournalCenter?> PutAsync(EmployerJournalCenter entity)
        {
            throw new NotImplementedException();
        }


        Task IActorViewService<EmployerEmployeeRole>.DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        Task<EmployerEmployeeRole?> IActorViewService<EmployerEmployeeRole>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        Task<EmployerHRBusinessPart?> IActorViewService<EmployerHRBusinessPart>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        Task<EmployerHRCenter?> IActorViewService<EmployerHRCenter>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        Task<EmployerHREmployee?> IActorViewService<EmployerHREmployee>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        Task<EmployerHRRole?> IActorViewService<EmployerHRRole>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        Task<EmployerJCommodity?> IActorViewService<EmployerJCommodity>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        Task<EmployerJournal?> IActorViewService<EmployerJournal>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        Task<EmployerJournalCenter?> IActorViewService<EmployerJournalCenter>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerEmployeeRole>?> IActorViewService<EmployerEmployeeRole>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerHRBusinessPart>?> IActorViewService<EmployerHRBusinessPart>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerHRCenter>?> IActorViewService<EmployerHRCenter>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerHREmployee>?> IActorViewService<EmployerHREmployee>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerHRRole>?> IActorViewService<EmployerHRRole>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerJCommodity>?> IActorViewService<EmployerJCommodity>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerJournal>?> IActorViewService<EmployerJournal>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<EmployerJournalCenter>?> IActorViewService<EmployerJournalCenter>.GetsAsync()
        {
            throw new NotImplementedException();
        }

        Task<EmployerEmployeeRole?> IActorViewService<EmployerEmployeeRole>.PostAsync(EmployerEmployeeRole entity)
        {
            throw new NotImplementedException();
        }

        Task<EmployerEmployeeRole?> IActorViewService<EmployerEmployeeRole>.PutAsync(EmployerEmployeeRole entity)
        {
            throw new NotImplementedException();
        }
    }
}
