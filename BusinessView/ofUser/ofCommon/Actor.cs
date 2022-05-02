﻿using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofUser
{
    public class ActorOption
    {
        public bool IsUseStorage = false;
    }
    public class Actor
    {
        protected ServiceBuilder ServiceBuilder = new();
        protected StorageBuilder StorageBuilder = new();
        protected ValidatorBuilder ValidatorBuilder = new();
        public Actor()
        {
            OnServiceBuilder(ServiceBuilder);
            OnValidatorBuilder(ValidatorBuilder);
            OnStrorageBuilder(StorageBuilder);
        }
        protected virtual void OnServiceBuilder(ServiceBuilder serviceBuilder) { }
        protected virtual void OnStrorageBuilder(StorageBuilder storageBuilder) { }
        protected virtual void OnValidatorBuilder(ValidatorBuilder validatorBuilde) { }

        // public async Task<IEnumerable<IdentityUserDTO>?> GetsAsync()
        // {
        //     var DTOService = ServiceBuilder.Get(nameof(IdentityUserDTO));
        //     if (DTOService != null)
        //     {
        //         IdentityUserDTOService identityUserDTOService = (IdentityUserDTOService)DTOService;
        //         IEnumerable<IdentityUserDTO>? IdentityUserDTOs = await identityUserDTOService.GetsAsync();
        //         return IdentityUserDTOs;
        //     }
        //     else
        //     {
        //         throw new ArgumentNullException(nameof(DTOService) + "Is Not Exist");
        //     }
        // }

        // public virtual Task<T> CreateAsync<T>(T t) where T : IViewModel 
        // {
        //     throw new NotImplementedException(); 
        // }
        // public virtual Task<T> UpdateAsync<T>(T t) where T : IViewModel 
        // { 
        //     throw new NotImplementedException(); 
        // }
        // public virtual Task<T> GetById<T>(string userId, string id) where T : IViewModel 
        // {
        //     throw new NotImplementedException(); 
        // }
        // public virtual Task DeleteById<T>(string UuserId, string id) where T : IViewModel {
        //     throw new ArgumentNullException(); 
        // }
    }
}