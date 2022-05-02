namespace BusinessView.ofCommon.ofServices
{
    public interface IDTOService<T> where T : class
    {
        Task<IEnumerable<T>?> GetsAsync();
        Task<T?> GetByIdAsync(string id);
        Task<T?> PostAsync(T entity);
        Task DeleteAsync(string id);
        Task<T?> PutAsync(T entity);
    }
    public class DTOServiceOptions
    {
        public bool IsDevelopment = true;
    }
    public class DTOService
    {
        protected HttpClient _httpClient = new();
        protected DTOServiceOptions _options = new();
        public DTOService()
        {
        }
    }
    //public class DTOService
    //{
    //    protected HttpClient _httpClient = new();
    //    private DTOServiceOptions _options = new();
    //    public DTOService(Action<DTOServiceOptions> options)
    //    {
    //        options.Invoke(_options);
    //    }
    //}
}
