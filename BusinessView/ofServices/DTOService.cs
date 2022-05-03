using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

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
        public virtual async Task<T?> PostAsync<T>(T t) where T : class
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(t),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;
            using var httpResponseMessage =
               await _httpClient.PostAsync($"/api/{nameof(T)}", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonIdentityUserDTO = await httpResponseMessage.Content.ReadAsStringAsync();
            T? dto = JsonSerializer.Deserialize<T>(JsonIdentityUserDTO);
            return dto;
        }
        public virtual async Task<T?> PutAsync<T>(T t) where T : class
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(t),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;
            using var httpResponseMessage =
               await _httpClient.PutAsync($"/api/{nameof(T)}", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonIdentityUserDTO = await httpResponseMessage.Content.ReadAsStringAsync();
            T? dto = JsonSerializer.Deserialize<T>(JsonIdentityUserDTO);
            return dto;
        }
        public virtual async Task DeleteAsync<T>(string id) where T : class
        {
            var Response = await _httpClient.DeleteAsync($"api/{nameof(T)}/{id}");
            Response.EnsureSuccessStatusCode();
        }
        public virtual async Task<T?> GetByIdAsync<T>(string id) where T : class
        {
            return await _httpClient.GetFromJsonAsync<T>($"/api/{nameof(T)}/{id}");
        }
        public virtual async Task<IEnumerable<T>?> GetsAsync<T>() where T : class
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<T>?>($"/api/{nameof(T)}");
        }
        public virtual async Task<IEnumerable<T>?> GetsAsyncByUserId<T>(string userid) where T : class
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<T>?>($"/api/user/{userid}");
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
