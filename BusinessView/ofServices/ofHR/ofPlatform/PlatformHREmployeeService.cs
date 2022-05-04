using BusinessView.ofDTO.ofHR.ofPlatform;
using BusinessView.ofServices.ofHR;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofHR.ofEmployee
{
    public class PlatformHREmployeeService : HRService, IDTOService<PlatformHREmployee>
    {
        public PlatformHREmployeeService(HRServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformHREmployee/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformHREmployee?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformHREmployee>($"/api/PlatformHREmployee/{id}");
        }

        public async Task<IEnumerable<PlatformHREmployee>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformHREmployee>>("/api/PlatformHREmployee");
        }

        public async Task<PlatformHREmployee?> PostAsync(PlatformHREmployee entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformHREmployee", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformHREmployee = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformHREmployee? PlatformHREmployee = JsonSerializer.Deserialize<PlatformHREmployee>(JsonPlatformHREmployee);
            return PlatformHREmployee;
        }

        public async Task<PlatformHREmployee?> PutAsync(PlatformHREmployee entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformHREmployee", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformHREmployee = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformHREmployee? PlatformHREmployee = JsonSerializer.Deserialize<PlatformHREmployee>(JsonPlatformHREmployee);

            return PlatformHREmployee;
        }
    }
}
