﻿using BusinessView.ofCommon.ofServices.ofHR.ofEmployer;
using BusinessView.ofCommon.ofServices.ofJournal.ofEmployer;
using BusinessView.ofDTO.ofHRDTO;
using BusinessView.ofDTO.ofHRDTO.ofEmployer;
using BusinessView.ofDTO.ofJournalDTO.ofEmployer;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofUser
{
    public class EmployerActor : UserActor
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
    }
}
