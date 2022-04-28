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
    public class PlatformHREmployeeService : HRService, IDTOService<PlatformHREmployee>
    {
        public PlatformHREmployeeService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformHREmployee/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformHREmployee?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformHREmployee>($"/api/PlatformHREmployee/{id}");
        }

        public async Task<IEnumerable<PlatformHREmployee>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformHREmployee>>("/api/PlatformHREmployee");
        }

        public async Task PostAsync(PlatformHREmployee entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformHREmployee", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(PlatformHREmployee entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformHREmployee", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
