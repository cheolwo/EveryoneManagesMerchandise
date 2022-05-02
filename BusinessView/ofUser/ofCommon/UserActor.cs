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

        public async Task<IEnumerable<IdentityUserDTO>?> GetsAsync()
        {
            var DTOService = ServiceBuilder.Get(nameof(IdentityUserDTO));
            if (DTOService != null)
            {
                IdentityUserDTOService identityUserDTOService = (IdentityUserDTOService)DTOService;
                IEnumerable<IdentityUserDTO>? IdentityUserDTOs = await identityUserDTOService.GetsAsync();
                return IdentityUserDTOs;
            }
            else
            {
                throw new ArgumentNullException(nameof(DTOService) + "Is Not Exist");
            }
        }
        public async Task DeleteAsync(string id)
        {
            var DTOService = ServiceBuilder.Get(nameof(IdentityUserDTO));
            if (DTOService != null)
            {
                IdentityUserDTOService identityUserDTOService = (IdentityUserDTOService)DTOService;
                await identityUserDTOService.DeleteAsync(id);
            }
            else
            {
                throw new ArgumentNullException(nameof(DTOService) + "Is Not Exist");
            }
        }
        public async Task<IdentityUserDTO?> GetByIdAsync(string id)
        {
            var DTOService = ServiceBuilder.Get(nameof(IdentityUserDTO));
            if (DTOService != null)
            {
                IdentityUserDTOService identityUserDTOService = (IdentityUserDTOService)DTOService;
                return await identityUserDTOService.GetByIdAsync(id);
            }
            else
            {
                throw new ArgumentNullException(nameof(DTOService) + "Is Not Exist");
            }
        }

        public async Task<IdentityUserDTO?> PostAsync(IdentityUserDTO entity)
        {
            var DTOService = ServiceBuilder.Get(nameof(IdentityUserDTO));
            if (DTOService != null)
            {
                IdentityUserDTOService identityUserDTOService = (IdentityUserDTOService)DTOService;
                return await identityUserDTOService.PostAsync(entity);
            }
            else
            {
                throw new ArgumentNullException(nameof(DTOService) + "Is Not Exist");
            }
        }
        public async Task<IdentityUserDTO?> PutAsync(IdentityUserDTO entity)
        {
            var DTOService = ServiceBuilder.Get(nameof(IdentityUserDTO));
            if (DTOService != null)
            {
                IdentityUserDTOService identityUserDTOService = (IdentityUserDTOService)DTOService;
                return await identityUserDTOService.PutAsync(entity);
            }
            else
            {
                throw new ArgumentNullException(nameof(DTOService) + "Is Not Exist");
            }
        }
    }
}
