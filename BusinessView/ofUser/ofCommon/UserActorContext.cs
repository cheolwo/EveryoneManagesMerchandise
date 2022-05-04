using BusinessView.ofActorService;
using BusinessView.ofCommon.ofServices;
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofUser
{
    public class UserActorContext : ActorContext
    {
        protected ActorServiceOption _options = new();
        public UserActorContext(ActorServiceOption options)
        {
            _options = options;
        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder)
        {
            serviceBuilder.Add(nameof(IdentityUserDTO), new IdentityUserDTOService(_options.DTOServiceOptions));
        }

        protected override void OnStrorageBuilder(StorageBuilder storageBuilder)
        {
        }

        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilder)
        {
        }
        public override async Task<T> PostAsync<T>(T t)
        {
            DTOService service = ServiceBuilder.Get(typeof(T).Name);
            if(service != null)
            {
                T? Value = await service.PostAsync<T>(t);
                if(Value != null)
                {
                    return Value;
                }
                else
                {
                    throw new ArgumentNullException("UserActor PostAsync's Return Value is Null");
                }
            }
            throw new ArgumentNullException("Not Register Service On Builder");
        }

        public override async Task<T> PutAsync<T>(T t)
        {
            DTOService service = ServiceBuilder.Get(typeof(T).Name);
            if(service != null)
            {
                T? Value = await service.PutAsync<T>(t);
                if (Value != null)
                {
                    return Value;
                }
                else
                {
                    throw new ArgumentNullException("UserActor PostAsync's Return Value is Null");
                }
            }
            throw new ArgumentNullException("Not Register Service On Builder");
        }

        public override async Task<T> GetByIdAsync<T>(string id)
        {
            DTOService service = ServiceBuilder.Get(typeof(T).Name);
            if (service != null)
            {
                T? Value = await service.GetByIdAsync<T>(id);
                if (Value != null)
                {
                    return Value;
                }
                else
                {
                    throw new ArgumentNullException("UserActor PostAsync's Return Value is Null");
                }
            }
            throw new ArgumentNullException("Not Register Service On Builder");
        }

        public override async Task DeleteByIdAsync<T>(string id)
        {
            DTOService service = ServiceBuilder.Get(typeof(T).Name);
            if (service != null)
            {
                await service.DeleteAsync<T>(id);           
            }
            throw new ArgumentNullException("Not Register Service On Builder");
        }

        public override async Task<IEnumerable<T>> GetsAsync<T>()
        {
            DTOService service = ServiceBuilder.Get(typeof(T).Name);
            if (service != null)
            {
                IEnumerable<T>? Value = await service.GetsAsync<T>();
                if(Value != null)
                {
                    return Value;
                }
                else
                {
                    throw new ArgumentNullException("UserActor PostAsync's Return Value is Null");
                }
            }
            throw new ArgumentNullException("Not Register Service On Builder");
        }

        public override async Task<IEnumerable<T>> GetsAsyncByUserId<T>(string userid)
        {
            DTOService service = ServiceBuilder.Get(typeof(T).Name);
            if (service != null)
            {
                IEnumerable<T>? Value = await service.GetsAsyncByUserId<T>(userid);
                if (Value != null)
                {
                    return Value;
                }
                else
                {
                    throw new ArgumentNullException("UserActor PostAsync's Return Value is Null");
                }
            }
            throw new ArgumentNullException("Not Register Service On Builder");
        }
    }
}
