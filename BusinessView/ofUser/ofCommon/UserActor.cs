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

        public async Task<IEnumerable<IdentityUserDTO>?> Get()
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
        public Task Delete(string Id)
        {
            throw new NotImplementedException();
        }
        public Task<IdentityUserDTO> GetById(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityUserDTO> Post(IdentityUserDTO t)
        {
            throw new NotImplementedException();
        }
        Task<IdentityUserDTO> IActorViewService<IdentityUserDTO>.Update(string Id, IdentityUserDTO t)
        {
            throw new NotImplementedException();
        }
    }
}
