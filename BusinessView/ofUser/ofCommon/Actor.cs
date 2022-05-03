using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofUser
{
    public class ActorOption
    {
        public bool IsUseStorage = false;
    }
    // Get 및 Gets는 관련 데이터까지 로드하는 것을 의미한다.
    public abstract class Actor
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

        public abstract Task<T> PostAsync<T>(T t) where T : class;
        public abstract Task<T> PutAsync<T>(T t) where T : class;
        public abstract Task<T> GetById<T>(string id) where T : class;
        public abstract Task DeleteById<T>(string id) where T : class;
        public abstract Task<IEnumerable<T>> GetsAsync<T>() where T : class;
        public abstract Task<IEnumerable<T>> GetsAsyncByUserId<T>(string userid) where T : class;
    }
}
