using BusinessView.ofDTO.ofHRDTO;
using BusinessView.ofDTO.ofHRDTO.ofEmployee;
using BusinessView.ofDTO.ofHRDTO.ofPlatform;
using BusinessView.ofServices.ofHR;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofHR.ofPlatform
{
    public class PlatformHRRoleService : HRService, IDTOService<PlatformHRRole>
    {
        public PlatformHRRoleService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformHRRole/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformHRRole?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformHRRole>($"/api/PlatformHRRole/{id}");
        }

        public async Task<IEnumerable<PlatformHRRole>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformHRRole>>("/api/PlatformHRRole");
        }

        public async Task PostAsync(PlatformHRRole entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformHRRole", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(PlatformHRRole entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformHRRole", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
