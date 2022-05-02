using BusinessView.ofDTO.ofHRDTO.ofPlatform;
using BusinessView.ofServices.ofHR;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofHR.ofEmployee
{
    public class PlatformEmployeeRoleService : HRService, IDTOService<PlatformEmployeeRole>
    {
        public PlatformEmployeeRoleService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformEmployeeRole/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformEmployeeRole?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformEmployeeRole>($"/api/PlatformEmployeeRole/{id}");
        }

        public async Task<IEnumerable<PlatformEmployeeRole>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformEmployeeRole>>("/api/PlatformEmployeeRole");
        }

        public async Task<PlatformEmployeeRole?> PostAsync(PlatformEmployeeRole entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformEmployeeRole", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformEmployeeRole = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformEmployeeRole? PlatformEmployeeRole = JsonSerializer.Deserialize<PlatformEmployeeRole>(JsonPlatformEmployeeRole);
            return PlatformEmployeeRole;
        }

        public async Task<PlatformEmployeeRole?> PutAsync(PlatformEmployeeRole entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformEmployeeRole", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformEmployeeRole = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformEmployeeRole? PlatformEmployeeRole = JsonSerializer.Deserialize<PlatformEmployeeRole>(JsonPlatformEmployeeRole);

            return PlatformEmployeeRole;
        }
    }
}
