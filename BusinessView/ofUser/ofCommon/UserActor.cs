using BusinessView.ofCommon.ofServices;
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofGeneric;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofUser
{
    public class UserActor : Actor, IActorViewService<IdentityUserDTO>
    {
        public UserActor()
        {
        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder)
        {
            serviceBuilder.Add(nameof(IdentityUserDTO), new IdentityUserDTOService(e => e.IsDevelopment = true));
        }

        protected override void OnStrorageBuilder(StorageBuilder storageBuilder)
        {
        }

        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilder)
        {
        }

        public async Task<IEnumerable<IdentityUserDTO>?> GetAsync()
        {
            var DTOService = ServiceBuilder.Get(nameof(IdentityUserDTO));
            if(DTOService != null)
            {
                IdentityUserDTOService identityUserDTOService = (IdentityUserDTOService)DTOService;
                IEnumerable<IdentityUserDTO>? IdentityUserDTOs = await identityUserDTOService.GetsAsync();
                return IdentityUserDTOs;
            }
            throw new ArgumentNullException(nameof(DTOService) + "Is Not Exist");
        }
        public Task DeleteAsync(string Id)
        {
            throw new NotImplementedException();
        }
        public Task<IdentityUserDTO> GetByIdAsync(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityUserDTO> PostAsync(IdentityUserDTO t)
        {
            throw new NotImplementedException();
        }
        Task<IdentityUserDTO> IActorViewService<IdentityUserDTO>.PutAsync(IdentityUserDTO t)
        {
            throw new NotImplementedException();
        }
    }
}
