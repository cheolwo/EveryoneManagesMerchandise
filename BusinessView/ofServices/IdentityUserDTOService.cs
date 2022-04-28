using BusinessView.ofDTO.ofCommon;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices
{
    public class IdentityService : DTOService
    {
        public IdentityService(Action<DTOServiceOptions> options)
        {
            options.Invoke(_options);
            if (_options.IsDevelopment)
            {
                _httpClient.BaseAddress = new Uri(DevelopmentServerBaseAddress.IdentityWebAPIServerURL);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
    public class IdentityUserDTOService : IdentityService, IDTOService<IdentityUserDTO>
    {
        public IdentityUserDTOService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/IdentityUserDTO/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<IdentityUserDTO?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<IdentityUserDTO>($"/api/IdentityUserDTO/{id}");
        }

        public async Task<IEnumerable<IdentityUserDTO>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<IdentityUserDTO>>("/api/IdentityUserDTO");           
        }

        public async Task PostAsync(IdentityUserDTO entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/TodoItems", entityJson);
            
            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(IdentityUserDTO entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/TodoItems", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
