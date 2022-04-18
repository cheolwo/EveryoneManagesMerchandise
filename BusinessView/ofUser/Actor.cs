namespace BusinessView.ofUser
{
    public class Actor
    {
        protected ServiceBuilder ServiceBuilder = new();
        protected StorageBuilder StorageBuilder = new();
        protected ValidatorBuilder ValidatorBuilder = new();
        protected virtual void OnServiceBuilder(ServiceBuilder serviceBuilder) { }
        protected virtual void OnStrorageBuilder(StorageBuilder storageBuilder) { }
        protected virtual void OnValidatorBuilder(ValidatorBuilder validatorBuilde) { }
        public virtual Task<T> CreateAsync<T>(T t) where T : IViewModel { throw new NotImplementedException(); }
        public virtual Task<T> UpdateAsync<T>(T t) where T : IViewModel { throw new NotImplementedException(); }
        public virtual Task<T> GetById<T>(string userId, string id) where T : IViewModel { throw new NotImplementedException(); }
        public virtual Task DeleteById(string UuserId, string id) where T : IVewModel { throw new ArgumentNullException(); }
        public virtual Task<IEnumerable<T>> GetAlls<T>(string userId) where T : IViewModel { throw new NotImplementedException(); }
    }
}
